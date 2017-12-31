using FacadePattern.API;

namespace FacadePattern.BookService
{
    public class BookService
    {
        public Book LookUpBookInformation(string isbn)
        {
            var book = new Book(isbn);

            var authorService = new AuthorService();
            var publisherService = new PublisherService();
            var titleService = new TitleService();

            book.Author = authorService.LookUpAuthor(isbn);
            book.Publisher = publisherService.LookUpPublisher(isbn);
            book.Title = titleService.LookUpTitle(isbn);

            return book;
        }
    }
}