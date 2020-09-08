# testing-github-actions

## dev

- Setting up some C# project

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

- Setting up CI

```bash
# set up
mkdir -p .github/workflows
code .github/workflows/tests.yml # see file

# docker hub account https://hub.docker.com/u/testingchneau
# docker hub image https://hub.docker.com/r/testingchneau/testing-github-actions/tags
```

- Setting up account for docker

```bash
# ubuntu
sudo adduser gitci
sudo usermod -aG docker gitci
```
