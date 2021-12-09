open System.IO
open System
open Class

let input = File.ReadAllLines("input.txt")

let numbers = input[0].Split ',' |> Seq.map Convert.ToInt32 |> Seq.toList

let answer1 = run1
let answer2 = run1

printfn "%O" answer1
printfn "%O" answer2