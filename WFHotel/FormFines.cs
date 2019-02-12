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
    public partial class FormFines : Form
    {
        public FormFines()
        {
            InitializeComponent();
            
        }

        private void FormFines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Fines' table. You can move, or remove it, as needed.
            this.finesTableAdapter.Fill(this.hotelDataSet.Fines);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            finesTableAdapter.Update(hotelDataSet.Fines);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteFines();
        }

        private void deleteFines()
        {
            try
            {
                int id = (int)dataGridViewFines.CurrentRow.Cells["idfineDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> order_count = qTableAdapterDTHotel1.SQCountid_orderInOrder_Services(id);

                if (order_count == 0)
                {
                    DialogResult result1 = MessageBox.Show("Ця послуга буде видалена назавжди, ви впевнені що хочете це зробити?", "Процес видалення",
        MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        finesBindingSource.RemoveCurrent();
                        finesTableAdapter.Update(hotelDataSet.Fines);
                    }
                }
                else
                {
                    MessageBox.Show("Видаллення неможливе! Порушення вже було скоїне, тож боржнички мають сплатити борг :)", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації", "Видалення інформації");
            }
        }

        private void dataGridViewFines_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено недопустимі дані", "Помилка збереження");
        }
    }
}
