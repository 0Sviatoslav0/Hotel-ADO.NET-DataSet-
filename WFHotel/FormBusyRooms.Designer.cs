namespace WFHotel
{
    partial class FormBusyRooms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooms2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rooms2TableAdapter = new WFHotel.HotelDataSetTableAdapters.Rooms2TableAdapter();
            this.categoriesTableAdapter = new WFHotel.HotelDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooms2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.idcategoryDataGridViewTextBoxColumn,
            this.idorderDataGridViewTextBoxColumn,
            this.checkindateDataGridViewTextBoxColumn,
            this.checkoutdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rooms2BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Кімната";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcategoryDataGridViewTextBoxColumn
            // 
            this.idcategoryDataGridViewTextBoxColumn.DataPropertyName = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource;
            this.idcategoryDataGridViewTextBoxColumn.DisplayMember = "name";
            this.idcategoryDataGridViewTextBoxColumn.HeaderText = "Категорія";
            this.idcategoryDataGridViewTextBoxColumn.Name = "idcategoryDataGridViewTextBoxColumn";
            this.idcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcategoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idcategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idcategoryDataGridViewTextBoxColumn.ValueMember = "id_category";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "Номер замовлення";
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.ReadOnly = true;
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
            // rooms2BindingSource
            // 
            this.rooms2BindingSource.DataMember = "Rooms2";
            this.rooms2BindingSource.DataSource = this.hotelDataSet;
            // 
            // rooms2TableAdapter
            // 
            this.rooms2TableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // FormBusyRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBusyRooms";
            this.Text = "Зайняті номери";
            this.Load += new System.EventHandler(this.FormBusyRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooms2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource rooms2BindingSource;
        private HotelDataSetTableAdapters.Rooms2TableAdapter rooms2TableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private HotelDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutdateDataGridViewTextBoxColumn;
    }
}