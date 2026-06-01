THE BATTLESHIP GAME

ZHAN DAUTOV: 20240947


Project Title: The Battleship game

Overview: This project is a command-line battleship game where the
user plays against an enemy. Each player has his own board with
his ships. The goal is to destroy all ships on opponent's board.


Rules: The game is played by 2 people.
Each of the Two players have their own board.

The two boards have fixed size( 6 by 6, 8 by 8 etc.) 

Both players, secretly from each other, put ships on their own boards.
The ships are rectangles 1 by n where n can be any integer.

The length of the ship is determined by n

Depending on the size of the board the number of ships of each size is same and fixed for both player. However the placing of ships is under player's consideration. However the ships can't intersect.


After placing the ships, both players alternatively attack the opponent's board picking a cell and hitting it.
If the cell belongs to the ship this cell is  destroyed, and the corresponding message is displayed. Otherwise this hit is considered a miss

The ships is destroyed only if all of its cells are destroyed.

The one who destroys all opponents ships in fewer turns is the winner.

if Both destroy each other ships in the same number of turns it will a draw

In this projects there are two modes:
Player vs Computer
or 2 Player mode
to pick "vs Computer" mode enter "1". For 2 Player mode enter "2".
Also the sizes of the board available are  6 by6, 7 by 7 and 9 by 9

For 6 by 6 board each player places:
	1 ship of length 3
	2 ship of length 2
	1 ship of length 1    
	on their own board

For 7 by 7 board each player places:
	1 ship of length 4
	2 ship of length 3
	1 ship of length 2    
	on their own board

For 9 by 9 board each player places:
	1 ship of length 4
	2 ship of length 3
	2 ship of length 2    
	on their own board


The placing of ships is done manually.
To place an ship of length n
first a player enters a coordingate of the leftmost/bottommost cell of the ships( it depends on whether the ship that player wants to place is vertical of horizontal) 
The board  of size n by n has coordinates (x,y) where x, y are integers between 1 and n. The leftmost bottom cell is (1,1)
To enter the coordinate it's  enough to enter "xy". For example input "34" is valid while input "(4,5)" is invalid.the first is x coordinate second is y
The player presses "enter" button.(in case input has more than 2 characters the first 2 characters will be taken as input)
The player indicates the direction of the ship (vertical or horizontal). Then player presses "enter" again.
if the input is invalid the program will ask to place a ship again. Otherwise the ship will be placed on board.

On each turn the player see his own board on the left and the opponent's board on the right. Ships on opponents board will be unvisible.

"X" denotes a cell that belong to some ship and was destroyed
"." denotes a miss(the attacked cell which doesn't belong to any ship)
"■" denotes a cell of player's ship and wasn't attacked

To attacj opponents board you need to enter coordinates of the cell to be hit. For example input "34" is valid while input "(4,5)" is invalid. the first is x coordinate second is y

IMPORTANT: for 2Players mode each of two players share the screen must not look at each inputs and screen while the other makes a turn.


The changes:
1) 2 playes mode was added for more entertainment and variety
2) For convinience the method for placing ship was slightly changed. First "xy entered where x, y are integers between 1 and n (n by n is the size of the box)
