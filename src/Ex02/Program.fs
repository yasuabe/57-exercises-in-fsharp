// Ex2: Counting the Number of Characters
//
// ・Prompt the user to enter an input string.
// ・Determine the number of characters using a built-in function.
// ・Output the original string and its character count.
// ・Use a single output statement to construct the output.
namespace Ex02

open System
open System.IO
open Common.Input

module Program =
    let run (input: TextReader) (output: TextWriter) = 
        let input = promptInput input output "What is the input string? "
        let count = input.Length

        output.WriteLine($"{input} has {count} characters.")

    [<EntryPoint>]
    let main argv =
        run Console.In Console.Out |> ignore
        0
