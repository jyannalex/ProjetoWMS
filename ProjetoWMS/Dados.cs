using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoWMS
{
    internal class Dados
    {
        // prudotus
        public int Cod_Produto { get; set; }
        public string Descricao_Prod { get; set; }
        public int Cod_Barra { get; set; }
        public string Un_Venda { get; set; }
        public decimal Custo { get; set; }

        // locais   
        public int Cod_local { get; set; }
        public string Descricao_Local { get; set; }
        public int Capacidade { get; set; }


    }

    public static class Sessao
    {
        public static string UsuarioLogado { get; set; }
    }

    public class Lancamento
    {
        public int ID_Lancamento { get; set; }
        public int Cod_Produto { get; set; }
        public int Cod_Local { get; set; }
        public decimal Quantidade { get; set; }
        public int Tipo_Lancamento { get; set; }
        public string Data_Lancamento { get; set; }
        public string Usuario { get; set; }
    }
}
