namespace Common

open System.IO

module Input =
    let promptInput (input: TextReader) (output: TextWriter) (prompt: string) =
        output.Write(prompt)
        input.ReadLine()
