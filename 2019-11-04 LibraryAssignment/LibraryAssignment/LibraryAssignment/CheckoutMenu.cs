using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAssignment
{
    class CheckoutMenu
    {
        public static void PickLibrary()
        {
            Console.WriteLine("Pick Library:");
            Console.WriteLine("1: Viborg");
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "1")
            {
                Library localLibrary = new Library("Viborg", 5);
                Console.WriteLine($"Hello welcome to {localLibrary.city} library. \nWe are currently {localLibrary.employees} at work\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Error");
                PickLibrary();
            }
        }

        public static void OptionsMenu()
        {
            Console.WriteLine("Would you like to: \n1. Pick a book. \n2. Return a book. \n3. Extend");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                PickBook();
            }
            else if (input == "2")
            {
                Console.Clear();
                Books.BookReturn("Something dark side", 1);
            }
            else if (input == "3")
            {
                Console.Clear();
                Books.BookRenew(DateTime.Now.ToString());
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadKey();
                OptionsMenu();
            }
        }
        public static void PickBook()
        {
            Console.WriteLine("Pick a book:");
            Console.WriteLine("1: Something dark side");
            string input = Console.ReadLine();
            Books firstBook = new Books("Something dark side", "Comedy", 1);

            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine($"You picked {firstBook.title}");
                Console.WriteLine("Proceed to checkout?\n");
                Console.ReadKey();
                Console.WriteLine(Books.BookLoan(firstBook.title, firstBook.copies, firstBook.loanDate));
                Console.WriteLine("Press any key to continue to start");
                Console.ReadKey();
                Console.Clear();
                OptionsMenu();
            }
            else
            {
                Console.WriteLine("Error");
                PickBook();
            }
        }
    }
}
