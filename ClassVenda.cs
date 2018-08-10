using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaGames
{
    class ClassVenda
    {
        public ClassVenda()
        {
            Valor = 0;
            Venda = 0;
            Data = DateTime.Now;
            Cliente = 0;
            Vendedor = 0;
            PDesconto = 0;
            Obs = "";
            Erro = "";
            FormaPgto = "";
            VDesconto = 0;
        }
        public decimal Valor { get; set; }
        public int Venda { get; set; }
        public DateTime Data { get; set; }
        public int Cliente { get; set; }
        public int Vendedor { get; set; }
        public int PDesconto { get; set; }
        public string Obs { get; set; }
        public string Erro { get; set; }
        public string FormaPgto { get; set; }
        public decimal VDesconto { get; set; }
        public int CodVenda { get; set; }
        public int CodVendaCr { get; set; }


        public bool FVenda()
        {
            string query = "insert into venda values (0,now()," + Valor.ToString().Replace(",",".") + "," + PDesconto.ToString().Replace(",", ".") + ",'" + Obs + "','" + FormaPgto + "'," + Cliente + "," + Vendedor + "); select last_insert_id();";

            ClassConexao c = new ClassConexao();
            int a = c.ExecutaQueryID(query);
            CodVenda = a;

            if (a != 0)
            {
                CodVendaCr = a;
                return true;
            }

            else
            {
                Erro = c.ComandoErro;
                return false;
            }
        }
    }
}
