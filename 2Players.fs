namespace CS
open System

type Players (s: int) =
  let player = Board (s,true)
  let opponent = Board (s,true)
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
        player.PrintBoard ()
        printfn "Player 1's ships are placed!"
        printfn "Press Enter to pass the screen to Player 2..."

        System.Console.ReadLine() |> ignore 
        System.Console.Clear()
        let k = gameinterface.Read3 (opponent)
        __.Put opponent (k.[0])
        __.Put opponent (k.[1])
        __.Put opponent (k.[2])

        printfn "\n[*] The ship is put\n"
        let l = gameinterface.Read1 (opponent)
        __.Put opponent l
        printfn "\n[*] The ship is put\n"
    
        let m = gameinterface.Read2(opponent)
        __.Put opponent (m.[0])
        __.Put opponent (m.[1])
        printfn "\n[*] The ship is put\n"

        let n = gameinterface.Read2(opponent)
        __.Put opponent (n.[0])
        __.Put opponent (n.[1])
        printfn "\n[*] The ship is put\n"

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
        player.PrintBoard ()
        printfn "Player 1's ships are placed!"
        printfn "Press Enter to pass the screen to Player 2..."

        System.Console.ReadLine() |> ignore 
        System.Console.Clear()

        let k = gameinterface.Read3 (opponent)
        __.Put opponent (k.[0])
        __.Put opponent (k.[1])
        __.Put opponent (k.[2])

        printfn "\n[*] The ship is put\n"
        let l = gameinterface.Read3 (opponent)
        __.Put opponent (l.[0])
        __.Put opponent (l.[1])
        __.Put opponent (l.[2])
        printfn "\n[*] The ship is put\n"
    
        let m = gameinterface.Read2(opponent)
        __.Put opponent (m.[0])
        __.Put opponent (m.[1])
        printfn "\n[*] The ship is put\n"
        let n = gameinterface.Read4(opponent)
        __.Put opponent (n.[0])
        __.Put opponent (n.[1])
        __.Put opponent (n.[2])
        __.Put opponent (n.[3])
        printfn "\n[*] The ship is put\n"
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
        player.PrintBoard ()
        printfn "Player 1's ships are placed!"
        printfn "Press Enter to pass the screen to Player 2..."

        System.Console.ReadLine() |> ignore 
        System.Console.Clear()

        let k = gameinterface.Read3 (opponent)
        __.Put opponent (k.[0])
        __.Put opponent (k.[1])
        __.Put opponent (k.[2])

        printfn "\n[*] The ship is put\n"
        
        let l = gameinterface.Read3 (opponent)
        __.Put opponent (l.[0])
        __.Put opponent (l.[1])
        __.Put opponent (l.[2])
      
        printfn "\n[*] The ship is put\n"
    
        let m = gameinterface.Read2(opponent)
        __.Put opponent (m.[0])
        __.Put opponent (m.[1])

        printfn "\n[*] The ship is put\n"
        let w = gameinterface.Read2(opponent)
        __.Put opponent (w.[0])
        __.Put opponent (w.[1])

        printfn "\n[*] The ship is put\n"
        let n = gameinterface.Read4(opponent)
        __.Put opponent (n.[0])
        __.Put opponent (n.[1])
        __.Put opponent (n.[2])
        __.Put opponent (n.[3])

        printfn "\n[*] The ship is put\n"

  member __.Run () =
    __.Readd ()

   
    let mutable t = 0

    let rec loop () =
      let start () =
          if t=0 then
            opponent.PrintBoard ()
  
            printfn "Player 2's ships are placed!"
            printfn "Press Enter to pass the screen to Player 1..."

            System.Console.ReadLine() |> ignore 

            System.Console.Clear()
        


            printfn "\n[*] The game has started!\n"
            t<-1
          else
              gameinterface.Print (opponent, player)
              printfn "Player 2's turn is over!"
              printfn "Press Enter to pass the screen to Player 1..."

              System.Console.ReadLine() |> ignore 

              System.Console.Clear()
      start ()


      gameinterface.Print (player, opponent)
      let nextMove = gameinterface.ReadNextMove (player, opponent)
      __.Move opponent nextMove

      gameinterface.Print (player, opponent)
      printfn "Player 1's turn is over!"
      printfn "Press Enter to pass the screen to Player 2..."
      System.Console.ReadLine() |> ignore 


      System.Console.Clear()

      gameinterface.Print (opponent, player)
      let nextove = gameinterface.ReadNextMove (opponent, player)
      __.Move player nextove
      
      opponent.more ()
      
      if __.ShouldStop () then winner
      else loop ()

    
    loop () |> function
      | 0 -> 
        gameinterface.Print ()
        printfn "[*] Game ended in draw.\n"
      | 1 -> 
        gameinterface.Print ()
        printfn "[*] %s won the game!\n" ("Player 2" )
      | _ -> 
        gameinterface.Print ()
        printfn "[*] %s won the game!\n" ("Player 1" )
    