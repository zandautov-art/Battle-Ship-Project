namespace CS
open System

type Computer (s: int) =
  let player = Board (s,true)
  let opponent = Board (s,false)
  let gameinterface = GameInterface (player, opponent)
  let mutable winner = 0

  member __.ShouldStop () =
    match gameinterface.CheckWinner () with
    | 1 -> winner <- 1; true
    | 0 -> winner <- 0; true
    | -1 -> winner <- -1; true
    | _ -> false

  member __.Move (nextPlayer: Board) nextMove =
    match nextPlayer.Mark nextMove with
    | Ok () -> ()
    | Error () -> ()

  member __.Put (nextPlayer: Board) nextMove =
    match nextPlayer.Put nextMove with
    | Ok () -> ()
    | Error () -> ()


  member __.Readd () =
    if (s= 6) then
        let g = gameinterface.Read3 (player)
        __.Put player (g.[0])
        __.Put player (g.[1])
        __.Put player (g.[2])

        printfn "\n[*] The ship is put\n"
        let t = gameinterface.Read1 (player)
        __.Put player t
        printfn "\n[*] The ship is put\n"
    
        let a = gameinterface.Read2 (player)
        __.Put player (a.[0])
        __.Put player (a.[1])
        printfn "\n[*] The ship is put\n"

        let s = gameinterface.Read2 (player)
        __.Put player (s.[0])
        __.Put player (s.[1])

        printfn "\n[*] The ship is put\n"

        let k = gameinterface.Take3 ()
        __.Put opponent (k.[0])
        __.Put opponent (k.[1])
        __.Put opponent (k.[2])

        let l = gameinterface.Take1 ()
        __.Put opponent l
    
        let m = gameinterface.Take2()
        __.Put opponent (m.[0])
        __.Put opponent (m.[1])

        let n = gameinterface.Take2()
        __.Put opponent (n.[0])
        __.Put opponent (n.[1])

    else if(s=7) then
        let g = gameinterface.Read3 (player)
        __.Put player (g.[0])
        __.Put player (g.[1])
        __.Put player (g.[2])

        printfn "\n[*] The ship is put\n"
        let t = gameinterface.Read3 (player)
        __.Put player (t.[0])
        __.Put player (t.[1])
        __.Put player (t.[2])

        printfn "\n[*] The ship is put\n"
    
        let a = gameinterface.Read2 (player)
        __.Put player (a.[0])
        __.Put player (a.[1])
        printfn "\n[*] The ship is put\n"

        let s = gameinterface.Read4 (player)
        __.Put player (s.[0])
        __.Put player (s.[1])

        __.Put player (s.[2])
        __.Put player (s.[3])

        printfn "\n[*] The ship is put\n"

        let k = gameinterface.Take3 ()
        __.Put opponent (k.[0])
        __.Put opponent (k.[1])
        __.Put opponent (k.[2])

        
        let l = gameinterface.Take3 ()
        __.Put opponent (l.[0])
        __.Put opponent (l.[1])
        __.Put opponent (l.[2])
      
    
        let m = gameinterface.Take2()
        __.Put opponent (m.[0])
        __.Put opponent (m.[1])
       
        let n = gameinterface.Take4()
        __.Put opponent (n.[0])
        __.Put opponent (n.[1])
        __.Put opponent (n.[2])
        __.Put opponent (n.[3])
    else
        let g = gameinterface.Read3 (player)
        __.Put player (g.[0])
        __.Put player (g.[1])
        __.Put player (g.[2])

        printfn "\n[*] The ship is put\n"
        let t = gameinterface.Read3 (player)
        __.Put player (t.[0])
        __.Put player (t.[1])
        __.Put player (t.[2])

        printfn "\n[*] The ship is put\n"
    
        let a = gameinterface.Read2 (player)
        __.Put player (a.[0])
        __.Put player (a.[1])
        printfn "\n[*] The ship is put\n"

        let x = gameinterface.Read2 (player)
        __.Put player (x.[0])
        __.Put player (x.[1])
        printfn "\n[*] The ship is put\n"
        let s = gameinterface.Read4 (player)
        __.Put player (s.[0])
        __.Put player (s.[1])

        __.Put player (s.[2])
        __.Put player (s.[3])

        printfn "\n[*] The ship is put\n"

        let k = gameinterface.Take3 ()
        __.Put opponent (k.[0])
        __.Put opponent (k.[1])
        __.Put opponent (k.[2])

        
        let l = gameinterface.Take3 ()
        __.Put opponent (l.[0])
        __.Put opponent (l.[1])
        __.Put opponent (l.[2])
      
    
        let m = gameinterface.Take2()
        __.Put opponent (m.[0])
        __.Put opponent (m.[1])
        let w = gameinterface.Take2()
        __.Put opponent (w.[0])
        __.Put opponent (w.[1])
        let n = gameinterface.Take4()
        __.Put opponent (n.[0])
        __.Put opponent (n.[1])
        __.Put opponent (n.[2])
        __.Put opponent (n.[3])

  member __.Run () =
    __.Readd ()
   

    
  

    let rec loop () =
      gameinterface.Print (player, opponent)
      let nextMove = gameinterface.ReadNextMove (player, opponent)
      __.Move opponent nextMove

      gameinterface.Print (player, opponent)
      printfn "Press Enter to continue..."

      System.Console.ReadLine() |> ignore 

        
    
      __.Move player opponent.Ar.[opponent.ste ()]
      
      opponent.more ()
      
      if __.ShouldStop () then winner
      else loop ()
    printfn "\n[*] The game has started!\n"
    
    loop () |> function
      | 0 -> 
        gameinterface.Print (player, opponent)
        printfn "[*] Game ended in draw.\n"
      | 1 -> 
        gameinterface.Print (player, opponent)
        
        printfn "[*] YOU LOST!!!\n" 
      | _ -> 
        gameinterface.Print (player, opponent)
        printfn "[*] YOU WON!!!\n" 
    