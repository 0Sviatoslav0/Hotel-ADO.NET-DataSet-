namespace WFHotel
{
    partial class FormEmpl
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
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WFHotel.HotelDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new WFHotel.HotelDataSetTableAdapters.RoomsTableAdapter();
            this.buttonSaveEmpl = new System.Windows.Forms.Button();
            this.buttonDeleteEmpl = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new WFHotel.HotelDataSetTableAdapters.EmployeesTableAdapter();
            this.positionsTableAdapter = new WFHotel.HotelDataSetTableAdapters.PositionsTableAdapter();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idemployeeDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.midnameDataGridViewTextBoxColumn,
            this.idpositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(513, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.hotelDataSet;
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
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSaveEmpl
            // 
            this.buttonSaveEmpl.Location = new System.Drawing.Point(53, 21);
            this.buttonSaveEmpl.Name = "buttonSaveEmpl";
            this.buttonSaveEmpl.Size = new System.Drawing.Size(140, 40);
            this.buttonSaveEmpl.TabIndex = 1;
            this.buttonSaveEmpl.Text = "Зберегти зміни";
            this.buttonSaveEmpl.UseVisualStyleBackColor = true;
            this.buttonSaveEmpl.Click += new System.EventHandler(this.buttonSaveEmpl_Click);
            // 
            // buttonDeleteEmpl
            // 
            this.buttonDeleteEmpl.Location = new System.Drawing.Point(256, 21);
            this.buttonDeleteEmpl.Name = "buttonDeleteEmpl";
            this.buttonDeleteEmpl.Size = new System.Drawing.Size(154, 40);
            this.buttonDeleteEmpl.TabIndex = 2;
            this.buttonDeleteEmpl.Text = "Видалити рядок";
            this.buttonDeleteEmpl.UseVisualStyleBackColor = true;
            this.buttonDeleteEmpl.Click += new System.EventHandler(this.buttonDeleteEmpl_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            this.idemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idemployeeDataGridViewTextBoxColumn.Visible = false;
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
            // idpositionDataGridViewTextBoxColumn
            // 
            this.idpositionDataGridViewTextBoxColumn.DataPropertyName = "id_position";
            this.idpositionDataGridViewTextBoxColumn.DataSource = this.positionsBindingSource;
            this.idpositionDataGridViewTextBoxColumn.DisplayMember = "position";
            this.idpositionDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.idpositionDataGridViewTextBoxColumn.Name = "idpositionDataGridViewTextBoxColumn";
            this.idpositionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpositionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpositionDataGridViewTextBoxColumn.ValueMember = "id_position";
            // 
            // FormEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 368);
            this.Controls.Add(this.buttonDeleteEmpl);
            this.Controls.Add(this.buttonSaveEmpl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEmpl";
            this.Text = "Співробітники";
            this.Load += new System.EventHandler(this.FormRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private HotelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Button buttonSaveEmpl;
        private System.Windows.Forms.Button buttonDeleteEmpl;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HotelDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private HotelDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpositionDataGridViewTextBoxColumn;
    }
}