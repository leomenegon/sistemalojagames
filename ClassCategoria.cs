using System;
using System.Data;

namespace SistemaLojaGames
{
    class ClassCategoria
    {
        public ClassCategoria()
        {
            CodCategoria = 0;
            NomeCategoria = null;
            DescricaoCategoria = null;
            Status = 0;
            DataCadastro = DateTime.Now;
        }

        public int CodCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime DataCadastro { get; set; }
        public string DescricaoCategoria { get; set; }
        public int Status { get; set; }

        public int CadastrarCategoria()
        {
            string query = "insert into categoria values (0," + "'"+NomeCategoria+"'" + "," + "'"+DescricaoCategoria+"'" + ",1" + ",now());";

            ClassConexao objCon = new ClassConexao();
            return objCon.ExecutaQuery(query);
        }
        public DataTable CbCat()
        {
            string query = "select CodCategoria, Nome from Categoria where status = 1";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
    }
}
