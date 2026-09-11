# 2007delete

`2007delete` is a minimal .NET 10 console application that demonstrates a basic C# object model. It creates a collection of animals, where each `Animal` has a name, age, species, and simple behavior methods.

## Current behavior

When the application starts, it:

1. Writes `Hello, World!` to the console.
2. Creates an in-memory `List<Animal>`.
3. Adds seven hard-coded animals to the list.
4. Writes a summary line for each animal.
5. Calls `Eat()` and `Sleep()` for each animal.

The expected console output begins with:

```text
Hello, World!
```

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

No external NuGet packages or services are required.

## Build and run

From the repository root:

```powershell
dotnet restore
dotnet build
dotnet run
```

To create a release build:

```powershell
dotnet build --configuration Release
```

## Project structure

| Path | Purpose |
| --- | --- |
| `Program.cs` | Contains the top-level application flow and the `Animal` class. |
| `2007delete.csproj` | Configures the .NET 10 executable, nullable analysis, and implicit global usings. |
| `docs/architecture.md` | Describes the current design, execution flow, and extension points. |
| `.gitignore` | Excludes .NET build output and common editor-generated files. |

## Data model

The `Animal` class exposes:

| Member | Type | Description |
| --- | --- | --- |
| `AnimalName` | `string` | Required name of the animal. |
| `Age` | `int` | Age supplied by the caller; no range validation is currently performed. |
| `Species` | `string` | Required species name. |
| `Eat()` | Method | Writes an eating message to the console. |
| `Sleep()` | Method | Writes a sleeping message to the console. |

The `required` properties must be assigned when an `Animal` is initialized. Nullable reference type analysis is enabled for the project.

## Development notes

- The application has no command-line options, user input, persistence, or error handling.
- The sample animal data exists only for the lifetime of the process.
- There is currently no automated test project.
- Build output is generated under `bin/` and `obj/` and is excluded from source control.

See [`docs/architecture.md`](docs/architecture.md) for a more detailed analysis of the code and sensible next steps.
