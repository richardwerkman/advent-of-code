open System.IO
open System

let rowLength = 12
let flipBits number:int = ~~~number &&& Convert.ToInt32(new String([|for i in 0..rowLength-1 -> '1'|]), 2)

let input = File.ReadAllLines("input.txt") |> Seq.map(fun x -> Convert.ToInt32(x, 2)) |> Seq.toList

// bitshift to right until needed bit is the last bit. Then (x % 2) = 1 to see if the bit is 0 or 1
let mostCommonBitInRow (columnNr:int) (rows:int list) =
    let zeroBits = rows
                    |> Seq.filter(fun x -> ((x >>> rowLength - columnNr) % 2) = 1)
                    |> Seq.length
    let oneBits = rows.Length - zeroBits
    if zeroBits = oneBits then true else zeroBits > oneBits

// call mostCommonInRow rowLength times and add 0 or 1 bit to integer (<<< 1)
// end with >>> 1 as the last bitshift was one too many
let result1 = Seq.fold (fun (uNext:int) i -> (uNext + Convert.ToInt32 (mostCommonBitInRow i input)) <<< 1) 0 {1..rowLength} >>> 1

let inversed = flipBits result1

let answer1 = result1 * inversed
printfn "%O" answer1

let rec findOxygen columnNr (rows: int list): int = 
    if rows.Length = 1 then rows.Head else 
    let mostCommon = mostCommonBitInRow columnNr rows;
    let filtered = rows |> List.filter(fun x -> ((x >>> rowLength - columnNr) % 2) = Convert.ToInt32 mostCommon)
    findOxygen (columnNr + 1) filtered

let rec findCo2 columnNr (rows: int list): int = 
    if rows.Length = 1 then rows.Head else 
    let mostCommon = not (mostCommonBitInRow columnNr rows)
    let filtered = rows |> List.filter(fun x -> ((x >>> rowLength - columnNr) % 2) = Convert.ToInt32 mostCommon)
    findCo2 (columnNr + 1) filtered

let oxygen = findOxygen 1 input
let co2 = findCo2 1 input

let answer2 = oxygen * co2
printfn "%O" answer2