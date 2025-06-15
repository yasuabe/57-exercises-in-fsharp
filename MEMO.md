# Memo
### How to add ExNN
```
$ dotnet new console -lang "F#" -n Ex{{NN}} -o src/Ex{{NN}}
$ dotnet sln add src/Ex{{NN}}/Ex{{NN}}.fsproj
```

### Reference Common from ExNN
```
$ dotnet add src/ExNN/ExNN.fsproj reference src/Common/Common.fsproj
```
### How to Run ExNN
```
$ dotnet run --project src/ExNN
```

### Add Test Project
```
dotnet new xunit -lang "F#" -o tests/Ex01.Tests
dotnet sln add tests/Ex01.Tests/Ex01.Tests.fsproj
dotnet add tests/Ex01.Tests/Ex01.Tests.fsproj reference src/Ex01/Ex01.fsproj
```

### How to run ExNN
```
$ dotnet test tests/ExNN.Tests/ExNN.Tests.fsproj 
```
