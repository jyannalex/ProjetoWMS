using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoWMS
{
    public partial class Configuracao : MaterialForm
    {
        public Configuracao()
        {
            InitializeComponent();

            var footer = new MaterialSkin.Controls.MaterialCard()
            {
                Height = 25,
                Dock = DockStyle.Bottom,
                Padding = new Padding(8),
                BackColor = Color.White
            };

            var lblFooter = new Label()
            {
                Text = "Usuário: " + Sessao.UsuarioLogado,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            footer.Controls.Add(lblFooter);
            this.Controls.Add(footer);
        }

        private void configuracao(object sender, EventArgs e)
        {
            txtImportaProd.TrailingIcon = Properties.Resources.lupa; 
            txtImportaLocal.TrailingIcon = Properties.Resources.lupa; 
        }

        private void TxtImportarProdutos_TrailingIconClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files|*.csv|Todos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImportaProd.Text = ofd.FileName;
                btnImportaProd.Focus();
            }
        }

        private void txtImportaLocal_TrailingIconClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files|*.csv|Todos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImportaLocal.Text = ofd.FileName;
                btnImportaLocal.Focus();
            }
        }
    }
}
