# testing-github-actions

## dev

```bash
# set up
dotnet new sln --name Maths
dotnet new gitignore

dotnet new classlib --framework netcoreapp3.1 --name Operations
dotnet new xunit --name Operations.Tests
dotnet new console --name EntryPoint
dotnet sln add Operations
dotnet sln add Operations.Tests
dotnet sln add EntryPoint

# references
dotnet add Operations.Tests reference Operations
dotnet add EntryPoint reference Operations

# run
dotnet run --project EntryPoint

# test
dotnet test
```
