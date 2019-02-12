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
    public partial class FormFreeRooms : Form
    {
        public FormFreeRooms()
        {
            InitializeComponent();
        }

        private void FormFreeRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.hotelDataSet.Categories);
            // TODO: This line of code loads data into the 'hotelDataSet.Rooms1' table. You can move, or remove it, as needed.
            this.rooms1TableAdapter.Fill(this.hotelDataSet.Rooms1);

        }
    }
}
