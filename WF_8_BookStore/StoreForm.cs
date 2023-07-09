
//Form control names start with a lowercase abbreviation of the type of control
#pragma warning disable IDE1006 // Naming Styles


namespace BookStore
{
    public partial class StoreForm : Form, IStoreFormView
    {
        public StoreForm() =>
            InitializeComponent();

        public event EventHandler? GetAll;
        public event EventHandler<SearchEventArgs>? SearchInBooksEvent;
        public event EventHandler<BookDataEventArgs>? AddEvent;
        public event EventHandler<BookDataEventArgs>? UpdateBookEvent;
        public event EventHandler? GetColumnNamesFromBookTableEvent;

        //---------------- helpers --------------------------------------

        protected static bool IsUrl(string input)
        {
            // Try to create a Uri object from the input string
            return Uri.TryCreate(input, UriKind.Absolute, out Uri? uriResult)
                ? uriResult != null && (uriResult.Scheme == Uri.UriSchemeHttp ||
                uriResult.Scheme == Uri.UriSchemeHttps)
                : false;
        }
        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right &&
                e.KeyCode != Keys.Delete && e.Modifiers == Keys.None)
            {
                //In this code, we check if the pressed key is either a number key
                //from the top row(Keys.D0 to Keys.D9)
                //or a number key from the numpad (Keys.NumPad0 to Keys.NumPad9).
                bool isNumericKey = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                                    (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);

                e.SuppressKeyPress = !isNumericKey;
            }
        }

        //------------------ properties -----------------------------------

        public string Book_Title { get => txtBookTitle.Text; set => txtBookTitle.Text = value; }
        public string Author { get => txtAuthor.Text; set => txtAuthor.Text = value; }
        public int ID
        {
            get
            {
                int.TryParse(lblID.Text, out int id);
                return id;
            }
            set => lblID.Text = value.ToString();
        }

        public string Message { get; set; } = "";
        public bool CRUD_IsSuccessful { get; set; }
        public int RowsAffected { get; set; }
        //public string SearchPhrase { get => Txt_Search.Text; set => Txt_Search.Text = value.ToString(); }
        public string? ColumnName { get => cmbSearchContext.SelectedValue.ToString(); }


        public void SetBooksBindingSource(BindingSource Books) =>
            dgvAll.DataSource = Books.DataSource;

        public void SetBookColumnNamesBindingSource(BindingSource BookColumns) =>
            cmbSearchContext.DataSource = BookColumns.DataSource;

        private void btnLoadAllBooks_Click(object sender, EventArgs e)
        {
            GetAll?.Invoke(this, EventArgs.Empty);
            lblRowCountStatus.Text = "Records loaded: " + RowsAffected;
        }

        /*private void btnSearchInBooks_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ColumnName))
            {
                SearchEventArgs searchArgs = new(SearchPhrase, ColumnName);
                SearchInBooksEvent?.Invoke(this, searchArgs);
                lblRowCountStatus.Text = "Records found: " + RowsAffected;
            }
        }*/

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            BookDataEventArgs BookData =
               new()
               {
                   ID = ID,
                   Book_Title = Book_Title,
                   Author = Author,
               };

            AddEvent?.Invoke(this, BookData);

            if (CRUD_IsSuccessful)
            {
                lblRowCountStatus.ForeColor = Color.Green;
                lblRowCountStatus.Text = "Records inserted: " + RowsAffected;
            }
            else
            {
                lblRowCountStatus.ForeColor = Color.Red;
                lblRowCountStatus.Text = "Record insertion Failed: " + RowsAffected;
                MessageBox.Show(Message);
            }
        }



        /*private void dgvAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int rowClicked = e.RowIndex;
            if (rowClicked > -1 && rowClicked <= dgv.RowCount)
            {
                lblID.Text = dgv.CurrentRow.Cells["ID"].Value.ToString();
                txtBookTitle.Text = dgv.CurrentRow.Cells["Book_Title"].Value.ToString();
                txtAuthor.Text = dgv.CurrentRow.Cells["Author"].Value.ToString();

                foreach (Control control in groupAddOrEdit.Controls)
                {
                    if (control is TextBox textBox)
                        textBox.ReadOnly = false;
                }
            }
        }*/

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            BookDataEventArgs BookData = new()
            {
                ID = ID,
                Book_Title = Book_Title,
                Author = Author,
            };

            UpdateBookEvent?.Invoke(this, BookData);

            if (CRUD_IsSuccessful)
            {
                lblRowCountStatus.ForeColor = Color.Green;
                lblRowCountStatus.Text = "Records updated: " + RowsAffected;
            }
            else
            {
                lblRowCountStatus.ForeColor = Color.Red;
                lblRowCountStatus.Text = "Record update Failed. Records updated: " + RowsAffected;
                MessageBox.Show(Message);
            }

        }

        /*private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupAddOrEdit.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    textBox.Text = "";
                }
            }
        }*/

        private void storeForm_Load(object sender, EventArgs e) =>
            GetColumnNamesFromBookTableEvent?.Invoke(this, e);

    }
}