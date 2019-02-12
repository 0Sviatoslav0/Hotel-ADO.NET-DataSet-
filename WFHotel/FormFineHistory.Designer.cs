namespace WFHotel
{
    partial class FormFineHistory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finesTableAdapter = new WFHotel.HotelDataSetTableAdapters.FinesTableAdapter();
            this.clientsTableAdapter = new WFHotel.HotelDataSetTableAdapters.ClientsTableAdapter();
            this.fineHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fine_HistoryTableAdapter = new WFHotel.HotelDataSetTableAdapters.Fine_HistoryTableAdapter();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idfineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.idfineDataGridViewTextBoxColumn,
            this.amount});
            this.dataGridView1.DataSource = this.fineHistoryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // fineHistoryBindingSource
            // 
            this.fineHistoryBindingSource.DataMember = "Fine_History";
            this.fineHistoryBindingSource.DataSource = this.hotelDataSet;
            // 
            // fine_HistoryTableAdapter
            // 
            this.fine_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "Номер замовлення";
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idorderDataGridViewTextBoxColumn.Width = 175;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
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
            // idfineDataGridViewTextBoxColumn
            // 
            this.idfineDataGridViewTextBoxColumn.DataPropertyName = "id_fine";
            this.idfineDataGridViewTextBoxColumn.DataSource = this.finesBindingSource;
            this.idfineDataGridViewTextBoxColumn.DisplayMember = "name";
            this.idfineDataGridViewTextBoxColumn.HeaderText = "Штраф";
            this.idfineDataGridViewTextBoxColumn.Name = "idfineDataGridViewTextBoxColumn";
            this.idfineDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfineDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idfineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idfineDataGridViewTextBoxColumn.ValueMember = "id_fine";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.amount.HeaderText = "Сума";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // FormFineHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFineHistory";
            this.Text = "Історія штрафів";
            this.Load += new System.EventHandler(this.FormFineHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource finesHistoryBindingSource;
        private System.Windows.Forms.BindingSource finesBindingSource;
        private HotelDataSetTableAdapters.FinesTableAdapter finesTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource fineHistoryBindingSource;
        private HotelDataSetTableAdapters.Fine_HistoryTableAdapter fine_HistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idfineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}