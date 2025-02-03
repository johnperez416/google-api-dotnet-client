﻿// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated a list of packages with links to product documentation, NuGet,
// and library reference documentation, within README.md.

using Google.Apis.Discovery.v1.Data;
using ToolUtilities;

namespace UpdateReadmePackageList;

internal class PackageTableEntry
{
    public string PackageName { get; }
    public string NugetLink => $"https://www.nuget.org/packages/{PackageName}";
    public string NugetBadgeLink => $"https://img.shields.io/nuget/v/{PackageName}";
    public string ReferenceDocsLink => $"https://googleapis.dev/dotnet/{PackageName}/latest/api/{PackageName}.html";
    public string ApiDocsLink { get; }
    public string ApiName { get; }

    private PackageTableEntry(RestDescription discoveryDoc)
    {
        PackageName = Discovery.GetPackageName(discoveryDoc);
        ApiDocsLink = discoveryDoc.DocumentationLink;
        ApiName = $"{discoveryDoc.Title} {discoveryDoc.Version.Replace('.', '_')}";
    }

    public static PackageTableEntry Load(string discoveryFilePath) =>
        new(Discovery.ParseDiscoveryJson(File.ReadAllText(discoveryFilePath)));

    internal string ToMarkdown() =>
        $"| [{PackageName}]({ReferenceDocsLink}) | [![NuGet]({NugetBadgeLink})]({NugetLink}) | [{ApiName}]({ApiDocsLink}) |";
}
