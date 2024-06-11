namespace WholeSaleManagementSystem
{
    partial class individualProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.proCategory_label = new System.Windows.Forms.Label();
            this.proQuantity_label = new System.Windows.Forms.Label();
            this.proPrice_label = new System.Windows.Forms.Label();
            this.proName_label = new System.Windows.Forms.Label();
            this.proID_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity_updown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.proExpireLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_updown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.proExpireLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.quantity_updown);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.proCategory_label);
            this.groupBox1.Controls.Add(this.proQuantity_label);
            this.groupBox1.Controls.Add(this.proPrice_label);
            this.groupBox1.Controls.Add(this.proName_label);
            this.groupBox1.Controls.Add(this.proID_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(493, 204);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.Location = new System.Drawing.Point(351, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proCategory_label
            // 
            this.proCategory_label.AutoSize = true;
            this.proCategory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proCategory_label.Location = new System.Drawing.Point(185, 132);
            this.proCategory_label.Name = "proCategory_label";
            this.proCategory_label.Size = new System.Drawing.Size(99, 25);
            this.proCategory_label.TabIndex = 13;
            this.proCategory_label.Text = "Category";
            // 
            // proQuantity_label
            // 
            this.proQuantity_label.AutoSize = true;
            this.proQuantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proQuantity_label.Location = new System.Drawing.Point(185, 107);
            this.proQuantity_label.Name = "proQuantity_label";
            this.proQuantity_label.Size = new System.Drawing.Size(92, 25);
            this.proQuantity_label.TabIndex = 12;
            this.proQuantity_label.Text = "Quantity";
            // 
            // proPrice_label
            // 
            this.proPrice_label.AutoSize = true;
            this.proPrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proPrice_label.Location = new System.Drawing.Point(185, 82);
            this.proPrice_label.Name = "proPrice_label";
            this.proPrice_label.Size = new System.Drawing.Size(61, 25);
            this.proPrice_label.TabIndex = 11;
            this.proPrice_label.Text = "Price";
            // 
            // proName_label
            // 
            this.proName_label.AutoSize = true;
            this.proName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proName_label.Location = new System.Drawing.Point(185, 57);
            this.proName_label.Name = "proName_label";
            this.proName_label.Size = new System.Drawing.Size(160, 25);
            this.proName_label.TabIndex = 10;
            this.proName_label.Text = "Product Name: ";
            // 
            // proID_label
            // 
            this.proID_label.AutoSize = true;
            this.proID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proID_label.Location = new System.Drawing.Point(185, 32);
            this.proID_label.Name = "proID_label";
            this.proID_label.Size = new System.Drawing.Size(124, 25);
            this.proID_label.TabIndex = 9;
            this.proID_label.Text = "Product ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(19, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID: ";
            // 
            // quantity_updown
            // 
            this.quantity_updown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_updown.Location = new System.Drawing.Point(351, 49);
            this.quantity_updown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity_updown.Name = "quantity_updown";
            this.quantity_updown.Size = new System.Drawing.Size(107, 38);
            this.quantity_updown.TabIndex = 15;
            this.quantity_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(19, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Expire:";
            // 
            // proExpireLabel
            // 
            this.proExpireLabel.AutoSize = true;
            this.proExpireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proExpireLabel.Location = new System.Drawing.Point(185, 157);
            this.proExpireLabel.Name = "proExpireLabel";
            this.proExpireLabel.Size = new System.Drawing.Size(73, 25);
            this.proExpireLabel.TabIndex = 17;
            this.proExpireLabel.Text = "Expire";
            // 
            // individualProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "individualProduct";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(513, 224);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_updown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label proCategory_label;
        private System.Windows.Forms.Label proQuantity_label;
        private System.Windows.Forms.Label proPrice_label;
        private System.Windows.Forms.Label proName_label;
        private System.Windows.Forms.Label proID_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown quantity_updown;
        private System.Windows.Forms.Label proExpireLabel;
        private System.Windows.Forms.Label label6;
    }
}
