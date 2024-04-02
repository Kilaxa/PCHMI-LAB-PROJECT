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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            checkBoxAV.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Получаем информацию о новой книге из полей ввода
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string genre = txtGenre.Text;
            string description = txtDescription.Text;

            int availability;
            if (checkBoxAV.Checked == true)
                availability = 1;
            else availability = 0;
                

            // Создаем новую книгу и добавляем ее в базу данных
            using (var db = new AppContext())
            {
                var newBook = new Book
                {
                    title = title,
                    author = author,
                    genre = genre,
                    description = description,
                    availability = availability
                };

                db.Books.Add(newBook);
                db.SaveChanges();

                MessageBox.Show("Книга успешно добавлена!");
            }

            // Очищаем поля ввода
            ClearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            // Очищаем все поля ввода
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtDescription.Clear();
            checkBoxAV.Checked = true;
        }
    }
}
