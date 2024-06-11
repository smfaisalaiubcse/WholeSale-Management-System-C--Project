
namespace WholeSaleManagementSystem
{
    partial class ManageCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Manage_Name = new System.Windows.Forms.Label();
            this.Manage_ID = new System.Windows.Forms.Label();
            this.Manage_Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPhnNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.custDGV = new System.Windows.Forms.DataGridView();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleManagementStudioDataSet6 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet6();
            this.wholeSaleManagementStudioDataSet5 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet5();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet5TableAdapters.CustomerTableAdapter();
            this.customerTableAdapter1 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet6TableAdapters.CustomerTableAdapter();
            this.cbSelectColumn = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.useridErr = new System.Windows.Forms.Label();
            this.emailErr = new System.Windows.Forms.Label();
            this.phoneErr = new System.Windows.Forms.Label();
            this.dobErr = new System.Windows.Forms.Label();
            this.passwordErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.custDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxLastName.Location = new System.Drawing.Point(113, 116);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(130, 23);
            this.txtBoxLastName.TabIndex = 26;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxFirstName.Location = new System.Drawing.Point(113, 72);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(130, 23);
            this.txtBoxFirstName.TabIndex = 27;
            // 
            // txtBoxId
            // 
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxId.Location = new System.Drawing.Point(113, 31);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(130, 23);
            this.txtBoxId.TabIndex = 28;
            this.txtBoxId.Text = "\r\n";
            this.txtBoxId.TextChanged += new System.EventHandler(this.txtBoxId_TextChanged);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkMagenta;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(411, 158);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(71, 30);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DarkMagenta;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(334, 158);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(71, 30);
            this.Edit.TabIndex = 24;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkMagenta;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(257, 158);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(71, 30);
            this.Add.TabIndex = 25;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Manage_Name
            // 
            this.Manage_Name.AutoSize = true;
            this.Manage_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Name.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Manage_Name.Location = new System.Drawing.Point(17, 76);
            this.Manage_Name.Name = "Manage_Name";
            this.Manage_Name.Size = new System.Drawing.Size(89, 19);
            this.Manage_Name.TabIndex = 20;
            this.Manage_Name.Text = "First Name";
            // 
            // Manage_ID
            // 
            this.Manage_ID.AutoSize = true;
            this.Manage_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_ID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Manage_ID.Location = new System.Drawing.Point(17, 35);
            this.Manage_ID.Name = "Manage_ID";
            this.Manage_ID.Size = new System.Drawing.Size(24, 19);
            this.Manage_ID.TabIndex = 21;
            this.Manage_ID.Text = "ID";
            // 
            // Manage_Description
            // 
            this.Manage_Description.AutoSize = true;
            this.Manage_Description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Description.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Manage_Description.Location = new System.Drawing.Point(16, 116);
            this.Manage_Description.Name = "Manage_Description";
            this.Manage_Description.Size = new System.Drawing.Size(90, 19);
            this.Manage_Description.TabIndex = 22;
            this.Manage_Description.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(253, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Phone No";
            // 
            // txtBoxPhnNo
            // 
            this.txtBoxPhnNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPhnNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhnNo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxPhnNo.Location = new System.Drawing.Point(350, 72);
            this.txtBoxPhnNo.Name = "txtBoxPhnNo";
            this.txtBoxPhnNo.Size = new System.Drawing.Size(130, 23);
            this.txtBoxPhnNo.TabIndex = 26;
            this.txtBoxPhnNo.TextChanged += new System.EventHandler(this.txtBoxPhnNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(253, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "E Mail";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxEmail.Location = new System.Drawing.Point(350, 31);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(130, 23);
            this.txtBoxEmail.TabIndex = 26;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.txtBoxEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(253, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(18, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxPass.Location = new System.Drawing.Point(115, 153);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(130, 23);
            this.txtBoxPass.TabIndex = 26;
            this.txtBoxPass.TextChanged += new System.EventHandler(this.txtBoxPass_TextChanged);
            // 
            // custDGV
            // 
            this.custDGV.AllowUserToAddRows = false;
            this.custDGV.AllowUserToDeleteRows = false;
            this.custDGV.AllowUserToResizeColumns = false;
            this.custDGV.AllowUserToResizeRows = false;
            this.custDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custDGV.BackgroundColor = System.Drawing.Color.White;
            this.custDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.custDGV.ColumnHeadersHeight = 30;
            this.custDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.custDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.custDGV.GridColor = System.Drawing.Color.DarkMagenta;
            this.custDGV.Location = new System.Drawing.Point(0, 226);
            this.custDGV.Name = "custDGV";
            this.custDGV.ReadOnly = true;
            this.custDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.custDGV.RowHeadersVisible = false;
            this.custDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.custDGV.Size = new System.Drawing.Size(632, 194);
            this.custDGV.TabIndex = 48;
            this.custDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custDGV_CellContentClick);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.wholeSaleManagementStudioDataSet6;
            // 
            // wholeSaleManagementStudioDataSet6
            // 
            this.wholeSaleManagementStudioDataSet6.DataSetName = "WholeSaleManagementStudioDataSet6";
            this.wholeSaleManagementStudioDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wholeSaleManagementStudioDataSet5
            // 
            this.wholeSaleManagementStudioDataSet5.DataSetName = "WholeSaleManagementStudioDataSet5";
            this.wholeSaleManagementStudioDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.wholeSaleManagementStudioDataSet5;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // cbSelectColumn
            // 
            this.cbSelectColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectColumn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbSelectColumn.FormattingEnabled = true;
            this.cbSelectColumn.Items.AddRange(new object[] {
            "All",
            "ID",
            "First Name",
            "Last Name",
            "Phone Number",
            "E-Mail",
            "Password"});
            this.cbSelectColumn.Location = new System.Drawing.Point(152, 195);
            this.cbSelectColumn.Name = "cbSelectColumn";
            this.cbSelectColumn.Size = new System.Drawing.Size(121, 25);
            this.cbSelectColumn.TabIndex = 53;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxSearch.Location = new System.Drawing.Point(352, 194);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(130, 23);
            this.textBoxSearch.TabIndex = 52;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(87, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Column";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(293, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Search";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(349, 114);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(131, 23);
            this.dtpDOB.TabIndex = 54;
            this.dtpDOB.CloseUp += new System.EventHandler(this.dtpDOB_CloseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label7.Location = new System.Drawing.Point(231, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Manage Customer";
            // 
            // useridErr
            // 
            this.useridErr.AutoSize = true;
            this.useridErr.BackColor = System.Drawing.Color.Transparent;
            this.useridErr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridErr.ForeColor = System.Drawing.Color.Red;
            this.useridErr.Location = new System.Drawing.Point(112, 54);
            this.useridErr.Name = "useridErr";
            this.useridErr.Size = new System.Drawing.Size(0, 16);
            this.useridErr.TabIndex = 55;
            // 
            // emailErr
            // 
            this.emailErr.AutoSize = true;
            this.emailErr.BackColor = System.Drawing.Color.Transparent;
            this.emailErr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErr.ForeColor = System.Drawing.Color.Red;
            this.emailErr.Location = new System.Drawing.Point(349, 54);
            this.emailErr.Name = "emailErr";
            this.emailErr.Size = new System.Drawing.Size(0, 16);
            this.emailErr.TabIndex = 55;
            // 
            // phoneErr
            // 
            this.phoneErr.AutoSize = true;
            this.phoneErr.BackColor = System.Drawing.Color.Transparent;
            this.phoneErr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErr.ForeColor = System.Drawing.Color.Red;
            this.phoneErr.Location = new System.Drawing.Point(349, 95);
            this.phoneErr.Name = "phoneErr";
            this.phoneErr.Size = new System.Drawing.Size(0, 16);
            this.phoneErr.TabIndex = 55;
            // 
            // dobErr
            // 
            this.dobErr.AutoSize = true;
            this.dobErr.BackColor = System.Drawing.Color.Transparent;
            this.dobErr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobErr.ForeColor = System.Drawing.Color.Red;
            this.dobErr.Location = new System.Drawing.Point(349, 139);
            this.dobErr.Name = "dobErr";
            this.dobErr.Size = new System.Drawing.Size(0, 16);
            this.dobErr.TabIndex = 55;
            // 
            // passwordErr
            // 
            this.passwordErr.AutoSize = true;
            this.passwordErr.BackColor = System.Drawing.Color.Transparent;
            this.passwordErr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErr.ForeColor = System.Drawing.Color.Red;
            this.passwordErr.Location = new System.Drawing.Point(114, 177);
            this.passwordErr.Name = "passwordErr";
            this.passwordErr.Size = new System.Drawing.Size(0, 16);
            this.passwordErr.TabIndex = 55;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 420);
            this.Controls.Add(this.passwordErr);
            this.Controls.Add(this.dobErr);
            this.Controls.Add(this.phoneErr);
            this.Controls.Add(this.emailErr);
            this.Controls.Add(this.useridErr);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cbSelectColumn);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.custDGV);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPhnNo);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Manage_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Manage_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Manage_Description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Manage_Name;
        private System.Windows.Forms.Label Manage_ID;
        private System.Windows.Forms.Label Manage_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPhnNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.DataGridView custDGV;
        private WholeSaleManagementStudioDataSet5 wholeSaleManagementStudioDataSet5;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private WholeSaleManagementStudioDataSet5TableAdapters.CustomerTableAdapter customerTableAdapter;
        private WholeSaleManagementStudioDataSet6 wholeSaleManagementStudioDataSet6;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private WholeSaleManagementStudioDataSet6TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.ComboBox cbSelectColumn;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label useridErr;
        private System.Windows.Forms.Label emailErr;
        private System.Windows.Forms.Label phoneErr;
        private System.Windows.Forms.Label dobErr;
        private System.Windows.Forms.Label passwordErr;
    }
}