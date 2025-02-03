#!/bin/bash

set -e

declare -r repo_root=$(git rev-parse --show-toplevel)

cd $repo_root

# Avoid dotnet restore failing if the directory isn't present
mkdir -p NuPkgs/Support

# Install docfx (and any other dotnet tools)
dotnet tool restore > /dev/null

rm -rf Src/Generated/*/obj
rm -rf Src/Generated/*/bin

# Extract the support libraries version number from the XML.
# This is pretty horrible, but it works...
declare -r supportversion=$(grep \<Version\> Src/Support/CommonProjectProperties.xml | sed 's/</>/g' | cut -d\> -f 3)

# Temporary location for xref maps
# TODO: Work out somewhere better to put these!
rm -rf obj
mkdir obj

# Temporary workaround for failure to fetch xref maps from googleapis.dev: build locally and copy.
# This is far from great, as it means we could refer to unreleased methods, but it's better than nothing.
.kokoro/BuildSupportDocs.sh
cp Src/Support/Google.Apis/obj/site/xrefmap.yml obj/Google.Apis.xrefmap.yml
cp Src/Support/Google.Apis.Core/obj/site/xrefmap.yml obj/Google.Apis.Core.xrefmap.yml
cp Src/Support/Google.Apis.Auth/obj/site/xrefmap.yml obj/Google.Apis.Auth.xrefmap.yml
#curl -sSL https://googleapis.dev/dotnet/Google.Apis/$supportversion/xrefmap.yml -o obj/Google.Apis.xrefmap.yml
#curl -sSL https://googleapis.dev/dotnet/Google.Apis.Core/$supportversion/xrefmap.yml -o obj/Google.Apis.Core.xrefmap.yml
#curl -sSL https://googleapis.dev/dotnet/Google.Apis.Auth/$supportversion/xrefmap.yml -o obj/Google.Apis.Auth.xrefmap.yml

build_site() {
  declare -r package=$1
  declare -r directory=Src/Generated/$1
  declare -r json=$directory/docfx.json
  declare -r version=$(grep \<Version\> $directory/$package.csproj | sed 's/</>/g' | cut -d\> -f 3)

  if [[ $(curl -s -o /dev/null -w "%{http_code}" https://googleapis.dev/dotnet/${package}/${version}/) == "200" ]]
  then
    # TODO: Allow a --force switch or similar
    echo "Documentation for $package version $version already exists; skipping"
    return 0
  fi

  echo "Generating documentation for $package version $version"
  dotnet build Src/Generated/$package/$package.csproj
  
  cp Docs/docfx-1.json $json
  cp Docs/index.md $directory
  # All generated packages effectively have the same dependencies
  echo "      \"../../../obj/Google.Apis.xrefmap.yml\"," >> $json
  echo "      \"../../../obj/Google.Apis.Core.xrefmap.yml\"," >> $json
  echo "      \"../../../obj/Google.Apis.Auth.xrefmap.yml\"," >> $json

  cat Docs/docfx-2.json >> $json
  sed -i "s/\\\$package/$package/g" $json
  sed -i "s/\\\$target/netstandard2.0/g" $json
  sed -i "s/\\\$title/$package/g" $json
  
  sed -i "s/\\\$title/$package/g" $directory/index.md  
  sed -i "s/\\\$entry_namespace/$package/g" $directory/index.md  
  
  dotnet docfx metadata --disableGitFeatures $json
  dotnet docfx build --disableGitFeatures $json

  if [ ! -d $directory/obj/api ]
  then
    echo 'No metadata generated! Looks like docfx is broken...'
    exit 1
  fi
  
  sed -i "1s/^/baseUrl: https:\/\/googleapis.dev\/dotnet\/$package\/$version\/\n/" $directory/obj/site/xrefmap.yml
}

# Allow a single package name to be specified on the command line, for ease of testing.
if [[ "$1" == "" ]]
then
  for pkgdir in Src/Generated/Google.*
  do
    pkg=$(basename $pkgdir)
    build_site $pkg
  done
else
  build_site $1
fi
