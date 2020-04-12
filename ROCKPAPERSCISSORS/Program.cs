using System;
using System.Threading;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCpu = 0;
                int numberRound = 0;
                string playerChoice = "none";
            

                Console.Write("Enter the number of rounds to win:  ");
            int rounds = Convert.ToInt32(Console.ReadLine());

            while (scorePlayer < rounds && scoreCpu < rounds)
            {
                numberRound++;

                Console.WriteLine($"Round #{numberRound}");
                Console.WriteLine($"Win {rounds} rounds to win.");
                Console.WriteLine($"Score: Player:{scorePlayer}    Computer:{scoreCpu}");
                Console.Write("Choose between Rock, Paper and Scissors: ");
                inputPlayer = Console.ReadLine();

                playerChoice = inputPlayer.ToLower();

                Random rnd = new Random();
                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "Rock";
                        Console.WriteLine("Computer chose Rock");
                        if (playerChoice == "rock")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (playerChoice == "paper")
                        {
                            Console.WriteLine("Player Wins!");
                            scorePlayer++;
                        }
                        else if (playerChoice == "scissors")
                        {
                            Console.WriteLine("Player Wins");
                            scoreCpu++;
                        }

                        break;
                    case 2:
                        inputCPU = "Paper";
                        Console.WriteLine("Computer chose Paper");
                        if (playerChoice == "rock")
                        {
                            Console.WriteLine("Computer Wins!");
                            scoreCpu++;
                        }
                        else if (playerChoice == "paper")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (playerChoice == "scissors")
                        {
                            Console.WriteLine("Player Wins");
                            scorePlayer++;
                        }

                        break;
                    case 3:
                        inputCPU = "Scissors";
                        Console.WriteLine("Computer chose Scissors");
                        if (playerChoice == "rock")
                        {
                            Console.WriteLine("Player Wins!");
                            scorePlayer++;
                        }
                        else if (playerChoice == "paper")
                        {
                            Console.WriteLine("Computer Wins!");
                            scoreCpu++;
                        }
                        else if (playerChoice == "scissors")
                        {
                            Console.WriteLine("Draw");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;

                }

                if (scorePlayer == rounds)
                {
                    Console.WriteLine("Player has won the game!");
                }
                else if (scoreCpu == rounds)
                {
                    Console.WriteLine("Computer has won the game!");
                }
                else
                {
                    
                }

                

            }
            Console.WriteLine("Do you want to play again?(y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                playAgain = true;
                Console.Clear();
            }
            else if (loop == "n")
            {
                playAgain = false;
            }
            else
            {
                    
            }
            }
        }
    }
}