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
    public partial class AddReaderForm : Form
    {
        public AddReaderForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Получаем введенное ФИО читателя
            string fio = txtFIO.Text;

            // Проверяем, чтобы ФИО не было пустым
            if (!string.IsNullOrEmpty(fio))
            {
                // Создаем нового читателя
                Reader newReader = new Reader
                {
                    fio = fio,
                    takenbooks = "" // При создании нового читателя список взятых книг пустой
                };

                // Добавляем нового читателя в базу данных
                using (var db = new AppContext())
                {
                    db.Readers.Add(newReader);
                    db.SaveChanges();
                }

                MessageBox.Show("Читатель успешно добавлен.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите ФИО читателя.");
            }
        }
    }
}
