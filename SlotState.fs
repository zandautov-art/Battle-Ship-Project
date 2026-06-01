namespace CS
type SlotState =
  | EmptySlot
  | Marked 
  |Hit
  |Dead

module SlotState =
  let toString = function
    | EmptySlot -> " "
    | Marked  -> " "
    |Hit -> "•"
    |Dead -> "X"
  let toStringP = function
    | EmptySlot -> " "
    | Marked  -> "■"
    |Hit -> "•"
    |Dead -> "X"

