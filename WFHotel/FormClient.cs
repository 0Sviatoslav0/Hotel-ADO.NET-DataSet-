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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSHotel.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDataSet.Clients);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.Update(hotelDataSet.Clients);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            deleteString();
        }

        private void deleteString()
        {
            try
            {
                int id = (int)dataGridViewClient.CurrentRow.Cells["idClientDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> orders_count = qTableAdapterDTHotel1.SQCountid_orderInOrders(id);

                if (orders_count == 0)
                {
                    DialogResult result1 = MessageBox.Show("Цей клієнт буде видалений назавжди, ви впевнені що хочете це зробити?", "Процес видалення",
        MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        clientsBindingSource.RemoveCurrent();
                        clientsTableAdapter.Update(hotelDataSet.Clients);
                    }
                }
                else
                {
                    MessageBox.Show("Видаллення неможливе! Клієнт має замовлення", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації", "Видалення інформації");
            }
        }

        private void dataGridViewClient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено недопустимі дані", "Помилка збереження");
        }
    }
}
