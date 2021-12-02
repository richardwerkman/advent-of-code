open System.IO
open System

let input = File.ReadAllLines("input.txt") |> Seq.map(fun x -> x.Split ' ') |> Seq.toList

let dive1 (depth:int, distance:int) (item:string[]) =
    let value = Int32.Parse(item[1])
    match item[0] with
        | "down" -> (depth + value, distance)
        | "up" -> (depth - value, distance)
        | "forward" -> (depth, distance + value)

let dive2 (depth:int, distance:int, aim:int) (item:string[]) =
    let value = Int32.Parse(item[1])
    match item[0] with
        | "down" -> (depth, distance, aim + value)
        | "up" -> (depth, distance, aim - value)
        | "forward" -> (depth + value * aim, distance + value, aim)

let (depth1, distance1) = List.fold dive1 (0, 0) input
let answer1 = depth1 * distance1

let (depth2, distance2, _) = List.fold dive2 (0, 0, 0) input
let answer2 = depth2 * distance2

printfn "%O" answer1
printfn "%O" answer2