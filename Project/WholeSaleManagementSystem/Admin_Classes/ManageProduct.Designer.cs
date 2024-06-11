
namespace WholeSaleManagementSystem
{
    partial class ManageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProduct));
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Product_Name = new System.Windows.Forms.Label();
            this.Product_Category = new System.Windows.Forms.Label();
            this.Product_ID = new System.Windows.Forms.Label();
            this.Product_Quantity = new System.Windows.Forms.Label();
            this.Product_Price = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleManagementStudioDataSet7 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet7();
            this.productTableAdapter = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet7TableAdapters.ProductTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectColumn = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wholeSaleManagementStudioDataSet8 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet8();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_CategoryTableAdapter = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet8TableAdapters.Product_CategoryTableAdapter();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.proDGV = new System.Windows.Forms.DataGridView();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleManagementStudioDataSet9 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet9();
            this.productTableAdapter1 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet9TableAdapters.ProductTableAdapter();
            this.expiryDtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.notExpiredList = new System.Windows.Forms.RadioButton();
            this.expiredList = new System.Windows.Forms.RadioButton();
            this.showGreen = new System.Windows.Forms.RadioButton();
            this.showRed = new System.Windows.Forms.RadioButton();
            this.showAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet9)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuant.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxQuant.Location = new System.Drawing.Point(345, 30);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(130, 23);
            this.textBoxQuant.TabIndex = 41;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrice.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxPrice.Location = new System.Drawing.Point(109, 88);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(130, 23);
            this.txtBoxPrice.TabIndex = 40;
            // 
            // txtBoxName
            // 
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxName.Location = new System.Drawing.Point(109, 59);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(130, 23);
            this.txtBoxName.TabIndex = 45;
            // 
            // txtBoxId
            // 
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxId.Enabled = false;
            this.txtBoxId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBoxId.Location = new System.Drawing.Point(109, 30);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(130, 23);
            this.txtBoxId.TabIndex = 46;
            this.txtBoxId.Text = "Auto Generated";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkMagenta;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(345, 119);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(71, 30);
            this.Delete.TabIndex = 37;
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
            this.Edit.Location = new System.Drawing.Point(258, 120);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(71, 30);
            this.Edit.TabIndex = 38;
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
            this.Add.Location = new System.Drawing.Point(168, 120);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(71, 30);
            this.Add.TabIndex = 39;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSize = true;
            this.Product_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Name.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Product_Name.Location = new System.Drawing.Point(13, 63);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(58, 19);
            this.Product_Name.TabIndex = 30;
            this.Product_Name.Text = "Name";
            // 
            // Product_Category
            // 
            this.Product_Category.AutoSize = true;
            this.Product_Category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Category.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Product_Category.Location = new System.Drawing.Point(248, 59);
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.Size = new System.Drawing.Size(81, 19);
            this.Product_Category.TabIndex = 33;
            this.Product_Category.Text = "Category";
            // 
            // Product_ID
            // 
            this.Product_ID.AutoSize = true;
            this.Product_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_ID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Product_ID.Location = new System.Drawing.Point(13, 34);
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Size = new System.Drawing.Size(24, 19);
            this.Product_ID.TabIndex = 31;
            this.Product_ID.Text = "ID";
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.AutoSize = true;
            this.Product_Quantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Quantity.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Product_Quantity.Location = new System.Drawing.Point(248, 30);
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.Size = new System.Drawing.Size(74, 19);
            this.Product_Quantity.TabIndex = 36;
            this.Product_Quantity.Text = "Quantity";
            // 
            // Product_Price
            // 
            this.Product_Price.AutoSize = true;
            this.Product_Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Price.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Product_Price.Location = new System.Drawing.Point(12, 88);
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.Size = new System.Drawing.Size(47, 19);
            this.Product_Price.TabIndex = 32;
            this.Product_Price.Text = "Price";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.wholeSaleManagementStudioDataSet7;
            // 
            // wholeSaleManagementStudioDataSet7
            // 
            this.wholeSaleManagementStudioDataSet7.DataSetName = "WholeSaleManagementStudioDataSet7";
            this.wholeSaleManagementStudioDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(233, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Manage Product";
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
            "Price",
            "Category"});
            this.cbSelectColumn.Location = new System.Drawing.Point(186, 156);
            this.cbSelectColumn.Name = "cbSelectColumn";
            this.cbSelectColumn.Size = new System.Drawing.Size(121, 25);
            this.cbSelectColumn.TabIndex = 53;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxSearch.Location = new System.Drawing.Point(386, 155);
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
            this.label5.Location = new System.Drawing.Point(121, 157);
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
            this.label2.Location = new System.Drawing.Point(327, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Search";
            // 
            // wholeSaleManagementStudioDataSet8
            // 
            this.wholeSaleManagementStudioDataSet8.DataSetName = "WholeSaleManagementStudioDataSet8";
            this.wholeSaleManagementStudioDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "Product_Category";
            this.productCategoryBindingSource.DataSource = this.wholeSaleManagementStudioDataSet8;
            // 
            // product_CategoryTableAdapter
            // 
            this.product_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCat.ForeColor = System.Drawing.Color.DarkMagenta;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(345, 60);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(130, 24);
            this.comboBoxCat.TabIndex = 54;
            // 
            // proDGV
            // 
            this.proDGV.AllowUserToAddRows = false;
            this.proDGV.AllowUserToDeleteRows = false;
            this.proDGV.AllowUserToResizeColumns = false;
            this.proDGV.AllowUserToResizeRows = false;
            this.proDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.proDGV.BackgroundColor = System.Drawing.Color.White;
            this.proDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.proDGV.ColumnHeadersHeight = 30;
            this.proDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.proDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.proDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proDGV.GridColor = System.Drawing.Color.DarkMagenta;
            this.proDGV.Location = new System.Drawing.Point(0, 242);
            this.proDGV.Name = "proDGV";
            this.proDGV.ReadOnly = true;
            this.proDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.proDGV.RowHeadersVisible = false;
            this.proDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.proDGV.Size = new System.Drawing.Size(632, 178);
            this.proDGV.TabIndex = 55;
            this.proDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proDGV_CellContentClick);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.wholeSaleManagementStudioDataSet9;
            // 
            // wholeSaleManagementStudioDataSet9
            // 
            this.wholeSaleManagementStudioDataSet9.DataSetName = "WholeSaleManagementStudioDataSet9";
            this.wholeSaleManagementStudioDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // expiryDtp
            // 
            this.expiryDtp.Checked = false;
            this.expiryDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryDtp.Location = new System.Drawing.Point(345, 91);
            this.expiryDtp.Name = "expiryDtp";
            this.expiryDtp.Size = new System.Drawing.Size(127, 20);
            this.expiryDtp.TabIndex = 56;
            this.expiryDtp.Value = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(266, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Expire";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.notExpiredList);
            this.groupBox2.Controls.Add(this.expiredList);
            this.groupBox2.Controls.Add(this.showGreen);
            this.groupBox2.Controls.Add(this.showRed);
            this.groupBox2.Controls.Add(this.showAll);
            this.groupBox2.Location = new System.Drawing.Point(129, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 51);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // notExpiredList
            // 
            this.notExpiredList.AutoSize = true;
            this.notExpiredList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notExpiredList.Location = new System.Drawing.Point(224, 19);
            this.notExpiredList.Name = "notExpiredList";
            this.notExpiredList.Size = new System.Drawing.Size(88, 20);
            this.notExpiredList.TabIndex = 4;
            this.notExpiredList.TabStop = true;
            this.notExpiredList.Text = "Not Expired";
            this.notExpiredList.UseVisualStyleBackColor = true;
            this.notExpiredList.CheckedChanged += new System.EventHandler(this.notExpiredList_CheckedChanged);
            // 
            // expiredList
            // 
            this.expiredList.AutoSize = true;
            this.expiredList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredList.Location = new System.Drawing.Point(318, 19);
            this.expiredList.Name = "expiredList";
            this.expiredList.Size = new System.Drawing.Size(66, 20);
            this.expiredList.TabIndex = 3;
            this.expiredList.TabStop = true;
            this.expiredList.Text = "Expired";
            this.expiredList.UseVisualStyleBackColor = true;
            this.expiredList.CheckedChanged += new System.EventHandler(this.expiredList_CheckedChanged);
            // 
            // showGreen
            // 
            this.showGreen.AutoSize = true;
            this.showGreen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGreen.ForeColor = System.Drawing.Color.Green;
            this.showGreen.Location = new System.Drawing.Point(147, 20);
            this.showGreen.Name = "showGreen";
            this.showGreen.Size = new System.Drawing.Size(78, 20);
            this.showGreen.TabIndex = 2;
            this.showGreen.TabStop = true;
            this.showGreen.Text = "Green List";
            this.showGreen.UseVisualStyleBackColor = true;
            this.showGreen.CheckedChanged += new System.EventHandler(this.showGreen_CheckedChanged);
            // 
            // showRed
            // 
            this.showRed.AutoSize = true;
            this.showRed.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRed.ForeColor = System.Drawing.Color.Red;
            this.showRed.Location = new System.Drawing.Point(77, 20);
            this.showRed.Name = "showRed";
            this.showRed.Size = new System.Drawing.Size(66, 20);
            this.showRed.TabIndex = 1;
            this.showRed.TabStop = true;
            this.showRed.Text = "Red List";
            this.showRed.UseVisualStyleBackColor = true;
            this.showRed.CheckedChanged += new System.EventHandler(this.showRed_CheckedChanged);
            // 
            // showAll
            // 
            this.showAll.AutoSize = true;
            this.showAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll.Location = new System.Drawing.Point(20, 20);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(52, 20);
            this.showAll.TabIndex = 0;
            this.showAll.TabStop = true;
            this.showAll.Text = "All list";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.CheckedChanged += new System.EventHandler(this.showAll_CheckedChanged);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expiryDtp);
            this.Controls.Add(this.proDGV);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.cbSelectColumn);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.Product_Category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Product_ID);
            this.Controls.Add(this.Product_Quantity);
            this.Controls.Add(this.Product_Price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet9)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Product_Name;
        private System.Windows.Forms.Label Product_Category;
        private System.Windows.Forms.Label Product_ID;
        private System.Windows.Forms.Label Product_Quantity;
        private System.Windows.Forms.Label Product_Price;
        private WholeSaleManagementStudioDataSet7 wholeSaleManagementStudioDataSet7;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WholeSaleManagementStudioDataSet7TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectColumn;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private WholeSaleManagementStudioDataSet8 wholeSaleManagementStudioDataSet8;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private WholeSaleManagementStudioDataSet8TableAdapters.Product_CategoryTableAdapter product_CategoryTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.DataGridView proDGV;
        private WholeSaleManagementStudioDataSet9 wholeSaleManagementStudioDataSet9;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private WholeSaleManagementStudioDataSet9TableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.DateTimePicker expiryDtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton notExpiredList;
        private System.Windows.Forms.RadioButton expiredList;
        private System.Windows.Forms.RadioButton showGreen;
        private System.Windows.Forms.RadioButton showRed;
        private System.Windows.Forms.RadioButton showAll;
    }
}