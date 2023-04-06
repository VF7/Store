using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]{
            new Book(1, "Book Programming"),
            new Book(2, "Book Designers"),
            new Book(3, "Book Refactoring"),
            };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book=>book.Title.Contains(titlePart)).ToArray();
        }
    }
}