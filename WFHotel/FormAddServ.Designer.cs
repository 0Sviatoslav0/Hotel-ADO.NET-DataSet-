namespace WFHotel
{
    partial class FormAddServ
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
            this.dataGridViewAddServ = new System.Windows.Forms.DataGridView();
            this.idaddservDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.buttonDeleteAddServ = new System.Windows.Forms.Button();
            this.buttonSaveAddServ = new System.Windows.Forms.Button();
            this.additional_servicesTableAdapter = new WFHotel.HotelDataSetTableAdapters.Additional_servicesTableAdapter();
            this.qTableAdapterDTHotel1 = new WFHotel.HotelDataSetTableAdapters.QTableAdapterDTHotel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddServ
            // 
            this.dataGridViewAddServ.AllowUserToDeleteRows = false;
            this.dataGridViewAddServ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAddServ.AutoGenerateColumns = false;
            this.dataGridViewAddServ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddServ.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAddServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaddservDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewAddServ.DataSource = this.additionalservicesBindingSource;
            this.dataGridViewAddServ.Location = new System.Drawing.Point(1, 68);
            this.dataGridViewAddServ.Name = "dataGridViewAddServ";
            this.dataGridViewAddServ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewAddServ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAddServ.RowTemplate.Height = 28;
            this.dataGridViewAddServ.Size = new System.Drawing.Size(973, 266);
            this.dataGridViewAddServ.TabIndex = 1;
            this.dataGridViewAddServ.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewAddServ_DataError);
            // 
            // idaddservDataGridViewTextBoxColumn
            // 
            this.idaddservDataGridViewTextBoxColumn.DataPropertyName = "id_addserv";
            this.idaddservDataGridViewTextBoxColumn.HeaderText = "id_addserv";
            this.idaddservDataGridViewTextBoxColumn.Name = "idaddservDataGridViewTextBoxColumn";
            this.idaddservDataGridViewTextBoxColumn.ReadOnly = true;
            this.idaddservDataGridViewTextBoxColumn.Visible = false;
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
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // additionalservicesBindingSource
            // 
            this.additionalservicesBindingSource.DataMember = "Additional_services";
            this.additionalservicesBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDeleteAddServ
            // 
            this.buttonDeleteAddServ.Location = new System.Drawing.Point(224, 12);
            this.buttonDeleteAddServ.Name = "buttonDeleteAddServ";
            this.buttonDeleteAddServ.Size = new System.Drawing.Size(165, 41);
            this.buttonDeleteAddServ.TabIndex = 3;
            this.buttonDeleteAddServ.Text = "Видалити рядок";
            this.buttonDeleteAddServ.UseVisualStyleBackColor = true;
            this.buttonDeleteAddServ.Click += new System.EventHandler(this.buttonDeleteAddServ_Click);
            // 
            // buttonSaveAddServ
            // 
            this.buttonSaveAddServ.Location = new System.Drawing.Point(24, 12);
            this.buttonSaveAddServ.Name = "buttonSaveAddServ";
            this.buttonSaveAddServ.Size = new System.Drawing.Size(170, 38);
            this.buttonSaveAddServ.TabIndex = 0;
            this.buttonSaveAddServ.Text = "Зберегти зміни";
            this.buttonSaveAddServ.UseVisualStyleBackColor = true;
            this.buttonSaveAddServ.Click += new System.EventHandler(this.button1_Click);
            // 
            // additional_servicesTableAdapter
            // 
            this.additional_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 333);
            this.Controls.Add(this.buttonDeleteAddServ);
            this.Controls.Add(this.dataGridViewAddServ);
            this.Controls.Add(this.buttonSaveAddServ);
            this.Name = "FormAddServ";
            this.Text = "База додаткових послуг";
            this.Load += new System.EventHandler(this.FormAddServ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAddServ;
        private System.Windows.Forms.Button buttonDeleteAddServ;
        private System.Windows.Forms.Button buttonSaveAddServ;
        private HotelDataSet hotelDataSet;
        private HotelDataSetTableAdapters.Additional_servicesTableAdapter additional_servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaddservDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource additionalservicesBindingSource;
        private HotelDataSetTableAdapters.QTableAdapterDTHotel qTableAdapterDTHotel1;
    }
}