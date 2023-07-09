
namespace BookStore
{
    public interface IStoreFormView
    {
        void SetBooksBindingSource(BindingSource books);

        void SetBookColumnNamesBindingSource(BindingSource bookColumns);

        event EventHandler GetAll;

        public event EventHandler<BookDataEventArgs>? AddEvent;

        event EventHandler<BookDataEventArgs> UpdateBookEvent;

        public event EventHandler<SearchEventArgs>? SearchInBooksEvent;

        event EventHandler GetColumnNamesFromBookTableEvent;

        public string Book_Title { get; set; }

        public string Author { get; set; }

        public string Message { get; set; }

        public bool CRUD_IsSuccessful { get; set; }

        public int RowsAffected { get; set; }
    }
}
