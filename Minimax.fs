namespace CS220

/// Minimax strategy.
type MinimaxStrategy () =
  inherit AI ()
  override __.NextMove player (board: Board) =
    let sign player = if (player = O) then 1 else -1

    let rec check (board: Board) play =
        match board.CheckWinner() with
            |Some O -> sign play
            |Some X -> -sign play
            |_ ->           
                if (board.IsDraw() ) then 0
                else
                   let f (acc: int) num = 
                      if (board.IsOccupied num) then acc               
                      else
                          board.Mark num play
                          let a = check board (Marker.getOpponent play)
                          board.Clear num
                          if (-a> acc) then 
                                
                                -a
                          else
                              
                                acc
                          

                   Array.fold f -2 [|1;2;3;4;5;6;7;8;9|]
    let g acc num = 
        if (board.IsOccupied acc) then num
        else if (board.IsOccupied num) then acc
        else
            board.Mark num player
            let a = check board (Marker.getOpponent player)
            board.Clear num
            board.Mark acc player

            let b  = check board (Marker.getOpponent player)
            board.Clear acc
            if(a<   b) then num
            else acc
            
    Array.fold g  1 [|1;2;3;4;5;6;7;8;9|]