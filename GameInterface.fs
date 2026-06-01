namespace CS

open System

type GameInterface (player: Board, opponent: Board) =  
  let i = player.Size
  let rnd = System.Random()
  let m  = player.ToString()
  let s =
        match i with 
        |6 -> 8
        |7 -> 12
        |_ ->14
  
  member __.p = player
  member __.o = opponent
  
  member __.CheckWinner () =
 
      
      if ((s <> __.p.Cell()) && (s <>  __.o.Cell ())) then 2
      else
        if ((s = __.p.Cell()) && (s =  __.o.Cell ())) then 0

        else 
           if s = __.p.Cell() then 1
           else -1

  member __.Print(player:Board, opponent: Board) = 
    let s = player.S ()
    let b = opponent.T ()
    if (i = 6) then
        printfn "           You:%d                              Opponent:%d    "(opponent.Cell ()) (player.Cell ()) 
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5]   b.[0].[5] b.[1].[5] b.[2].[5] b.[3].[5] b.[4].[5] b.[5].[5]
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4]   b.[0].[4] b.[1].[4] b.[2].[4] b.[3].[4] b.[4].[4] b.[5].[4]
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3]   b.[0].[3] b.[1].[3] b.[2].[3] b.[3].[3] b.[4].[3] b.[5].[3]
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2]   b.[0].[2] b.[1].[2] b.[2].[2] b.[3].[2] b.[4].[2] b.[5].[2]
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1]   b.[0].[1] b.[1].[1] b.[2].[1] b.[3].[1] b.[4].[1] b.[5].[1] 
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0]   b.[0].[0] b.[1].[0] b.[2].[0] b.[3].[0] b.[4].[0] b.[5].[0]                                                                            
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
    else if (i=9) then
        printfn "           You:%d                              Opponent:%d    " (opponent.Cell ()) (player.Cell ()) 
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[8] s.[1].[8] s.[2].[8] s.[3].[8] s.[4].[8] s.[5].[8] s.[6].[8] s.[7].[8] s.[8].[8]   b.[0].[8] b.[1].[8] b.[2].[8] b.[3].[8] b.[4].[8] b.[5].[8] b.[6].[8] b.[7].[8] b.[8].[8]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[7] s.[1].[7] s.[2].[7] s.[3].[7] s.[4].[7] s.[5].[7] s.[6].[7] s.[7].[7] s.[8].[7]   b.[0].[7] b.[1].[7] b.[2].[7] b.[3].[7] b.[4].[7] b.[5].[7] b.[6].[7] b.[7].[7] b.[8].[7]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[6] s.[1].[6] s.[2].[6] s.[3].[6] s.[4].[6] s.[5].[6] s.[6].[6] s.[7].[6] s.[8].[6]   b.[0].[6] b.[1].[6] b.[2].[6] b.[3].[6] b.[4].[6] b.[5].[6] b.[6].[6] b.[7].[6] b.[8].[6]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5] s.[6].[5] s.[7].[5] s.[8].[5]   b.[0].[5] b.[1].[5] b.[2].[5] b.[3].[5] b.[4].[5] b.[5].[5] b.[6].[5] b.[7].[5] b.[8].[5]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4] s.[6].[4] s.[7].[4] s.[8].[4]   b.[0].[4] b.[1].[4] b.[2].[4] b.[3].[4] b.[4].[4] b.[5].[4] b.[6].[4] b.[7].[4] b.[8].[4]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3] s.[6].[3] s.[7].[3] s.[8].[3]   b.[0].[3] b.[1].[3] b.[2].[3] b.[3].[3] b.[4].[3] b.[5].[3] b.[6].[3] b.[7].[3] b.[8].[3]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2] s.[6].[2] s.[7].[2] s.[8].[2]   b.[0].[2] b.[1].[2] b.[2].[2] b.[3].[2] b.[4].[2] b.[5].[2] b.[6].[2] b.[7].[2] b.[8].[2]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1] s.[6].[1] s.[7].[1] s.[8].[1]   b.[0].[1] b.[1].[1] b.[2].[1] b.[3].[1] b.[4].[1] b.[5].[1] b.[6].[1] b.[7].[1] b.[8].[1] 
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0] s.[6].[0] s.[7].[0] s.[8].[0]   b.[0].[0] b.[1].[0] b.[2].[0] b.[3].[0] b.[4].[0] b.[5].[0] b.[6].[0] b.[7].[0] b.[8].[0]                                                                            
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
    else
        printfn "           You:%d                              Opponent:%d    " (opponent.Cell ()) (player.Cell ()) 
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[6] s.[1].[6] s.[2].[6] s.[3].[6] s.[4].[6] s.[5].[6] s.[6].[6]   b.[0].[6] b.[1].[6] b.[2].[6] b.[3].[6] b.[4].[6] b.[5].[6] b.[6].[6]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5] s.[6].[5]   b.[0].[5] b.[1].[5] b.[2].[5] b.[3].[5] b.[4].[5] b.[5].[5] b.[6].[5]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4] s.[6].[4]   b.[0].[4] b.[1].[4] b.[2].[4] b.[3].[4] b.[4].[4] b.[5].[4] b.[6].[4]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3] s.[6].[3]   b.[0].[3] b.[1].[3] b.[2].[3] b.[3].[3] b.[4].[3] b.[5].[3] b.[6].[3]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2] s.[6].[2]   b.[0].[2] b.[1].[2] b.[2].[2] b.[3].[2] b.[4].[2] b.[5].[2] b.[6].[2]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1] s.[6].[1]   b.[0].[1] b.[1].[1] b.[2].[1] b.[3].[1] b.[4].[1] b.[5].[1] b.[6].[1] 
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0] s.[6].[0]   b.[0].[0] b.[1].[0] b.[2].[0] b.[3].[0] b.[4].[0] b.[5].[0] b.[6].[0]                                                                            
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        
   member __.Print() = 
    let s = player.S ()
    let b = opponent.S ()
    if (i = 6) then
        printfn "           You:%d                              Opponent:%d    " (opponent.Cell ()) (player.Cell ()) 
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5]   b.[0].[5] b.[1].[5] b.[2].[5] b.[3].[5] b.[4].[5] b.[5].[5]
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4]   b.[0].[4] b.[1].[4] b.[2].[4] b.[3].[4] b.[4].[4] b.[5].[4]
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3]   b.[0].[3] b.[1].[3] b.[2].[3] b.[3].[3] b.[4].[3] b.[5].[3]
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2]   b.[0].[2] b.[1].[2] b.[2].[2] b.[3].[2] b.[4].[2] b.[5].[2]
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1]   b.[0].[1] b.[1].[1] b.[2].[1] b.[3].[1] b.[4].[1] b.[5].[1] 
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0]   b.[0].[0] b.[1].[0] b.[2].[0] b.[3].[0] b.[4].[0] b.[5].[0]                                                                            
        printfn "+---+---+---+---+---+---+      +---+---+---+---+---+---+"
    else if (i=9) then
        printfn "           You:%d                              Opponent:%d    "(opponent.Cell ()) (player.Cell ()) 
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[8] s.[1].[8] s.[2].[8] s.[3].[8] s.[4].[8] s.[5].[8] s.[6].[8] s.[7].[8] s.[8].[8]   b.[0].[8] b.[1].[8] b.[2].[8] b.[3].[8] b.[4].[8] b.[5].[8] b.[6].[8] b.[7].[8] b.[8].[8]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[7] s.[1].[7] s.[2].[7] s.[3].[7] s.[4].[7] s.[5].[7] s.[6].[7] s.[7].[7] s.[8].[7]   b.[0].[7] b.[1].[7] b.[2].[7] b.[3].[7] b.[4].[7] b.[5].[7] b.[6].[7] b.[7].[7] b.[8].[7]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[6] s.[1].[6] s.[2].[6] s.[3].[6] s.[4].[6] s.[5].[6] s.[6].[6] s.[7].[6] s.[8].[6]   b.[0].[6] b.[1].[6] b.[2].[6] b.[3].[6] b.[4].[6] b.[5].[6] b.[6].[6] b.[7].[6] b.[8].[6]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5] s.[6].[5] s.[7].[5] s.[8].[5]   b.[0].[5] b.[1].[5] b.[2].[5] b.[3].[5] b.[4].[5] b.[5].[5] b.[6].[5] b.[7].[5] b.[8].[5]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4] s.[6].[4] s.[7].[4] s.[8].[4]   b.[0].[4] b.[1].[4] b.[2].[4] b.[3].[4] b.[4].[4] b.[5].[4] b.[6].[4] b.[7].[4] b.[8].[4]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3] s.[6].[3] s.[7].[3] s.[8].[3]   b.[0].[3] b.[1].[3] b.[2].[3] b.[3].[3] b.[4].[3] b.[5].[3] b.[6].[3] b.[7].[3] b.[8].[3]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2] s.[6].[2] s.[7].[2] s.[8].[2]   b.[0].[2] b.[1].[2] b.[2].[2] b.[3].[2] b.[4].[2] b.[5].[2] b.[6].[2] b.[7].[2] b.[8].[2]
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1] s.[6].[1] s.[7].[1] s.[8].[1]   b.[0].[1] b.[1].[1] b.[2].[1] b.[3].[1] b.[4].[1] b.[5].[1] b.[6].[1] b.[7].[1] b.[8].[1] 
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0] s.[6].[0] s.[7].[0] s.[8].[0]   b.[0].[0] b.[1].[0] b.[2].[0] b.[3].[0] b.[4].[0] b.[5].[0] b.[6].[0] b.[7].[0] b.[8].[0]                                                                            
        printfn "+---+---+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+---+---+"
    else
        printfn "           You:%d                              Opponent:%d    " (opponent.Cell ()) (player.Cell ()) 
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[6] s.[1].[6] s.[2].[6] s.[3].[6] s.[4].[6] s.[5].[6] s.[6].[6]   b.[0].[6] b.[1].[6] b.[2].[6] b.[3].[6] b.[4].[6] b.[5].[6] b.[6].[6]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[5] s.[1].[5] s.[2].[5] s.[3].[5] s.[4].[5] s.[5].[5] s.[6].[5]   b.[0].[5] b.[1].[5] b.[2].[5] b.[3].[5] b.[4].[5] b.[5].[5] b.[6].[5]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[4] s.[1].[4] s.[2].[4] s.[3].[4] s.[4].[4] s.[5].[4] s.[6].[4]   b.[0].[4] b.[1].[4] b.[2].[4] b.[3].[4] b.[4].[4] b.[5].[4] b.[6].[4]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[3] s.[1].[3] s.[2].[3] s.[3].[3] s.[4].[3] s.[5].[3] s.[6].[3]   b.[0].[3] b.[1].[3] b.[2].[3] b.[3].[3] b.[4].[3] b.[5].[3] b.[6].[3]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[2] s.[1].[2] s.[2].[2] s.[3].[2] s.[4].[2] s.[5].[2] s.[6].[2]   b.[0].[2] b.[1].[2] b.[2].[2] b.[3].[2] b.[4].[2] b.[5].[2] b.[6].[2]
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[1] s.[1].[1] s.[2].[1] s.[3].[1] s.[4].[1] s.[5].[1] s.[6].[1]   b.[0].[1] b.[1].[1] b.[2].[1] b.[3].[1] b.[4].[1] b.[5].[1] b.[6].[1] 
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        printfn "| %s | %s | %s | %s | %s | %s | %s |      | %s | %s | %s | %s | %s | %s | %s |" s.[0].[0] s.[1].[0] s.[2].[0] s.[3].[0] s.[4].[0] s.[5].[0] s.[6].[0]   b.[0].[0] b.[1].[0] b.[2].[0] b.[3].[0] b.[4].[0] b.[5].[0] b.[6].[0]                                                                            
        printfn "+---+---+---+---+---+---+---+      +---+---+---+---+---+---+---+"
        
  member __.Read1 (player: Board) =
    player.PrintBoard ()
    printfn "[*] Enter the coordinates of the ship (length 1).\n"
    let idx =  Console.ReadLine ()
    try 
        let a = int( string idx.[0])
        let b = int( string idx.[1])
        if a >= 1 && a <=i  && b >= 1 && b <= i && not (player.IsMarke (a,b)) then  (a,b)
        else
        if(player.IsMarke (a,b)) then
            printfn "\n[*] The cell can't be marked.\n"
            __.Read1 (player: Board)
        else 
            printfn "\n[*] Invalid input is given.\n"
            __.Read1 (player: Board)            
    with
    | _ ->
        printfn "\n[*] Invalid input is given.\n"
        __.Read1(player: Board)
  member __.Read2 (player: Board) =
    player.PrintBoard ()

    printfn "[*] Enter the coordinates of leftmost/bottommost cell of the ship (length 2).\n"
    let i =  Console.ReadLine ()
    printfn "[*] Enter the direction of the ship"
    printfn "1. vertical"
    printfn "2. horizontal"
    let j =  Console.ReadLine ()
    try 
        let a = int( string i.[0])
        let b = int( string i.[1])
        let c = int( string j)
        if (c=1) then
            if not (player.IsMarke (a,b)) && not (player.IsMarke (a,b + 1))  then [|(a,b);(a,b+1)|]
            else
                    printfn "\n[*] Some of the cells can't be marked.\n"
                    __.Read2 (player: Board)
                

        else if (c=2) then
            if not (player.IsMarke (a,b)) && not (player.IsMarke (a+1,b ))  then [|(a,b);(a+1,b)|]
            else
                    printfn "\n[*] Some of the cells can't be marked.\n"
                    __.Read2 (player: Board)
             
        else
            printfn "\n[*] Invalid input is given.\n"
            __.Read2 (player: Board)
    with
        | _ ->
            printfn "\n[*] Invalid input is given.\n"
            __.Read2(player: Board)



  member __.Read3 (player: Board) =
    player.PrintBoard ()

    printfn "[*] Enter the coordinates of leftmost/bottommost cell of the ship (length 3).\n"
    let i =  Console.ReadLine ()

    printfn "[*] Enter the direction of the ship"
    printfn "1. vertical"
    printfn "2. horizontal"
    let j =  Console.ReadLine ()
    
    try 
        let a = int( string i.[0])
        let b = int( string i.[1])
        let c = int( string j)
        if (c=1) then
            if not (player.IsMarke (a,b)) && not (player.IsMarke (a,b + 1)) && not (player.IsMarke (a,b + 2)) then [|(a,b);(a,b+1);(a,b+2)|]
            else
                    printfn "\n[*] Some of the cells can't be marked.\n"
                    __.Read3 (player: Board)
                

        else if (c=2) then
            if not (player.IsMarke (a,b)) && not (player.IsMarke (a+1,b )) && not (player.IsMarke (a+2,b )) then [|(a,b);(a+1,b);(a+2,b)|]
            else
                    printfn "\n[*] Some of the cells can't be marked.\n"
                    __.Read3 (player: Board)
                
        else
            printfn "\n[*] Invalid input is given.\n"
            __.Read3 (player: Board)
    with
        | _ ->
            printfn "\n[*] Invalid input is given.\n"
            __.Read3(player: Board)


  member __.Read4 (player: Board) =
    player.PrintBoard ()

    printfn "[*] Enter the coordinates of leftmost/bottommost cell of the ship (length 4).\n"
    let i =  Console.ReadLine ()

    printfn "[*] Enter the direction of the ship"
    printfn "1. vertical"
    printfn "2. horizontal"
    let j =  Console.ReadLine ()
    try 
        let a = int( string i.[0])
        let b = int( string i.[1])
        let c = int( string j)
        if (c=1) then
            if not (player.IsMarke (a,b)) && not (player.IsMarke (a,b + 1)) && not (player.IsMarke (a,b+2)) && not (player.IsMarke (a,b + 3))  then [|(a,b);(a,b+1);(a,b+2);(a,b+3)|]
            else
                    printfn "\n[*] Some of the cells can't be marked.\n"
                    __.Read4 (player: Board)
                

        else if (c=2) then
            if not (player.IsMarke (a,b)) && not (player.IsMarke (a+1,b ))&& not (player.IsMarke (a+2,b)) && not (player.IsMarke (a+3,b ))  then [|(a,b);(a+1,b);(a+2,b);(a+3,b)|]
            else
                    printfn "\n[*] Some of the cells can't be marked.\n"
                    __.Read4 (player: Board)
                
        else
            printfn "\n[*] Invalid input is given.\n"
            __.Read4 (player: Board)
    with
        | _ ->
            printfn "\n[*] Invalid input is given.\n"
            __.Read4 (player: Board)



   member __.Take1 () =
    let a = rnd.Next(1,i+1)
    let b = rnd.Next(1,i+1)
    if not (opponent.IsMarke (a,b)) then (a,b)
    else __.Take1 ()


   member __.Take2 () =
    let a = rnd.Next(1,i+1)
    let b = rnd.Next(1,i+1)
    let c = rnd.Next(1,3)
    
    if not (opponent.IsMarke (a,b))&& not (opponent.IsMarke (a + c - 1,b + 2 - c )) then [|(a,b);(a + c - 1,b + 2 - c )|]
    else __.Take2 ()


   member __.Take3 () =
    
  
    let a = rnd.Next(1,i+1)
    let b = rnd.Next(1,i+1)
    let c = rnd.Next(1,3)
    
    if not (opponent.IsMarke (a,b))&& not (opponent.IsMarke (a + c - 1,b + 2 - c ))&&not (opponent.IsMarke (a + 2*c - 2 ,b + 2*(2 - c))) then [|(a,b);(a + c - 1,b + 2 - c );(a + 2*c - 2 ,b + 2*(2 - c))|]
    else __.Take3 ()

   member __.Take4 () =
    
  
    let a = rnd.Next(1,i+1)
    let b = rnd.Next(1,i+1)
    let c = rnd.Next(1,3)
    
    if not (opponent.IsMarke (a,b))&& not (opponent.IsMarke (a + c - 1,b + 2 - c ))&&not (opponent.IsMarke (a + 2*c - 2 ,b + 2*(2 - c))) && not (opponent.IsMarke (a + 3*(c - 1),b + 3*(2 - c) )) then [|(a,b);(a + c - 1,b + 2 - c );(a + 2*c - 2 ,b + 2*(2 - c));(a + 3*(c - 1),b + 3*(2 - c) )|]
    else __.Take4 ()
    


    
  member __.ReadNextMove (player: Board,opponent: Board): int*int  =
        
        printfn "[*] Make a next move.\n"
        let idx =  Console.ReadLine ()
       
        
        try
              let a = int( string idx.[0])
              let b = int( string idx.[1])
              if a >= 1 && a <=i  && b >= 1 && b <= i && not (opponent.IsOccupied (a,b)) then (a, b)
              else 
                if (opponent.IsOccupied (a,b))  then
                    printfn "\n[*] The cell is already occupied.\n"
                    __.ReadNextMove (player, opponent)
                else
                    printfn "\n[*] Invalid input is given.\n"
                    __.ReadNextMove (player,opponent)
        with
        | _ ->
            printfn "\n[*] Invalid input is given.\n"
            __.ReadNextMove(player,opponent)
