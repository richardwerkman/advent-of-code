module lanternfishCounter

let handleLanternfish (index:int) (states:int[]) = 
    for i in 0 .. states.Length - 1 do
        

let nextDay (counts:int[]) (day:int) :int[] = 
    printfn "%O" $"After day {day}: {counts}"
    counts |> Seq.fold (fun state index -> handleLanternfish index state) counts

let countLanternfish (startingState:int List) (repeatCount:int) :bigint = 
    printfn "%O" $"Initial state: {startingState}"
    let startMap = startingState |> Seq.countBy (fun x -> x)
    let map = [| for _ in 0 .. 8 -> 0 |]
    for (key, value) in startMap do
       Array.set map key value

    let result = {1..repeatCount} |> Seq.fold (fun state day -> nextDay state day) map
    result.Length