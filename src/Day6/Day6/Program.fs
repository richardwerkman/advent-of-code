open System.IO
open System
open lanternfishCounter

let input = File.ReadAllLines("input.txt")

let numbers = input[0].Split ',' |> Seq.map Convert.ToInt32 |> Seq.toList

let answer1 = countLanternfish numbers 256

printfn "%O" answer1