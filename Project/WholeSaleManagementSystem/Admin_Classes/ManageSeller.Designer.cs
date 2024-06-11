
namespace WholeSaleManagementSystem
{
    partial class ManageSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSeller));
            this.dgvSellerList = new System.Windows.Forms.DataGridView();
            this.sellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleManagementStudioDataSet3 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet3();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Manage_Name = new System.Windows.Forms.Label();
            this.Manage_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.sellerTableAdapter = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet3TableAdapters.SellerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSelectColumn = new System.Windows.Forms.ComboBox();
            this.phoneNumberErr = new System.Windows.Forms.Label();
            this.passwordErr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dobErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSellerList
            // 
            this.dgvSellerList.AllowUserToAddRows = false;
            this.dgvSellerList.AllowUserToDeleteRows = false;
            this.dgvSellerList.AllowUserToResizeColumns = false;
            this.dgvSellerList.AllowUserToResizeRows = false;
            this.dgvSellerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSellerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSellerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellerList.ColumnHeadersHeight = 30;
            this.dgvSellerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSellerList.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgvSellerList.Location = new System.Drawing.Point(0, 210);
            this.dgvSellerList.Name = "dgvSellerList";
            this.dgvSellerList.ReadOnly = true;
            this.dgvSellerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSellerList.RowHeadersVisible = false;
            this.dgvSellerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSellerList.Size = new System.Drawing.Size(600, 210);
            this.dgvSellerList.TabIndex = 47;
            this.dgvSellerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellerList_CellContentClick);
            // 
            // sellerBindingSource
            // 
            this.sellerBindingSource.DataMember = "Seller";
            this.sellerBindingSource.DataSource = this.wholeSaleManagementStudioDataSet3;
            // 
            // wholeSaleManagementStudioDataSet3
            // 
            this.wholeSaleManagementStudioDataSet3.DataSetName = "WholeSaleManagementStudioDataSet3";
            this.wholeSaleManagementStudioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxPassword.Location = new System.Drawing.Point(286, 89);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(130, 23);
            this.textBoxPassword.TabIndex = 44;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxPhoneNo.Location = new System.Drawing.Point(80, 87);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(130, 23);
            this.textBoxPhoneNo.TabIndex = 41;
            this.textBoxPhoneNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPhoneNo_KeyDown);
            // 
            // txtBoxName
            // 
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxName.Location = new System.Drawing.Point(80, 58);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(130, 23);
            this.txtBoxName.TabIndex = 45;
            this.txtBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxName_KeyDown);
            // 
            // txtBoxId
            // 
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxId.Enabled = false;
            this.txtBoxId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxId.Location = new System.Drawing.Point(81, 29);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(130, 23);
            this.txtBoxId.TabIndex = 46;
            this.txtBoxId.Text = "Auto Generated";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkMagenta;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(350, 133);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(62, 30);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DarkMagenta;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(248, 133);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(63, 30);
            this.Edit.TabIndex = 38;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(216, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Password";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkMagenta;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(145, 133);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(66, 30);
            this.Add.TabIndex = 39;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(216, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "DOB";
            // 
            // Manage_Name
            // 
            this.Manage_Name.AutoSize = true;
            this.Manage_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Name.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Manage_Name.Location = new System.Drawing.Point(11, 64);
            this.Manage_Name.Name = "Manage_Name";
            this.Manage_Name.Size = new System.Drawing.Size(47, 16);
            this.Manage_Name.TabIndex = 30;
            this.Manage_Name.Text = "Name";
            // 
            // Manage_ID
            // 
            this.Manage_ID.AutoSize = true;
            this.Manage_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_ID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Manage_ID.Location = new System.Drawing.Point(12, 35);
            this.Manage_ID.Name = "Manage_ID";
            this.Manage_ID.Size = new System.Drawing.Size(21, 16);
            this.Manage_ID.TabIndex = 31;
            this.Manage_ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(10, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Phone No";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSalary.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxSalary.Location = new System.Drawing.Point(287, 30);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(130, 23);
            this.textBoxSalary.TabIndex = 42;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Salary.Location = new System.Drawing.Point(217, 32);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(50, 16);
            this.Salary.TabIndex = 33;
            this.Salary.Text = "Salary";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(285, 59);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(131, 23);
            this.dtpDOB.TabIndex = 48;
            this.dtpDOB.CloseUp += new System.EventHandler(this.dtpDOB_CloseUp);
            // 
            // sellerTableAdapter
            // 
            this.sellerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(295, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxSearch.Location = new System.Drawing.Point(354, 168);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(130, 23);
            this.textBoxSearch.TabIndex = 46;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(89, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Column";
            // 
            // cbSelectColumn
            // 
            this.cbSelectColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectColumn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbSelectColumn.FormattingEnabled = true;
            this.cbSelectColumn.Items.AddRange(new object[] {
            "All",
            "ID",
            "Name",
            "Phone No"});
            this.cbSelectColumn.Location = new System.Drawing.Point(154, 169);
            this.cbSelectColumn.Name = "cbSelectColumn";
            this.cbSelectColumn.Size = new System.Drawing.Size(121, 25);
            this.cbSelectColumn.TabIndex = 49;
            // 
            // phoneNumberErr
            // 
            this.phoneNumberErr.AutoSize = true;
            this.phoneNumberErr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberErr.ForeColor = System.Drawing.Color.Red;
            this.phoneNumberErr.Location = new System.Drawing.Point(78, 113);
            this.phoneNumberErr.Name = "phoneNumberErr";
            this.phoneNumberErr.Size = new System.Drawing.Size(0, 16);
            this.phoneNumberErr.TabIndex = 50;
            // 
            // passwordErr
            // 
            this.passwordErr.AutoSize = true;
            this.passwordErr.BackColor = System.Drawing.Color.Transparent;
            this.passwordErr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErr.ForeColor = System.Drawing.Color.Red;
            this.passwordErr.Location = new System.Drawing.Point(284, 113);
            this.passwordErr.Name = "passwordErr";
            this.passwordErr.Size = new System.Drawing.Size(0, 16);
            this.passwordErr.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkMagenta;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(261, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Manage Seller";
            // 
            // dobErr
            // 
            this.dobErr.AutoSize = true;
            this.dobErr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobErr.ForeColor = System.Drawing.Color.Red;
            this.dobErr.Location = new System.Drawing.Point(422, 66);
            this.dobErr.Name = "dobErr";
            this.dobErr.Size = new System.Drawing.Size(0, 16);
            this.dobErr.TabIndex = 50;
            // 
            // ManageSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.passwordErr);
            this.Controls.Add(this.dobErr);
            this.Controls.Add(this.phoneNumberErr);
            this.Controls.Add(this.cbSelectColumn);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.dgvSellerList);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Manage_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Manage_ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageSeller";
            this.Text = "ManageSeller";
            this.Load += new System.EventHandler(this.ManageSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSellerList;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Manage_Name;
        private System.Windows.Forms.Label Manage_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private WholeSaleManagementStudioDataSet3 wholeSaleManagementStudioDataSet3;
        private System.Windows.Forms.BindingSource sellerBindingSource;
        private WholeSaleManagementStudioDataSet3TableAdapters.SellerTableAdapter sellerTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSelectColumn;
        private System.Windows.Forms.Label phoneNumberErr;
        private System.Windows.Forms.Label passwordErr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dobErr;
    }
}