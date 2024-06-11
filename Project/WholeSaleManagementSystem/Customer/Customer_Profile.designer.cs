
namespace WholeSaleManagementSystem
{
    partial class Customer_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Profile));
            this.changeIDButton = new System.Windows.Forms.Button();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // changeIDButton
            // 
            this.changeIDButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.changeIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeIDButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeIDButton.ForeColor = System.Drawing.Color.White;
            this.changeIDButton.Location = new System.Drawing.Point(12, 160);
            this.changeIDButton.Name = "changeIDButton";
            this.changeIDButton.Size = new System.Drawing.Size(166, 30);
            this.changeIDButton.TabIndex = 23;
            this.changeIDButton.Text = "Change User ID";
            this.changeIDButton.UseVisualStyleBackColor = false;
            this.changeIDButton.Click += new System.EventHandler(this.changeIDButton_Click);
            // 
            // editProfileButton
            // 
            this.editProfileButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.editProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProfileButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileButton.ForeColor = System.Drawing.Color.White;
            this.editProfileButton.Location = new System.Drawing.Point(12, 124);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(166, 30);
            this.editProfileButton.TabIndex = 24;
            this.editProfileButton.Text = "Edit Profile";
            this.editProfileButton.UseVisualStyleBackColor = false;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.viewProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProfileButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProfileButton.ForeColor = System.Drawing.Color.White;
            this.viewProfileButton.Location = new System.Drawing.Point(12, 88);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(166, 30);
            this.viewProfileButton.TabIndex = 25;
            this.viewProfileButton.Text = "View Profile";
            this.viewProfileButton.UseVisualStyleBackColor = false;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(12, 196);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(166, 30);
            this.changePasswordButton.TabIndex = 30;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(184, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 396);
            this.panel1.TabIndex = 31;
            // 
            // Customer_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 420);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.changeIDButton);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.viewProfileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Profile";
            this.Load += new System.EventHandler(this.Customer_Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button changeIDButton;
        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Button viewProfileButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Panel panel1;
    }
}