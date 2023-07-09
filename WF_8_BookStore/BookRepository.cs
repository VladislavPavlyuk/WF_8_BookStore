

namespace BookStore
{
    public class BookRepository : IBookRepository 
    {
        public IEnumerable<Book> GetAll()
        {
            List<Book> allBooks = new();

            return allBooks;
        }

        public IEnumerable<Book> GetBooksByValue( string searchText, string columnName)
        {
            List<Book> foundBooks = new();

            return foundBooks;
        }

        public int AddBook(Book Book)
        {
            int rowsAffected = 0;

            return rowsAffected;
            
        }

        public int Edit(Book Book)
        {
            int rowsAffected = 1;

            return rowsAffected;
    }

        public List<string> GetTableColumns(string tableName)
        {
            List<string> columnNames = new List<string>();
    
            return columnNames;
        }
        
        private static void GetResultingRecords(List<Book> Books)
        {

        }        

    }
}
