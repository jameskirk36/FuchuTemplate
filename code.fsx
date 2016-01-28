#load "loadDeps.fsx"

open Fuchu
open Swensen.Unquote

let tests =
  testList "some tests here" [
    testCase "test here" <| fun _ ->
      test <@ 1 = 2 @>
  ]


run tests
