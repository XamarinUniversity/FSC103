type PointTransformations = {
    StartingPoint : float * float
    Move : float * float -> float * float -> float * float
} 

let Adding = {
    StartingPoint = (1., 2.) 
    Move = (fun startingpoint displacement ->  
                (fst startingpoint + fst displacement, snd startingpoint + snd displacement))
}

let Subtracting = { Adding with Move = (fun startingpoint displacement ->  
                                        (fst startingpoint - fst displacement, snd startingpoint - snd displacement))
}

//examples of using the record
let myTrans = {StartingPoint = (1.0, 2.0); Move = (fun (a,b) (c,d) -> (a*c, b*d))};;
let somePosition = myTrans.Move myTrans.StartingPoint (5.0, 5.0)

//adding is just a more specific example of above
let finalPosition = Adding.Move Adding.StartingPoint  (4.0, 5.0) //this will add the tuple 4,5 to the starting point
let finalPosition2 = Subtracting.Move Adding.StartingPoint  (8.5, 10.5) 

//and we don't need to use the provided StartingPoint, another tuple can be passed into Move
let finalPosition3 = Adding.Move (10.0, 10.0) (40.0, 50.0)

//or we can chain them together
let finalPosition4 = Adding.Move Adding.StartingPoint (Subtracting.Move (10.0, 10.0) (5.0, 5.0))
