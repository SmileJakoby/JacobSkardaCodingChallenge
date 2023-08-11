string[] theBoard = new String[9];
for (int i = 1; i <= theBoard.Length; i++)
{
    theBoard[i - 1] = i.ToString();
}

int turnCount = 0;
int difficulty = 0; //0 is Easy (random moves) 1 is Hard (Impossible)
string playerMove;
int randomRoll;
Random randomGenerator = new Random();
int victor = 3; //0 is Bot, 1 is Player, 2 is draw, 3 is undetermined
bool madePlay = false;

start:

Console.WriteLine("Hello, ready to play Tic-Tac-Toe? \nPress Enter to start on easy, or type Hard to start on Hard");
playerMove = Console.ReadLine();
if (playerMove == "Hard" || playerMove == "hard")
{
    difficulty = 1;
    Console.WriteLine("Good luck beating the Hard computer!");
}
else
{
    Console.WriteLine("Good luck beating the Easy computer!");
}
Console.WriteLine();
Console.WriteLine("Here is the board:\n1 2 3\n4 5 6\n7 8 9");

while (true)
{
    if (victor == 3)
    {
        Console.WriteLine("\nEnter in a number from 1 to 9 to place an X");
        playerMove = Console.ReadLine();

        //Respone to the preferred key choice
        switch (playerMove)
        {
            case "1":
                if (theBoard[0] != "O" && theBoard[0] != "X")
                {
                    theBoard[0] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }
            case "2":
                if (theBoard[1] != "O" && theBoard[1] != "X")
                {
                    theBoard[1] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }

            case "3":
                if (theBoard[2] != "O" && theBoard[2] != "X")
                {
                    theBoard[2] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }
            case "4":
                if (theBoard[3] != "O" && theBoard[3] != "X")
                {
                    theBoard[3] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }

            case "5":
                if (theBoard[4] != "O" && theBoard[4] != "X")
                {
                    theBoard[4] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }

            case "6":
                if (theBoard[5] != "O" && theBoard[5] != "X")
                {
                    theBoard[5] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }
            case "7":
                if (theBoard[6] != "O" && theBoard[6] != "X")
                {
                    theBoard[6] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }

            case "8":
                if (theBoard[7] != "O" && theBoard[7] != "X")
                {
                    theBoard[7] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }

            case "9":
                if (theBoard[8] != "O" && theBoard[8] != "X")
                {
                    theBoard[8] = "X";
                    turnCount++;
                    ComputerMove();
                    CheckForVictory();
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 3; i < 6; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 6; i < 9; i++)
                    {
                        Console.Write(theBoard[i] + " ");
                    }
                    if (victor == 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid number");
                    continue;
                }

            default:
                Console.WriteLine("\n Please enter a valid number");
                continue;
        }
    }
    //Console.WriteLine("Broke out of switch");
    if (victor == 0)
    {
        if (difficulty == 0)
        {
            Console.WriteLine("\nOh no! The easy bot won!");
        }
        if (difficulty == 1)
        {
            Console.WriteLine("\nOh no! The easy bot won!");
        }
    }
    if (victor == 1)
    {
        if (difficulty == 0)
        {
            Console.WriteLine("\nCongratulations! You beat the easy bot!");
        }
        if (difficulty == 1)
        {
            Console.WriteLine("\nIf you are seeing this, it means I failed at programming an impossible AI");
        }
    }
    if (victor == 2)
    {
        if (difficulty == 0)
        {
            Console.WriteLine("\nBummer, it's a draw!");
        }
        if (difficulty == 1)
        {
            Console.WriteLine("\nBummer, it's a draw!");
        }
    }
    
    while (true)
    {
        Console.WriteLine("\n\nWould you like to play again? Enter Y for yes, and N for no");
        playerMove = Console.ReadLine();
        switch (playerMove)
        {
            case "Y":
                Console.WriteLine("\nAlright, good luck!\n\n");
                ResetVariables();
                goto start;
            case "y":
                Console.WriteLine("\nAlright, good luck!\n\n");
                ResetVariables();
                goto start;
            case "N":
                Console.WriteLine("\nOkay, thank you for playing!");
                Environment.Exit(0);
                break;
            case "n":
                Console.WriteLine("\nOkay, thank you for playing!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nPlease enter a valid response");
                continue;
        }
            
        }
    }

void CheckForVictory()
{
    //Horizontal Player Victories
    if (theBoard[0] == "X" && theBoard[1] == "X" && theBoard[2] == "X")
    {
        victor = 1;
    }
    if (theBoard[3] == "X" && theBoard[4] == "X" && theBoard[5] == "X")
    {
        victor = 1;
    }
    if (theBoard[6] == "X" && theBoard[7] == "X" && theBoard[8] == "X")
    {
        victor = 1;
    }

    //Vertical Player Victories
    if (theBoard[0] == "X" && theBoard[3] == "X" && theBoard[6] == "X")
    {
        victor = 1;
    }
    if (theBoard[1] == "X" && theBoard[4] == "X" && theBoard[7] == "X")
    {
        victor = 1;
    }
    if (theBoard[2] == "X" && theBoard[5] == "X" && theBoard[8] == "X")
    {
        victor = 1;
    }

    //Diagonal Player Victories
    if (theBoard[0] == "X" && theBoard[4] == "X" && theBoard[8] == "X")
    {
        victor = 1;
    }
    if (theBoard[2] == "X" && theBoard[4] == "X" && theBoard[6] == "X")
    {
        victor = 1;
    }

    //Horizontal Bot Victories
    if (theBoard[0] == "O" && theBoard[1] == "O" && theBoard[2] == "O")
    {
        victor = 0;
    }
    if (theBoard[3] == "O" && theBoard[4] == "O" && theBoard[5] == "O")
    {
        victor = 0;
    }
    if (theBoard[6] == "O" && theBoard[7] == "O" && theBoard[8] == "O")
    {
        victor = 0;
    }

    //Vertical Bot Victories
    if (theBoard[0] == "O" && theBoard[3] == "O" && theBoard[6] == "O")
    {
        victor = 0;
    }
    if (theBoard[1] == "O" && theBoard[4] == "O" && theBoard[7] == "O")
    {
        victor = 0;
    }
    if (theBoard[2] == "O" && theBoard[5] == "O" && theBoard[8] == "O")
    {
        victor = 0;
    }

    //Diagonal Bot Victories
    if (theBoard[0] == "O" && theBoard[4] == "O" && theBoard[8] == "O")
    {
        victor = 0;
    }
    if (theBoard[2] == "O" && theBoard[4] == "O" && theBoard[6] == "O")
    {
        victor = 0;
    }

    //Draw
    if (theBoard[0] != "1" && theBoard[1] != "2" && theBoard[2] != "3" && theBoard[3] != "4" && theBoard[4] != "5" && theBoard[5] != "6" && theBoard[6] != "7" && theBoard[7] != "8" && theBoard[8] != "9")
    {
        victor = 2;
    }

}
void ResetVariables() //0 is bot win, 1 is player win
{
    turnCount = 0;
    difficulty = 0; 
    victor = 3;
    madePlay = false;
    for (int i = 1; i <= theBoard.Length; i++)
    {
        theBoard[i - 1] = i.ToString();
    }
}
void ComputerMove()
{
    if (difficulty == 0)
    {
        if (turnCount < 5)
        {
            randomRoll = randomGenerator.Next(0, 9);
            for (int i = 0; i < 9; i++)
            {
                if (theBoard[randomRoll] != "O" && theBoard[randomRoll] != "X")
                {
                    theBoard[randomRoll] = "O";
                    break;
                }
                else
                {
                    randomRoll++;
                    if (randomRoll > 8) { randomRoll = 0; }
                }
            }
        }
    }
    if (difficulty == 1)
    {
        if (turnCount == 1)
        {
            //Choose the middle if the player chooses a corner, choose a corner if the player does otherwise
            if (theBoard[0] == "X" || theBoard[2] == "X" || theBoard[6] == "X" | theBoard[8] == "X")
            {
                theBoard[4] = "O";
            }
            else
            {
                theBoard[0] = "O";
            }
        }
        if (turnCount >1 && turnCount < 5)
        {
            BlockPlayer();
        }
    }
}
void BlockPlayer()
{
    madePlay = false;
    //Search for any potential victories
    if (theBoard[0] == "O" && theBoard[1] == "O" && theBoard[2] == "3")
    {
        theBoard[2] = "O";
        madePlay = true;
    }
    if (!madePlay)
    {
        if (theBoard[0] == "O" && theBoard[3] == "O" && theBoard[6] == "7")
        {
            theBoard[6] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[0] == "O" && theBoard[4] == "O" && theBoard[8] == "9")
        {
            theBoard[8] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[1] == "O" && theBoard[2] == "O" && theBoard[0] != "1")
        {
            theBoard[0] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[1] == "O" && theBoard[4] == "O" && theBoard[7] == "8")
        {
            theBoard[7] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[2] == "O" && theBoard[5] == "O" && theBoard[8] == "9")
        {
            theBoard[8] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[2] == "O" && theBoard[4] == "O" && theBoard[6] == "7")
        {
            theBoard[6] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[6]  == "O" && theBoard[3] == "O" && theBoard[0] == "1")
        {
            theBoard[0] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[8] == "O" && theBoard[4] == "O" && theBoard[0] == "1")
        {
            theBoard[0] = "O"; 
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[8] == "O" && theBoard[7] == "O" && theBoard[6] == "7")
        {
            theBoard[6] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[6] == "O" && theBoard[7] == "O" && theBoard[8] == "9")
        {
            theBoard[8] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[3] == "O" && theBoard[4] == "O" && theBoard[5] == "6")
        {
            theBoard[5] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[5] == "O" && theBoard[4] == "O" && theBoard[3] == "4")
        {
            theBoard[8] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[7] == "O" && theBoard[4] == "O" && theBoard[1] == "2")
        {
            theBoard[1] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[6] == "O" && theBoard[4] == "O" && theBoard[2] == "3")
        {
            theBoard[2] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[5] == "O" && theBoard[8] == "O" && theBoard[2] == "3")
        {
            theBoard[2] = "O";
            madePlay = true;
        }
    }
    //Oops, I forgot to check for victories where the bot plays in the middle. Lemme fix that
    if (!madePlay)
    {
        if (theBoard[0] == "O" && theBoard[2] == "O" && theBoard[1] == "2")
        {
            theBoard[1] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[0] == "O" && theBoard[6] == "O" && theBoard[3] == "4")
        {
            theBoard[3] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[0] == "O" && theBoard[8] == "O" && theBoard[4] == "5")
        {
            theBoard[4] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[6] == "O" && theBoard[8] == "O" && theBoard[7] == "8")
        {
            theBoard[7] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[1] == "O" && theBoard[7] == "O" && theBoard[4] == "5")
        {
            theBoard[4] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[3] == "O" && theBoard[5] == "O" && theBoard[4] == "5")
        {
            theBoard[4] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[2] == "O" && theBoard[6] == "O" && theBoard[4] == "5")
        {
            theBoard[4] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[2] == "O" && theBoard[8] == "O" && theBoard[5] == "6")
        {
            theBoard[5] = "O";
            madePlay = true;
        }
    }
    //If no victories are found, check to make sure player doesn't have 2 corners on the 2nd turn. If they do, make the appropriate play
    if (!madePlay)
    {
        if (turnCount == 2)
        {
            if (theBoard[0] == "X" && theBoard[8] == "X")
            {
                theBoard[1] = "O";
                madePlay = true;
            }
            if (theBoard[2] == "X" && theBoard[6] == "X")
            {
                theBoard[1] = "O";
                madePlay = true;
            }
        }
    }

    //If the player doesn't have 2 corners, try to block any 3 in a rows that player might have. Using the exact same code as before, but now with "X" and "O" swapped
    if (!madePlay)
    {
        if (theBoard[0] == "X" && theBoard[1] == "X" && theBoard[2] == "3")
        {
            theBoard[2] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[0] == "X" && theBoard[3] == "X" && theBoard[6] == "7")
        {
            theBoard[6] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[0] == "X" && theBoard[4] == "X" && theBoard[8] == "9")
        {
            theBoard[8] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[1] == "X" && theBoard[2] == "X" && theBoard[0] != "1")
        {
            theBoard[0] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[1] == "X" && theBoard[4] == "X" && theBoard[7] == "8")
        {
            theBoard[7] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[2] == "X" && theBoard[5] == "X" && theBoard[8] == "9")
        {
            theBoard[8] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[2] == "X" && theBoard[4] == "X" && theBoard[6] == "7")
        {
            theBoard[6] = "O";
            madePlay = true;
        }
    }

    if (!madePlay)
    {
        if (theBoard[6] == "X" && theBoard[3] == "X" && theBoard[0] == "1")
        {
            theBoard[0] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[8] == "X" && theBoard[4] == "X" && theBoard[0] == "1")
        {
            theBoard[0] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[8] == "X" && theBoard[7] == "X" && theBoard[6] == "7")
        {
            theBoard[6] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[6] == "X" && theBoard[7] == "X" && theBoard[8] == "9")
        {
            theBoard[8] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[3] == "X" && theBoard[4] == "X" && theBoard[5] == "6")
        {
            theBoard[5] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[5] == "X" && theBoard[4] == "X" && theBoard[3] == "4")
        {
            theBoard[8] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[7] == "X" && theBoard[4] == "X" && theBoard[1] == "2")
        {
            theBoard[1] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[6] == "X" && theBoard[4] == "X" && theBoard[2] == "3")
        {
            theBoard[2] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[5] == "X" && theBoard[8] == "X" && theBoard[2] == "3")
        {
            theBoard[2] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[0] == "X" && theBoard[2] == "X" && theBoard[1] == "2")
        {
            theBoard[1] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[0] == "X" && theBoard[6] == "X" && theBoard[3] == "4")
        {
            theBoard[3] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[0] == "X" && theBoard[8] == "X" && theBoard[4] == "5")
        {
            theBoard[4] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[6] == "X" && theBoard[8] == "X" && theBoard[7] == "8")
        {
            theBoard[7] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[1] == "X" && theBoard[7] == "X" && theBoard[4] == "5")
        {
            theBoard[4] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[3] == "X" && theBoard[5] == "X" && theBoard[4] == "5")
        {
            theBoard[4] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[2] == "X" && theBoard[6] == "X" && theBoard[4] == "5")
        {
            theBoard[4] = "O";
            madePlay = true;
        }
    }
    if (!madePlay)
    {
        if (theBoard[2] == "X" && theBoard[8] == "X" && theBoard[5] == "6")
        {
            theBoard[5] = "O";
            madePlay = true;
        }
    }
    //If the bot still hasn't made a move, just make a random move (The player might just make bad, unexpected moves, so this is a failsafe)
    if (!madePlay)
    {
        randomRoll = randomGenerator.Next(0, 9);
        for (int i = 0; i < 9; i++)
        {
            if (theBoard[randomRoll] != "O" && theBoard[randomRoll] != "X")
            {
                theBoard[randomRoll] = "O";
                break;
            }
            else
            {
                randomRoll++;
                if (randomRoll > 8) { randomRoll = 0; }
            }
        }
        madePlay = true;
    }

}

