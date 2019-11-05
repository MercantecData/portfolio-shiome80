using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAssignment
{
    class Books
    {
        public string title;
        public string genre;
        public int copies;
        public string loanDate;

        public Books(string title, string genre, int copies)
        {
            this.title = title;
            this.genre = genre;
            this.copies = copies;
        }

        public static string BookLoan(string title, int copies, string loanDate)
        {
            DateTime date = DateTime.Now;

            if (copies > 0)
            {
                loanDate = date.ToString();
                copies -= 1;
                return $"You have checked out {title} \nThere are {copies} left \nAt {loanDate}";
            }
            else
            {
                return $"Unfortunatly we are out of copies";
            }
        }

        public static void BookReturn(string title, int copies)
        {
            copies += 1;
            Console.WriteLine($"You have returned {title} \nThere is now {copies} left");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            CheckoutMenu.OptionsMenu();
        }

        public static void BookRenew(string loanDate)
        {
            DateTime date = DateTime.Parse(loanDate);

            Console.WriteLine("\nHow many days would you like to extend?");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    TimeSpan time1 = new TimeSpan(1, 0, 0, 0);
                    DateTime extend1 = date.Add(time1);
                    Console.WriteLine($"Your new return date is: {extend1}");
                    break;
                case "2":
                    TimeSpan time2 = new TimeSpan(2, 0, 0, 0);
                    DateTime extend2 = date.Add(time2);
                    Console.WriteLine($"Your new return date is: {extend2}");
                    break;
                case "3":
                    TimeSpan time3 = new TimeSpan(3, 0, 0, 0);
                    DateTime extend3 = date.Add(time3);
                    Console.WriteLine($"Your new return date is: {extend3}");
                    break;
                case "4":
                    TimeSpan time4 = new TimeSpan(4, 0, 0, 0);
                    DateTime extend4 = date.Add(time4);
                    Console.WriteLine($"Your new return date is: {extend4}");
                    break;
                case "5":
                    TimeSpan time5 = new TimeSpan(5, 0, 0, 0);
                    DateTime extend5 = date.Add(time5);
                    Console.WriteLine($"Your new return date is: {extend5}");
                    break;
                case "6":
                    TimeSpan time6 = new TimeSpan(6, 0, 0, 0);
                    DateTime extend6 = date.Add(time6);
                    Console.WriteLine($"Your new return date is: {extend6}");
                    break;
                case "7":
                    TimeSpan time7 = new TimeSpan(7, 0, 0, 0);
                    DateTime extend7 = date.Add(time7);
                    Console.WriteLine($"Your new return date is: {extend7}");
                    break;
                default:
                    Console.WriteLine("Wrong input (1-7) only");
                    BookRenew(loanDate);
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            CheckoutMenu.OptionsMenu();
        }
    }
}
