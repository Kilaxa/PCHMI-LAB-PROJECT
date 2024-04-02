using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHMI_LAB_PROJECT
{
    public partial class Form1 : Form
    {
        AppContext db;

        int selectedBookId = 0;


        public Form1()
        {
            InitializeComponent();
            db = new AppContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBooks();
            UpdateReaders();
            updateComboBox();
        }

        private void UpdateBooks()
        {
            using (var db = new AppContext())
            {
                var books = db.Books.ToList();
                dataGridViewBooks.Rows.Clear();
                foreach (var book in books)
                {
                    dataGridViewBooks.Rows.Add(book.id, book.title, book.author, book.genre, book.description, book.availability);
                }
            }
        }

        private void UpdateReaders()
        {
            using (var db = new AppContext())
            {
                var readers = db.Readers.ToList();
                dataGridViewReaders.Rows.Clear();
                foreach (var reader in readers)
                {
                    dataGridViewReaders.Rows.Add(reader.id, reader.fio, reader.takenbooks);
                }
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            // Создаем новое окно для добавления книги
            var addBookForm = new AddBookForm();
            addBookForm.ShowDialog();

            // После закрытия окна обновляем DataGridView, чтобы отобразить добавленную книгу
            UpdateBooks();
            updateComboBox();
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что была нажата ячейка с данными, а не заголовок
            if (e.RowIndex >= 0)
            {
                // Получаем выбранную книгу
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];
                int bookId = Convert.ToInt32(row.Cells["idBook"].Value); // Предполагается, что в таблице есть столбец Id

                selectedBookId = bookId;
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли читатель
            if (dataGridViewReaders.SelectedRows.Count == 1)
            {
                // Получаем выбранного читателя
                DataGridViewRow readerRow = dataGridViewReaders.SelectedRows[0];
                int readerId = Convert.ToInt32(readerRow.Cells["idReader"].Value); // Предполагается, что в таблице есть столбец Id

                // Проверяем, выбрана ли книга
                if (selectedBookId != 0)
                {
                    // Обновляем доступность книги
                    using (var db = new AppContext())
                    {
                        var book = db.Books.FirstOrDefault(b => b.id == selectedBookId);
                        if (book != null && book.availability > 0)
                        {
                            book.availability--;

                            // Обновляем информацию в базе данных
                            db.SaveChanges();

                            // Добавляем книгу к списку взятых книг читателя
                            var reader = db.Readers.FirstOrDefault(r => r.id == readerId);
                            if (reader != null)
                            {
                                DateTime currentDate = DateTime.Today;
                                string formattedDate = currentDate.ToString("dd.MM.yyyy");

                                if (string.IsNullOrEmpty(reader.takenbooks))
                                    reader.takenbooks = book.title;
                                else
                                    reader.takenbooks += ", " + book.title;

                                reader.takenbooks += " (" + formattedDate + ")";

                                // Обновляем информацию в базе данных
                                db.SaveChanges();

                                MessageBox.Show("Книга успешно забронирована!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Книга недоступна для бронирования.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите книгу для бронирования.");
                }
            }
            else
            {
                MessageBox.Show("Выберите читателя для бронирования книги.");
            }
            UpdateBooks();
            UpdateReaders();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли читатель
            if (dataGridViewReaders.SelectedRows.Count == 1)
            {
                // Получаем выбранного читателя
                DataGridViewRow readerRow = dataGridViewReaders.SelectedRows[0];
                int readerId = Convert.ToInt32(readerRow.Cells["idReader"].Value); // Предполагается, что в таблице есть столбец Id

                // Открываем новое окно для возврата книги
                ReturnBookForm returnBookForm = new ReturnBookForm(readerId);
                returnBookForm.ShowDialog();

                // После закрытия окна обновляем DataGridView, чтобы отобразить изменения
                UpdateReaders();
                UpdateBooks();
            }
            else
            {
                MessageBox.Show("Выберите читателя для возврата книги.");
            }
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            // Открываем форму для добавления читателя
            AddReaderForm addReaderForm = new AddReaderForm();
            addReaderForm.ShowDialog();

            // После закрытия формы обновляем данные в таблице с читателями
            UpdateReaders();
        }


        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли книга для удаления
            if (dataGridViewBooks.SelectedRows.Count == 1)
            {
                // Получаем выбранную книгу
                DataGridViewRow row = dataGridViewBooks.SelectedRows[0];
                int bookId = Convert.ToInt32(row.Cells["idBook"].Value); // Предполагается, что в таблице есть столбец Id

                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту книгу?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Удаляем книгу из базы данных
                    using (var db = new AppContext())
                    {
                        var book = db.Books.FirstOrDefault(b => b.id == bookId);
                        if (book != null)
                        {
                            db.Books.Remove(book);
                            db.SaveChanges();
                            MessageBox.Show("Книга успешно удалена.");
                            UpdateBooks(); // Обновляем таблицу с книгами
                            updateComboBox();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления.");
            }
        }

        private void btnDeleteReader_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли читатель для удаления
            if (dataGridViewReaders.SelectedRows.Count == 1)
            {
                // Получаем выбранного читателя
                DataGridViewRow row = dataGridViewReaders.SelectedRows[0];
                int readerId = Convert.ToInt32(row.Cells["idReader"].Value); // Предполагается, что в таблице есть столбец Id

                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого читателя?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Удаляем читателя из базы данных
                    using (var db = new AppContext())
                    {
                        var reader = db.Readers.FirstOrDefault(r => r.id == readerId);
                        if (reader != null)
                        {
                            db.Readers.Remove(reader);
                            db.SaveChanges();
                            MessageBox.Show("Читатель успешно удален.");
                            UpdateReaders(); // Обновляем таблицу с читателями
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите читателя для удаления.");
            }
        }

        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenre = comboBoxGenres.SelectedItem.ToString();

            if (selectedGenre == "Все жанры")
            {
                // Если выбрана опция "Все жанры", отобразить все книги без фильтрации
                DisplayAllBooks();
            }
            else
            {
                // Иначе отобразить только книги выбранного жанра
                DisplayBooksByGenre(selectedGenre);
            }
        }

        private void DisplayAllBooks()
        {
            using (var db = new AppContext())
            {
                var books = db.Books.ToList();

                // Очищаем таблицу
                dataGridViewBooks.Rows.Clear();

                // Выводим все книги в таблицу
                foreach (var book in books)
                {
                    dataGridViewBooks.Rows.Add(book.id, book.title, book.author, book.genre, book.description, book.availability);
                }
            }
        }

        private void DisplayBooksByGenre(string genre)
        {
            using (var db = new AppContext())
            {
                var books = db.Books
                    .Where(b => b.genre.ToLower() == genre.ToLower())
                    .ToList();

                // Очищаем таблицу
                dataGridViewBooks.Rows.Clear();

                // Выводим найденные книги в таблицу
                foreach (var book in books)
                {
                    dataGridViewBooks.Rows.Add(book.id, book.title, book.author, book.genre, book.description, book.availability);
                }
            }
        }

        private void updateComboBox()
        {
            comboBoxGenres.Items.Clear(); // Очистка списка

            using (var db = new AppContext())
            {
                // Получаем список уникальных жанров из базы данных
                var genres = db.Books.Select(b => b.genre).Distinct().ToList();

                // Добавляем опцию "Все жанры" в начало списка
                comboBoxGenres.Items.Add("Все жанры");

                // Заполняем ComboBox списком жанров
                comboBoxGenres.Items.AddRange(genres.ToArray());
            }

            // Выбираем первый элемент в списке (опцию "Все жанры")
            comboBoxGenres.SelectedIndex = 0;
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearchBooks.Text.Trim();
            using (var db = new AppContext())
            {
                var books = db.Books
                    .Where(b => b.title.Contains(searchQuery) ||
                                b.author.Contains(searchQuery) ||
                                b.genre.Contains(searchQuery))
                    .ToList();

                dataGridViewBooks.Rows.Clear();

                foreach (var book in books)
                {
                    dataGridViewBooks.Rows.Add(book.id, book.title, book.author, book.genre, book.description, book.availability);
                }
            }
        }

        private void btnSearchReaders_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearchReaders.Text.Trim();
            using (var db = new AppContext())
            {
                var readers = db.Readers
                    .Where(r => r.fio.Contains(searchQuery) ||
                                r.takenbooks.Contains(searchQuery))
                    .ToList();

                dataGridViewReaders.Rows.Clear();

                foreach (var reader in readers)
                {
                    dataGridViewReaders.Rows.Add(reader.id, reader.fio, reader.takenbooks);
                }
            }
        }

        private void btnResetSearchBooks_Click(object sender, EventArgs e)
        {
            txtSearchBooks.Text = "";
            UpdateBooks();
        }

        private void btnResetSearchReaders_Click(object sender, EventArgs e)
        {
            txtSearchReaders.Text = "";
            UpdateBooks();
        }
    }
}
