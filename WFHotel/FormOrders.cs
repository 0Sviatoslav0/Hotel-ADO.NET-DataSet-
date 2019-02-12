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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDataSet.Clients);
            // TODO: This line of code loads data into the 'hotelDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hotelDataSet.Employees);
            // TODO: This line of code loads data into the 'hotelDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelDataSet.Rooms);
            // TODO: This line of code loads data into the 'hotelDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.hotelDataSet.Orders);

        }

        private void dataGridViewAddServ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
