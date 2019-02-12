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
    public partial class FormEmpl : Form
    {
        public FormEmpl()
        {
            InitializeComponent();
        }

        private void FormRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.hotelDataSet.Positions);
            // TODO: This line of code loads data into the 'hotelDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hotelDataSet.Employees);

        }

        private void buttonSaveEmpl_Click(object sender, EventArgs e)
        {
            employeesTableAdapter.Update(hotelDataSet.Employees);
        }

        private void buttonDeleteEmpl_Click(object sender, EventArgs e)
        {
            deleteEmp();
        }

        private void deleteEmp()
        {
            try
            {
                DialogResult result1 = MessageBox.Show("Ця послуга буде видалена назавжди, ви впевнені що хочете це зробити?", "Процес видалення",
        MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    employeesBindingSource.RemoveCurrent();
                    employeesTableAdapter.Update(hotelDataSet.Employees);
                }
            }
            catch
            {
                MessageBox.Show("Видалення неможливе, цей співробітник зайнятий, перевідкрийте вікно для відновлення даних!", "Помилка видалення!");
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено недопустимі дані", "Помилка збереження");
        }
    }
}
