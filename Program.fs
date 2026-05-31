module CS220.Program

let start = function
  | six ->
    TicTacToe(6).Run()
    true
  | seven ->
    TicTacToe(6).Run()
    true
  | Minima->
    TicTacToe(6).Run()
    true
  | MinimaxAIComputerFirst ->
    TicTacToe(6).Run()
    true
  | Exit -> false

let rec gameLoop keepGoing =
  if keepGoing then GameOption.take () |> start |> gameLoop
  else 0

[<EntryPoint>]
let main _args =
  printfn "[CS220] Tic Tac Toe"
  gameLoop true
