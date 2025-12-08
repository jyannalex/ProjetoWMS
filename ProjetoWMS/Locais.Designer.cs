namespace ProjetoWMS
{
    partial class Locais
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
            txtLocal = new MaterialSkin.Controls.MaterialTextBox();
            txtDescricaoLocal = new MaterialSkin.Controls.MaterialTextBox();
            txtCapacidade = new MaterialSkin.Controls.MaterialTextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            button1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtLocal
            // 
            txtLocal.AnimateReadOnly = false;
            txtLocal.BorderStyle = BorderStyle.None;
            txtLocal.Depth = 0;
            txtLocal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLocal.Hint = "Código";
            txtLocal.LeadingIcon = null;
            txtLocal.Location = new Point(22, 76);
            txtLocal.MaxLength = 50;
            txtLocal.MouseState = MaterialSkin.MouseState.OUT;
            txtLocal.Multiline = false;
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(339, 50);
            txtLocal.TabIndex = 23;
            txtLocal.Text = "";
            txtLocal.TrailingIcon = null;
            txtLocal.Enter += txtLocal_Enter;
            txtLocal.Leave += txtLocal_Leave_1;
            // 
            // txtDescricaoLocal
            // 
            txtDescricaoLocal.AnimateReadOnly = false;
            txtDescricaoLocal.BorderStyle = BorderStyle.None;
            txtDescricaoLocal.Depth = 0;
            txtDescricaoLocal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricaoLocal.Hint = "Descrição";
            txtDescricaoLocal.LeadingIcon = null;
            txtDescricaoLocal.Location = new Point(22, 132);
            txtDescricaoLocal.MaxLength = 50;
            txtDescricaoLocal.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricaoLocal.Multiline = false;
            txtDescricaoLocal.Name = "txtDescricaoLocal";
            txtDescricaoLocal.Size = new Size(339, 50);
            txtDescricaoLocal.TabIndex = 24;
            txtDescricaoLocal.Text = "";
            txtDescricaoLocal.TrailingIcon = null;
            // 
            // txtCapacidade
            // 
            txtCapacidade.AnimateReadOnly = false;
            txtCapacidade.BorderStyle = BorderStyle.None;
            txtCapacidade.Depth = 0;
            txtCapacidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCapacidade.Hint = "Capacidade";
            txtCapacidade.LeadingIcon = null;
            txtCapacidade.Location = new Point(22, 188);
            txtCapacidade.MaxLength = 50;
            txtCapacidade.MouseState = MaterialSkin.MouseState.OUT;
            txtCapacidade.Multiline = false;
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.Size = new Size(339, 50);
            txtCapacidade.TabIndex = 25;
            txtCapacidade.Text = "";
            txtCapacidade.TrailingIcon = null;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Enabled = false;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(168, 247);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(80, 36);
            materialButton1.TabIndex = 26;
            materialButton1.Text = "Excluir";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Location = new Point(256, 247);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(105, 36);
            button1.TabIndex = 27;
            button1.Text = "Confirmar";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Locais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 317);
            Controls.Add(button1);
            Controls.Add(materialButton1);
            Controls.Add(txtCapacidade);
            Controls.Add(txtDescricaoLocal);
            Controls.Add(txtLocal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Locais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Locais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label2;
        private Label label1;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtDescricaoLocal;
        private MaterialSkin.Controls.MaterialTextBox txtLocal;
        private MaterialSkin.Controls.MaterialTextBox txtCapacidade;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton button1;
    }
}