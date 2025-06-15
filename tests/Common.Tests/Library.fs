namespace Common.Tests

open System
open System.IO

module TextExt =
    let runSysIO (lines: String) (run: TextReader -> TextWriter ->Unit) =
        let input  = new StringReader(lines)
        let output = new StringWriter()

        Console.SetIn(input)
        Console.SetOut(output)

        run Console.In Console.Out

        output.ToString()
