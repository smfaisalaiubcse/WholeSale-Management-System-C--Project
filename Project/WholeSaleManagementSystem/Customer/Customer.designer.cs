
namespace WholeSaleManagementSystem
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelside = new System.Windows.Forms.Panel();
            this.oderListButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.ManageProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.Minimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Exit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ID_label = new System.Windows.Forms.Label();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelside.Controls.Add(this.ID_label);
            this.panelside.Controls.Add(this.oderListButton);
            this.panelside.Controls.Add(this.profileButton);
            this.panelside.Controls.Add(this.ManageProduct);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.LogOut);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelside.Location = new System.Drawing.Point(0, 30);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(168, 420);
            this.panelside.TabIndex = 8;
            // 
            // oderListButton
            // 
            this.oderListButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.oderListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.oderListButton.FlatAppearance.BorderSize = 0;
            this.oderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oderListButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oderListButton.ForeColor = System.Drawing.Color.White;
            this.oderListButton.Image = global::WholeSaleManagementSystem.Properties.Resources.product_24px;
            this.oderListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oderListButton.Location = new System.Drawing.Point(0, 213);
            this.oderListButton.Name = "oderListButton";
            this.oderListButton.Size = new System.Drawing.Size(200, 30);
            this.oderListButton.TabIndex = 5;
            this.oderListButton.Text = "Oder List";
            this.oderListButton.UseVisualStyleBackColor = false;
            this.oderListButton.Click += new System.EventHandler(this.oderListButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Image = global::WholeSaleManagementSystem.Properties.Resources.product_24px;
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Location = new System.Drawing.Point(0, 249);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(200, 30);
            this.profileButton.TabIndex = 4;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // ManageProduct
            // 
            this.ManageProduct.BackColor = System.Drawing.Color.DarkMagenta;
            this.ManageProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ManageProduct.FlatAppearance.BorderSize = 0;
            this.ManageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageProduct.ForeColor = System.Drawing.Color.White;
            this.ManageProduct.Image = global::WholeSaleManagementSystem.Properties.Resources.product_24px;
            this.ManageProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageProduct.Location = new System.Drawing.Point(0, 177);
            this.ManageProduct.Name = "ManageProduct";
            this.ManageProduct.Size = new System.Drawing.Size(200, 30);
            this.ManageProduct.TabIndex = 2;
            this.ManageProduct.Text = "View Products";
            this.ManageProduct.UseVisualStyleBackColor = false;
            this.ManageProduct.Click += new System.EventHandler(this.ManageProduct_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WholeSaleManagementSystem.Properties.Resources.staff_96px;
            this.pictureBox1.Location = new System.Drawing.Point(32, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LogOut
            // 
            this.LogOut.AllowAnimations = true;
            this.LogOut.AllowMouseEffects = true;
            this.LogOut.AllowToggling = false;
            this.LogOut.AnimationSpeed = 200;
            this.LogOut.AutoGenerateColors = false;
            this.LogOut.AutoRoundBorders = false;
            this.LogOut.AutoSizeLeftIcon = true;
            this.LogOut.AutoSizeRightIcon = true;
            this.LogOut.BackColor = System.Drawing.Color.Transparent;
            this.LogOut.BackColor1 = System.Drawing.Color.Transparent;
            this.LogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOut.BackgroundImage")));
            this.LogOut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOut.ButtonText = "LOG OUT";
            this.LogOut.ButtonTextMarginLeft = 0;
            this.LogOut.ColorContrastOnClick = 45;
            this.LogOut.ColorContrastOnHover = 45;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.LogOut.CustomizableEdges = borderEdges3;
            this.LogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogOut.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LogOut.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LogOut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LogOut.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LogOut.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LogOut.IconMarginLeft = 11;
            this.LogOut.IconPadding = 10;
            this.LogOut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LogOut.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LogOut.IconSize = 25;
            this.LogOut.IdleBorderColor = System.Drawing.Color.White;
            this.LogOut.IdleBorderRadius = 1;
            this.LogOut.IdleBorderThickness = 1;
            this.LogOut.IdleFillColor = System.Drawing.Color.Transparent;
            this.LogOut.IdleIconLeftImage = null;
            this.LogOut.IdleIconRightImage = null;
            this.LogOut.IndicateFocus = false;
            this.LogOut.Location = new System.Drawing.Point(41, 384);
            this.LogOut.Name = "LogOut";
            this.LogOut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogOut.OnDisabledState.BorderRadius = 1;
            this.LogOut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOut.OnDisabledState.BorderThickness = 1;
            this.LogOut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LogOut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LogOut.OnDisabledState.IconLeftImage = null;
            this.LogOut.OnDisabledState.IconRightImage = null;
            this.LogOut.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LogOut.onHoverState.BorderRadius = 1;
            this.LogOut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOut.onHoverState.BorderThickness = 1;
            this.LogOut.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LogOut.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LogOut.onHoverState.IconLeftImage = null;
            this.LogOut.onHoverState.IconRightImage = null;
            this.LogOut.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.LogOut.OnIdleState.BorderRadius = 1;
            this.LogOut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOut.OnIdleState.BorderThickness = 1;
            this.LogOut.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.LogOut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LogOut.OnIdleState.IconLeftImage = null;
            this.LogOut.OnIdleState.IconRightImage = null;
            this.LogOut.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LogOut.OnPressedState.BorderRadius = 1;
            this.LogOut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogOut.OnPressedState.BorderThickness = 1;
            this.LogOut.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LogOut.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LogOut.OnPressedState.IconLeftImage = null;
            this.LogOut.OnPressedState.IconRightImage = null;
            this.LogOut.Size = new System.Drawing.Size(80, 24);
            this.LogOut.TabIndex = 3;
            this.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogOut.TextMarginLeft = 0;
            this.LogOut.TextPadding = new System.Windows.Forms.Padding(0);
            this.LogOut.UseDefaultRadiusAndThickness = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(168, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(632, 420);
            this.mainpanel.TabIndex = 9;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Magenta;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(770, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 30);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Magenta;
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Controls.Add(this.Minimize);
            this.panelheader.Controls.Add(this.Exit);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(800, 30);
            this.panelheader.TabIndex = 7;
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
            this.Minimize.Location = new System.Drawing.Point(32, 4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Rotation = 0;
            this.Minimize.ShowActiveImage = true;
            this.Minimize.ShowCursorChanges = true;
            this.Minimize.ShowImageBorders = true;
            this.Minimize.ShowSizeMarkers = false;
            this.Minimize.Size = new System.Drawing.Size(20, 20);
            this.Minimize.TabIndex = 0;
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
            this.Exit.AllowZoomingOnFocus = false;
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
            this.Exit.Location = new System.Drawing.Point(6, 4);
            this.Exit.Name = "Exit";
            this.Exit.Rotation = 0;
            this.Exit.ShowActiveImage = true;
            this.Exit.ShowCursorChanges = true;
            this.Exit.ShowImageBorders = true;
            this.Exit.ShowSizeMarkers = false;
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 0;
            this.Exit.ToolTipText = "";
            this.Exit.WaitOnLoad = false;
            this.Exit.Zoom = 40;
            this.Exit.ZoomSpeed = 10;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.ID_label.ForeColor = System.Drawing.Color.White;
            this.ID_label.Location = new System.Drawing.Point(12, 133);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(21, 23);
            this.ID_label.TabIndex = 15;
            this.ID_label.Text = "?";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panelside.ResumeLayout(false);
            this.panelside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ManageProduct;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel mainpanel;
        private Bunifu.UI.WinForms.BunifuImageButton Exit;
        private Bunifu.UI.WinForms.BunifuImageButton Minimize;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button oderListButton;
        private System.Windows.Forms.Label ID_label;
    }
}

