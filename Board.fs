namespace CS220

/// Board represents a 3x3 game board.
type Board (int, bool) =
  let rnd = System.Random()
  let mutable step = 0
  let mutable states = Array2D.create 6 6 EmptySlot
  let mutable g = 0
  let array =
  let mutable arr = 
    `   Array.create 36 (0,0)

        for i in 0..5 do
            for j in 0..5 do
                arr.[6*i + j] <- (i,j)

        for i in 0..35 do
            let y = rnd.Next(i,36)
            let x = arr.[i]
            arr.[i] <- arr.[y]
            arr.[y] <- x

        arr

  
  member __.more () = 
    step <- step + 1
  member __.ste =
    step
  member __.inc () =
    g <- g + 1 
  member __.Cell =
     g
  member __.Ar = 
    array
    
  member __.toString =
    if bool then "player"
    else "computer"
  member __.PrintBoard () =
    if bool then
        let s =
          states
          |> Array.map (Array.map SlotState.toStringP)
        printfn "+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[0].[1] s.[0].[2] s.[0].[3] s.[0].[4] s.[0].[5]
        printfn "+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |" s.[1].[0] s.[1].[1] s.[1].[2] s.[1].[3] s.[1].[4] s.[1].[5]
        printfn "+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |" s.[2].[0] s.[2].[1] s.[2].[2] s.[2].[3] s.[2].[4] s.[2].[5]
        printfn "+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |" s.[3].[0] s.[3].[1] s.[3].[2] s.[3].[3] s.[3].[4] s.[3].[5]
        printfn "+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |" s.[4].[0] s.[4].[1] s.[4].[2] s.[4].[3] s.[4].[4] s.[4].[5]
        printfn "+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |" s.[5].[0] s.[5].[1] s.[5].[2] s.[5].[3] s.[5].[4] s.[5].[5]
        printfn "+---+---+---+---+---+---+"
    else 
      let s =
          states
          |> Array.map (Array.map SlotState.toString)
      printfn "+---+---+---+---+---+---+"
      printfn "| %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[0].[1] s.[0].[2] s.[0].[3] s.[0].[4] s.[0].[5]
      printfn "+---+---+---+---+---+---+"
      printfn "| %s | %s | %s | %s | %s | %s |" s.[1].[0] s.[1].[1] s.[1].[2] s.[1].[3] s.[1].[4] s.[1].[5]
      printfn "+---+---+---+---+---+---+"
      printfn "| %s | %s | %s | %s | %s | %s |" s.[2].[0] s.[2].[1] s.[2].[2] s.[2].[3] s.[2].[4] s.[2].[5]
      printfn "+---+---+---+---+---+---+"
      printfn "| %s | %s | %s | %s | %s | %s |" s.[3].[0] s.[3].[1] s.[3].[2] s.[3].[3] s.[3].[4] s.[3].[5]
      printfn "+---+---+---+---+---+---+"
      printfn "| %s | %s | %s | %s | %s | %s |" s.[4].[0] s.[4].[1] s.[4].[2] s.[4].[3] s.[4].[4] s.[4].[5]
      printfn "+---+---+---+---+---+---+"
      printfn "| %s | %s | %s | %s | %s | %s |" s.[5].[0] s.[5].[1] s.[5].[2] s.[5].[3] s.[5].[4] s.[5].[5]
      printfn "+---+---+---+---+---+---+"

  member __.IsOccupied (m: int,n: int) =
    match states.[m-1].[n-1] with
    | EmptySlot|Marked -> false
    | _ -> true
  member __.Mark (m,n) =
    if __.IsOccupied (m,n) then Error ()
    else 
        match states.[m - 1].[n-1] with
        |EmptySlot -> states.[m - 1].[n-1]<- Hit Ok ()
        |Marked -> 
            states.[m - 1].[n-1]<- Dead
            g <- g + 1
            Ok ()
        

  /// Undo marking for the given slot.
  /// Check the winner.
  member __.CheckWinner (): Marker option =
    BoardHelper.checkWinner states


