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
    public partial class Lancamentos : MaterialForm
    {
        int tp_lancamento = 0, data;
        public Lancamentos()
        {

            InitializeComponent();
            if (cbEntrada.Checked == true)
            {
                cbSaida.Checked = false;
            }
            else
            {
                cbSaida.Checked = true;
            }
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
        public Lancamentos(bool Entrada)
        {
            InitializeComponent();
            cbEntrada.Checked = Entrada;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cbSaida.Checked)
            {
                tp_lancamento = 1;
            }
            data = Convert.ToInt32(DateTime.Now.ToString("ddMMyyyy"));
            banco bd = new banco();

            bd.Lancamentos(Convert.ToInt32(txtProduto.Text), Convert.ToInt32(txtLocal.Text), Convert.ToDecimal(txtQuantidade.Text), tp_lancamento, data, Sessao.UsuarioLogado, txtObs.Text);
            MessageBox.Show("Lançamento realizado com sucesso!");
            txtProduto.Text = "";
            txtLocal.Text = "";
            txtDescricaoProd.Text = "";
            txtDescricaoLocal.Text = "";
            txtQuantidade.Text = "";
            txtObs.Text = "";
            txtProduto.Focus();

        }

        private void txtProduto_Leave_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtProduto.Text))
                return;
            banco bd = new banco();
            Dados dados = bd.ConsultaProduto(Convert.ToInt32(txtProduto.Text));
            if (bd.ProdutoExiste == false)
            {
                MessageBox.Show("Produto não cadastrado!");
                txtProduto.Focus();
                return;
            }
            else
                txtDescricaoProd.Text = dados.Descricao_Prod;
        }

        private void txtLocal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocal.Text))
                return;
            banco bd = new banco();
            Dados dados = bd.ConsultaLocal(Convert.ToInt32(txtLocal.Text));
            bd.ConsultaLocal(Convert.ToInt32(txtLocal.Text));
            if (bd.LocalExiste == false)
            {
                MessageBox.Show("Local não cadastrado!");
                txtLocal.Focus();
                return;
            }
            else
                txtDescricaoLocal.Text = dados.Descricao_Local;
        }

    }
}
