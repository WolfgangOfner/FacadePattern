using System;

namespace FacadePattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var bookServicve = new BookService.BookService();
            var book = bookServicve.LookUpBookInformation("123456789");

            Console.WriteLine($"Information for the book with the isbn  {book.Isbn}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"The author is: {book.Author}");
            Console.WriteLine($"The title is: {book.Title}");
            Console.WriteLine($"The publisher is {book.Publisher}");

            Console.ReadKey();
        }
    }
}