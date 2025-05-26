namespace Ex04

open System
open Common.Input
open System.IO

module Program =
    let run (input: TextReader) (output: TextWriter) =
        let read = promptInput input output
        let n   = read "Enter a noun: "
        let v   = read "Enter a verb: "
        let adj = read "Enter an adjective: "
        let adv = read "Enter an adverb: "

        let sentence = $"Do you {v} your {adj} {n} {adv}? That's hilarious!"
        Console.WriteLine(sentence)

    [<EntryPoint>]
    let main argv =
        run Console.In Console.Out |> ignore
        0