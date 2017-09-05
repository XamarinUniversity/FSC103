let nums = [| 0..100 |]
let evens = Array.filter(fun n -> n%2 = 0) nums
printfn "The sum is %i" (Array.sum evens);;

[| 0..100 |]
|> Array.filter(fun n -> n%2 = 0)
|> Array.sum
|> printfn "The sum is %d" 

let list1 = [3; 4; 2; 18; 4; 22]
let list2 = Array.toList([|67; 61; 88; 36; 93; 4|])
let list3 = list1 @ list2
 
printfn "The average is %f" (List.averageBy(fun n -> float n) list3)
printfn "The average is %f" (List.average(List.map (fun n -> float n) list3))

let sum = List.sum list3
let avg = (float sum / float list3.Length)
printfn "The average is %f" (float sum / float list3.Length)

list3 
  |> List.averageBy (fun n -> float n) 
  |> printfn "The average is %f"