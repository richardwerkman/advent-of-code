open System.IO

let list = File.ReadAllLines("input.txt") |> Seq.map System.Int32.Parse |> Seq.toList

let answer1 = list |> Seq.pairwise
                   |> Seq.filter(fun (a, b) -> a < b)
                   |> Seq.length

let answer2 = list |> Seq.windowed 3
                   |> Seq.map(fun x -> Seq.sum x)
                   |> Seq.pairwise
                   |> Seq.filter(fun (a, b) -> a < b)
                   |> Seq.length

printfn "%O" answer1
printfn "%O" answer2