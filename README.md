This package allows you to foreach over a range using C# 9.0's extension GetEnumerator.

The loop is inclusive start, exclusive end. Therefore `foreach(var i in 1..3) Console.Write(i);` will print `12`.

### Nuget

https://www.nuget.org/packages/RangeForeach/0.0.1

- nuget package manager: `Install-Package RangeForeach -Version 0.0.1`
- .net CLI: `dotnet add package RangeForeach --version 0.0.1`
- package reference `<PackageReference Include="RangeForeach" Version="0.0.1" />`


