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
    public partial class FormHotel : Form
    {
        public FormHotel()
        {
            InitializeComponent();
        }

        

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }

        private void додатковіПослугиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddServ formAddServ = new FormAddServ();
            formAddServ.Show();
        }

        private void порушенняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFines formFines = new FormFines();
            formFines.Show();
        }

        private void співробітникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpl formEmpl = new FormEmpl();
            formEmpl.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }

        private void рахункиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaids formPaids = new FormPaids();
            formPaids.Show();
        }

        private void замовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
        }

        private void вільніНомериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFreeRooms formFreeRooms = new FormFreeRooms();
            formFreeRooms.Show();
        }

        private void зайнятіНомериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusyRooms formBusyRooms = new FormBusyRooms();
            formBusyRooms.Show();
        }

        private void історіяШтрафівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFineHistory formFineHistory = new FormFineHistory();
            formFineHistory.Show();
        }

        private void номериГотелюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRooms formRooms = new FormRooms();
            formRooms.Show();
        }

        private void FormHotel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Ви впевнені що хочете закрити програму ?",
            "Увага!",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
