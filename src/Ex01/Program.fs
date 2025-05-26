open System

[<EntryPoint>]
let main argv =
    Console.Write("What is your name? ")
    let name     = Console.ReadLine()
    let greeting = "Hello, " + name + ", nice to meet you!"
    Console.WriteLine(greeting)
    0
