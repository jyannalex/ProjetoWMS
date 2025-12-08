namespace ProjetoWMS
{
    partial class Registrar
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
            txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            txtLogin = new MaterialSkin.Controls.MaterialTextBox();
            txtSenha2 = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            button1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(26, 133);
            txtSenha.MaxLength = 50;
            txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Password = true;
            txtSenha.Size = new Size(339, 50);
            txtSenha.TabIndex = 15;
            txtSenha.Text = "";
            txtSenha.TrailingIcon = null;
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.Hint = "Login";
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(26, 77);
            txtLogin.MaxLength = 50;
            txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            txtLogin.Multiline = false;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(339, 50);
            txtLogin.TabIndex = 14;
            txtLogin.Text = "";
            txtLogin.TrailingIcon = null;
            txtLogin.Leave += txtLogin_Leave_1;
            // 
            // txtSenha2
            // 
            txtSenha2.AnimateReadOnly = false;
            txtSenha2.BorderStyle = BorderStyle.None;
            txtSenha2.Depth = 0;
            txtSenha2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha2.Hint = "Senha";
            txtSenha2.LeadingIcon = null;
            txtSenha2.Location = new Point(26, 189);
            txtSenha2.MaxLength = 50;
            txtSenha2.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha2.Multiline = false;
            txtSenha2.Name = "txtSenha2";
            txtSenha2.Password = true;
            txtSenha2.Size = new Size(339, 50);
            txtSenha2.TabIndex = 16;
            txtSenha2.Text = "";
            txtSenha2.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(26, 245);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(339, 50);
            txtEmail.TabIndex = 17;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Location = new Point(260, 304);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(105, 36);
            button1.TabIndex = 18;
            button1.Text = "Confirmar";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 352);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha2);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private MaterialSkin.Controls.MaterialTextBox txtLogin;
        private MaterialSkin.Controls.MaterialTextBox txtSenha2;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialButton button1;
    }
}