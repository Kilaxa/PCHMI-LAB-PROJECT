using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHMI_LAB_PROJECT
{
    public partial class ReturnBookForm : Form
    {
        private int readerId;

        public ReturnBookForm(int readerId)
        {
            InitializeComponent();
            this.readerId = readerId;
            PopulateBookList();
        }

        private void PopulateBookList()
        {
            // Заполним выпадающий список книгами, которые читатель еще не вернул
            using (var db = new AppContext())
            {
                var reader = db.Readers.FirstOrDefault(r => r.id == readerId);
                if (reader != null)
                {
                    string[] takenBooks = reader.takenbooks.Split(','); // Разбиваем строку на отдельные книги

                    foreach (var takenBook in takenBooks)
                    {
                        comboBoxBooks.Items.Add(takenBook.Trim()); // Удаляем лишние пробелы и добавляем в список
                    }
                }
            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли книга для возврата
            if (comboBoxBooks.SelectedItem != null)
            {
                string selectedBookTitle = comboBoxBooks.SelectedItem.ToString();
                
                // Помечаем книгу как возвращенную
                using (var db = new AppContext())
                {
                    var reader = db.Readers.FirstOrDefault(r => r.id == readerId);
                    if (reader != null)
                    {
                        // Удаляем выбранную книгу из списка взятых книг читателя
                        string[] takenBooks = reader.takenbooks.Split(','); // Разбиваем строку на отдельные книги

                        reader.takenbooks = string.Join(",", takenBooks.Where(b => b.Trim() != selectedBookTitle.Trim())); // Обновляем список книг, исключив выбранную

                        // Обновляем информацию о доступности книги
                        // Извлекаем название книги из строки вида "Название книги (дата)"
                        selectedBookTitle = selectedBookTitle.Substring(0, selectedBookTitle.IndexOf("("));
                        var book = db.Books.FirstOrDefault(b => b.title.Trim() == selectedBookTitle.Trim());
                        if (book != null)
                        {
                            book.availability++; // Увеличиваем доступность книги
                        }

                        db.SaveChanges();

                        MessageBox.Show("Книга успешно возвращена.");
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите книгу для возврата.");
            }
        }
    }

}
