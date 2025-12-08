namespace ProjetoWMS
{
    partial class Lancamentos
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
            txtProduto = new MaterialSkin.Controls.MaterialTextBox();
            txtDescricaoLocal = new MaterialSkin.Controls.MaterialTextBox();
            txtDescricaoProd = new MaterialSkin.Controls.MaterialTextBox();
            txtQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            txtObs = new MaterialSkin.Controls.MaterialTextBox();
            cbEntrada = new MaterialSkin.Controls.MaterialCheckbox();
            cbSaida = new MaterialSkin.Controls.MaterialCheckbox();
            button1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtLocal
            // 
            txtLocal.AnimateReadOnly = false;
            txtLocal.BorderStyle = BorderStyle.None;
            txtLocal.Depth = 0;
            txtLocal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLocal.Hint = "Local";
            txtLocal.LeadingIcon = null;
            txtLocal.Location = new Point(19, 197);
            txtLocal.MaxLength = 50;
            txtLocal.MouseState = MaterialSkin.MouseState.OUT;
            txtLocal.Multiline = false;
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(124, 50);
            txtLocal.TabIndex = 31;
            txtLocal.Text = "";
            txtLocal.TrailingIcon = null;
            txtLocal.Leave += txtLocal_Leave;
            // 
            // txtProduto
            // 
            txtProduto.AnimateReadOnly = false;
            txtProduto.BorderStyle = BorderStyle.None;
            txtProduto.Depth = 0;
            txtProduto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProduto.Hint = "Produto";
            txtProduto.LeadingIcon = null;
            txtProduto.Location = new Point(19, 141);
            txtProduto.MaxLength = 50;
            txtProduto.MouseState = MaterialSkin.MouseState.OUT;
            txtProduto.Multiline = false;
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(124, 50);
            txtProduto.TabIndex = 30;
            txtProduto.Text = "";
            txtProduto.TrailingIcon = null;
            txtProduto.Leave += txtProduto_Leave_1;
            // 
            // txtDescricaoLocal
            // 
            txtDescricaoLocal.AnimateReadOnly = false;
            txtDescricaoLocal.BorderStyle = BorderStyle.None;
            txtDescricaoLocal.Depth = 0;
            txtDescricaoLocal.Enabled = false;
            txtDescricaoLocal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricaoLocal.Hint = "Descrição";
            txtDescricaoLocal.LeadingIcon = null;
            txtDescricaoLocal.Location = new Point(149, 197);
            txtDescricaoLocal.MaxLength = 50;
            txtDescricaoLocal.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricaoLocal.Multiline = false;
            txtDescricaoLocal.Name = "txtDescricaoLocal";
            txtDescricaoLocal.Size = new Size(339, 50);
            txtDescricaoLocal.TabIndex = 33;
            txtDescricaoLocal.Text = "";
            txtDescricaoLocal.TrailingIcon = null;
            // 
            // txtDescricaoProd
            // 
            txtDescricaoProd.AnimateReadOnly = false;
            txtDescricaoProd.BorderStyle = BorderStyle.None;
            txtDescricaoProd.Depth = 0;
            txtDescricaoProd.Enabled = false;
            txtDescricaoProd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricaoProd.Hint = "Descrição";
            txtDescricaoProd.LeadingIcon = null;
            txtDescricaoProd.Location = new Point(149, 141);
            txtDescricaoProd.MaxLength = 50;
            txtDescricaoProd.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricaoProd.Multiline = false;
            txtDescricaoProd.Name = "txtDescricaoProd";
            txtDescricaoProd.Size = new Size(339, 50);
            txtDescricaoProd.TabIndex = 32;
            txtDescricaoProd.Text = "";
            txtDescricaoProd.TrailingIcon = null;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.Hint = "Quantidade";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(19, 253);
            txtQuantidade.MaxLength = 50;
            txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantidade.Multiline = false;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(469, 50);
            txtQuantidade.TabIndex = 34;
            txtQuantidade.Text = "";
            txtQuantidade.TrailingIcon = null;
            // 
            // txtObs
            // 
            txtObs.AnimateReadOnly = false;
            txtObs.BorderStyle = BorderStyle.None;
            txtObs.Depth = 0;
            txtObs.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObs.Hint = "Observação";
            txtObs.LeadingIcon = null;
            txtObs.Location = new Point(19, 309);
            txtObs.MaxLength = 50;
            txtObs.MouseState = MaterialSkin.MouseState.OUT;
            txtObs.Multiline = false;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(469, 50);
            txtObs.TabIndex = 35;
            txtObs.Text = "";
            txtObs.TrailingIcon = null;
            // 
            // cbEntrada
            // 
            cbEntrada.AutoSize = true;
            cbEntrada.Depth = 0;
            cbEntrada.Enabled = false;
            cbEntrada.Location = new Point(88, 84);
            cbEntrada.Margin = new Padding(0);
            cbEntrada.MouseLocation = new Point(-1, -1);
            cbEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            cbEntrada.Name = "cbEntrada";
            cbEntrada.ReadOnly = false;
            cbEntrada.Ripple = true;
            cbEntrada.Size = new Size(90, 37);
            cbEntrada.TabIndex = 36;
            cbEntrada.Text = "Entrada";
            cbEntrada.UseVisualStyleBackColor = true;
            // 
            // cbSaida
            // 
            cbSaida.AutoSize = true;
            cbSaida.Depth = 0;
            cbSaida.Enabled = false;
            cbSaida.Location = new Point(335, 84);
            cbSaida.Margin = new Padding(0);
            cbSaida.MouseLocation = new Point(-1, -1);
            cbSaida.MouseState = MaterialSkin.MouseState.HOVER;
            cbSaida.Name = "cbSaida";
            cbSaida.ReadOnly = false;
            cbSaida.Ripple = true;
            cbSaida.Size = new Size(76, 37);
            cbSaida.TabIndex = 37;
            cbSaida.Text = "Saída";
            cbSaida.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Location = new Point(383, 368);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(105, 36);
            button1.TabIndex = 38;
            button1.Text = "Confirmar";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Lancamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 434);
            Controls.Add(button1);
            Controls.Add(cbSaida);
            Controls.Add(cbEntrada);
            Controls.Add(txtObs);
            Controls.Add(txtQuantidade);
            Controls.Add(txtDescricaoLocal);
            Controls.Add(txtDescricaoProd);
            Controls.Add(txtLocal);
            Controls.Add(txtProduto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Lancamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lancamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private MaterialSkin.Controls.MaterialTextBox txtProduto;
        private MaterialSkin.Controls.MaterialTextBox txtLocal;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidade;
        private MaterialSkin.Controls.MaterialTextBox txtDescricaoProd;
        private MaterialSkin.Controls.MaterialTextBox txtDescricaoLocal;
        private MaterialSkin.Controls.MaterialTextBox txtObs;
        private MaterialSkin.Controls.MaterialCheckbox cbEntrada;
        private MaterialSkin.Controls.MaterialCheckbox cbSaida;
        private MaterialSkin.Controls.MaterialButton button1;
    }
}