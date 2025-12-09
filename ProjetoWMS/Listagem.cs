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
    public partial class Listagem : MaterialForm
    {
        public Listagem()
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

            lvListagem.View = View.Details;
            lvListagem.Columns.Add("Produto", 90);
            lvListagem.Columns.Add("Descrição", 150);
            lvListagem.Columns.Add("Local", 70);
            lvListagem.Columns.Add("Descrição", 130);
            lvListagem.Columns.Add("Quantidade", 100);
            lvListagem.Columns.Add("Custo", 100);
            lvListagem.Columns.Add("Tipo", 100);
            lvListagem.Columns.Add("Data", 70);
            lvListagem.Columns.Add("Usuário", 100);
        }

        private void materialTextBox1_Leave(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {
                return;
            }
            var bd = new banco();
            Dados dados = bd.ConsultaProduto(Convert.ToInt32(txtProduto.Text));
            if (bd.ProdutoExiste == true)
            {
                btnListar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Produto não cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtLocal_Leave(object sender, EventArgs e)
        {
            if (txtLocal.Text == "")
            {
                return;
            }
            var bd = new banco();
            Dados dados = bd.ConsultaLocal(Convert.ToInt32(txtLocal.Text));
            if (bd.LocalExiste == true)
            {
                btnListar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Local não cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            banco bd = new banco();
            int? codProduto = null;
            int? codLocal = null;
            decimal custototal = 0;
            int quantidadeTotal = 0;

            if (!string.IsNullOrWhiteSpace(txtProduto.Text))
                codProduto = Convert.ToInt32(txtProduto.Text);

            if (!string.IsNullOrWhiteSpace(txtLocal.Text))
                codLocal = Convert.ToInt32(txtLocal.Text);

            var dados = bd.BuscarLancamentos(codProduto, codLocal);

            lvListagem.Items.Clear();

            foreach (var l in dados)
            {
                string data = ConverterData(l.Data_Lancamento);
                bd.ConsultaLocal(l.Cod_Local);
                var item = new ListViewItem(l.Cod_Produto.ToString());
                item.SubItems.Add(bd.ConsultaProduto(l.Cod_Produto).Descricao_Prod);
                item.SubItems.Add(l.Cod_Local.ToString());
                item.SubItems.Add(bd.ConsultaLocal(l.Cod_Local).Descricao_Local);
                if (l.Tipo_Lancamento == 1)
                    item.SubItems.Add("- " + l.Quantidade.ToString());
                else
                    item.SubItems.Add("+ " + l.Quantidade.ToString());
                item.SubItems.Add(bd.ConsultaProduto(l.Cod_Produto).Custo.ToString("F2"));
                item.SubItems.Add(l.Tipo_Lancamento == 0 ? "Entrada" : "Saída");
                item.SubItems.Add(data);
                item.SubItems.Add(l.Usuario);

                lvListagem.Items.Add(item);

                if (l.Tipo_Lancamento == 0)
                {
                    quantidadeTotal += (int)l.Quantidade;
                }
                else
                {
                    quantidadeTotal -= (int)l.Quantidade;
                }
                if (l.Tipo_Lancamento == 0)
                {
                    custototal += (bd.ConsultaProduto(l.Cod_Produto).Custo * l.Quantidade);
                }
                else
                {
                    custototal -= (bd.ConsultaProduto(l.Cod_Produto).Custo * l.Quantidade);
                }
            }
            materialLabel1.Text = "Quantidade Total: " + quantidadeTotal.ToString();
            materialLabel2.Text = "Custo Total: R$ " + custototal.ToString();
        }

        public static string ConverterData(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return "";

            int ano = int.Parse(data.Substring(data.Length - 4, 4));

            int mes = int.Parse(data.Substring(data.Length - 6, 2));

            int dia = int.Parse(data.Substring(0, data.Length - 6));

            DateTime dt = new DateTime(ano, mes, dia);
            return dt.ToString("dd/MM/yyyy");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Arquivos CSV (*.csv)|*.csv";
                sfd.FileName = "Lancamentos.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportarListViewParaCSV(lvListagem, sfd.FileName);
                    MessageBox.Show("Arquivo exportado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void ExportarListViewParaCSV(ListView listView, string caminhoArquivo)
        {
            using (StreamWriter sw = new StreamWriter(caminhoArquivo, false, Encoding.UTF8))
            {
                List<string> colunas = new List<string>();
                foreach (ColumnHeader coluna in listView.Columns)
                {
                    colunas.Add(coluna.Text);
                }
                sw.WriteLine(string.Join(";", colunas));

                foreach (ListViewItem item in listView.Items)
                {
                    List<string> valores = new List<string>();
                    valores.Add(item.Text); 

                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                        valores.Add(item.SubItems[i].Text);
                    }
                    sw.WriteLine(string.Join(";", valores));
                }
            }
        }
    }
}
