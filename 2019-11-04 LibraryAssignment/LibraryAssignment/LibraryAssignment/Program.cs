using System;

namespace LibraryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lol library
            Library localLibrary = new Library("Viborg", 5);
            Console.WriteLine($"Hello welcome to {localLibrary.city} library. \nWe are currently {localLibrary.employees} at work\n");

            // Maybe move this to another function (Menu)
            Books firstBook = new Books("Something dark side", "Comedy", 3);
            Console.WriteLine($"You picked {firstBook.title}");
            Console.WriteLine("Proceed to checkout?\n");
            Console.WriteLine(Books.BookLoan(firstBook.title, firstBook.copies));
            
            // Capture time of checkout
            DateTime date = DateTime.Now;
            firstBook.loanDate = date.ToString();
            Console.WriteLine(firstBook.loanDate);

            Books.BookRenew(firstBook.loanDate);

        }
    }
}
