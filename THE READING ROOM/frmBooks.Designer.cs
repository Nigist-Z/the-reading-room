namespace THE_READING_ROOM;

partial class frmBooks
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        tblBooksRoot = new TableLayoutPanel();
        pnlBooksIntro = new Panel();
        lblBooksIntro = new Label();
        btnAddBook = new Button();
        tlpBooksBody = new TableLayoutPanel();
        pnlBookCatalogue = new Panel();
        tlpBookFilters = new TableLayoutPanel();
        txtSearch = new TextBox();
        cmbCategory = new ComboBox();
        cmbStock = new ComboBox();
        dgvBooks = new DataGridView();
        colIsbn = new DataGridViewTextBoxColumn();
        colTitle = new DataGridViewTextBoxColumn();
        colAuthor = new DataGridViewTextBoxColumn();
        colCategory = new DataGridViewTextBoxColumn();
        colPrice = new DataGridViewTextBoxColumn();
        colQuantity = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        lblBookCount = new Label();
        grpSelectedBook = new GroupBox();
        tlpBookDetails = new TableLayoutPanel();
        lblSelectedTitle = new Label();
        lblSelectedAuthor = new Label();
        lblIsbnCaption = new Label();
        lblSelectedIsbn = new Label();
        lblCategoryCaption = new Label();
        lblSelectedCategory = new Label();
        lblPriceCaption = new Label();
        lblSelectedPrice = new Label();
        lblOnHandCaption = new Label();
        lblSelectedQuantity = new Label();
        btnSellSelected = new Button();
        btnEditSelected = new Button();
        btnDeleteSelected = new Button();
        tblBooksRoot.SuspendLayout();
        pnlBooksIntro.SuspendLayout();
        tlpBooksBody.SuspendLayout();
        pnlBookCatalogue.SuspendLayout();
        tlpBookFilters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
        grpSelectedBook.SuspendLayout();
        tlpBookDetails.SuspendLayout();
        SuspendLayout();
        // 
        // tblBooksRoot
        // 
        tblBooksRoot.ColumnCount = 1;
        tblBooksRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblBooksRoot.Controls.Add(pnlBooksIntro, 0, 0);
        tblBooksRoot.Controls.Add(tlpBooksBody, 0, 1);
        tblBooksRoot.Dock = DockStyle.Fill;
        tblBooksRoot.Location = new Point(0, 0);
        tblBooksRoot.Name = "tblBooksRoot";
        tblBooksRoot.RowCount = 2;
        tblBooksRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        tblBooksRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblBooksRoot.Size = new Size(1000, 640);
        tblBooksRoot.TabIndex = 0;
        // 
        // pnlBooksIntro
        // 
        pnlBooksIntro.BackColor = Color.FromArgb(234, 225, 209);
        pnlBooksIntro.Controls.Add(lblBooksIntro);
        pnlBooksIntro.Controls.Add(btnAddBook);
        pnlBooksIntro.Dock = DockStyle.Fill;
        pnlBooksIntro.Location = new Point(3, 3);
        pnlBooksIntro.Name = "pnlBooksIntro";
        pnlBooksIntro.Size = new Size(994, 58);
        pnlBooksIntro.TabIndex = 0;
        // 
        // lblBooksIntro
        // 
        lblBooksIntro.AutoSize = true;
        lblBooksIntro.Font = new Font("Segoe UI", 9F);
        lblBooksIntro.ForeColor = Color.FromArgb(107, 91, 75);
        lblBooksIntro.Location = new Point(16, 23);
        lblBooksIntro.Name = "lblBooksIntro";
        lblBooksIntro.Size = new Size(123, 15);
        lblBooksIntro.TabIndex = 0;
        lblBooksIntro.Text = "Every title, in its place.";
        // 
        // btnAddBook
        // 
        btnAddBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddBook.BackColor = Color.FromArgb(61, 74, 59);
        btnAddBook.FlatStyle = FlatStyle.Flat;
        btnAddBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAddBook.ForeColor = Color.FromArgb(244, 238, 225);
        btnAddBook.Location = new Point(1642, 8);
        btnAddBook.Name = "btnAddBook";
        btnAddBook.Size = new Size(130, 36);
        btnAddBook.TabIndex = 1;
        btnAddBook.Text = "+ Add book";
        btnAddBook.UseVisualStyleBackColor = false;
        // 
        // tlpBooksBody
        // 
        tlpBooksBody.ColumnCount = 2;
        tlpBooksBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
        tlpBooksBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tlpBooksBody.Controls.Add(pnlBookCatalogue, 0, 0);
        tlpBooksBody.Controls.Add(grpSelectedBook, 1, 0);
        tlpBooksBody.Dock = DockStyle.Fill;
        tlpBooksBody.Location = new Point(3, 67);
        tlpBooksBody.Name = "tlpBooksBody";
        tlpBooksBody.RowCount = 1;
        tlpBooksBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpBooksBody.Size = new Size(994, 570);
        tlpBooksBody.TabIndex = 1;
        // 
        // pnlBookCatalogue
        // 
        pnlBookCatalogue.BackColor = Color.FromArgb(234, 225, 209);
        pnlBookCatalogue.Controls.Add(tlpBookFilters);
        pnlBookCatalogue.Controls.Add(dgvBooks);
        pnlBookCatalogue.Controls.Add(lblBookCount);
        pnlBookCatalogue.Dock = DockStyle.Fill;
        pnlBookCatalogue.Location = new Point(3, 3);
        pnlBookCatalogue.Name = "pnlBookCatalogue";
        pnlBookCatalogue.Padding = new Padding(12, 0, 12, 0);
        pnlBookCatalogue.Size = new Size(659, 564);
        pnlBookCatalogue.TabIndex = 0;
        // 
        // tlpBookFilters
        // 
        tlpBookFilters.ColumnCount = 3;
        tlpBookFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
        tlpBookFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
        tlpBookFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
        tlpBookFilters.Controls.Add(txtSearch, 0, 0);
        tlpBookFilters.Controls.Add(cmbCategory, 1, 0);
        tlpBookFilters.Controls.Add(cmbStock, 2, 0);
        tlpBookFilters.Dock = DockStyle.Top;
        tlpBookFilters.Location = new Point(12, 0);
        tlpBookFilters.Name = "tlpBookFilters";
        tlpBookFilters.RowCount = 1;
        tlpBookFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpBookFilters.Size = new Size(635, 40);
        tlpBookFilters.TabIndex = 0;
        // 
        // txtSearch
        // 
        txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSearch.Font = new Font("Segoe UI", 9F);
        txtSearch.Location = new Point(3, 5);
        txtSearch.Margin = new Padding(3, 5, 6, 3);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search title, author or ISBN";
        txtSearch.Size = new Size(384, 23);
        txtSearch.TabIndex = 0;
        // 
        // cmbCategory
        // 
        cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategory.Font = new Font("Segoe UI", 9F);
        cmbCategory.FormattingEnabled = true;
        cmbCategory.Location = new Point(396, 3);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.Size = new Size(133, 23);
        cmbCategory.TabIndex = 1;
        // 
        // cmbStock
        // 
        cmbStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbStock.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStock.Font = new Font("Segoe UI", 9F);
        cmbStock.FormattingEnabled = true;
        cmbStock.Location = new Point(535, 3);
        cmbStock.Name = "cmbStock";
        cmbStock.Size = new Size(97, 23);
        cmbStock.TabIndex = 2;
        // 
        // dgvBooks
        // 
        dgvBooks.AllowUserToAddRows = false;
        dgvBooks.AllowUserToDeleteRows = false;
        dgvBooks.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 241, 230);
        dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvBooks.BackgroundColor = Color.FromArgb(255, 252, 246);
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(221, 207, 180);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(58, 46, 36);
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvBooks.ColumnHeadersHeight = 32;
        dgvBooks.Columns.AddRange(new DataGridViewColumn[] { colIsbn, colTitle, colAuthor, colCategory, colPrice, colQuantity, colStatus });
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 252, 246);
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(58, 46, 36);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(211, 193, 162);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(58, 46, 36);
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        dgvBooks.DefaultCellStyle = dataGridViewCellStyle4;
        dgvBooks.EnableHeadersVisualStyles = false;
        dgvBooks.Location = new Point(12, 48);
        dgvBooks.MultiSelect = false;
        dgvBooks.Name = "dgvBooks";
        dgvBooks.ReadOnly = true;
        dgvBooks.RowHeadersVisible = false;
        dgvBooks.RowTemplate.Height = 48;
        dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBooks.Size = new Size(1094, 940);
        dgvBooks.TabIndex = 1;
        // 
        // colIsbn
        // 
        colIsbn.DataPropertyName = "Isbn";
        colIsbn.HeaderText = "ISBN";
        colIsbn.Name = "colIsbn";
        colIsbn.ReadOnly = true;
        colIsbn.SortMode = DataGridViewColumnSortMode.NotSortable;
        colIsbn.Width = 105;
        // 
        // colTitle
        // 
        colTitle.DataPropertyName = "Title";
        colTitle.HeaderText = "Title";
        colTitle.Name = "colTitle";
        colTitle.ReadOnly = true;
        colTitle.SortMode = DataGridViewColumnSortMode.NotSortable;
        colTitle.Width = 120;
        // 
        // colAuthor
        // 
        colAuthor.DataPropertyName = "Author";
        colAuthor.HeaderText = "Author";
        colAuthor.Name = "colAuthor";
        colAuthor.ReadOnly = true;
        colAuthor.SortMode = DataGridViewColumnSortMode.NotSortable;
        colAuthor.Width = 95;
        // 
        // colCategory
        // 
        colCategory.DataPropertyName = "Category";
        colCategory.HeaderText = "Category";
        colCategory.Name = "colCategory";
        colCategory.ReadOnly = true;
        colCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
        colCategory.Width = 78;
        // 
        // colPrice
        // 
        colPrice.DataPropertyName = "Price";
        dataGridViewCellStyle3.Format = "N2";
        colPrice.DefaultCellStyle = dataGridViewCellStyle3;
        colPrice.HeaderText = "Price";
        colPrice.Name = "colPrice";
        colPrice.ReadOnly = true;
        colPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
        colPrice.Width = 68;
        // 
        // colQuantity
        // 
        colQuantity.DataPropertyName = "Quantity";
        colQuantity.HeaderText = "Stock";
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;
        colQuantity.SortMode = DataGridViewColumnSortMode.NotSortable;
        colQuantity.Width = 48;
        // 
        // colStatus
        // 
        colStatus.DataPropertyName = "Status";
        colStatus.HeaderText = "Status";
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
        colStatus.Width = 80;
        // 
        // lblBookCount
        // 
        lblBookCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblBookCount.AutoSize = true;
        lblBookCount.Font = new Font("Segoe UI", 9F);
        lblBookCount.ForeColor = Color.FromArgb(107, 91, 75);
        lblBookCount.Location = new Point(12, 999);
        lblBookCount.Name = "lblBookCount";
        lblBookCount.Size = new Size(120, 15);
        lblBookCount.TabIndex = 2;
        lblBookCount.Text = "Showing 0 of 0 books";
        // 
        // grpSelectedBook
        // 
        grpSelectedBook.BackColor = Color.FromArgb(234, 225, 209);
        grpSelectedBook.Controls.Add(tlpBookDetails);
        grpSelectedBook.Dock = DockStyle.Fill;
        grpSelectedBook.Font = new Font("Segoe UI", 9F);
        grpSelectedBook.ForeColor = Color.FromArgb(107, 91, 75);
        grpSelectedBook.Location = new Point(668, 3);
        grpSelectedBook.Name = "grpSelectedBook";
        grpSelectedBook.Padding = new Padding(12, 8, 12, 12);
        grpSelectedBook.Size = new Size(323, 564);
        grpSelectedBook.TabIndex = 1;
        grpSelectedBook.TabStop = false;
        grpSelectedBook.Text = "Selected book";
        // 
        // tlpBookDetails
        // 
        tlpBookDetails.ColumnCount = 2;
        tlpBookDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpBookDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpBookDetails.Controls.Add(lblSelectedTitle, 0, 0);
        tlpBookDetails.Controls.Add(lblSelectedAuthor, 0, 1);
        tlpBookDetails.Controls.Add(lblIsbnCaption, 0, 2);
        tlpBookDetails.Controls.Add(lblSelectedIsbn, 1, 2);
        tlpBookDetails.Controls.Add(lblCategoryCaption, 0, 3);
        tlpBookDetails.Controls.Add(lblSelectedCategory, 1, 3);
        tlpBookDetails.Controls.Add(lblPriceCaption, 0, 4);
        tlpBookDetails.Controls.Add(lblSelectedPrice, 1, 4);
        tlpBookDetails.Controls.Add(lblOnHandCaption, 0, 5);
        tlpBookDetails.Controls.Add(lblSelectedQuantity, 1, 5);
        tlpBookDetails.Controls.Add(btnSellSelected, 0, 6);
        tlpBookDetails.Controls.Add(btnEditSelected, 0, 7);
        tlpBookDetails.Controls.Add(btnDeleteSelected, 0, 8);
        tlpBookDetails.Dock = DockStyle.Fill;
        tlpBookDetails.Location = new Point(12, 24);
        tlpBookDetails.Name = "tlpBookDetails";
        tlpBookDetails.RowCount = 9;
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpBookDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpBookDetails.Size = new Size(299, 528);
        tlpBookDetails.TabIndex = 0;
        // 
        // lblSelectedTitle
        // 
        lblSelectedTitle.AutoSize = true;
        tlpBookDetails.SetColumnSpan(lblSelectedTitle, 2);
        lblSelectedTitle.Dock = DockStyle.Fill;
        lblSelectedTitle.Font = new Font("Georgia", 14F, FontStyle.Bold);
        lblSelectedTitle.ForeColor = Color.FromArgb(58, 46, 36);
        lblSelectedTitle.Location = new Point(3, 0);
        lblSelectedTitle.Name = "lblSelectedTitle";
        lblSelectedTitle.Size = new Size(293, 34);
        lblSelectedTitle.TabIndex = 0;
        lblSelectedTitle.Text = "Select a book";
        // 
        // lblSelectedAuthor
        // 
        lblSelectedAuthor.AutoSize = true;
        tlpBookDetails.SetColumnSpan(lblSelectedAuthor, 2);
        lblSelectedAuthor.Dock = DockStyle.Fill;
        lblSelectedAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        lblSelectedAuthor.ForeColor = Color.FromArgb(107, 91, 75);
        lblSelectedAuthor.Location = new Point(3, 34);
        lblSelectedAuthor.Name = "lblSelectedAuthor";
        lblSelectedAuthor.Size = new Size(293, 28);
        lblSelectedAuthor.TabIndex = 1;
        // 
        // lblIsbnCaption
        // 
        lblIsbnCaption.AutoSize = true;
        lblIsbnCaption.Dock = DockStyle.Fill;
        lblIsbnCaption.ForeColor = Color.FromArgb(107, 91, 75);
        lblIsbnCaption.Location = new Point(3, 62);
        lblIsbnCaption.Name = "lblIsbnCaption";
        lblIsbnCaption.Size = new Size(143, 30);
        lblIsbnCaption.TabIndex = 2;
        lblIsbnCaption.Text = "ISBN";
        // 
        // lblSelectedIsbn
        // 
        lblSelectedIsbn.AutoSize = true;
        lblSelectedIsbn.Dock = DockStyle.Fill;
        lblSelectedIsbn.ForeColor = Color.FromArgb(58, 46, 36);
        lblSelectedIsbn.Location = new Point(152, 62);
        lblSelectedIsbn.Name = "lblSelectedIsbn";
        lblSelectedIsbn.Size = new Size(144, 30);
        lblSelectedIsbn.TabIndex = 3;
        lblSelectedIsbn.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblCategoryCaption
        // 
        lblCategoryCaption.AutoSize = true;
        lblCategoryCaption.Dock = DockStyle.Fill;
        lblCategoryCaption.ForeColor = Color.FromArgb(107, 91, 75);
        lblCategoryCaption.Location = new Point(3, 92);
        lblCategoryCaption.Name = "lblCategoryCaption";
        lblCategoryCaption.Size = new Size(143, 30);
        lblCategoryCaption.TabIndex = 4;
        lblCategoryCaption.Text = "Category";
        // 
        // lblSelectedCategory
        // 
        lblSelectedCategory.AutoSize = true;
        lblSelectedCategory.Dock = DockStyle.Fill;
        lblSelectedCategory.ForeColor = Color.FromArgb(58, 46, 36);
        lblSelectedCategory.Location = new Point(152, 92);
        lblSelectedCategory.Name = "lblSelectedCategory";
        lblSelectedCategory.Size = new Size(144, 30);
        lblSelectedCategory.TabIndex = 5;
        lblSelectedCategory.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblPriceCaption
        // 
        lblPriceCaption.AutoSize = true;
        lblPriceCaption.Dock = DockStyle.Fill;
        lblPriceCaption.ForeColor = Color.FromArgb(107, 91, 75);
        lblPriceCaption.Location = new Point(3, 122);
        lblPriceCaption.Name = "lblPriceCaption";
        lblPriceCaption.Size = new Size(143, 30);
        lblPriceCaption.TabIndex = 6;
        lblPriceCaption.Text = "Price";
        // 
        // lblSelectedPrice
        // 
        lblSelectedPrice.AutoSize = true;
        lblSelectedPrice.Dock = DockStyle.Fill;
        lblSelectedPrice.ForeColor = Color.FromArgb(58, 46, 36);
        lblSelectedPrice.Location = new Point(152, 122);
        lblSelectedPrice.Name = "lblSelectedPrice";
        lblSelectedPrice.Size = new Size(144, 30);
        lblSelectedPrice.TabIndex = 7;
        lblSelectedPrice.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblOnHandCaption
        // 
        lblOnHandCaption.AutoSize = true;
        lblOnHandCaption.Dock = DockStyle.Fill;
        lblOnHandCaption.ForeColor = Color.FromArgb(107, 91, 75);
        lblOnHandCaption.Location = new Point(3, 152);
        lblOnHandCaption.Name = "lblOnHandCaption";
        lblOnHandCaption.Size = new Size(143, 30);
        lblOnHandCaption.TabIndex = 8;
        lblOnHandCaption.Text = "On hand";
        // 
        // lblSelectedQuantity
        // 
        lblSelectedQuantity.AutoSize = true;
        lblSelectedQuantity.Dock = DockStyle.Fill;
        lblSelectedQuantity.ForeColor = Color.FromArgb(58, 46, 36);
        lblSelectedQuantity.Location = new Point(152, 152);
        lblSelectedQuantity.Name = "lblSelectedQuantity";
        lblSelectedQuantity.Size = new Size(144, 30);
        lblSelectedQuantity.TabIndex = 9;
        lblSelectedQuantity.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnSellSelected
        // 
        btnSellSelected.BackColor = Color.FromArgb(61, 74, 59);
        tlpBookDetails.SetColumnSpan(btnSellSelected, 2);
        btnSellSelected.Dock = DockStyle.Fill;
        btnSellSelected.FlatAppearance.BorderSize = 0;
        btnSellSelected.FlatStyle = FlatStyle.Flat;
        btnSellSelected.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSellSelected.ForeColor = Color.FromArgb(244, 238, 225);
        btnSellSelected.Location = new Point(3, 185);
        btnSellSelected.Name = "btnSellSelected";
        btnSellSelected.Size = new Size(293, 38);
        btnSellSelected.TabIndex = 10;
        btnSellSelected.Text = "Sell this book";
        btnSellSelected.UseVisualStyleBackColor = false;
        // 
        // btnEditSelected
        // 
        btnEditSelected.BackColor = Color.FromArgb(244, 238, 225);
        tlpBookDetails.SetColumnSpan(btnEditSelected, 2);
        btnEditSelected.Dock = DockStyle.Fill;
        btnEditSelected.FlatAppearance.BorderColor = Color.FromArgb(169, 124, 84);
        btnEditSelected.FlatStyle = FlatStyle.Flat;
        btnEditSelected.ForeColor = Color.FromArgb(107, 91, 75);
        btnEditSelected.Location = new Point(3, 229);
        btnEditSelected.Name = "btnEditSelected";
        btnEditSelected.Size = new Size(293, 34);
        btnEditSelected.TabIndex = 11;
        btnEditSelected.Text = "Edit";
        btnEditSelected.UseVisualStyleBackColor = false;
        // 
        // btnDeleteSelected
        // 
        btnDeleteSelected.BackColor = Color.Brown;
        tlpBookDetails.SetColumnSpan(btnDeleteSelected, 2);
        btnDeleteSelected.Dock = DockStyle.Fill;
        btnDeleteSelected.FlatAppearance.BorderColor = Color.FromArgb(191, 55, 39);
        btnDeleteSelected.FlatStyle = FlatStyle.Flat;
        btnDeleteSelected.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnDeleteSelected.ForeColor = Color.FromArgb(191, 55, 39);
        btnDeleteSelected.Location = new Point(3, 269);
        btnDeleteSelected.Name = "btnDeleteSelected";
        btnDeleteSelected.Size = new Size(293, 256);
        btnDeleteSelected.TabIndex = 12;
        btnDeleteSelected.Text = "Delete";
        btnDeleteSelected.UseVisualStyleBackColor = false;
        // 
        // frmBooks
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(234, 225, 209);
        Controls.Add(tblBooksRoot);
        ClientSize = new Size(1000, 640);
        MinimumSize = new Size(900, 600);
        Name = "frmBooks";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Books";
        tblBooksRoot.ResumeLayout(false);
        pnlBooksIntro.ResumeLayout(false);
        pnlBooksIntro.PerformLayout();
        tlpBooksBody.ResumeLayout(false);
        pnlBookCatalogue.ResumeLayout(false);
        pnlBookCatalogue.PerformLayout();
        tlpBookFilters.ResumeLayout(false);
        tlpBookFilters.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
        grpSelectedBook.ResumeLayout(false);
        tlpBookDetails.ResumeLayout(false);
        tlpBookDetails.PerformLayout();
        ResumeLayout(false);
    }

    private TableLayoutPanel tblBooksRoot;
    private Panel pnlBooksIntro;
    private Label lblBooksIntro;
    private Button btnAddBook;
    private TableLayoutPanel tlpBooksBody;
    private Panel pnlBookCatalogue;
    private TableLayoutPanel tlpBookFilters;
    private TextBox txtSearch;
    private ComboBox cmbCategory;
    private ComboBox cmbStock;
    private DataGridView dgvBooks;
    private DataGridViewTextBoxColumn colIsbn;
    private DataGridViewTextBoxColumn colTitle;
    private DataGridViewTextBoxColumn colAuthor;
    private DataGridViewTextBoxColumn colCategory;
    private DataGridViewTextBoxColumn colPrice;
    private DataGridViewTextBoxColumn colQuantity;
    private DataGridViewTextBoxColumn colStatus;
    private Label lblBookCount;
    private GroupBox grpSelectedBook;
    private TableLayoutPanel tlpBookDetails;
    private Label lblSelectedTitle;
    private Label lblSelectedAuthor;
    private Label lblIsbnCaption;
    private Label lblSelectedIsbn;
    private Label lblCategoryCaption;
    private Label lblSelectedCategory;
    private Label lblPriceCaption;
    private Label lblSelectedPrice;
    private Label lblOnHandCaption;
    private Label lblSelectedQuantity;
    private Button btnSellSelected;
    private Button btnEditSelected;
    private Button btnDeleteSelected;
}
