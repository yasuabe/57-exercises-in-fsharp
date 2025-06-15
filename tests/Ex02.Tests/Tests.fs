module Tests

open Xunit
open Ex02.Program
open Common.Tests.TextExt

[<Fact>]
let ``sould match the example output from the book`` () =
    // Arrange / Act
    let output = runSysIO "Homer\n" run

    // Assert
    Assert.Contains("Homer has 5 characters.", output)
