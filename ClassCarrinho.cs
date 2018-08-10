using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojaGames
{
    class ClassCarrinho
    {
        public ClassCarrinho()
        {
            Carrinho = 0;
            Valor = 0;
            Qtde = 0;
            Produto = 0;
            Erro = "";
            Descricao = "";
        }
        public int Carrinho { get; set; }
        public decimal Valor { get; set; }
        public int Qtde { get; set; }
        public int Produto { get; set; }
        public int Venda { get; set; }
        public string Erro { get; set; }
        public string Descricao { get; set; }

        public bool CCarrinho(int v)
        {
            string query = "insert into carrinho values (0," + Valor.ToString().Replace(",",".") + "," + Qtde + "," + Produto + "," + v + ",'" + Descricao + "');";

            ClassConexao c = new ClassConexao();

            int a = c.ExecutaQueryID(query);

            if (a != 0) return true;

            else
            {
                Erro = c.ComandoErro;
                return false;
            }
        }

    }
}
