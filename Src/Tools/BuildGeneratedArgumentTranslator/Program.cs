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

// Translates the arguments from BuildGenerated.sh into directories containing
// libraries. This is primarily for the sake of being able to accept Discovery file
// paths as reported by earlier phases of the build pipeline. See BuildGenerated.sh
// for details of the expected arguments. The first argument is the generation directory,
// and is specified by BuildGenerated.sh itself.

using ToolUtilities;

if (args.Length == 0)
{
    Console.WriteLine("Arguments, one of two forms:");
    Console.WriteLine("  <generation-dir> <file-or-dir> [...]");
    Console.WriteLine("  <generation-dir> @file");
    Console.WriteLine("where @file specifies a file with one file/directory per line.");
    Console.WriteLine("Each file or directory should be either a project file/directory, or a Discovery file.");
    return 1;
}

string generationDir = args[0];
args = args.Skip(1).ToArray();

if (args.Length == 1 && args[0].StartsWith('@'))
{
    args = File.ReadAllLines(args[0].Substring(1));
}

// Note: we write all values out on a single line, to avoid line ending issues. We'll end up with a leading
// space, but that doesn't matter.
foreach (string path in args)
{
    // Any non-JSON argument is just passed through
    if (!path.EndsWith(".json"))
    {
        Console.Write($" {path}");
        continue;
    }

    var json = File.ReadAllText(path);
    string packageName = Discovery.GetPackageName(json);
    Console.Write($" {generationDir}/{packageName}");
}

return 0;
