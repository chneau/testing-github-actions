# testing-github-actions

Learning/testing github actions.

## next

- updating docker container latest tag to the latest deployment version too.

## conclusion

It's as easy as getting the workflow file correct. I'm now planing to replace some of my travis.ci to github action.

## links

- https://hub.docker.com/r/testingchneau/testing-github-actions/tags
- https://github.com/chneau/testing-github-actions/actions
- http://chneau.ddns.net

## dev

- Setting up some C# project

```bash
# set up
dotnet new sln --name Maths
dotnet new gitignore

dotnet new classlib --framework netcoreapp3.1 --name Operations
dotnet new xunit --name Operations.Tests
dotnet new console --name EntryPoint
dotnet new console --name HelloWorldHttp
dotnet sln add Operations
dotnet sln add Operations.Tests
dotnet sln add EntryPoint
dotnet sln add HelloWorldHttp

# references
dotnet add Operations.Tests reference Operations
dotnet add EntryPoint reference Operations

# add nugget
dotnet add package Microsoft.AspNetCore.Owin --version 3.1.3

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
