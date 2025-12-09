using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjetoWMS
{
    public partial class Form1 : MaterialForm
    {

        public Form1()
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

        private void btnProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produtos TelaProduto = new Produtos();
            TelaProduto.ShowDialog();
            this.Show();
        }

        private void btnLocais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Locais TelaLocais = new Locais();
            TelaLocais.ShowDialog();
            this.Show();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lancamentos TelaLancamento = new Lancamentos(true);
            TelaLancamento.ShowDialog();
            this.Show();

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lancamentos TelaLancamento = new Lancamentos();
            TelaLancamento.ShowDialog();
            this.Show();
        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listagem TelaListage = new Listagem();
            TelaListage.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracao TelaConfig = new Configuracao();
            TelaConfig.ShowDialog();
            this.Show();
        }
    }
}
