#!/usr/bin/env bash
"initializes a new C# project inside a folder titled 1-new_project"

dotnet new console -n 1-new_project
cd 1-new_project
dotnet build
