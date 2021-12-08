open System.IO
open System
open Class

let input = File.ReadAllLines("input.txt")

let numbers = input[0].Split ',' |> Seq.map Convert.ToInt32 |> Seq.toList

let answer1 = run
let answer2 = run

printfn "%O" answer1
printfn "%O" answer2