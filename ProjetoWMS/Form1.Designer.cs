namespace ProjetoWMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLocais = new MaterialSkin.Controls.MaterialButton();
            btnProduto = new MaterialSkin.Controls.MaterialButton();
            btnSaida = new MaterialSkin.Controls.MaterialButton();
            btnEntrada = new MaterialSkin.Controls.MaterialButton();
            btnListagem = new MaterialSkin.Controls.MaterialButton();
            btnConfig = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            SuspendLayout();
            // 
            // btnLocais
            // 
            btnLocais.AutoSize = false;
            btnLocais.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLocais.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLocais.Depth = 0;
            btnLocais.HighEmphasis = true;
            btnLocais.Icon = Properties.Resources.local;
            btnLocais.Location = new Point(18, 29);
            btnLocais.Margin = new Padding(4, 6, 4, 6);
            btnLocais.MouseState = MaterialSkin.MouseState.HOVER;
            btnLocais.Name = "btnLocais";
            btnLocais.NoAccentTextColor = Color.Empty;
            btnLocais.Size = new Size(155, 56);
            btnLocais.TabIndex = 3;
            btnLocais.Text = "Locais";
            btnLocais.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLocais.UseAccentColor = false;
            btnLocais.UseVisualStyleBackColor = true;
            btnLocais.Click += btnLocais_Click;
            // 
            // btnProduto
            // 
            btnProduto.AutoSize = false;
            btnProduto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProduto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProduto.Depth = 0;
            btnProduto.HighEmphasis = true;
            btnProduto.Icon = Properties.Resources.produto;
            btnProduto.Location = new Point(181, 29);
            btnProduto.Margin = new Padding(4, 6, 4, 6);
            btnProduto.MouseState = MaterialSkin.MouseState.HOVER;
            btnProduto.Name = "btnProduto";
            btnProduto.NoAccentTextColor = Color.Empty;
            btnProduto.Size = new Size(155, 56);
            btnProduto.TabIndex = 4;
            btnProduto.Text = "Produtos";
            btnProduto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProduto.UseAccentColor = false;
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // btnSaida
            // 
            btnSaida.AutoSize = false;
            btnSaida.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaida.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaida.Depth = 0;
            btnSaida.HighEmphasis = true;
            btnSaida.Icon = Properties.Resources.saida;
            btnSaida.Location = new Point(181, 30);
            btnSaida.Margin = new Padding(4, 6, 4, 6);
            btnSaida.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaida.Name = "btnSaida";
            btnSaida.NoAccentTextColor = Color.Empty;
            btnSaida.Size = new Size(155, 56);
            btnSaida.TabIndex = 6;
            btnSaida.Text = "Saída";
            btnSaida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaida.UseAccentColor = false;
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.AutoSize = false;
            btnEntrada.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEntrada.Depth = 0;
            btnEntrada.HighEmphasis = true;
            btnEntrada.Icon = Properties.Resources.entrada;
            btnEntrada.Location = new Point(18, 30);
            btnEntrada.Margin = new Padding(4, 6, 4, 6);
            btnEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            btnEntrada.Name = "btnEntrada";
            btnEntrada.NoAccentTextColor = Color.Empty;
            btnEntrada.Size = new Size(155, 56);
            btnEntrada.TabIndex = 5;
            btnEntrada.Text = "Entrada";
            btnEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEntrada.UseAccentColor = false;
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnListagem
            // 
            btnListagem.AutoSize = false;
            btnListagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnListagem.BackColor = SystemColors.Control;
            btnListagem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnListagem.Depth = 0;
            btnListagem.HighEmphasis = true;
            btnListagem.Icon = Properties.Resources.lista;
            btnListagem.Location = new Point(18, 30);
            btnListagem.Margin = new Padding(4, 6, 4, 6);
            btnListagem.MouseState = MaterialSkin.MouseState.HOVER;
            btnListagem.Name = "btnListagem";
            btnListagem.NoAccentTextColor = Color.Empty;
            btnListagem.Size = new Size(155, 56);
            btnListagem.TabIndex = 8;
            btnListagem.Text = "Estoque";
            btnListagem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnListagem.UseAccentColor = false;
            btnListagem.UseVisualStyleBackColor = false;
            btnListagem.Click += btnListagem_Click;
            // 
            // btnConfig
            // 
            btnConfig.AutoSize = false;
            btnConfig.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfig.Depth = 0;
            btnConfig.HighEmphasis = true;
            btnConfig.Icon = Properties.Resources.config;
            btnConfig.Location = new Point(181, 30);
            btnConfig.Margin = new Padding(4, 6, 4, 6);
            btnConfig.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfig.Name = "btnConfig";
            btnConfig.NoAccentTextColor = Color.Empty;
            btnConfig.Size = new Size(155, 56);
            btnConfig.TabIndex = 7;
            btnConfig.Text = "Administrador";
            btnConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfig.UseAccentColor = false;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(btnListagem);
            materialCard1.Controls.Add(btnConfig);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(26, 298);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(352, 106);
            materialCard1.TabIndex = 3;
            materialCard1.Tag = "";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 5);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(71, 19);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Listagem:";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Controls.Add(btnSaida);
            materialCard2.Controls.Add(btnEntrada);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(26, 187);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(352, 107);
            materialCard2.TabIndex = 4;
            materialCard2.Tag = "";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 1);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(102, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "Lançamentos:";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(materialLabel1);
            materialCard3.Controls.Add(btnProduto);
            materialCard3.Controls.Add(btnLocais);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(26, 78);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(352, 106);
            materialCard3.TabIndex = 4;
            materialCard3.Tag = "";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(18, 4);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(77, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Cadastros:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 455);
            Controls.Add(materialCard2);
            Controls.Add(materialCard3);
            Controls.Add(materialCard1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WMS - Jyann Alex Eberle";
            Load += Form1_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnLocais;
        private MaterialSkin.Controls.MaterialButton btnProduto;
        private MaterialSkin.Controls.MaterialButton btnSaida;
        private MaterialSkin.Controls.MaterialButton btnEntrada;
        private MaterialSkin.Controls.MaterialButton btnListagem;
        private MaterialSkin.Controls.MaterialButton btnConfig;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
