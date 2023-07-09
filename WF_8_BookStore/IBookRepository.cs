
namespace BookStore
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();

        IEnumerable<Book> GetBooksByValue(string search, string columnName);

        int AddBook(Book book);

        int Edit(Book book);

        List<string> GetTableColumns(string tableName);
    }
}
