module lanternfishCounter

let run runs input =
    [1 .. runs]
    // Shift all items left (state.Tail) and append the original first element. Add first element to index 6.
    |> Seq.fold (fun (state: int64 list) _ -> ((state.Tail |> List.mapi (fun i v -> if i = 6 then v + state[0] else v)) @ [state[0]])) input
    |> Seq.sum

let countLanternfish (startingState:int List) (repeatCount:int) :int64 = 
    printfn "%O" $"Initial state: {startingState}"

    let startingList = List.init 9 (fun _ -> 0L)
    let counts = startingState |> Seq.fold (fun state x -> state |> List.updateAt x (state[x] + 1L)) startingList
    
    run repeatCount counts