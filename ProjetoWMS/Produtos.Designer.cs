namespace ProjetoWMS
{
    partial class Produtos
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
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            button1 = new MaterialSkin.Controls.MaterialButton();
            txtDescricaoProduto = new MaterialSkin.Controls.MaterialTextBox();
            txtProduto = new MaterialSkin.Controls.MaterialTextBox();
            txtUnVenda = new MaterialSkin.Controls.MaterialTextBox();
            txtCodBarra = new MaterialSkin.Controls.MaterialTextBox();
            txtCusto = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Enabled = false;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(167, 359);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(80, 36);
            materialButton1.TabIndex = 6;
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
            button1.Location = new Point(255, 359);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(105, 36);
            button1.TabIndex = 5;
            button1.Text = "Confirmar";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.AnimateReadOnly = false;
            txtDescricaoProduto.BorderStyle = BorderStyle.None;
            txtDescricaoProduto.Depth = 0;
            txtDescricaoProduto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricaoProduto.Hint = "Descrição";
            txtDescricaoProduto.LeadingIcon = null;
            txtDescricaoProduto.Location = new Point(21, 132);
            txtDescricaoProduto.MaxLength = 50;
            txtDescricaoProduto.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricaoProduto.Multiline = false;
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(339, 50);
            txtDescricaoProduto.TabIndex = 1;
            txtDescricaoProduto.Text = "";
            txtDescricaoProduto.TrailingIcon = null;
            // 
            // txtProduto
            // 
            txtProduto.AnimateReadOnly = false;
            txtProduto.BorderStyle = BorderStyle.None;
            txtProduto.Depth = 0;
            txtProduto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProduto.Hint = "Código";
            txtProduto.LeadingIcon = null;
            txtProduto.Location = new Point(21, 76);
            txtProduto.MaxLength = 50;
            txtProduto.MouseState = MaterialSkin.MouseState.OUT;
            txtProduto.Multiline = false;
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(339, 50);
            txtProduto.TabIndex = 0;
            txtProduto.Text = "";
            txtProduto.TrailingIcon = null;
            txtProduto.Enter += txtProduto_Enter_1;
            txtProduto.Leave += txtProduto_Leave_1;
            // 
            // txtUnVenda
            // 
            txtUnVenda.AnimateReadOnly = false;
            txtUnVenda.BorderStyle = BorderStyle.None;
            txtUnVenda.Depth = 0;
            txtUnVenda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnVenda.Hint = "Un. Venda";
            txtUnVenda.LeadingIcon = null;
            txtUnVenda.Location = new Point(21, 188);
            txtUnVenda.MaxLength = 50;
            txtUnVenda.MouseState = MaterialSkin.MouseState.OUT;
            txtUnVenda.Multiline = false;
            txtUnVenda.Name = "txtUnVenda";
            txtUnVenda.Size = new Size(339, 50);
            txtUnVenda.TabIndex = 2;
            txtUnVenda.Text = "";
            txtUnVenda.TrailingIcon = null;
            // 
            // txtCodBarra
            // 
            txtCodBarra.AnimateReadOnly = false;
            txtCodBarra.BorderStyle = BorderStyle.None;
            txtCodBarra.Depth = 0;
            txtCodBarra.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodBarra.Hint = "Código de Barras";
            txtCodBarra.LeadingIcon = null;
            txtCodBarra.Location = new Point(21, 244);
            txtCodBarra.MaxLength = 50;
            txtCodBarra.MouseState = MaterialSkin.MouseState.OUT;
            txtCodBarra.Multiline = false;
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.Size = new Size(339, 50);
            txtCodBarra.TabIndex = 3;
            txtCodBarra.Text = "";
            txtCodBarra.TrailingIcon = null;
            // 
            // txtCusto
            // 
            txtCusto.AnimateReadOnly = false;
            txtCusto.BorderStyle = BorderStyle.None;
            txtCusto.Depth = 0;
            txtCusto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCusto.Hint = "Valor de Custo";
            txtCusto.LeadingIcon = null;
            txtCusto.Location = new Point(21, 300);
            txtCusto.MaxLength = 50;
            txtCusto.MouseState = MaterialSkin.MouseState.OUT;
            txtCusto.Multiline = false;
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(339, 50);
            txtCusto.TabIndex = 4;
            txtCusto.Text = "";
            txtCusto.TrailingIcon = null;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 429);
            Controls.Add(txtCusto);
            Controls.Add(txtCodBarra);
            Controls.Add(txtUnVenda);
            Controls.Add(txtProduto);
            Controls.Add(txtDescricaoProduto);
            Controls.Add(button1);
            Controls.Add(materialButton1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialTextBox txtProduto;
        private MaterialSkin.Controls.MaterialTextBox txtDescricaoProduto;
        private MaterialSkin.Controls.MaterialTextBox txtUnVenda;
        private MaterialSkin.Controls.MaterialTextBox txtCodBarra;
        private MaterialSkin.Controls.MaterialTextBox txtCusto;

    }
}