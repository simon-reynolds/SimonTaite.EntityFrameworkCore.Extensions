module Tests


open Expecto
open SimonTaite.EntityFrameworkCore.Extensions

[<Tests>]
let tests =
  testList "samples" [
    testCase "Say nothing" <| fun _ ->
      let subject = ""
      Expect.equal subject "" "Not an absolute unit"
  ]
