namespace PCHMI_LAB_PROJECT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
            this.idReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenbooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnDeleteReader = new System.Windows.Forms.Button();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetSearchReaders = new System.Windows.Forms.Button();
            this.btnSearchReaders = new System.Windows.Forms.Button();
            this.txtSearchReaders = new System.Windows.Forms.TextBox();
            this.btnResetSearchBooks = new System.Windows.Forms.Button();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.idBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBook,
            this.title,
            this.author,
            this.genre,
            this.description,
            this.availability});
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersVisible = false;
            this.dataGridViewBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1114, 324);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // dataGridViewReaders
            // 
            this.dataGridViewReaders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReader,
            this.fio,
            this.takenbooks});
            this.dataGridViewReaders.Location = new System.Drawing.Point(318, 462);
            this.dataGridViewReaders.Name = "dataGridViewReaders";
            this.dataGridViewReaders.ReadOnly = true;
            this.dataGridViewReaders.RowHeadersVisible = false;
            this.dataGridViewReaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReaders.Size = new System.Drawing.Size(808, 210);
            this.dataGridViewReaders.TabIndex = 1;
            // 
            // idReader
            // 
            this.idReader.HeaderText = "idReader";
            this.idReader.Name = "idReader";
            this.idReader.ReadOnly = true;
            this.idReader.Visible = false;
            // 
            // fio
            // 
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fio.Width = 220;
            // 
            // takenbooks
            // 
            this.takenbooks.HeaderText = "Взятые книги";
            this.takenbooks.Name = "takenbooks";
            this.takenbooks.ReadOnly = true;
            this.takenbooks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.takenbooks.Width = 586;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Данные по книгам";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(313, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Данные по читательским билетам";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.Location = new System.Drawing.Point(526, 22);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 30);
            this.buttonAddBook.TabIndex = 4;
            this.buttonAddBook.Text = "Добавить";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReserve.Location = new System.Drawing.Point(17, 462);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(250, 50);
            this.buttonReserve.TabIndex = 5;
            this.buttonReserve.Text = "Забронировать книгу";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturn.Location = new System.Drawing.Point(17, 574);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(250, 50);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Вернуть книгу ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddReader
            // 
            this.btnAddReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReader.Location = new System.Drawing.Point(971, 425);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(75, 30);
            this.btnAddReader.TabIndex = 8;
            this.btnAddReader.Text = "Добавить";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Location = new System.Drawing.Point(606, 22);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteBook.TabIndex = 9;
            this.btnDeleteBook.Text = "Удалить";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnDeleteReader
            // 
            this.btnDeleteReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReader.Location = new System.Drawing.Point(1051, 425);
            this.btnDeleteReader.Name = "btnDeleteReader";
            this.btnDeleteReader.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteReader.TabIndex = 10;
            this.btnDeleteReader.Text = "Удалить";
            this.btnDeleteReader.UseVisualStyleBackColor = true;
            this.btnDeleteReader.Click += new System.EventHandler(this.btnDeleteReader_Click);
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.Location = new System.Drawing.Point(1005, 27);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenres.TabIndex = 11;
            this.comboBoxGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(794, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фильтрация по жанру";
            // 
            // btnResetSearchReaders
            // 
            this.btnResetSearchReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSearchReaders.Location = new System.Drawing.Point(868, 430);
            this.btnResetSearchReaders.Name = "btnResetSearchReaders";
            this.btnResetSearchReaders.Size = new System.Drawing.Size(20, 20);
            this.btnResetSearchReaders.TabIndex = 19;
            this.btnResetSearchReaders.Text = "X";
            this.btnResetSearchReaders.UseVisualStyleBackColor = true;
            this.btnResetSearchReaders.Click += new System.EventHandler(this.btnResetSearchReaders_Click);
            // 
            // btnSearchReaders
            // 
            this.btnSearchReaders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchReaders.BackgroundImage")));
            this.btnSearchReaders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReaders.Location = new System.Drawing.Point(887, 425);
            this.btnSearchReaders.Name = "btnSearchReaders";
            this.btnSearchReaders.Size = new System.Drawing.Size(30, 30);
            this.btnSearchReaders.TabIndex = 18;
            this.btnSearchReaders.UseVisualStyleBackColor = true;
            this.btnSearchReaders.Click += new System.EventHandler(this.btnSearchReaders_Click);
            // 
            // txtSearchReaders
            // 
            this.txtSearchReaders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchReaders.Location = new System.Drawing.Point(629, 430);
            this.txtSearchReaders.Name = "txtSearchReaders";
            this.txtSearchReaders.Size = new System.Drawing.Size(241, 20);
            this.txtSearchReaders.TabIndex = 17;
            // 
            // btnResetSearchBooks
            // 
            this.btnResetSearchBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSearchBooks.Location = new System.Drawing.Point(425, 28);
            this.btnResetSearchBooks.Name = "btnResetSearchBooks";
            this.btnResetSearchBooks.Size = new System.Drawing.Size(20, 20);
            this.btnResetSearchBooks.TabIndex = 22;
            this.btnResetSearchBooks.Text = "X";
            this.btnResetSearchBooks.UseVisualStyleBackColor = true;
            this.btnResetSearchBooks.Click += new System.EventHandler(this.btnResetSearchBooks_Click);
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBooks.BackgroundImage")));
            this.btnSearchBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchBooks.Location = new System.Drawing.Point(444, 23);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(30, 30);
            this.btnSearchBooks.TabIndex = 21;
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBooks.Location = new System.Drawing.Point(186, 28);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(241, 20);
            this.txtSearchBooks.TabIndex = 20;
            // 
            // idBook
            // 
            this.idBook.HeaderText = "id";
            this.idBook.Name = "idBook";
            this.idBook.ReadOnly = true;
            this.idBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idBook.Visible = false;
            // 
            // title
            // 
            this.title.HeaderText = "Название";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.title.Width = 200;
            // 
            // author
            // 
            this.author.HeaderText = "Автор";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.author.Width = 150;
            // 
            // genre
            // 
            this.genre.HeaderText = "Жанр";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genre.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.description.Width = 592;
            // 
            // availability
            // 
            this.availability.FalseValue = "0";
            this.availability.HeaderText = "";
            this.availability.Name = "availability";
            this.availability.ReadOnly = true;
            this.availability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.availability.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.availability.TrueValue = "1";
            this.availability.Width = 20;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 684);
            this.Controls.Add(this.btnResetSearchBooks);
            this.Controls.Add(this.btnSearchBooks);
            this.Controls.Add(this.txtSearchBooks);
            this.Controls.Add(this.btnResetSearchReaders);
            this.Controls.Add(this.btnSearchReaders);
            this.Controls.Add(this.txtSearchReaders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGenres);
            this.Controls.Add(this.btnDeleteReader);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReaders);
            this.Controls.Add(this.dataGridViewBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridView dataGridViewReaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnDeleteReader;
        private System.Windows.Forms.ComboBox comboBoxGenres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenbooks;
        private System.Windows.Forms.Button btnResetSearchReaders;
        private System.Windows.Forms.Button btnSearchReaders;
        private System.Windows.Forms.TextBox txtSearchReaders;
        private System.Windows.Forms.Button btnResetSearchBooks;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availability;
    }
}

