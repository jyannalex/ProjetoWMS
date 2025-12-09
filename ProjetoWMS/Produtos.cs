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
    public partial class Produtos : MaterialForm
    {
        public Produtos()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            banco bd = new banco();
            bd.ConsultaProduto(Convert.ToInt32(txtProduto.Text));

            if (bd.ProdutoExiste == true)
            {
                bd.AtualizarProduto(Convert.ToInt32(txtProduto.Text), txtDescricaoProduto.Text, txtCodBarra.Text, txtUnVenda.Text, Convert.ToDecimal(txtCusto.Text));
                txtProduto.Text = "";
                txtDescricaoProduto.Text = "";
                txtCodBarra.Text = "";
                txtUnVenda.Text = "";
                txtCusto.Text = "";
                txtProduto.Focus();
            }
            else
            {
                bd.CadastraProduto(Convert.ToInt32(txtProduto.Text), txtDescricaoProduto.Text, txtCodBarra.Text, txtUnVenda.Text, Convert.ToDecimal(txtCusto.Text));
                MessageBox.Show("Produto Cadastrado" ,"Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Text = "";
                txtDescricaoProduto.Text = "";
                txtCodBarra.Text = "";
                txtUnVenda.Text = "";
                txtCusto.Text = "";
                txtProduto.Focus();
            }
        }

        private void txtProduto_Leave_1(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {
                return;
            }
            var bd = new banco();
            Dados dados = bd.ConsultaProduto(Convert.ToInt32(txtProduto.Text));
            if (bd.ProdutoExiste == true)
            {
                txtDescricaoProduto.Text = dados.Descricao_Prod;
                txtCodBarra.Text = dados.Cod_Barra.ToString();
                txtUnVenda.Text = dados.Un_Venda;
                txtCusto.Text = dados.Custo.ToString();
                materialButton1.Enabled = true;
            }
            else
            {
                txtDescricaoProduto.Text = "";
                txtCodBarra.Text = "";
                txtUnVenda.Text = "";
            }
        }

        private void txtProduto_Enter_1(object sender, EventArgs e)
        {
            txtProduto.Text = "";
            txtDescricaoProduto.Text = "";
            txtCodBarra.Text = "";
            txtUnVenda.Text = "";
            txtCusto.Text = "";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            banco bd = new banco();
            bd.ConsultaProduto(Convert.ToInt32(txtProduto.Text));

            if (bd.ProdutoExiste == true)
            {
                bd.ExcluirProduto(Convert.ToInt32(txtProduto.Text));
                MessageBox.Show("Produto Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Text = "";
                txtDescricaoProduto.Text = "";
                txtCodBarra.Text = "";
                txtUnVenda.Text = "";
                txtCusto.Text = "";
                txtProduto.Focus();
            }
            else
            {
                MessageBox.Show("Produto Nao Existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProduto.Text = "";
                txtDescricaoProduto.Text = "";
                txtCodBarra.Text = "";
                txtUnVenda.Text = "";
                txtCusto.Text = "";
                txtProduto.Focus();
            }
        }
    }
}