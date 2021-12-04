open System.IO
open System

let input = File.ReadAllLines("input.txt")

let numbers = input[0].Split ',' |> Seq.map Convert.ToInt32 |> Seq.toList

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
