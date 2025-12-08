using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoWMS
{
    public partial class Registrar : MaterialForm
    {
        public Registrar()
        {
            InitializeComponent();
        }
        banco bd = new banco();
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtSenha2.Text)
            {
                MessageBox.Show("Senhas nao conferem\" !", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
                return;
            }
            else
            {
                bd.CriaLogin(txtLogin.Text, txtSenha.Text, txtEmail.Text);
                MessageBox.Show("Cadastrado com Sucesso\" !", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login telaLogin = new Login();
                telaLogin.ShowDialog();
                this.Show();
            }
        }
        private void txtLogin_Leave_1(object sender, EventArgs e)
        {
            bd.RegistraLogin(txtLogin.Text, txtSenha.Text);
            if (bd.senhaexiste == true)
            {
                MessageBox.Show("Usuario ja cadastrado\" !", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text.Contains("@") == false || txtEmail.Text.Contains(".com") == false)
            {
                MessageBox.Show("Email invalido\" !", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
        }
    }
}
