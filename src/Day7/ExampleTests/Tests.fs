module Tests

open Class
open System
open Xunit
open System.IO

[<Fact>]
let ``Example input`` () =
    let input = File.ReadAllLines("input.txt")
    let startingState = input[0].Split ',' |> Seq.map Convert.ToInt32 |> Seq.toList
    let count = run1 startingState
    Assert.Equal(37, count)
