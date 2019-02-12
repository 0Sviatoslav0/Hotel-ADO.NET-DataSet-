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
    public partial class FormFineHistory : Form
    {
        public FormFineHistory()
        {
            InitializeComponent();
        }

        private void FormFineHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Fine_History' table. You can move, or remove it, as needed.
            this.fine_HistoryTableAdapter.Fill(this.hotelDataSet.Fine_History);
            // TODO: This line of code loads data into the 'hotelDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDataSet.Clients);
            // TODO: This line of code loads data into the 'hotelDataSet.Fines' table. You can move, or remove it, as needed.
            this.finesTableAdapter.Fill(this.hotelDataSet.Fines);

        }
    }
}
