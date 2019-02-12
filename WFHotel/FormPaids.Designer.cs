namespace WFHotel
{
    partial class FormPaids
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
            this.paidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.paidsTableAdapter = new WFHotel.HotelDataSetTableAdapters.PaidsTableAdapter();
            this.idpaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.Location = new System.Drawing.Point(203, 12);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(146, 39);
            this.buttonDeleteRoom.TabIndex = 4;
            this.buttonDeleteRoom.Text = "Видалити рядок";
            this.buttonDeleteRoom.UseVisualStyleBackColor = true;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // buttonSaveRoom
            // 
            this.buttonSaveRoom.Location = new System.Drawing.Point(30, 12);
            this.buttonSaveRoom.Name = "buttonSaveRoom";
            this.buttonSaveRoom.Size = new System.Drawing.Size(147, 39);
            this.buttonSaveRoom.TabIndex = 5;
            this.buttonSaveRoom.Text = "Зберегти зміни";
            this.buttonSaveRoom.UseVisualStyleBackColor = true;
            this.buttonSaveRoom.Click += new System.EventHandler(this.buttonSaveRoom_Click);
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
            this.idpaidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idorderDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridViewFines.DataSource = this.paidsBindingSource;
            this.dataGridViewFines.Location = new System.Drawing.Point(1, 76);
            this.dataGridViewFines.Name = "dataGridViewFines";
            this.dataGridViewFines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewFines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewFines.RowTemplate.Height = 28;
            this.dataGridViewFines.Size = new System.Drawing.Size(756, 375);
            this.dataGridViewFines.TabIndex = 6;
            // 
            // paidsBindingSource
            // 
            this.paidsBindingSource.DataMember = "Paids";
            this.paidsBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paidsTableAdapter
            // 
            this.paidsTableAdapter.ClearBeforeFill = true;
            // 
            // idpaidDataGridViewTextBoxColumn
            // 
            this.idpaidDataGridViewTextBoxColumn.DataPropertyName = "id_paid";
            this.idpaidDataGridViewTextBoxColumn.HeaderText = "";
            this.idpaidDataGridViewTextBoxColumn.Name = "idpaidDataGridViewTextBoxColumn";
            this.idpaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpaidDataGridViewTextBoxColumn.Visible = false;
            this.idpaidDataGridViewTextBoxColumn.Width = 29;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 84;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "Номер замовлення";
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.Width = 175;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Сума";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 83;
            // 
            // FormPaids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.dataGridViewFines);
            this.Controls.Add(this.buttonSaveRoom);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Name = "FormPaids";
            this.Text = "Рахунки клієнтів";
            this.Load += new System.EventHandler(this.FormPaids_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Button buttonSaveRoom;
        private System.Windows.Forms.DataGridView dataGridViewFines;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource paidsBindingSource;
        private HotelDataSetTableAdapters.PaidsTableAdapter paidsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}