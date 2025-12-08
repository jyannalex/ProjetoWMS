using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace ProjetoWMS
{
    class banco
    {
        public static SQLiteConnection conexao;
        public Boolean senhaexiste { get; set; }
        public Boolean ProdutoExiste { get; set; }
        public Boolean LocalExiste { get; set; }

        public static SQLiteConnection ConexaoBanco()
        {
           //teste gihub
            conexao = new SQLiteConnection("Data Source=D:\\R4\\ProjetoWMS\\ProjetoWMS\\BD\\WMS");
            conexao.Open();
            return conexao;

        }
        public static void FecharConexao()
        {
            conexao.Close();
        }

        public bool ValidarLogin(string login, string senha)
        {
            using (var conn = banco.ConexaoBanco())
            {
                Dados dados = new Dados();
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @login AND senha = @senha";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.CommandText = sql;

                    long count = (long)cmd.ExecuteScalar();

                    if (count < 1)
                    {
                        senhaexiste = false;
                    }
                    else
                    {
                        senhaexiste = true;
                    }

                    return count > 0;
                }
            }
        }
        public bool RegistraLogin(string login, string senha)
        {
            using (var conn = banco.ConexaoBanco())
            {
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @login";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.CommandText = sql;

                    long count = (long)cmd.ExecuteScalar();

                    if (count < 1)
                    {
                        senhaexiste = false;
                    }
                    else
                        senhaexiste = true;

                    return count > 0;
                }
            }
        }

        public bool CriaLogin(string Nlogin, string Nsenha, string email)
        {
            using (var conn = banco.ConexaoBanco())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Usuarios (Usuario,Senha, Email, Permissoes) VALUES (@Nlogin,@Nsenha, @email, 1);";

                cmd.Parameters.AddWithValue("@Nlogin", Nlogin);
                cmd.Parameters.AddWithValue("@Nsenha", Nsenha);
                cmd.Parameters.AddWithValue("@email", email);


                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
        }

        public Dados ConsultaProduto(int Cod_Produto)
        {
            using (var conn = banco.ConexaoBanco())
            {
                string sql = @"
            SELECT Cod_Produto, Descricao_Prod, Cod_Barra, Un_Venda , Custo
            FROM Produtos
            WHERE Cod_Produto = @Cod_produto;
        ";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Cod_produto", Cod_Produto);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        Dados dados = new Dados();

                        int idx;
                        idx = reader.GetOrdinal("Cod_Produto");
                        dados.Cod_Produto = reader.IsDBNull(idx) ? 0 : reader.GetInt32(idx);

                        if (HasColumn(reader, "Descricao_Prod"))
                        {
                            idx = reader.GetOrdinal("Descricao_Prod");
                            dados.Descricao_Prod = reader.IsDBNull(idx) ? "" : reader.GetString(idx);
                        }

                        if (HasColumn(reader, "Cod_Barra"))
                        {
                            idx = reader.GetOrdinal("Cod_Barra");
                            dados.Cod_Barra = reader.IsDBNull(idx) ? 0 : reader.GetInt32(idx);
                        }

                        if (HasColumn(reader, "Un_Venda"))
                        {
                            idx = reader.GetOrdinal("Un_Venda");
                            dados.Un_Venda = reader.IsDBNull(idx) ? "" : reader.GetString(idx);
                        }

                        if (HasColumn(reader, "Custo"))
                        {
                            idx = reader.GetOrdinal("Custo");
                            dados.Custo = reader.IsDBNull(idx) ? 0 : reader.GetDecimal(idx);
                        }
                        if (dados.Descricao_Prod != string.Empty)
                        {
                            ProdutoExiste = true;
                        }
                        else
                        {
                            ProdutoExiste = false;
                        }
                        return dados;
                    }
                }
            }
        }
        private bool HasColumn(System.Data.SQLite.SQLiteDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
                if (string.Equals(reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }

        public bool AtualizarProduto(int codProduto, string descricao, string codBarra, string unVenda, decimal Custo)
        {
            using (var conn = banco.ConexaoBanco())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                                  UPDATE Produtos
                                  SET Descricao_Prod = @Descricao_Prod,
                                  Cod_Barra     = @Cod_Barra,
                                  Un_Venda      = @Un_Venda,
                                  Custo         = @Custo
                                  WHERE Cod_Produto = @Cod_Produto;";

                cmd.Parameters.AddWithValue("@Descricao_Prod", descricao ?? string.Empty);
                cmd.Parameters.AddWithValue("@Cod_Barra", codBarra ?? string.Empty);
                cmd.Parameters.AddWithValue("@Un_Venda", unVenda ?? string.Empty);
                cmd.Parameters.AddWithValue("@Cod_Produto", codProduto);
                cmd.Parameters.AddWithValue("@Custo", Custo);


                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
        }
        public bool CadastraProduto(int codProduto, string descricao, string codBarra, string unVenda ,decimal Custo)
        {
            using (var conn = banco.ConexaoBanco())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Produtos (Cod_Produto,Descricao_Prod, Cod_Barra, Un_Venda, Custo) VALUES (@Cod_Produto,@Descricao_Prod, @Cod_Barra, @Un_Venda, @Custo);";

                cmd.Parameters.AddWithValue("@Descricao_Prod", descricao ?? string.Empty);
                cmd.Parameters.AddWithValue("@Cod_Barra", codBarra ?? string.Empty);
                cmd.Parameters.AddWithValue("@Un_Venda", unVenda ?? string.Empty);
                cmd.Parameters.AddWithValue("@Cod_Produto", codProduto);
                cmd.Parameters.AddWithValue("@Custo", Custo);


                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
        }
        public bool ExcluirProduto(int codProduto)
        {
            using (var conn = banco.ConexaoBanco())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM Produtos WHERE Cod_Produto = @Cod_Produto;";

                cmd.Parameters.AddWithValue("@Cod_Produto", codProduto);


                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
        }

        public Dados ConsultaLocal(int Cod_Local)
        {
            using (var conn = banco.ConexaoBanco())
            {
                string sql = @"
            SELECT Cod_Local, Descricao_Local, Capacidade
            FROM Locais
            WHERE Cod_Local = @Cod_Local;  ";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Cod_Local", Cod_Local);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        Dados dados = new Dados();

                        int idx;
                        idx = reader.GetOrdinal("Cod_Local");
                        dados.Cod_local = reader.IsDBNull(idx) ? 0 : reader.GetInt32(idx);

                        if (HasColumn(reader, "Descricao_Local"))
                        {
                            idx = reader.GetOrdinal("Descricao_Local");
                            dados.Descricao_Local = reader.IsDBNull(idx) ? "" : reader.GetString(idx);
                        }

                        if (HasColumn(reader, "Capacidade"))
                        {
                            idx = reader.GetOrdinal("Capacidade");
                            dados.Capacidade = reader.IsDBNull(idx) ? 0 : reader.GetInt32(idx);
                        }
                        if (dados.Descricao_Prod != string.Empty)
                        {
                            LocalExiste = true;
                        }
                        else
                        {
                            LocalExiste = false;
                        }
                        return dados;
                    }
                }
            }
        }

        public bool AtualizarLocais(int Cod_local, string descricaolocal, int capacidade)
        {
            using (var conn = banco.ConexaoBanco())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                                  UPDATE Locais
                                  SET Descricao_Local = @Descricao_Local,
                                  Capacidade    = @Capacidade 
                                  WHERE Cod_Local = @Cod_Local;";

                cmd.Parameters.AddWithValue("@Descricao_Local", descricaolocal ?? string.Empty);
                cmd.Parameters.AddWithValue("@Capacidade", capacidade);
                cmd.Parameters.AddWithValue("@Cod_Local", Cod_local);


                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
        }
        public bool CadastraLocais(int Cod_Local, string descricao_Local, int Capacidade)
        {
            using (var conn = banco.ConexaoBanco())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Locais (Cod_Local,Descricao_Local, Capacidade) VALUES (@Cod_Local,@Descricao_Local, @Capacidade);";

                cmd.Parameters.AddWithValue("@Cod_Local", Cod_Local);
                cmd.Parameters.AddWithValue("@Descricao_Local", descricao_Local ?? string.Empty);
                cmd.Parameters.AddWithValue("@Capacidade", Capacidade);


                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
        }
        public bool ExcluirLocal(int codLocal)
        {
            using (var conn = banco.ConexaoBanco())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"DELETE FROM Locais WHERE Cod_Local = @Cod_Local;";

                cmd.Parameters.AddWithValue("@Cod_Local", codLocal);


                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
        }
        public bool Lancamentos(int cod_Prod ,int Cod_Local,decimal quantidade, int tipo_lancamento, int data_lanc, string usuario, string obs)
        {
            using (var conn = banco.ConexaoBanco())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Lancamentos(Cod_Produto, Cod_Local, Quantidade, Tipo_Lancamento, Data_Lancamento, Usuario, Observacao) VALUES (@Cod_Produto, @Cod_Local, @Quantidade, @Tipo_Lancamento, @Data_Lancamento, @Usuario, @Observacao);";
                cmd.Parameters.AddWithValue("@Cod_Produto", cod_Prod);
                cmd.Parameters.AddWithValue("@Cod_Local", Cod_Local);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                cmd.Parameters.AddWithValue("@Tipo_Lancamento", tipo_lancamento);
                cmd.Parameters.AddWithValue("@Data_Lancamento", data_lanc);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Observacao", obs);



                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
        }
    }

}
