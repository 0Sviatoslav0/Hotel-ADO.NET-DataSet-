using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHotel
{
    public partial class FormRooms : Form
    {
        public FormRooms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter.Update(hotelDataSet.Categories);
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            deleteRoom();
        }

        private void deleteRoom()
        {
            try
            {
                DialogResult result1 = MessageBox.Show("Ця кімната буде видалена назавжди, ви впевнені що хочете це зробити?", "Процес видалення",
        MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    categoriesBindingSource.RemoveCurrent();
                    categoriesTableAdapter.Update(hotelDataSet.Categories);
                }
            }
            catch
            {
                MessageBox.Show("Видалення неможливе, ця кімната зайнята, перевідкрийте вікно для відновлення даних!", "Помилка видалення!");
            }
        }

        private void dataGridViewFines_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("Введено недопустимі дані", "Помилка збереження");
        }

        private void FormRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelDataSet.Rooms);
            // TODO: This line of code loads data into the 'hotelDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.hotelDataSet.Categories);

        }

    }
}
