namespace WFHotel
{
    partial class FormFines
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewFines = new System.Windows.Forms.DataGridView();
            this.idfineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.finesTableAdapter = new WFHotel.HotelDataSetTableAdapters.FinesTableAdapter();
            this.qTableAdapterDTHotel1 = new WFHotel.HotelDataSetTableAdapters.QTableAdapterDTHotel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Зберегти зміни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Видалити рядок";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewFines
            // 
            this.dataGridViewFines.AllowUserToDeleteRows = false;
            this.dataGridViewFines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFines.AutoGenerateColumns = false;
            this.dataGridViewFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFines.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfineDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewFines.DataSource = this.finesBindingSource;
            this.dataGridViewFines.Location = new System.Drawing.Point(-1, 92);
            this.dataGridViewFines.Name = "dataGridViewFines";
            this.dataGridViewFines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewFines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewFines.RowTemplate.Height = 28;
            this.dataGridViewFines.Size = new System.Drawing.Size(547, 284);
            this.dataGridViewFines.TabIndex = 0;
            this.dataGridViewFines.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewFines_DataError);
            // 
            // idfineDataGridViewTextBoxColumn
            // 
            this.idfineDataGridViewTextBoxColumn.DataPropertyName = "id_fine";
            this.idfineDataGridViewTextBoxColumn.HeaderText = "id_fine";
            this.idfineDataGridViewTextBoxColumn.Name = "idfineDataGridViewTextBoxColumn";
            this.idfineDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfineDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Штраф в грн.";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // finesBindingSource
            // 
            this.finesBindingSource.DataMember = "Fines";
            this.finesBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finesTableAdapter
            // 
            this.finesTableAdapter.ClearBeforeFill = true;
            // 
            // FormFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewFines);
            this.Name = "FormFines";
            this.Text = "База порушень";
            this.Load += new System.EventHandler(this.FormFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewFines;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource finesBindingSource;
        private HotelDataSetTableAdapters.FinesTableAdapter finesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private HotelDataSetTableAdapters.QTableAdapterDTHotel qTableAdapterDTHotel1;
    }
}