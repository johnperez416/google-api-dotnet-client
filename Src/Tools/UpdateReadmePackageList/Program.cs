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

using UpdateReadmePackageList;

// Everything before this line is preserved.
// Everything after this line, but before the next empty line, is replaced.
// Everything after the empty line after this line is preserved.
const string TableHeaderSeparator = "|---|---|---|";

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <path-to-README.md> <path-to-discovery-directory>");
    return 1;
}

string readmePath = args[0];
string discoveryDirectory = args[1];

var readmeLines = File.ReadAllLines(readmePath).ToList();
int separatorIndex = readmeLines.IndexOf(TableHeaderSeparator);
if (separatorIndex == -1)
{
    Console.WriteLine($"Unable to find header separator line in {readmePath}. Aborting.");
    return 1;
}

var linesBeforeSeparator = readmeLines.Take(separatorIndex);
var linesAfterTable = readmeLines.Skip(separatorIndex).SkipWhile(line => line != "");

var tableEntries = Directory.GetFiles(discoveryDirectory, "*.json")
    .Select(PackageTableEntry.Load)
    .OrderBy(te => te.PackageName, StringComparer.Ordinal);

var newReadmeLines = linesBeforeSeparator
    .Append(TableHeaderSeparator)
    .Concat(tableEntries.Select(te => te.ToMarkdown()))
    .Concat(linesAfterTable)
    .ToList(); // Evaluate eagerly before we start to write anything.

File.WriteAllLines(readmePath, newReadmeLines);

return 0;
