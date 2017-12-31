namespace FacadePattern.BookService
{
    public class Book
    {
        public Book(string isbn)
        {
            Isbn = isbn;
        }
        public string Author { get; set; }

        public string Title { get; set; }

        public string Publisher { get; set; }

        public string Isbn { get; set; }
    }
}