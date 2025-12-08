namespace ProjetoWMS
{
    partial class Login
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
            txtLogin = new MaterialSkin.Controls.MaterialTextBox();
            txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            button1 = new MaterialSkin.Controls.MaterialButton();
            linkLabel1 = new MaterialSkin.Controls.MaterialButton();
            cbTema = new MaterialSkin.Controls.MaterialSwitch();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.Hint = "Login";
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(24, 76);
            txtLogin.MaxLength = 50;
            txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            txtLogin.Multiline = false;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(339, 50);
            txtLogin.TabIndex = 12;
            txtLogin.Text = "";
            txtLogin.TrailingIcon = null;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(24, 132);
            txtSenha.MaxLength = 50;
            txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Password = true;
            txtSenha.Size = new Size(339, 50);
            txtSenha.TabIndex = 13;
            txtSenha.Text = "";
            txtSenha.TrailingIcon = null;
            // 
            // button1
            // 
            button1.AutoSize = false;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Location = new Point(250, 191);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(113, 36);
            button1.TabIndex = 14;
            button1.Text = "Login";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            linkLabel1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            linkLabel1.Depth = 0;
            linkLabel1.HighEmphasis = true;
            linkLabel1.Icon = null;
            linkLabel1.Location = new Point(134, 191);
            linkLabel1.Margin = new Padding(4, 6, 4, 6);
            linkLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            linkLabel1.Name = "linkLabel1";
            linkLabel1.NoAccentTextColor = Color.Empty;
            linkLabel1.Size = new Size(108, 36);
            linkLabel1.TabIndex = 15;
            linkLabel1.Text = "Regristrar";
            linkLabel1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            linkLabel1.UseAccentColor = false;
            linkLabel1.UseVisualStyleBackColor = true;
            linkLabel1.Click += linkLabel1_Click;
            // 
            // cbTema
            // 
            cbTema.AutoSize = true;
            cbTema.Depth = 0;
            cbTema.Location = new Point(24, 192);
            cbTema.Margin = new Padding(0);
            cbTema.MouseLocation = new Point(-1, -1);
            cbTema.MouseState = MaterialSkin.MouseState.HOVER;
            cbTema.Name = "cbTema";
            cbTema.Ripple = true;
            cbTema.Size = new Size(99, 37);
            cbTema.TabIndex = 16;
            cbTema.Text = "Tema";
            cbTema.UseVisualStyleBackColor = true;
            cbTema.CheckedChanged += cbTema_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 242);
            Controls.Add(cbTema);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtLogin;
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton linkLabel1;
        private MaterialSkin.Controls.MaterialSwitch cbTema;
    }
}