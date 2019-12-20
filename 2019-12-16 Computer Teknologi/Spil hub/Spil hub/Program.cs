using System;
using System.Diagnostics;

namespace Spil_hub
{
    class Program
    {
        static int p1points = 0;
        static int p2points = 0;
        static void Main(string[] args)
        {
            StartUp();
        }

        static void StartUp()
        {
            Console.WriteLine(" -------------------------------- ");
            Console.WriteLine("| Welcome to game hub            |");
            Console.WriteLine("| Press 1 for Guessing Game      |");
            Console.WriteLine("| Press 2 for Rock Paper Scissor |");
            Console.WriteLine("| Press 3 for chat               |");
            Console.WriteLine("| Press 0 to Exit                |");
            Console.WriteLine(" -------------------------------- ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                GuessingGame();
            }
            else if (input == "2")
            {
                Console.Clear();
                RockPaperScissor();
            }
            else if (input == "3")
            {
                // VIGTIGT - Path'en er sat lokalt på min labtop så det er usandsynligt den virker på repos
                string path = "\"C:\\Users\\RJHa.skp\\source\\repos\\shiome80\\portfolio_shiome80\\2019-12-16 Computer Teknologi\\Spil hub\\Home.html";
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe", path);
            }
            else if (input == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong input");
                StartUp();
            }
        }

        private static void GuessingGame()
        {
            Random randomNum = new Random();
            int answer = randomNum.Next(1, 11);
            int guess = 0;
            int MaxGuess = 3;
            bool gameOver = false;
            int input;

            while (gameOver != true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Guessing Game");
                Console.WriteLine("Guess the number from 1-10");
                Console.WriteLine($"Guess left: {MaxGuess - guess}");

                input = int.Parse(Console.ReadLine());

                if (input == answer)
                {
                    Console.WriteLine("Correct, You won");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    StartUp();
                }
                else
                {
                    Console.WriteLine("Try again");
                    guess++;
                    if (guess == MaxGuess) { gameOver = true; }
                }
            }
        }

        private static void RockPaperScissor()
        {
            int userInput = 0;

            Random ai = new Random();
            int result = ai.Next(1, 4);

            // I wanna play a game with you
            Console.WriteLine(" -------------------------------- ");
            Console.WriteLine("| Welcome to Rock Paper Scissor! |");
            Console.WriteLine("| Rules are:                     |");
            Console.WriteLine("| Press 1 for Rock               |");
            Console.WriteLine("| Press 2 for Paper              |");
            Console.WriteLine("| Press 3 for Scissor            |");
            Console.WriteLine("| Press 0 for Return to Game Hub |");
            Console.WriteLine(" -------------------------------- ");
            Console.WriteLine($"| Your Points: {p1points}                 |");
            Console.WriteLine($"| Opponent Points: {p2points}             |");
            Console.WriteLine(" ------------------------------- ");

            userInput = int.Parse(Console.ReadLine());

            // Exit button
            if (userInput == 0) 
            {
                Console.Clear();
                StartUp(); 
            }

            Console.Clear();
            // User input processing
            if (userInput > 3) { Console.WriteLine("Wrong input. \nPlease use 1, 2, 3 for Rock Paper or Scissor"); }
            else if (userInput == 1) { Console.WriteLine("User: Rock"); }
            else if (userInput == 2) { Console.WriteLine("User: Paper"); }
            else if (userInput == 3) { Console.WriteLine("User: Scissor"); }

            // Opponent input processing
            if (result == 1) { Console.WriteLine("Opponent: Rock"); }
            else if (result == 2) { Console.WriteLine("Opponent: Paper"); }
            else if (result == 3) { Console.WriteLine("Opponent: Scissor"); }

            // Win conditions : User
            if (result == userInput) { Console.WriteLine("Draw"); }
            else if (userInput == 1 && result == 3) 
            { 
                Console.WriteLine("User wins");
                p1points++;
                PrintPoints();
            }
            else if (userInput == 2 && result == 1)
            {
                Console.WriteLine("User wins");
                p1points++;
                PrintPoints();
            }
            else if (userInput == 3 && result == 2)
            {
                Console.WriteLine("User wins");
                p1points++;
                PrintPoints();
            }

            // Win conditions : Opponent
            else if (result == 1 && userInput == 3)
            {
                Console.WriteLine("Opponent wins");
                p2points++;
                PrintPoints();
            }
            else if (result == 2 && userInput == 1)
            {
                Console.WriteLine("Opponent wins");
                p2points++;
                PrintPoints();
            }
            else if (result == 3 && userInput == 2)
            {
                Console.WriteLine("Opponent wins");
                p2points++;
                PrintPoints();
            }

            string userEnd;
            bool endRunning = true;

            while (endRunning == true)
            {
                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("Y/N");
                userEnd = Console.ReadLine();
                if (userEnd.ToLower() == "y")
                {
                    Console.Clear();
                    RockPaperScissor();
                }
                else if (userEnd.ToLower() == "n")
                {
                    Console.Clear();
                    StartUp();
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
        }
        static void PrintPoints()
        {
            Console.WriteLine($"Your Points: {p1points}");
            Console.WriteLine($"Opponent Points: {p2points}");
        }
    }
}
