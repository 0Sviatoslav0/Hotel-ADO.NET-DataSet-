using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WFHotel
{
    public partial class FormAddServ : Form
    {
        public FormAddServ()
        {
            InitializeComponent();
        }

        private void FormAddServ_Load(object sender, EventArgs e)
        {
            this.additional_servicesTableAdapter.Fill(this.hotelDataSet.Additional_services);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            additional_servicesTableAdapter.Update(hotelDataSet.Additional_services);
        }

        private void buttonDeleteAddServ_Click(object sender, EventArgs e)
        {
            deleteAddServ();
        }

        private void deleteAddServ()
        {
            try
            {
                int id = (int)dataGridViewAddServ.CurrentRow.Cells["idaddservDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> order_count = qTableAdapterDTHotel1.SQCountid_orderInOrder_Services(id);

                if (order_count == 0)
                {
                    DialogResult result1 = MessageBox.Show("Ця послуга буде видалена назавжди, ви впевнені що хочете це зробити?", "Процес видалення",
        MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        additionalservicesBindingSource.RemoveCurrent();
                        additional_servicesTableAdapter.Update(hotelDataSet.Additional_services);

                    }
                }
                else
                {
                    MessageBox.Show("Видаллення неможливе! Данна послуга вже замовлена", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації", "Видалення інформації");
            }
        }

        private void dataGridViewAddServ_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено недопустимі дані", "Помилка збереження");
        }
    }
}
