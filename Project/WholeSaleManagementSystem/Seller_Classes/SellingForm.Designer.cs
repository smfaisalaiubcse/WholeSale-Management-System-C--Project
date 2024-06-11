
namespace WholeSaleManagementSystem.Seller
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.sellsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleManagementStudioDataSet2 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet2();
            this.SelledProDGV = new System.Windows.Forms.DataGridView();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selledProductListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleManagementStudioDataSet = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet();
            this.Sellername = new System.Windows.Forms.Label();
            this.proSDGV = new System.Windows.Forms.DataGridView();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.proPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.proQuant = new System.Windows.Forms.TextBox();
            this.proName = new System.Windows.Forms.TextBox();
            this.Bill_ID = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.Add_Bill = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.AddPro = new System.Windows.Forms.Button();
            this.Pro_Name = new System.Windows.Forms.Label();
            this.Tprice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Amount_label = new System.Windows.Forms.Label();
            this.BillID = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Selling_Form = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.selledProductListTableAdapter = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSetTableAdapters.SelledProductListTableAdapter();
            this.wholeSaleManagementStudioDataSet1 = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet1TableAdapters.ProductTableAdapter();
            this.sellsListTableAdapter = new WholeSaleManagementSystem.WholeSaleManagementStudioDataSet2TableAdapters.SellsListTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Minimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Exit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelledProDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selledProductListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proSDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.billDGV);
            this.panel1.Controls.Add(this.SelledProDGV);
            this.panel1.Controls.Add(this.Sellername);
            this.panel1.Controls.Add(this.proSDGV);
            this.panel1.Controls.Add(this.cmbcategory);
            this.panel1.Controls.Add(this.proPrice);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.proQuant);
            this.panel1.Controls.Add(this.proName);
            this.panel1.Controls.Add(this.Bill_ID);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.Add_Bill);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.AddPro);
            this.panel1.Controls.Add(this.Pro_Name);
            this.panel1.Controls.Add(this.Tprice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Amount_label);
            this.panel1.Controls.Add(this.BillID);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.Selling_Form);
            this.panel1.Location = new System.Drawing.Point(89, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 387);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // billDGV
            // 
            this.billDGV.AllowUserToAddRows = false;
            this.billDGV.AllowUserToDeleteRows = false;
            this.billDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.Location = new System.Drawing.Point(268, 220);
            this.billDGV.Name = "billDGV";
            this.billDGV.ReadOnly = true;
            this.billDGV.RowHeadersVisible = false;
            this.billDGV.Size = new System.Drawing.Size(399, 119);
            this.billDGV.TabIndex = 41;
            // 
            // sellsListBindingSource
            // 
            this.sellsListBindingSource.DataMember = "SellsList";
            this.sellsListBindingSource.DataSource = this.wholeSaleManagementStudioDataSet2;
            // 
            // wholeSaleManagementStudioDataSet2
            // 
            this.wholeSaleManagementStudioDataSet2.DataSetName = "WholeSaleManagementStudioDataSet2";
            this.wholeSaleManagementStudioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelledProDGV
            // 
            this.SelledProDGV.AllowUserToAddRows = false;
            this.SelledProDGV.AutoGenerateColumns = false;
            this.SelledProDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelledProDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelledProDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.proNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.SelledProDGV.DataSource = this.selledProductListBindingSource;
            this.SelledProDGV.Location = new System.Drawing.Point(268, 33);
            this.SelledProDGV.Name = "SelledProDGV";
            this.SelledProDGV.RowHeadersVisible = false;
            this.SelledProDGV.Size = new System.Drawing.Size(399, 135);
            this.SelledProDGV.TabIndex = 41;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "BillId";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proNameDataGridViewTextBoxColumn
            // 
            this.proNameDataGridViewTextBoxColumn.DataPropertyName = "ProName";
            this.proNameDataGridViewTextBoxColumn.HeaderText = "ProName";
            this.proNameDataGridViewTextBoxColumn.Name = "proNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // selledProductListBindingSource
            // 
            this.selledProductListBindingSource.DataMember = "SelledProductList";
            this.selledProductListBindingSource.DataSource = this.wholeSaleManagementStudioDataSet;
            // 
            // wholeSaleManagementStudioDataSet
            // 
            this.wholeSaleManagementStudioDataSet.DataSetName = "WholeSaleManagementStudioDataSet";
            this.wholeSaleManagementStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sellername
            // 
            this.Sellername.AutoSize = true;
            this.Sellername.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sellername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sellername.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Sellername.Location = new System.Drawing.Point(3, 0);
            this.Sellername.Name = "Sellername";
            this.Sellername.Size = new System.Drawing.Size(50, 19);
            this.Sellername.TabIndex = 0;
            this.Sellername.Text = "Seller";
            // 
            // proSDGV
            // 
            this.proSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.proSDGV.Location = new System.Drawing.Point(18, 231);
            this.proSDGV.Name = "proSDGV";
            this.proSDGV.ReadOnly = true;
            this.proSDGV.RowHeadersVisible = false;
            this.proSDGV.Size = new System.Drawing.Size(221, 150);
            this.proSDGV.TabIndex = 41;
            this.proSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proSDGV_CellContentClick);
            // 
            // cmbcategory
            // 
            this.cmbcategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategory.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(18, 199);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(144, 25);
            this.cmbcategory.TabIndex = 40;
            this.cmbcategory.Text = "Select category";
            this.cmbcategory.SelectedIndexChanged += new System.EventHandler(this.cmbcategory_SelectedIndexChanged);
            // 
            // proPrice
            // 
            this.proPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proPrice.Enabled = false;
            this.proPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proPrice.ForeColor = System.Drawing.Color.DarkMagenta;
            this.proPrice.Location = new System.Drawing.Point(109, 131);
            this.proPrice.Name = "proPrice";
            this.proPrice.Size = new System.Drawing.Size(130, 23);
            this.proPrice.TabIndex = 39;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Price.Location = new System.Drawing.Point(14, 131);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(47, 19);
            this.Price.TabIndex = 38;
            this.Price.Text = "Price";
            // 
            // proQuant
            // 
            this.proQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proQuant.ForeColor = System.Drawing.Color.DarkMagenta;
            this.proQuant.Location = new System.Drawing.Point(109, 97);
            this.proQuant.Name = "proQuant";
            this.proQuant.Size = new System.Drawing.Size(130, 23);
            this.proQuant.TabIndex = 35;
            // 
            // proName
            // 
            this.proName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proName.Enabled = false;
            this.proName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proName.ForeColor = System.Drawing.Color.DarkMagenta;
            this.proName.Location = new System.Drawing.Point(109, 63);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(130, 23);
            this.proName.TabIndex = 36;
            // 
            // Bill_ID
            // 
            this.Bill_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bill_ID.Enabled = false;
            this.Bill_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_ID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Bill_ID.Location = new System.Drawing.Point(109, 27);
            this.Bill_ID.Name = "Bill_ID";
            this.Bill_ID.Size = new System.Drawing.Size(130, 23);
            this.Bill_ID.TabIndex = 37;
            this.Bill_ID.Text = "Auto Generate";
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.White;
            this.Print.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Print.Location = new System.Drawing.Point(526, 351);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(71, 30);
            this.Print.TabIndex = 32;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Add_Bill
            // 
            this.Add_Bill.BackColor = System.Drawing.Color.White;
            this.Add_Bill.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Bill.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Add_Bill.Location = new System.Drawing.Point(346, 351);
            this.Add_Bill.Name = "Add_Bill";
            this.Add_Bill.Size = new System.Drawing.Size(71, 30);
            this.Add_Bill.TabIndex = 32;
            this.Add_Bill.Text = "Add";
            this.Add_Bill.UseVisualStyleBackColor = false;
            this.Add_Bill.Click += new System.EventHandler(this.Add_Bill_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.DarkMagenta;
            this.refresh.Location = new System.Drawing.Point(168, 196);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(71, 30);
            this.refresh.TabIndex = 33;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // AddPro
            // 
            this.AddPro.BackColor = System.Drawing.Color.White;
            this.AddPro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPro.ForeColor = System.Drawing.Color.DarkMagenta;
            this.AddPro.Location = new System.Drawing.Point(88, 160);
            this.AddPro.Name = "AddPro";
            this.AddPro.Size = new System.Drawing.Size(118, 30);
            this.AddPro.TabIndex = 34;
            this.AddPro.Text = "Add Product";
            this.AddPro.UseVisualStyleBackColor = false;
            this.AddPro.Click += new System.EventHandler(this.AddPro_Click);
            // 
            // Pro_Name
            // 
            this.Pro_Name.AutoSize = true;
            this.Pro_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pro_Name.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Pro_Name.Location = new System.Drawing.Point(14, 62);
            this.Pro_Name.Name = "Pro_Name";
            this.Pro_Name.Size = new System.Drawing.Size(82, 19);
            this.Pro_Name.TabIndex = 29;
            this.Pro_Name.Text = "ProName";
            // 
            // Tprice
            // 
            this.Tprice.AutoSize = true;
            this.Tprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tprice.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Tprice.Location = new System.Drawing.Point(522, 171);
            this.Tprice.Name = "Tprice";
            this.Tprice.Size = new System.Drawing.Size(26, 19);
            this.Tprice.TabIndex = 30;
            this.Tprice.Text = "TK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(444, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sells List";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_label.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Amount_label.Location = new System.Drawing.Point(367, 171);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(71, 19);
            this.Amount_label.TabIndex = 30;
            this.Amount_label.Text = "Amount";
            // 
            // BillID
            // 
            this.BillID.AutoSize = true;
            this.BillID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.BillID.Location = new System.Drawing.Point(18, 27);
            this.BillID.Name = "BillID";
            this.BillID.Size = new System.Drawing.Size(49, 19);
            this.BillID.TabIndex = 30;
            this.BillID.Text = "Bill Id";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Quantity.Location = new System.Drawing.Point(12, 97);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(74, 19);
            this.Quantity.TabIndex = 31;
            this.Quantity.Text = "Quantity";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Date.Location = new System.Drawing.Point(522, 11);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(45, 19);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date";
            // 
            // Selling_Form
            // 
            this.Selling_Form.AutoSize = true;
            this.Selling_Form.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selling_Form.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Selling_Form.Location = new System.Drawing.Point(264, 7);
            this.Selling_Form.Name = "Selling_Form";
            this.Selling_Form.Size = new System.Drawing.Size(139, 23);
            this.Selling_Form.TabIndex = 0;
            this.Selling_Form.Text = "SELLING FORM";
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.White;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.DarkMagenta;
            this.LogOut.Location = new System.Drawing.Point(12, 400);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(71, 30);
            this.LogOut.TabIndex = 34;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // selledProductListTableAdapter
            // 
            this.selledProductListTableAdapter.ClearBeforeFill = true;
            // 
            // wholeSaleManagementStudioDataSet1
            // 
            this.wholeSaleManagementStudioDataSet1.DataSetName = "WholeSaleManagementStudioDataSet1";
            this.wholeSaleManagementStudioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.wholeSaleManagementStudioDataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // sellsListTableAdapter
            // 
            this.sellsListTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Minimize
            // 
            this.Minimize.ActiveImage = ((System.Drawing.Image)(resources.GetObject("Minimize.ActiveImage")));
            this.Minimize.AllowAnimations = true;
            this.Minimize.AllowBuffering = false;
            this.Minimize.AllowToggling = false;
            this.Minimize.AllowZooming = true;
            this.Minimize.AllowZoomingOnFocus = false;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Minimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Minimize.ErrorImage")));
            this.Minimize.FadeWhenInactive = false;
            this.Minimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageActive = ((System.Drawing.Image)(resources.GetObject("Minimize.ImageActive")));
            this.Minimize.ImageLocation = null;
            this.Minimize.ImageMargin = 40;
            this.Minimize.ImageSize = new System.Drawing.Size(-20, -20);
            this.Minimize.ImageZoomSize = new System.Drawing.Size(20, 20);
            this.Minimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("Minimize.InitialImage")));
            this.Minimize.Location = new System.Drawing.Point(38, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Rotation = 0;
            this.Minimize.ShowActiveImage = true;
            this.Minimize.ShowCursorChanges = true;
            this.Minimize.ShowImageBorders = true;
            this.Minimize.ShowSizeMarkers = false;
            this.Minimize.Size = new System.Drawing.Size(20, 20);
            this.Minimize.TabIndex = 35;
            this.Minimize.ToolTipText = "";
            this.Minimize.WaitOnLoad = false;
            this.Minimize.Zoom = 40;
            this.Minimize.ZoomSpeed = 10;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.ActiveImage = ((System.Drawing.Image)(resources.GetObject("Exit.ActiveImage")));
            this.Exit.AllowAnimations = true;
            this.Exit.AllowBuffering = false;
            this.Exit.AllowToggling = false;
            this.Exit.AllowZooming = true;
            this.Exit.AllowZoomingOnFocus = true;
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AutoScrollMargin = new System.Drawing.Size(800, 450);
            this.Exit.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Exit.ErrorImage")));
            this.Exit.FadeWhenInactive = false;
            this.Exit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageActive = ((System.Drawing.Image)(resources.GetObject("Exit.ImageActive")));
            this.Exit.ImageLocation = null;
            this.Exit.ImageMargin = 40;
            this.Exit.ImageSize = new System.Drawing.Size(-20, -20);
            this.Exit.ImageZoomSize = new System.Drawing.Size(20, 20);
            this.Exit.InitialImage = ((System.Drawing.Image)(resources.GetObject("Exit.InitialImage")));
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Rotation = 0;
            this.Exit.ShowActiveImage = true;
            this.Exit.ShowCursorChanges = true;
            this.Exit.ShowImageBorders = true;
            this.Exit.ShowSizeMarkers = false;
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 36;
            this.Exit.ToolTipText = "";
            this.Exit.WaitOnLoad = false;
            this.Exit.Zoom = 40;
            this.Exit.ZoomSpeed = 10;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(784, 448);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelledProDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selledProductListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proSDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleManagementStudioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Selling_Form;
        private System.Windows.Forms.TextBox proPrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox proQuant;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.TextBox Bill_ID;
        private System.Windows.Forms.Button Add_Bill;
        private System.Windows.Forms.Button AddPro;
        private System.Windows.Forms.Label Pro_Name;
        private System.Windows.Forms.Label BillID;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.DataGridView SelledProDGV;
        private System.Windows.Forms.DataGridView proSDGV;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Label Tprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Amount_label;
        private WholeSaleManagementStudioDataSet wholeSaleManagementStudioDataSet;
        private System.Windows.Forms.BindingSource selledProductListBindingSource;
        private WholeSaleManagementStudioDataSetTableAdapters.SelledProductListTableAdapter selledProductListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private WholeSaleManagementStudioDataSet1 wholeSaleManagementStudioDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WholeSaleManagementStudioDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label Sellername;
        private WholeSaleManagementStudioDataSet2 wholeSaleManagementStudioDataSet2;
        private System.Windows.Forms.BindingSource sellsListBindingSource;
        private WholeSaleManagementStudioDataSet2TableAdapters.SellsListTableAdapter sellsListTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Bunifu.UI.WinForms.BunifuImageButton Minimize;
        private Bunifu.UI.WinForms.BunifuImageButton Exit;
    }
}