module Class

let getAdjecentValues (x:int, y:int) (input:int[][]) = seq {
    if x > 0 then yield input[x - 1][y]
    if x < input[0].Length then yield input[x + 1][y]
    if y > 0 then yield input[x][y - 1]
    if x < input.Length then yield input[x][y + 1]
}

let run1 (input:int[][]) = 
    let numbers = Array.fold (fun x -> Array.fold (fun y -> ((getAdjecentValues (x, y) input) (int list = []) input)) (int list = []) input)
    numbers |> Seq.map (fun x -> x + 1) |> Seq.sum
    
    