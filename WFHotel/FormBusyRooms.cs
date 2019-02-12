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
    public partial class FormBusyRooms : Form
    {
        public FormBusyRooms()
        {
            InitializeComponent();
        }

        private void FormBusyRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.hotelDataSet.Categories);
            // TODO: This line of code loads data into the 'hotelDataSet.Rooms2' table. You can move, or remove it, as needed.
            this.rooms2TableAdapter.Fill(this.hotelDataSet.Rooms2);

        }

    }
}
