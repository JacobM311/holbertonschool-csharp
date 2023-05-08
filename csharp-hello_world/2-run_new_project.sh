#!/usr/bin/env bash
"initializes a new C# project inside a folder titled 2-new_project"

dotnet new console -n 2-new_project
cd 1-new_project
dotnet build
dotnet run
