namespace ProjetoWMS
{
    partial class Listagem
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
            groupBox1 = new GroupBox();
            btnListar = new MaterialSkin.Controls.MaterialButton();
            txtProduto = new MaterialSkin.Controls.MaterialTextBox();
            txtLocal = new MaterialSkin.Controls.MaterialTextBox();
            lvListagem = new MaterialSkin.Controls.MaterialListView();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListar);
            groupBox1.Controls.Add(txtProduto);
            groupBox1.Controls.Add(txtLocal);
            groupBox1.Location = new Point(22, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(910, 81);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnListar
            // 
            btnListar.AutoSize = false;
            btnListar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnListar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnListar.Depth = 0;
            btnListar.HighEmphasis = true;
            btnListar.Icon = null;
            btnListar.Location = new Point(789, 22);
            btnListar.Margin = new Padding(4, 6, 4, 6);
            btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            btnListar.Name = "btnListar";
            btnListar.NoAccentTextColor = Color.Empty;
            btnListar.Size = new Size(114, 50);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnListar.UseAccentColor = false;
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtProduto
            // 
            txtProduto.AnimateReadOnly = false;
            txtProduto.BorderStyle = BorderStyle.None;
            txtProduto.Depth = 0;
            txtProduto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProduto.Hint = "Produto";
            txtProduto.LeadingIcon = null;
            txtProduto.Location = new Point(6, 22);
            txtProduto.MaxLength = 50;
            txtProduto.MouseState = MaterialSkin.MouseState.OUT;
            txtProduto.Multiline = false;
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(373, 50);
            txtProduto.TabIndex = 5;
            txtProduto.Text = "";
            txtProduto.TrailingIcon = null;
            txtProduto.Leave += materialTextBox1_Leave;
            // 
            // txtLocal
            // 
            txtLocal.AnimateReadOnly = false;
            txtLocal.BorderStyle = BorderStyle.None;
            txtLocal.Depth = 0;
            txtLocal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLocal.Hint = "Local";
            txtLocal.LeadingIcon = null;
            txtLocal.Location = new Point(393, 22);
            txtLocal.MaxLength = 50;
            txtLocal.MouseState = MaterialSkin.MouseState.OUT;
            txtLocal.Multiline = false;
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(377, 50);
            txtLocal.TabIndex = 10;
            txtLocal.Text = "";
            txtLocal.TrailingIcon = null;
            txtLocal.Leave += txtLocal_Leave;
            // 
            // lvListagem
            // 
            lvListagem.AutoSizeTable = false;
            lvListagem.BackColor = Color.FromArgb(255, 255, 255);
            lvListagem.BorderStyle = BorderStyle.None;
            lvListagem.Depth = 0;
            lvListagem.FullRowSelect = true;
            lvListagem.Location = new Point(22, 154);
            lvListagem.MinimumSize = new Size(200, 100);
            lvListagem.MouseLocation = new Point(-1, -1);
            lvListagem.MouseState = MaterialSkin.MouseState.OUT;
            lvListagem.Name = "lvListagem";
            lvListagem.OwnerDraw = true;
            lvListagem.Size = new Size(903, 357);
            lvListagem.TabIndex = 9;
            lvListagem.UseCompatibleStateImageBehavior = false;
            lvListagem.View = View.Details;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(798, 520);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(127, 36);
            materialButton2.TabIndex = 10;
            materialButton2.Text = "Exportar CSV";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(296, 530);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(136, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Total Quantidade : ";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(576, 530);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(91, 19);
            materialLabel2.TabIndex = 12;
            materialLabel2.Text = "Total Custo :";
            // 
            // Listagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 587);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(materialButton2);
            Controls.Add(lvListagem);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Listagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialListView lvListagem;
        private MaterialSkin.Controls.MaterialTextBox txtProduto;
        private MaterialSkin.Controls.MaterialButton txtListar;
        private MaterialSkin.Controls.MaterialTextBox txtLocal;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton btnListar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}