module Tests

open Class
open System
open Xunit
open System.IO

[<Fact>]
let ``Example input`` () =
    let input = File.ReadAllLines("input.txt")
    let map = input |> Seq.map Seq.toList |> Seq.map (fun x -> x |> Seq.map (fun y -> Convert.ToInt32(y.ToString())) |> Seq.toArray) |> Seq.toArray
    let count = run1 map
    Assert.Equal(15, count)
