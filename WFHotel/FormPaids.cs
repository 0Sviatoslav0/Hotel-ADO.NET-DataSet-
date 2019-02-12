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
    public partial class FormPaids : Form
    {
        public FormPaids()
        {
            InitializeComponent();
        }

        private void FormPaids_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Paids' table. You can move, or remove it, as needed.
            this.paidsTableAdapter.Fill(this.hotelDataSet.Paids);

        }

        private void buttonSaveRoom_Click(object sender, EventArgs e)
        {
            paidsTableAdapter.Update(hotelDataSet.Paids);
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("Цей рахунок буде видалена назавжди, ви впевнені що хочете це зробити?", "Процес видалення",
        MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    paidsBindingSource.RemoveCurrent();
                    paidsTableAdapter.Update(hotelDataSet.Paids);
                }
            }
            catch
            {
                MessageBox.Show("Видалення неможливе, цей рахунок вже виставлено");
            }
        }
    }
}

