namespace WFHotel
{
    partial class FormRooms
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
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.buttonSaveRoom = new System.Windows.Forms.Button();
            this.dataGridViewFines = new System.Windows.Forms.DataGridView();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.categoriesTableAdapter = new WFHotel.HotelDataSetTableAdapters.CategoriesTableAdapter();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new WFHotel.HotelDataSetTableAdapters.RoomsTableAdapter();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.Location = new System.Drawing.Point(231, 48);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(146, 39);
            this.buttonDeleteRoom.TabIndex = 3;
            this.buttonDeleteRoom.Text = "Видалити рядок";
            this.buttonDeleteRoom.UseVisualStyleBackColor = true;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // buttonSaveRoom
            // 
            this.buttonSaveRoom.Location = new System.Drawing.Point(24, 48);
            this.buttonSaveRoom.Name = "buttonSaveRoom";
            this.buttonSaveRoom.Size = new System.Drawing.Size(147, 39);
            this.buttonSaveRoom.TabIndex = 4;
            this.buttonSaveRoom.Text = "Зберегти зміни";
            this.buttonSaveRoom.UseVisualStyleBackColor = true;
            this.buttonSaveRoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewFines
            // 
            this.dataGridViewFines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFines.AutoGenerateColumns = false;
            this.dataGridViewFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFines.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.idcategoryDataGridViewTextBoxColumn,
            this.id_category,
            this.Column1});
            this.dataGridViewFines.DataSource = this.roomsBindingSource;
            this.dataGridViewFines.Location = new System.Drawing.Point(1, 107);
            this.dataGridViewFines.Name = "dataGridViewFines";
            this.dataGridViewFines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewFines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewFines.RowTemplate.Height = 28;
            this.dataGridViewFines.Size = new System.Drawing.Size(580, 344);
            this.dataGridViewFines.TabIndex = 5;
            this.dataGridViewFines.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewFines_DataError);
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
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.hotelDataSet;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Кімната";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 105;
            // 
            // idcategoryDataGridViewTextBoxColumn
            // 
            this.idcategoryDataGridViewTextBoxColumn.DataPropertyName = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource;
            this.idcategoryDataGridViewTextBoxColumn.DisplayMember = "name";
            this.idcategoryDataGridViewTextBoxColumn.HeaderText = "Категорія";
            this.idcategoryDataGridViewTextBoxColumn.Name = "idcategoryDataGridViewTextBoxColumn";
            this.idcategoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idcategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idcategoryDataGridViewTextBoxColumn.ValueMember = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.Width = 119;
            // 
            // id_category
            // 
            this.id_category.DataPropertyName = "id_category";
            this.id_category.DataSource = this.categoriesBindingSource;
            this.id_category.DisplayMember = "description";
            this.id_category.HeaderText = "Опис";
            this.id_category.Name = "id_category";
            this.id_category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_category.ValueMember = "id_category";
            this.id_category.Width = 83;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_category";
            this.Column1.DataSource = this.categoriesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.DisplayMember = "price";
            this.Column1.HeaderText = "Ціна";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.ValueMember = "id_category";
            this.Column1.Width = 78;
            // 
            // FormRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.dataGridViewFines);
            this.Controls.Add(this.buttonSaveRoom);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Name = "FormRooms";
            this.Text = "Список номерів";
            this.Load += new System.EventHandler(this.FormRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Button buttonSaveRoom;
        private System.Windows.Forms.DataGridView dataGridViewFines;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private HotelDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_category;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
    }
}