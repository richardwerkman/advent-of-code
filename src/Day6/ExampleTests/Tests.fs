module Tests

open lanternfishCounter
open Xunit
open System.IO
open System

[<Fact>]
let ``Example input`` () =
    let input = File.ReadAllLines("input.txt")
    let startingState = input[0].Split ',' |> Seq.map Convert.ToInt32 |> Seq.toList
    let count = countLanternfish startingState 80
    Assert.Equal(5934L, count)
