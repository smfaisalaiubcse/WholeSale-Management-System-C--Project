
namespace WholeSaleManagementSystem
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectRole = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.Label();
            this.Clear2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Clear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Signup = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LogInButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UserpassTxtBx = new Bunifu.UI.WinForms.BunifuTextBox();
            this.UserNameTxtBx = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LogInFormEllips = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Minimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Exit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SelectRole);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.Clear2);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Signup);
            this.panel1.Controls.Add(this.LogInButton);
            this.panel1.Controls.Add(this.UserpassTxtBx);
            this.panel1.Controls.Add(this.UserNameTxtBx);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 343);
            this.panel1.TabIndex = 0;
            // 
            // SelectRole
            // 
            this.SelectRole.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRole.ForeColor = System.Drawing.Color.DarkMagenta;
            this.SelectRole.FormattingEnabled = true;
            this.SelectRole.Items.AddRange(new object[] {
            "Admin",
            "Seller",
            "Customer"});
            this.SelectRole.Location = new System.Drawing.Point(90, 100);
            this.SelectRole.Name = "SelectRole";
            this.SelectRole.Size = new System.Drawing.Size(234, 24);
            this.SelectRole.TabIndex = 0;
            this.SelectRole.Text = "Select Role";
            this.SelectRole.SelectedIndexChanged += new System.EventHandler(this.SelectRole_SelectedIndexChanged);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Logo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Logo.Location = new System.Drawing.Point(91, 74);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(233, 23);
            this.Logo.TabIndex = 4;
            this.Logo.Text = "WholeSaleManagement";
            // 
            // Clear2
            // 
            this.Clear2.AllowAnimations = true;
            this.Clear2.AllowMouseEffects = true;
            this.Clear2.AllowToggling = false;
            this.Clear2.AnimationSpeed = 200;
            this.Clear2.AutoGenerateColors = false;
            this.Clear2.AutoRoundBorders = false;
            this.Clear2.AutoSizeLeftIcon = true;
            this.Clear2.AutoSizeRightIcon = true;
            this.Clear2.BackColor = System.Drawing.Color.Transparent;
            this.Clear2.BackColor1 = System.Drawing.Color.Transparent;
            this.Clear2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear2.BackgroundImage")));
            this.Clear2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear2.ButtonText = "Clear";
            this.Clear2.ButtonTextMarginLeft = 0;
            this.Clear2.ColorContrastOnClick = 45;
            this.Clear2.ColorContrastOnHover = 45;
            this.Clear2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Clear2.CustomizableEdges = borderEdges1;
            this.Clear2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Clear2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Clear2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Clear2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Clear2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Clear2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Clear2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Clear2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Clear2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Clear2.IconMarginLeft = 11;
            this.Clear2.IconPadding = 10;
            this.Clear2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clear2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Clear2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Clear2.IconSize = 25;
            this.Clear2.IdleBorderColor = System.Drawing.Color.Transparent;
            this.Clear2.IdleBorderRadius = 1;
            this.Clear2.IdleBorderThickness = 1;
            this.Clear2.IdleFillColor = System.Drawing.Color.Transparent;
            this.Clear2.IdleIconLeftImage = null;
            this.Clear2.IdleIconRightImage = null;
            this.Clear2.IndicateFocus = false;
            this.Clear2.Location = new System.Drawing.Point(135, 294);
            this.Clear2.Name = "Clear2";
            this.Clear2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Clear2.OnDisabledState.BorderRadius = 1;
            this.Clear2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear2.OnDisabledState.BorderThickness = 1;
            this.Clear2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Clear2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Clear2.OnDisabledState.IconLeftImage = null;
            this.Clear2.OnDisabledState.IconRightImage = null;
            this.Clear2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Clear2.onHoverState.BorderRadius = 1;
            this.Clear2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear2.onHoverState.BorderThickness = 1;
            this.Clear2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Clear2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Clear2.onHoverState.IconLeftImage = null;
            this.Clear2.onHoverState.IconRightImage = null;
            this.Clear2.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Clear2.OnIdleState.BorderRadius = 1;
            this.Clear2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear2.OnIdleState.BorderThickness = 1;
            this.Clear2.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Clear2.OnIdleState.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Clear2.OnIdleState.IconLeftImage = null;
            this.Clear2.OnIdleState.IconRightImage = null;
            this.Clear2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Clear2.OnPressedState.BorderRadius = 1;
            this.Clear2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear2.OnPressedState.BorderThickness = 1;
            this.Clear2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Clear2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Clear2.OnPressedState.IconLeftImage = null;
            this.Clear2.OnPressedState.IconRightImage = null;
            this.Clear2.Size = new System.Drawing.Size(147, 26);
            this.Clear2.TabIndex = 2;
            this.Clear2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clear2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Clear2.TextMarginLeft = 0;
            this.Clear2.TextPadding = new System.Windows.Forms.Padding(0);
            this.Clear2.UseDefaultRadiusAndThickness = true;
            this.Clear2.Visible = false;
            this.Clear2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Clear
            // 
            this.Clear.AllowAnimations = true;
            this.Clear.AllowMouseEffects = true;
            this.Clear.AllowToggling = false;
            this.Clear.AnimationSpeed = 200;
            this.Clear.AutoGenerateColors = false;
            this.Clear.AutoRoundBorders = false;
            this.Clear.AutoSizeLeftIcon = true;
            this.Clear.AutoSizeRightIcon = true;
            this.Clear.BackColor = System.Drawing.Color.Transparent;
            this.Clear.BackColor1 = System.Drawing.Color.Transparent;
            this.Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear.BackgroundImage")));
            this.Clear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear.ButtonText = "Clear";
            this.Clear.ButtonTextMarginLeft = 0;
            this.Clear.ColorContrastOnClick = 45;
            this.Clear.ColorContrastOnHover = 45;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Clear.CustomizableEdges = borderEdges2;
            this.Clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Clear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Clear.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Clear.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Clear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Clear.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Clear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Clear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Clear.IconMarginLeft = 11;
            this.Clear.IconPadding = 10;
            this.Clear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Clear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Clear.IconSize = 25;
            this.Clear.IdleBorderColor = System.Drawing.Color.Transparent;
            this.Clear.IdleBorderRadius = 1;
            this.Clear.IdleBorderThickness = 1;
            this.Clear.IdleFillColor = System.Drawing.Color.Transparent;
            this.Clear.IdleIconLeftImage = null;
            this.Clear.IdleIconRightImage = null;
            this.Clear.IndicateFocus = false;
            this.Clear.Location = new System.Drawing.Point(135, 249);
            this.Clear.Name = "Clear";
            this.Clear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Clear.OnDisabledState.BorderRadius = 1;
            this.Clear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear.OnDisabledState.BorderThickness = 1;
            this.Clear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Clear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Clear.OnDisabledState.IconLeftImage = null;
            this.Clear.OnDisabledState.IconRightImage = null;
            this.Clear.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Clear.onHoverState.BorderRadius = 1;
            this.Clear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear.onHoverState.BorderThickness = 1;
            this.Clear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Clear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Clear.onHoverState.IconLeftImage = null;
            this.Clear.onHoverState.IconRightImage = null;
            this.Clear.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Clear.OnIdleState.BorderRadius = 1;
            this.Clear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear.OnIdleState.BorderThickness = 1;
            this.Clear.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Clear.OnIdleState.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Clear.OnIdleState.IconLeftImage = null;
            this.Clear.OnIdleState.IconRightImage = null;
            this.Clear.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Clear.OnPressedState.BorderRadius = 1;
            this.Clear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Clear.OnPressedState.BorderThickness = 1;
            this.Clear.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Clear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Clear.OnPressedState.IconLeftImage = null;
            this.Clear.OnPressedState.IconRightImage = null;
            this.Clear.Size = new System.Drawing.Size(147, 26);
            this.Clear.TabIndex = 2;
            this.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Clear.TextMarginLeft = 0;
            this.Clear.TextPadding = new System.Windows.Forms.Padding(0);
            this.Clear.UseDefaultRadiusAndThickness = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Signup
            // 
            this.Signup.AllowAnimations = true;
            this.Signup.AllowMouseEffects = true;
            this.Signup.AllowToggling = false;
            this.Signup.AnimationSpeed = 200;
            this.Signup.AutoGenerateColors = false;
            this.Signup.AutoRoundBorders = false;
            this.Signup.AutoSizeLeftIcon = true;
            this.Signup.AutoSizeRightIcon = true;
            this.Signup.BackColor = System.Drawing.Color.Transparent;
            this.Signup.BackColor1 = System.Drawing.Color.DarkMagenta;
            this.Signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Signup.BackgroundImage")));
            this.Signup.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Signup.ButtonText = "Sign Up";
            this.Signup.ButtonTextMarginLeft = 0;
            this.Signup.ColorContrastOnClick = 45;
            this.Signup.ColorContrastOnHover = 45;
            this.Signup.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Signup.CustomizableEdges = borderEdges3;
            this.Signup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Signup.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Signup.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Signup.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Signup.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Signup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.ForeColor = System.Drawing.Color.White;
            this.Signup.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Signup.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Signup.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Signup.IconMarginLeft = 11;
            this.Signup.IconPadding = 10;
            this.Signup.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Signup.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Signup.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Signup.IconSize = 25;
            this.Signup.IdleBorderColor = System.Drawing.Color.DarkMagenta;
            this.Signup.IdleBorderRadius = 7;
            this.Signup.IdleBorderThickness = 1;
            this.Signup.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.Signup.IdleIconLeftImage = null;
            this.Signup.IdleIconRightImage = null;
            this.Signup.IndicateFocus = false;
            this.Signup.Location = new System.Drawing.Point(90, 249);
            this.Signup.Name = "Signup";
            this.Signup.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Signup.OnDisabledState.BorderRadius = 7;
            this.Signup.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Signup.OnDisabledState.BorderThickness = 1;
            this.Signup.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Signup.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Signup.OnDisabledState.IconLeftImage = null;
            this.Signup.OnDisabledState.IconRightImage = null;
            this.Signup.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Signup.onHoverState.BorderRadius = 7;
            this.Signup.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Signup.onHoverState.BorderThickness = 1;
            this.Signup.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Signup.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Signup.onHoverState.IconLeftImage = null;
            this.Signup.onHoverState.IconRightImage = null;
            this.Signup.OnIdleState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Signup.OnIdleState.BorderRadius = 7;
            this.Signup.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Signup.OnIdleState.BorderThickness = 1;
            this.Signup.OnIdleState.FillColor = System.Drawing.Color.DarkMagenta;
            this.Signup.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Signup.OnIdleState.IconLeftImage = null;
            this.Signup.OnIdleState.IconRightImage = null;
            this.Signup.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Signup.OnPressedState.BorderRadius = 7;
            this.Signup.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Signup.OnPressedState.BorderThickness = 1;
            this.Signup.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Signup.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Signup.OnPressedState.IconLeftImage = null;
            this.Signup.OnPressedState.IconRightImage = null;
            this.Signup.Size = new System.Drawing.Size(234, 39);
            this.Signup.TabIndex = 3;
            this.Signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Signup.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Signup.TextMarginLeft = 0;
            this.Signup.TextPadding = new System.Windows.Forms.Padding(0);
            this.Signup.UseDefaultRadiusAndThickness = true;
            this.Signup.Visible = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.AllowAnimations = true;
            this.LogInButton.AllowMouseEffects = true;
            this.LogInButton.AllowToggling = false;
            this.LogInButton.AnimationSpeed = 200;
            this.LogInButton.AutoGenerateColors = false;
            this.LogInButton.AutoRoundBorders = false;
            this.LogInButton.AutoSizeLeftIcon = true;
            this.LogInButton.AutoSizeRightIcon = true;
            this.LogInButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInButton.BackColor1 = System.Drawing.Color.DarkMagenta;
            this.LogInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogInButton.BackgroundImage")));
            this.LogInButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogInButton.ButtonText = "Log In";
            this.LogInButton.ButtonTextMarginLeft = 0;
            this.LogInButton.ColorContrastOnClick = 45;
            this.LogInButton.ColorContrastOnHover = 45;
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.LogInButton.CustomizableEdges = borderEdges4;
            this.LogInButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogInButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogInButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LogInButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LogInButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LogInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogInButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LogInButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LogInButton.IconMarginLeft = 11;
            this.LogInButton.IconPadding = 10;
            this.LogInButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogInButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LogInButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LogInButton.IconSize = 25;
            this.LogInButton.IdleBorderColor = System.Drawing.Color.DarkMagenta;
            this.LogInButton.IdleBorderRadius = 7;
            this.LogInButton.IdleBorderThickness = 1;
            this.LogInButton.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.LogInButton.IdleIconLeftImage = null;
            this.LogInButton.IdleIconRightImage = null;
            this.LogInButton.IndicateFocus = false;
            this.LogInButton.Location = new System.Drawing.Point(90, 204);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogInButton.OnDisabledState.BorderRadius = 7;
            this.LogInButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogInButton.OnDisabledState.BorderThickness = 1;
            this.LogInButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LogInButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LogInButton.OnDisabledState.IconLeftImage = null;
            this.LogInButton.OnDisabledState.IconRightImage = null;
            this.LogInButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LogInButton.onHoverState.BorderRadius = 7;
            this.LogInButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogInButton.onHoverState.BorderThickness = 1;
            this.LogInButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LogInButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LogInButton.onHoverState.IconLeftImage = null;
            this.LogInButton.onHoverState.IconRightImage = null;
            this.LogInButton.OnIdleState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.LogInButton.OnIdleState.BorderRadius = 7;
            this.LogInButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogInButton.OnIdleState.BorderThickness = 1;
            this.LogInButton.OnIdleState.FillColor = System.Drawing.Color.DarkMagenta;
            this.LogInButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LogInButton.OnIdleState.IconLeftImage = null;
            this.LogInButton.OnIdleState.IconRightImage = null;
            this.LogInButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LogInButton.OnPressedState.BorderRadius = 7;
            this.LogInButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogInButton.OnPressedState.BorderThickness = 1;
            this.LogInButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LogInButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LogInButton.OnPressedState.IconLeftImage = null;
            this.LogInButton.OnPressedState.IconRightImage = null;
            this.LogInButton.Size = new System.Drawing.Size(234, 39);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogInButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogInButton.TextMarginLeft = 0;
            this.LogInButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.LogInButton.UseDefaultRadiusAndThickness = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // UserpassTxtBx
            // 
            this.UserpassTxtBx.AcceptsReturn = false;
            this.UserpassTxtBx.AcceptsTab = false;
            this.UserpassTxtBx.AnimationSpeed = 200;
            this.UserpassTxtBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserpassTxtBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserpassTxtBx.BackColor = System.Drawing.Color.White;
            this.UserpassTxtBx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserpassTxtBx.BackgroundImage")));
            this.UserpassTxtBx.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.UserpassTxtBx.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserpassTxtBx.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UserpassTxtBx.BorderColorIdle = System.Drawing.Color.Silver;
            this.UserpassTxtBx.BorderRadius = 10;
            this.UserpassTxtBx.BorderThickness = 1;
            this.UserpassTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserpassTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserpassTxtBx.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserpassTxtBx.DefaultText = "";
            this.UserpassTxtBx.FillColor = System.Drawing.Color.White;
            this.UserpassTxtBx.ForeColor = System.Drawing.Color.DarkMagenta;
            this.UserpassTxtBx.HideSelection = true;
            this.UserpassTxtBx.IconLeft = null;
            this.UserpassTxtBx.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserpassTxtBx.IconPadding = 10;
            this.UserpassTxtBx.IconRight = null;
            this.UserpassTxtBx.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserpassTxtBx.Lines = new string[0];
            this.UserpassTxtBx.Location = new System.Drawing.Point(90, 167);
            this.UserpassTxtBx.MaxLength = 32767;
            this.UserpassTxtBx.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserpassTxtBx.Modified = false;
            this.UserpassTxtBx.Multiline = false;
            this.UserpassTxtBx.Name = "UserpassTxtBx";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserpassTxtBx.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserpassTxtBx.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserpassTxtBx.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.DarkMagenta;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserpassTxtBx.OnIdleState = stateProperties4;
            this.UserpassTxtBx.Padding = new System.Windows.Forms.Padding(3);
            this.UserpassTxtBx.PasswordChar = '●';
            this.UserpassTxtBx.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserpassTxtBx.PlaceholderText = "Enter Pasword";
            this.UserpassTxtBx.ReadOnly = false;
            this.UserpassTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserpassTxtBx.SelectedText = "";
            this.UserpassTxtBx.SelectionLength = 0;
            this.UserpassTxtBx.SelectionStart = 0;
            this.UserpassTxtBx.ShortcutsEnabled = true;
            this.UserpassTxtBx.Size = new System.Drawing.Size(234, 31);
            this.UserpassTxtBx.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserpassTxtBx.TabIndex = 2;
            this.UserpassTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserpassTxtBx.TextMarginBottom = 0;
            this.UserpassTxtBx.TextMarginLeft = 3;
            this.UserpassTxtBx.TextMarginTop = 0;
            this.UserpassTxtBx.TextPlaceholder = "Enter Pasword";
            this.UserpassTxtBx.UseSystemPasswordChar = true;
            this.UserpassTxtBx.WordWrap = true;
            this.UserpassTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserpassTxtBx_KeyDown);
            // 
            // UserNameTxtBx
            // 
            this.UserNameTxtBx.AcceptsReturn = false;
            this.UserNameTxtBx.AcceptsTab = false;
            this.UserNameTxtBx.AnimationSpeed = 200;
            this.UserNameTxtBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserNameTxtBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserNameTxtBx.BackColor = System.Drawing.Color.White;
            this.UserNameTxtBx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserNameTxtBx.BackgroundImage")));
            this.UserNameTxtBx.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.UserNameTxtBx.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserNameTxtBx.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UserNameTxtBx.BorderColorIdle = System.Drawing.Color.Silver;
            this.UserNameTxtBx.BorderRadius = 10;
            this.UserNameTxtBx.BorderThickness = 1;
            this.UserNameTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserNameTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxtBx.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxtBx.DefaultText = "";
            this.UserNameTxtBx.FillColor = System.Drawing.Color.White;
            this.UserNameTxtBx.ForeColor = System.Drawing.Color.DarkMagenta;
            this.UserNameTxtBx.HideSelection = true;
            this.UserNameTxtBx.IconLeft = null;
            this.UserNameTxtBx.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxtBx.IconPadding = 10;
            this.UserNameTxtBx.IconRight = null;
            this.UserNameTxtBx.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxtBx.Lines = new string[0];
            this.UserNameTxtBx.Location = new System.Drawing.Point(90, 130);
            this.UserNameTxtBx.MaxLength = 32767;
            this.UserNameTxtBx.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserNameTxtBx.Modified = false;
            this.UserNameTxtBx.Multiline = false;
            this.UserNameTxtBx.Name = "UserNameTxtBx";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTxtBx.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserNameTxtBx.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTxtBx.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.DarkMagenta;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTxtBx.OnIdleState = stateProperties8;
            this.UserNameTxtBx.Padding = new System.Windows.Forms.Padding(3);
            this.UserNameTxtBx.PasswordChar = '\0';
            this.UserNameTxtBx.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserNameTxtBx.PlaceholderText = "Enter User Name";
            this.UserNameTxtBx.ReadOnly = false;
            this.UserNameTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTxtBx.SelectedText = "";
            this.UserNameTxtBx.SelectionLength = 0;
            this.UserNameTxtBx.SelectionStart = 0;
            this.UserNameTxtBx.ShortcutsEnabled = true;
            this.UserNameTxtBx.Size = new System.Drawing.Size(234, 31);
            this.UserNameTxtBx.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserNameTxtBx.TabIndex = 1;
            this.UserNameTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserNameTxtBx.TextMarginBottom = 0;
            this.UserNameTxtBx.TextMarginLeft = 3;
            this.UserNameTxtBx.TextMarginTop = 0;
            this.UserNameTxtBx.TextPlaceholder = "Enter User Name";
            this.UserNameTxtBx.UseSystemPasswordChar = false;
            this.UserNameTxtBx.WordWrap = true;
            this.UserNameTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameTxtBx_KeyDown);
            // 
            // LogInFormEllips
            // 
            this.LogInFormEllips.ElipseRadius = 10;
            this.LogInFormEllips.TargetControl = this;
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
            this.Minimize.Location = new System.Drawing.Point(38, 8);
            this.Minimize.Name = "Minimize";
            this.Minimize.Rotation = 0;
            this.Minimize.ShowActiveImage = true;
            this.Minimize.ShowCursorChanges = true;
            this.Minimize.ShowImageBorders = true;
            this.Minimize.ShowSizeMarkers = false;
            this.Minimize.Size = new System.Drawing.Size(20, 20);
            this.Minimize.TabIndex = 5;
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
            this.Exit.Location = new System.Drawing.Point(12, 8);
            this.Exit.Name = "Exit";
            this.Exit.Rotation = 0;
            this.Exit.ShowActiveImage = true;
            this.Exit.ShowCursorChanges = true;
            this.Exit.ShowImageBorders = true;
            this.Exit.ShowSizeMarkers = false;
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 7;
            this.Exit.ToolTipText = "";
            this.Exit.WaitOnLoad = false;
            this.Exit.Zoom = 40;
            this.Exit.ZoomSpeed = 10;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(433, 389);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox UserpassTxtBx;
        private Bunifu.UI.WinForms.BunifuTextBox UserNameTxtBx;
        private System.Windows.Forms.ComboBox SelectRole;
        private System.Windows.Forms.Label Logo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LogInButton;
        private Bunifu.Framework.UI.BunifuElipse LogInFormEllips;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Clear;
        private Bunifu.UI.WinForms.BunifuImageButton Minimize;
        private Bunifu.UI.WinForms.BunifuImageButton Exit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Signup;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Clear2;
    }
}