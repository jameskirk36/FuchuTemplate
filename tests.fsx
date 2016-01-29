#load "code.fsx"

open Fuchu
open Swensen.Unquote
open Code

let tests =
  testList "some tests here" [
    testCase "test here" <| fun _ ->
      test <@ getOne () = 1 @>
  ]

run tests
