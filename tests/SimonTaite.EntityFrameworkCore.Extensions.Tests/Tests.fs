module Tests

open System
open Expecto
open SimonTaite.EntityFrameworkCore.Extensions

[<Tests>]
let tests =
    testList "Empty" [
        testCase "Add two integers" <| fun _ ->
            let subject = 1 + 2
            Expect.equal subject 3 "Addition works" ]
