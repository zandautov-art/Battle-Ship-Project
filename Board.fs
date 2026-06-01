namespace CS

/// Board represents a 3x3 game board.
type Board (size: int,t: bool) =
   
  let rnd = System.Random()
  let mutable step = 0

  let mutable states = 
    [| for r in 1 .. (size) -> 
        [| for c in 1 .. (size) -> EmptySlot |] 
    |]
  let mutable g = 0
  let array =
        let mutable arr = Array.create (size*size) (0,0)

        for i in 0..(size-1) do
            for j in 0..(size-1) do
                arr.[size*i + j] <- (i+1,j+1)

        for i in 0..(size*size-1) do
            let y = rnd.Next(i,size*size)
            let x = arr.[i]
            arr.[i] <- arr.[y]
            arr.[y] <- x

        arr
  member this.Size = size
  member this.IsActive = t
  
  member __.more () = 
    step <- step + 1
  member __.ste () =
    step
  member __.inc (m: int,n:int) =
    g <- g + 1 
    printfn"[*] HIT! A ship was struck at coordinate (%d, %d)!" m n
  member __.Cell ()=
     g
  member __.Ar = 
    array
    
  
  
  member __.S() =
    
          states
          |> Array.map( Array.map SlotState.toStringP)
   member __.T() =
        states
          |> Array.map( Array.map SlotState.toString)

  member __.PrintBoard () =
    
        let s =
          states
          |> Array.map( Array.map SlotState.toStringP)
        if (size=6) then
            
            printfn "+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5]
            printfn "+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4] 
            printfn "+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3]
            printfn "+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2]
            printfn "+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1]
            printfn "+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0]  
            printfn "+---+---+---+---+---+---+"
            
        else if (size =7) then 
            printfn "+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s |" s.[0].[6] s.[1].[6] s.[2].[6] s.[3].[6] s.[4].[6] s.[5].[6] s.[6].[6]
            printfn "+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5] s.[6].[5]
            printfn "+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4] s.[6].[4]
            printfn "+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3] s.[6].[3]
            printfn "+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2] s.[6].[2]
            printfn "+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1] s.[6].[1]
            printfn "+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0] s.[6].[0]
            printfn "+---+---+---+---+---+---+---+"
        else
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[8] s.[1].[8] s.[2].[8] s.[3].[8] s.[4].[8] s.[5].[8] s.[6].[8] s.[7].[8] s.[8].[8]
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[7] s.[1].[7] s.[2].[7] s.[3].[7] s.[4].[7] s.[5].[7] s.[6].[7] s.[7].[7] s.[8].[7]
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[6] s.[1].[6] s.[2].[6] s.[3].[6] s.[4].[6] s.[5].[6] s.[6].[6] s.[7].[6] s.[8].[6]
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5] s.[6].[5] s.[7].[5] s.[8].[5]
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4] s.[6].[4] s.[7].[4] s.[8].[4]
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3] s.[6].[3] s.[7].[3] s.[8].[3]
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2] s.[6].[2] s.[7].[2] s.[8].[2]
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1] s.[6].[1] s.[7].[1] s.[8].[1]
            printfn "+---+---+---+---+---+---+---+---+---+"
            printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0] s.[6].[0] s.[7].[0] s.[8].[0]
            printfn "+---+---+---+---+---+---+---+---+---+"
  
    
  member __.IsOccupied (m: int,n: int) =
    match states.[m-1].[n-1] with
    | EmptySlot|Marked -> false
    | _ -> true

  member __.IsMarke (m: int,n: int) =
    if (m>size)||(n>size)||(m=0)||(n=0) then true
    else
    match states.[m-1].[n-1] with
    | Marked -> true
    | _ -> false
    
  member __.Put (m: int,n: int) =
    if (m>size)||(n>size )||(m=0)||(n=0) then Error()
    else
    match states.[m-1].[n-1] with
    | Marked -> Error() 
        
    | _ -> 
        states.[m-1].[n-1] <- Marked
        Ok()

  member __.Mark (m,n) =
    
    if __.IsOccupied (m,n) then Error ()
    else 
        match states.[m - 1].[n-1] with
        |EmptySlot -> 
            states.[m - 1].[n-1]<- Hit 
            printfn"[*] MISS! The shell splashed harmlessly into the ocean.\n"
            Ok ()
        |Marked -> 
            states.[m - 1].[n-1]<- Dead
            __.inc(m,n)
            Ok ()

   member __.Get () = states
        

  


