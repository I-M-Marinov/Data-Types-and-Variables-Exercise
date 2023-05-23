using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            while (true)
            {
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "Paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "Scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again...");
                    return;
                }
                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;

                    case 2:
                        computerMove = Paper;
                        break;

                    case 3:
                        computerMove = Scissors;
                        break;
                }

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))
                {
                    Console.WriteLine("You win.");
                }

                else if ((computerMove == Rock && playerMove == Scissors) ||
                    (computerMove == Paper && playerMove == Rock) ||
                    (computerMove == Scissors && playerMove == Paper))
                {
                    Console.WriteLine("You lose.");
                }
                else
                {
                    Console.WriteLine("This game was a draw.");
                }
                Console.WriteLine("Do you want to play again? (y/n)");
                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "y")
                    break;
                Console.Clear();
            }
        }
    }
}
