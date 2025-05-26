module Tests

open System
open Xunit
open System.IO
open Ex04.Program

[<Fact>]
let ``run generates correct sentence from inputs`` () =
    // Arrange
    let input  = new StringReader("cat\nrun\nquick\nhappily")
    let output = new StringWriter()
    Console.SetIn(input)
    Console.SetOut(output)

    // Act
    let result = run Console.In Console.Out

    // Assert
    Assert.Contains(
        "Do you run your quick cat happily? That's hilarious!",
        output.ToString())
