module CS220.BoardHelper

let checkWinner (states: SlotState array) =
    match states with
        |[|Marked O; Marked  O ;Marked  O;_;_;_;_;_;_|] -> Some O
        |[|_;_;_;Marked O; Marked  O ;Marked  O;_;_;_|] -> Some O
        |[|_;_;_;_;_;_;Marked O; Marked O ;Marked  O|] -> Some O
        |[|Marked O; _;_;_;Marked O; _;_;_;Marked O|] -> Some O
        |[|_;_;Marked O;_; Marked  O ;_;Marked  O;_;_|] -> Some O
        |[|Marked O; _;_;Marked  O ;_;_;Marked  O;_;_|] -> Some O
        |[|_;Marked O; _;_;Marked  O ;_;_;Marked  O;_|] -> Some O
        |[|_;_;Marked O; _;_;Marked  O ;_;_;Marked  O|] -> Some O
        |[|Marked X ;Marked  X ;Marked  X;_;_;_;_;_;_|] -> Some X
        |[|_;_;_;Marked X; Marked  X ;Marked  X;_;_;_|] -> Some X
        |[|_;_;_;_;_;_;Marked X; Marked  X ;Marked  X|] -> Some X
        |[|Marked X; _;_;_;Marked X; _;_;_;Marked X|] -> Some X
        |[|_;_;Marked X;_; Marked  X ;_;Marked  X;_;_|] -> Some X
        |[|Marked X; _;_;Marked  X ;_;_;Marked  X;_;_|] -> Some X
        |[|_;Marked X; _;_;Marked X ;_;_;Marked  X;_|] -> Some X
        |[|_;_;Marked X; _;_;Marked  X ;_;_;Marked  X|] -> Some X
        | _ -> None

        
        

let isDraw (states: SlotState array ) =
  if (states[0]<> EmptySlot)&&(states[1]<> EmptySlot)&&(states[2]<> EmptySlot)&&(states[3]<> EmptySlot)&&(states[4]<> EmptySlot)&&(states[5]<> EmptySlot)&&(states[6]<> EmptySlot)&&(states[7]<> EmptySlot)&&(states[8]<> EmptySlot)&&(checkWinner states =None) then true
  else false