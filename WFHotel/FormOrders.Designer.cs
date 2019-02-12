namespace WFHotel
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAddServ = new System.Windows.Forms.DataGridView();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WFHotel.HotelDataSetTableAdapters.OrdersTableAdapter();
            this.roomsTableAdapter = new WFHotel.HotelDataSetTableAdapters.RoomsTableAdapter();
            this.employeesTableAdapter = new WFHotel.HotelDataSetTableAdapters.EmployeesTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new WFHotel.HotelDataSetTableAdapters.ClientsTableAdapter();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddServ
            // 
            this.dataGridViewAddServ.AllowUserToAddRows = false;
            this.dataGridViewAddServ.AllowUserToDeleteRows = false;
            this.dataGridViewAddServ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAddServ.AutoGenerateColumns = false;
            this.dataGridViewAddServ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddServ.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAddServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.checkindateDataGridViewTextBoxColumn,
            this.checkoutdateDataGridViewTextBoxColumn,
            this.idroomDataGridViewTextBoxColumn,
            this.idemployeeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridViewAddServ.DataSource = this.ordersBindingSource;
            this.dataGridViewAddServ.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAddServ.Location = new System.Drawing.Point(-1, 12);
            this.dataGridViewAddServ.Name = "dataGridViewAddServ";
            this.dataGridViewAddServ.ReadOnly = true;
            this.dataGridViewAddServ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewAddServ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAddServ.RowTemplate.Height = 28;
            this.dataGridViewAddServ.Size = new System.Drawing.Size(1163, 435);
            this.dataGridViewAddServ.TabIndex = 2;
            this.dataGridViewAddServ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddServ_CellContentClick);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hotelDataSet;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.hotelDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "Номер замовлення";
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.DataSource = this.clientsBindingSource;
            this.idclientDataGridViewTextBoxColumn.DisplayMember = "client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "Клієнт";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idclientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idclientDataGridViewTextBoxColumn.ValueMember = "Id_Client";
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "Дата замовлення";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkindateDataGridViewTextBoxColumn
            // 
            this.checkindateDataGridViewTextBoxColumn.DataPropertyName = "checkin_date";
            this.checkindateDataGridViewTextBoxColumn.HeaderText = "Дата заїзду";
            this.checkindateDataGridViewTextBoxColumn.Name = "checkindateDataGridViewTextBoxColumn";
            this.checkindateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkoutdateDataGridViewTextBoxColumn
            // 
            this.checkoutdateDataGridViewTextBoxColumn.DataPropertyName = "checkout_date";
            this.checkoutdateDataGridViewTextBoxColumn.HeaderText = "Дата виїзду";
            this.checkoutdateDataGridViewTextBoxColumn.Name = "checkoutdateDataGridViewTextBoxColumn";
            this.checkoutdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idroomDataGridViewTextBoxColumn
            // 
            this.idroomDataGridViewTextBoxColumn.DataPropertyName = "id_room";
            this.idroomDataGridViewTextBoxColumn.DataSource = this.roomsBindingSource;
            this.idroomDataGridViewTextBoxColumn.DisplayMember = "number";
            this.idroomDataGridViewTextBoxColumn.HeaderText = "Кімната";
            this.idroomDataGridViewTextBoxColumn.Name = "idroomDataGridViewTextBoxColumn";
            this.idroomDataGridViewTextBoxColumn.ReadOnly = true;
            this.idroomDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idroomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idroomDataGridViewTextBoxColumn.ValueMember = "id_room";
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.DataSource = this.employeesBindingSource;
            this.idemployeeDataGridViewTextBoxColumn.DisplayMember = "employee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "Співробітник";
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            this.idemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idemployeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idemployeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idemployeeDataGridViewTextBoxColumn.ValueMember = "id_employee";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Сума в грн.";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 450);
            this.Controls.Add(this.dataGridViewAddServ);
            this.Name = "FormOrders";
            this.Text = "Усі замовлення";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddServ;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private HotelDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HotelDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}