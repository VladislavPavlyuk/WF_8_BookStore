namespace BookStore
{

    public class StoreFormPresenter : IStoreFormPresenter
    {
        private readonly IStoreFormView _storeFormView;
        private readonly IBookRepository _BookRepository;
        private IEnumerable<Book>? _BookList;
        private readonly BindingSource _BookBindingSource;
        private readonly BindingSource _columnNamesBindingsource;


        public StoreFormPresenter(IStoreFormView mainView, IBookRepository BookRepository)
        {
            _BookBindingSource = new BindingSource();
            _columnNamesBindingsource = new BindingSource();
            _storeFormView = mainView;
            _BookRepository = BookRepository;
            AssociateEvents();
        }
        private void AssociateEvents()
        {
            _storeFormView.GetAll += OnGetAll;
            _storeFormView.SearchInBooksEvent += OnSearchInBooks;
            _storeFormView.AddEvent += OnAdd;
            _storeFormView.UpdateBookEvent += OnUpdate;
            _storeFormView.GetColumnNamesFromBookTableEvent += OnGetColumnNamesFromTable;
        }

        public void OnAdd(object? sender, BookDataEventArgs Book)
        {
            Book theBook = new()
            {
                ID = Book.ID,
                Book_Title = Book.Book_Title,
                Author = Book.Author,
            };

            ModelValidator<Book> validation = new();
            if (validation.ValidateModel(theBook) == false) //validation failed
            {
                _storeFormView.Message = validation.GetFormattedValidationResults();
                _storeFormView.CRUD_IsSuccessful = false;
                _storeFormView.RowsAffected = 0;
            }
            else //data validated
            {
                _storeFormView.RowsAffected = _BookRepository.AddBook(theBook);

                //Query has been executed but nothing was added
                if (_storeFormView.RowsAffected == 0)
                {
                    _storeFormView.Message =
                        "No records were affected. Did you try to add an Book with the same ID?";
                    _storeFormView.CRUD_IsSuccessful = false;
                }
                else
                {
                    _storeFormView.CRUD_IsSuccessful = true;
                }
            }
        }

        public void OnUpdate(object? sender, BookDataEventArgs Book)
        {
            Book theBook = new()
            {
                ID = Book.ID,
                Book_Title = Book.Book_Title,
                Author = Book.Author,
            };

            ModelValidator<Book> validation = new();

            if (validation.ValidateModel(theBook) == false) //validation failed
            {
                _storeFormView.Message = validation.GetFormattedValidationResults();
                _storeFormView.CRUD_IsSuccessful = false;
                _storeFormView.RowsAffected = 0;
            }
            else //validation success
            {
                _storeFormView.CRUD_IsSuccessful = true;
                _storeFormView.RowsAffected = _BookRepository.Edit(theBook);
            }
        }



        public void OnGetAll(object? sender, EventArgs e)
        {
            _BookList = _BookRepository.GetAll();
            _storeFormView.RowsAffected = _BookList.Count();
            SetGridViewBindingSource();
        }

 

        public void OnSearchInBooks(object? sender, SearchEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.SearchColumn))
            {
                _BookList = _BookRepository.GetBooksByValue(e.SearchPhrase, e.SearchColumn);
                _storeFormView.RowsAffected = _BookList.Count();
                SetGridViewBindingSource();
            }
            else
            {
                _storeFormView.Message =
                    "Search was HALTED: the table name was NULL or EMPTY (no table name)";
                _storeFormView.RowsAffected = 0;
            }
        }

        public void OnGetColumnNamesFromTable(object? sender, EventArgs e)
        {
            string tableName = "Books";

        }

        private void SetGridViewBindingSource()
        {
            _BookBindingSource.DataSource = _BookList;

            _storeFormView.SetBooksBindingSource(_BookBindingSource);
        }
    }
}