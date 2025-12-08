using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ProjetoWMS
{
    public partial class Login : MaterialForm
    {
        string login, senha;
        public Login()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            skinManager.ColorScheme = new ColorScheme(
              Primary.DeepPurple600,
              Primary.DeepPurple700,
              Primary.DeepPurple800,
              Accent.Purple200,
              TextShade.WHITE
            );
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login = txtLogin.Text;
            senha = txtSenha.Text;
            banco bd = new banco();

            bd.ValidarLogin(login, senha);

            if (bd.senhaexiste == true)
            {
                Sessao.UsuarioLogado = login;
                this.Hide();
                Form1 TelaMenu = new Form1();
                TelaMenu.ShowDialog();
                this.Show();
                return;
            }
            else

                MessageBox.Show("Senha nao cadastrada\" !", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar TelaRegistrar = new Registrar();
            TelaRegistrar.ShowDialog();
            this.Show();

        }

        private void cbTema_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTema.Checked == true)
            {
                var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            }
            else
            {
                var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            }
        }
    }
}
