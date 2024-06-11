
namespace WholeSaleManagementSystem
{
    partial class ManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategory));
            this.CatDescTb = new System.Windows.Forms.TextBox();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.CatIdTb = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Manage_Name = new System.Windows.Forms.Label();
            this.Manage_ID = new System.Windows.Forms.Label();
            this.Manage_Description = new System.Windows.Forms.Label();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleManagementStudioDataSet4 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet4();
            this.product_CategoryTableAdapter = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet4TableAdapters.Product_CategoryTableAdapter();
            this.cbSelectColumn = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.catDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CatDescTb
            // 
            this.CatDescTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatDescTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDescTb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CatDescTb.Location = new System.Drawing.Point(488, 49);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(130, 23);
            this.CatDescTb.TabIndex = 26;
            // 
            // CatNameTb
            // 
            this.CatNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CatNameTb.Location = new System.Drawing.Point(255, 49);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(130, 23);
            this.CatNameTb.TabIndex = 27;
            // 
            // CatIdTb
            // 
            this.CatIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatIdTb.Enabled = false;
            this.CatIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdTb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CatIdTb.Location = new System.Drawing.Point(41, 48);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(130, 23);
            this.CatIdTb.TabIndex = 28;
            this.CatIdTb.Text = "Auto Generate";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkMagenta;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(355, 78);
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
            this.Edit.Location = new System.Drawing.Point(278, 78);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(71, 30);
            this.Edit.TabIndex = 24;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkMagenta;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(201, 78);
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
            this.Manage_Name.Location = new System.Drawing.Point(191, 48);
            this.Manage_Name.Name = "Manage_Name";
            this.Manage_Name.Size = new System.Drawing.Size(58, 19);
            this.Manage_Name.TabIndex = 20;
            this.Manage_Name.Text = "Name";
            // 
            // Manage_ID
            // 
            this.Manage_ID.AutoSize = true;
            this.Manage_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_ID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Manage_ID.Location = new System.Drawing.Point(11, 48);
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
            this.Manage_Description.Location = new System.Drawing.Point(391, 49);
            this.Manage_Description.Name = "Manage_Description";
            this.Manage_Description.Size = new System.Drawing.Size(94, 19);
            this.Manage_Description.TabIndex = 22;
            this.Manage_Description.Text = "Description";
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "Product_Category";
            this.productCategoryBindingSource.DataSource = this.wholeSaleManagementStudioDataSet4;
            // 
            // wholeSaleManagementStudioDataSet4
            // 
            this.wholeSaleManagementStudioDataSet4.DataSetName = "WholeSaleManagementStudioDataSet4";
            this.wholeSaleManagementStudioDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_CategoryTableAdapter
            // 
            this.product_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // cbSelectColumn
            // 
            this.cbSelectColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectColumn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbSelectColumn.FormattingEnabled = true;
            this.cbSelectColumn.Items.AddRange(new object[] {
            "All",
            "ID",
            "Name"});
            this.cbSelectColumn.Location = new System.Drawing.Point(180, 115);
            this.cbSelectColumn.Name = "cbSelectColumn";
            this.cbSelectColumn.Size = new System.Drawing.Size(121, 25);
            this.cbSelectColumn.TabIndex = 53;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxSearch.Location = new System.Drawing.Point(380, 114);
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
            this.label5.Location = new System.Drawing.Point(115, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(321, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Category";
            // 
            // catDGV
            // 
            this.catDGV.AllowUserToAddRows = false;
            this.catDGV.AllowUserToDeleteRows = false;
            this.catDGV.AllowUserToResizeColumns = false;
            this.catDGV.AllowUserToResizeRows = false;
            this.catDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catDGV.BackgroundColor = System.Drawing.Color.White;
            this.catDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.catDGV.ColumnHeadersHeight = 30;
            this.catDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.catDGV.GridColor = System.Drawing.Color.DarkMagenta;
            this.catDGV.Location = new System.Drawing.Point(20, 171);
            this.catDGV.Name = "catDGV";
            this.catDGV.ReadOnly = true;
            this.catDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.catDGV.RowHeadersVisible = false;
            this.catDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.catDGV.Size = new System.Drawing.Size(600, 237);
            this.catDGV.TabIndex = 54;
            this.catDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDGV_CellContentClick_1);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 420);
            this.ControlBox = false;
            this.Controls.Add(this.catDGV);
            this.Controls.Add(this.cbSelectColumn);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CatDescTb);
            this.Controls.Add(this.CatNameTb);
            this.Controls.Add(this.CatIdTb);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Manage_Name);
            this.Controls.Add(this.Manage_ID);
            this.Controls.Add(this.Manage_Description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategory";
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CatDescTb;
        private System.Windows.Forms.TextBox CatNameTb;
        private System.Windows.Forms.TextBox CatIdTb;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Manage_Name;
        private System.Windows.Forms.Label Manage_ID;
        private System.Windows.Forms.Label Manage_Description;
        private WholeSaleManagementStudioDataSet4 wholeSaleManagementStudioDataSet4;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private WholeSaleManagementStudioDataSet4TableAdapters.Product_CategoryTableAdapter product_CategoryTableAdapter;
        private System.Windows.Forms.ComboBox cbSelectColumn;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView catDGV;
    }
}