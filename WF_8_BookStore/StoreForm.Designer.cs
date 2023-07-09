namespace BookStore
{
    partial class StoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAll = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            addAuthorToolStripMenuItem = new ToolStripMenuItem();
            deleteAuthorToolStripMenuItem = new ToolStripMenuItem();
            editAuthorToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            deleteBookToolStripMenuItem = new ToolStripMenuItem();
            editBookToolStripMenuItem = new ToolStripMenuItem();
            searchByBookToolStripMenuItem = new ToolStripMenuItem();
            lblRowCountStatus = new Label();
            lblID = new Label();
            label1 = new Label();
            cmbSearchContext = new ComboBox();
            label7 = new Label();
            txtAuthor = new ToolStripTextBox();
            txtBookTitle = new ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAll).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAll
            // 
            dgvAll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAll.BackgroundColor = SystemColors.ControlLightLight;
            dgvAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAll.GridColor = SystemColors.Window;
            dgvAll.Location = new Point(12, 44);
            dgvAll.Name = "dgvAll";
            dgvAll.RowTemplate.Height = 25;
            dgvAll.Size = new Size(570, 281);
            dgvAll.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(754, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += btnLoadAllBooks_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += btnSaveEdit_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAuthorToolStripMenuItem, deleteAuthorToolStripMenuItem, editAuthorToolStripMenuItem, addBookToolStripMenuItem, deleteBookToolStripMenuItem, editBookToolStripMenuItem, searchByBookToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // addAuthorToolStripMenuItem
            // 
            addAuthorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtAuthor });
            addAuthorToolStripMenuItem.Name = "addAuthorToolStripMenuItem";
            addAuthorToolStripMenuItem.Size = new Size(180, 22);
            addAuthorToolStripMenuItem.Text = "Add Author";
            // 
            // deleteAuthorToolStripMenuItem
            // 
            deleteAuthorToolStripMenuItem.Name = "deleteAuthorToolStripMenuItem";
            deleteAuthorToolStripMenuItem.Size = new Size(180, 22);
            deleteAuthorToolStripMenuItem.Text = "Delete Author";
            // 
            // editAuthorToolStripMenuItem
            // 
            editAuthorToolStripMenuItem.Name = "editAuthorToolStripMenuItem";
            editAuthorToolStripMenuItem.Size = new Size(180, 22);
            editAuthorToolStripMenuItem.Text = "Edit Author";
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtBookTitle });
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(180, 22);
            addBookToolStripMenuItem.Text = "Add Book";
            addBookToolStripMenuItem.Click += btnAddNewBook_Click;
            // 
            // deleteBookToolStripMenuItem
            // 
            deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            deleteBookToolStripMenuItem.Size = new Size(180, 22);
            deleteBookToolStripMenuItem.Text = "Delete Book";
            // 
            // editBookToolStripMenuItem
            // 
            editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            editBookToolStripMenuItem.Size = new Size(180, 22);
            editBookToolStripMenuItem.Text = "Edit Book";
            // 
            // searchByBookToolStripMenuItem
            // 
            searchByBookToolStripMenuItem.Name = "searchByBookToolStripMenuItem";
            searchByBookToolStripMenuItem.Size = new Size(180, 22);
            searchByBookToolStripMenuItem.Text = "Search by Book";
            // 
            // lblRowCountStatus
            // 
            lblRowCountStatus.AutoSize = true;
            lblRowCountStatus.Location = new Point(491, 342);
            lblRowCountStatus.Name = "lblRowCountStatus";
            lblRowCountStatus.Size = new Size(111, 15);
            lblRowCountStatus.TabIndex = 18;
            lblRowCountStatus.Text = "No Book added yet.";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = SystemColors.GrayText;
            lblID.Location = new Point(448, 342);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 20;
            lblID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(406, 342);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 19;
            label1.Text = "ID:";
            // 
            // cmbSearchContext
            // 
            cmbSearchContext.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchContext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSearchContext.FormattingEnabled = true;
            cmbSearchContext.Location = new Point(123, 328);
            cmbSearchContext.Name = "cmbSearchContext";
            cmbSearchContext.Size = new Size(217, 29);
            cmbSearchContext.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 328);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 5;
            label7.Text = "Search in column:";
            // 
            // txtAuthor
            // 
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            // 
            // txtBookTitle
            // 
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(100, 23);
            // 
            // StoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 374);
            Controls.Add(label1);
            Controls.Add(lblID);
            Controls.Add(label7);
            Controls.Add(lblRowCountStatus);
            Controls.Add(cmbSearchContext);
            Controls.Add(dgvAll);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StoreForm";
            Text = "Book Store";
            Load += storeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAll).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAll;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem addAuthorToolStripMenuItem;
        private ToolStripMenuItem deleteAuthorToolStripMenuItem;
        private ToolStripMenuItem editAuthorToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem deleteBookToolStripMenuItem;
        private ToolStripMenuItem editBookToolStripMenuItem;
        private ToolStripMenuItem searchByBookToolStripMenuItem;
        private Label lblID;
        private Label label1;
        private Label lblRowCountStatus;
        private ComboBox cmbSearchContext;
        private Label label7;
        private ToolStripTextBox txtAuthor;
        private ToolStripTextBox txtBookTitle;
    }
}