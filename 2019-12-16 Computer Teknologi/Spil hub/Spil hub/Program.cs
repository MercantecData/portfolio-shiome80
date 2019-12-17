using System;
using System.Diagnostics;

namespace Spil_hub
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUp();
        }

        static void StartUp()
        {
            Console.WriteLine("Welcome to game hub");
            Console.WriteLine("Press 1 for Guessing Game");
            Console.WriteLine("Press 2 for Some other game");
            Console.WriteLine("Press 3 for chat");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Starting Guessing Game");
                GuessingGame();
            }
            else if (input == "2")
            {
                Console.WriteLine("Starting Some other game");
            }
            else if (input == "3")
            {
                string path = "\"C:\\Users\\RJHa.skp\\source\\repos\\shiome80\\portfolio_shiome80\\2019-12-16 Computer Teknologi\\Spil hub\\Home.html";
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe", path);
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
    }
}
