# Memo
### How to add ExNN
```
$ dotnet new console -lang "F#" -n Ex{{NN}} -o src/Ex{{NN}}
$ dotnet sln add src/Ex{{NN}}/Ex{{NN}}.fsproj
```

### Reference Common from Ex01
```
dotnet add src/Ex01/Ex01.fsproj reference src/Common/Common.fsproj
```

### Add Test Project
```
dotnet new xunit -lang "F#" -o tests/Ex01.Tests
dotnet sln add tests/Ex01.Tests/Ex01.Tests.fsproj
dotnet add tests/Ex01.Tests/Ex01.Tests.fsproj reference src/Ex01/Ex01.fsproj
```