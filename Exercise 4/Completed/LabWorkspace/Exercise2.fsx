let generateTriangleNumbers (state, counter) = 
    Some(state, (state + counter+1, counter+1))

let triangulars = Seq.unfold generateTriangleNumbers (1,1)

triangulars 
    |> Seq.take 4
    |> Seq.toList
