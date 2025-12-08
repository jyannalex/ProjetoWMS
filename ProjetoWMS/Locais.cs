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
    public partial class Locais : MaterialForm
    {
        public Locais()
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
        private void txtLocal_Leave_1(object sender, EventArgs e)
        {
            if (txtLocal.Text == "")
            {
                return;
            }
            var bd = new banco();
            Dados dados = bd.ConsultaLocal(Convert.ToInt32(txtLocal.Text));
            if (bd.LocalExiste == true)
            {
                materialButton1.Enabled = true;
                txtDescricaoLocal.Text = dados.Descricao_Local;
                txtCapacidade.Text = dados.Capacidade.ToString();
            }
            else
            {
                txtDescricaoLocal.Text = "";
                txtCapacidade.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            banco bd = new banco();
            bd.ConsultaLocal(Convert.ToInt32(txtLocal.Text));

            if (bd.LocalExiste == true)
            {
                bd.AtualizarLocais(Convert.ToInt32(txtLocal.Text), txtDescricaoLocal.Text, Convert.ToInt32(txtCapacidade.Text));
                MessageBox.Show("Local Atualizado");
                txtLocal.Text = "";
                txtDescricaoLocal.Text = "";
                txtCapacidade.Text = "";
                txtLocal.Focus();
            }
            else
            {
                bd.CadastraLocais(Convert.ToInt32(txtLocal.Text), txtDescricaoLocal.Text, Convert.ToInt32(txtCapacidade.Text));
                MessageBox.Show("Local Cadastrado");
                txtLocal.Text = "";
                txtDescricaoLocal.Text = "";
                txtCapacidade.Text = "";
                txtLocal.Focus();
            }
        }

        private void txtLocal_Enter(object sender, EventArgs e)
        {
            txtLocal.Text = "";
            txtDescricaoLocal.Text = "";
            txtCapacidade.Text = "";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            banco bd = new banco();
            bd.ConsultaLocal(Convert.ToInt32(txtLocal.Text));

            if (bd.LocalExiste == true)
            {
                bd.ExcluirLocal(Convert.ToInt32(txtLocal.Text));
                MessageBox.Show("Local Excluido");
                txtLocal.Text = "";
                txtDescricaoLocal.Text = "";
                txtCapacidade.Text = "";
                txtLocal.Focus();
            }
            else
            {
                MessageBox.Show("Local Nao Existe");
                txtLocal.Text = "";
                txtDescricaoLocal.Text = "";
                txtCapacidade.Text = "";
                txtLocal.Focus();
            }
        }
    }
 }
