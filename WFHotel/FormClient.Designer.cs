namespace WFHotel
{
    partial class FormClient
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.buttonSaveClients = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new WFHotel.HotelDataSetTableAdapters.ClientsTableAdapter();
            this.qTableAdapterDTHotel1 = new WFHotel.HotelDataSetTableAdapters.QTableAdapterDTHotel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewClient.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.midnameDataGridViewTextBoxColumn,
            this.contactphoneDataGridViewTextBoxColumn,
            this.additionalphoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.clientsBindingSource;
            this.dataGridViewClient.Location = new System.Drawing.Point(1, 61);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewClient.RowTemplate.Height = 28;
            this.dataGridViewClient.Size = new System.Drawing.Size(965, 388);
            this.dataGridViewClient.TabIndex = 0;
            this.dataGridViewClient.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewClient_DataError);
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "Id_Client";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "Id_Client";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // midnameDataGridViewTextBoxColumn
            // 
            this.midnameDataGridViewTextBoxColumn.DataPropertyName = "midname";
            this.midnameDataGridViewTextBoxColumn.HeaderText = "По-батькові";
            this.midnameDataGridViewTextBoxColumn.Name = "midnameDataGridViewTextBoxColumn";
            // 
            // contactphoneDataGridViewTextBoxColumn
            // 
            this.contactphoneDataGridViewTextBoxColumn.DataPropertyName = "contact_phone";
            this.contactphoneDataGridViewTextBoxColumn.HeaderText = "Контактний телефон";
            this.contactphoneDataGridViewTextBoxColumn.Name = "contactphoneDataGridViewTextBoxColumn";
            // 
            // additionalphoneDataGridViewTextBoxColumn
            // 
            this.additionalphoneDataGridViewTextBoxColumn.DataPropertyName = "additional_phone";
            this.additionalphoneDataGridViewTextBoxColumn.HeaderText = "Додатковий телефон";
            this.additionalphoneDataGridViewTextBoxColumn.Name = "additionalphoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Електронна адреса";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Паспортний номер";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSaveClients
            // 
            this.buttonSaveClients.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSaveClients.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSaveClients.Location = new System.Drawing.Point(56, 12);
            this.buttonSaveClients.Name = "buttonSaveClients";
            this.buttonSaveClients.Size = new System.Drawing.Size(139, 42);
            this.buttonSaveClients.TabIndex = 1;
            this.buttonSaveClients.Text = "Зберегти зміни\r\n";
            this.buttonSaveClients.UseVisualStyleBackColor = false;
            this.buttonSaveClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(250, 13);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(147, 41);
            this.buttonDeleteClient.TabIndex = 2;
            this.buttonDeleteClient.Text = "Видалити рядок";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonSaveClients);
            this.Controls.Add(this.dataGridViewClient);
            this.Name = "FormClient";
            this.Text = "База клієнтів";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonSaveClients;
        private System.Windows.Forms.Button buttonDeleteClient;
        private HotelDataSet hotelDataSet;
        private HotelDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private HotelDataSetTableAdapters.QTableAdapterDTHotel qTableAdapterDTHotel1;
    }
}