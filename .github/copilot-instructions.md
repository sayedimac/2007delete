# Repository overview

`2007delete` is a small .NET 10 console application. It contains one executable project, one C# source file, and lightweight documentation.

## Working in this repository

- Keep changes small and focused.
- Preserve the current console-app structure unless the task explicitly asks for a refactor.
- There are no external packages, services, or persistent stores.

## Build and validate

From the repository root:

```powershell
dotnet restore
dotnet build
dotnet run
```

- `dotnet build` is the primary validation step.
- There is currently no test project.

## Repository layout

- `Program.cs` contains the top-level statements and the `Animal` type.
- `2007delete.csproj` targets `net10.0` and enables nullable reference types and implicit usings.
- `docs/architecture.md` explains the current structure and likely next steps.
- `README.md` documents the project and build commands.

