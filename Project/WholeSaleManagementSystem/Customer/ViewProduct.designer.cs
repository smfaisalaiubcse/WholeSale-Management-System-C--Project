
namespace WholeSaleManagementSystem
{
    partial class ViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBoxTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 364);
            this.panel1.TabIndex = 1;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchBoxTextBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(632, 56);
            this.searchPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(170, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search:";
            // 
            // searchBoxTextBox
            // 
            this.searchBoxTextBox.AcceptsReturn = false;
            this.searchBoxTextBox.AcceptsTab = false;
            this.searchBoxTextBox.AnimationSpeed = 200;
            this.searchBoxTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBoxTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBoxTextBox.BackColor = System.Drawing.Color.White;
            this.searchBoxTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBoxTextBox.BackgroundImage")));
            this.searchBoxTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchBoxTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchBoxTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchBoxTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchBoxTextBox.BorderRadius = 10;
            this.searchBoxTextBox.BorderThickness = 1;
            this.searchBoxTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBoxTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBoxTextBox.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxTextBox.DefaultText = "";
            this.searchBoxTextBox.FillColor = System.Drawing.Color.White;
            this.searchBoxTextBox.ForeColor = System.Drawing.Color.DarkMagenta;
            this.searchBoxTextBox.HideSelection = true;
            this.searchBoxTextBox.IconLeft = null;
            this.searchBoxTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBoxTextBox.IconPadding = 10;
            this.searchBoxTextBox.IconRight = null;
            this.searchBoxTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBoxTextBox.Lines = new string[0];
            this.searchBoxTextBox.Location = new System.Drawing.Point(255, 14);
            this.searchBoxTextBox.MaxLength = 32767;
            this.searchBoxTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBoxTextBox.Modified = false;
            this.searchBoxTextBox.Multiline = false;
            this.searchBoxTextBox.Name = "searchBoxTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBoxTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBoxTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBoxTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.DarkMagenta;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBoxTextBox.OnIdleState = stateProperties4;
            this.searchBoxTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.searchBoxTextBox.PasswordChar = '\0';
            this.searchBoxTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBoxTextBox.PlaceholderText = "Type here to search";
            this.searchBoxTextBox.ReadOnly = false;
            this.searchBoxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBoxTextBox.SelectedText = "";
            this.searchBoxTextBox.SelectionLength = 0;
            this.searchBoxTextBox.SelectionStart = 0;
            this.searchBoxTextBox.ShortcutsEnabled = true;
            this.searchBoxTextBox.Size = new System.Drawing.Size(234, 31);
            this.searchBoxTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchBoxTextBox.TabIndex = 17;
            this.searchBoxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBoxTextBox.TextMarginBottom = 0;
            this.searchBoxTextBox.TextMarginLeft = 3;
            this.searchBoxTextBox.TextMarginTop = 0;
            this.searchBoxTextBox.TextPlaceholder = "Type here to search";
            this.searchBoxTextBox.UseSystemPasswordChar = false;
            this.searchBoxTextBox.WordWrap = true;
            this.searchBoxTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBoxTextBox_KeyUp);
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProduct";
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox searchBoxTextBox;
    }
}