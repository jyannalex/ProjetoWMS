namespace ProjetoWMS
{
    partial class Configuracao
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
            txtImportaProd = new MaterialSkin.Controls.MaterialTextBox();
            btnImportaProd = new MaterialSkin.Controls.MaterialButton();
            btnImportaLocal = new MaterialSkin.Controls.MaterialButton();
            txtImportaLocal = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // txtImportaProd
            // 
            txtImportaProd.AnimateReadOnly = false;
            txtImportaProd.BorderStyle = BorderStyle.None;
            txtImportaProd.Depth = 0;
            txtImportaProd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImportaProd.Hint = "Importar Produtos";
            txtImportaProd.LeadingIcon = null;
            txtImportaProd.Location = new Point(20, 86);
            txtImportaProd.MaxLength = 50;
            txtImportaProd.MouseState = MaterialSkin.MouseState.OUT;
            txtImportaProd.Multiline = false;
            txtImportaProd.Name = "txtImportaProd";
            txtImportaProd.Size = new Size(452, 50);
            txtImportaProd.TabIndex = 1;
            txtImportaProd.Text = "";
            txtImportaProd.TrailingIcon = null;
            txtImportaProd.TrailingIconClick += TxtImportarProdutos_TrailingIconClick;
            // 
            // btnImportaProd
            // 
            btnImportaProd.AutoSize = false;
            btnImportaProd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImportaProd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImportaProd.Depth = 0;
            btnImportaProd.HighEmphasis = true;
            btnImportaProd.Icon = null;
            btnImportaProd.Location = new Point(494, 86);
            btnImportaProd.Margin = new Padding(4, 6, 4, 6);
            btnImportaProd.MouseState = MaterialSkin.MouseState.HOVER;
            btnImportaProd.Name = "btnImportaProd";
            btnImportaProd.NoAccentTextColor = Color.Empty;
            btnImportaProd.Size = new Size(118, 50);
            btnImportaProd.TabIndex = 0;
            btnImportaProd.Text = "Importar";
            btnImportaProd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImportaProd.UseAccentColor = false;
            btnImportaProd.UseVisualStyleBackColor = true;
            // 
            // btnImportaLocal
            // 
            btnImportaLocal.AutoSize = false;
            btnImportaLocal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImportaLocal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImportaLocal.Depth = 0;
            btnImportaLocal.HighEmphasis = true;
            btnImportaLocal.Icon = null;
            btnImportaLocal.Location = new Point(494, 154);
            btnImportaLocal.Margin = new Padding(4, 6, 4, 6);
            btnImportaLocal.MouseState = MaterialSkin.MouseState.HOVER;
            btnImportaLocal.Name = "btnImportaLocal";
            btnImportaLocal.NoAccentTextColor = Color.Empty;
            btnImportaLocal.Size = new Size(118, 50);
            btnImportaLocal.TabIndex = 2;
            btnImportaLocal.Text = "Importar";
            btnImportaLocal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImportaLocal.UseAccentColor = false;
            btnImportaLocal.UseVisualStyleBackColor = true;
            // 
            // txtImportaLocal
            // 
            txtImportaLocal.AnimateReadOnly = false;
            txtImportaLocal.BorderStyle = BorderStyle.None;
            txtImportaLocal.Depth = 0;
            txtImportaLocal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImportaLocal.Hint = "Importar Locais";
            txtImportaLocal.LeadingIcon = null;
            txtImportaLocal.Location = new Point(20, 154);
            txtImportaLocal.MaxLength = 50;
            txtImportaLocal.MouseState = MaterialSkin.MouseState.OUT;
            txtImportaLocal.Multiline = false;
            txtImportaLocal.Name = "txtImportaLocal";
            txtImportaLocal.Size = new Size(452, 50);
            txtImportaLocal.TabIndex = 3;
            txtImportaLocal.Text = "";
            txtImportaLocal.TrailingIcon = null;
            txtImportaLocal.TrailingIconClick += txtImportaLocal_TrailingIconClick;
            // 
            // Configuracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 254);
            Controls.Add(btnImportaLocal);
            Controls.Add(txtImportaLocal);
            Controls.Add(btnImportaProd);
            Controls.Add(txtImportaProd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Configuracao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações";
            Load += configuracao;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtImportaProd;
        private MaterialSkin.Controls.MaterialButton btnImportaProd;
        private MaterialSkin.Controls.MaterialButton btnImportaLocal;
        private MaterialSkin.Controls.MaterialTextBox txtImportaLocal;
    }
}