using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaGames
{
    class ClassPlataforma
    {
        public ClassPlataforma()
        {
            CodPlat = 0;
            NomePlat = null;
        }
        public int CodPlat { get; set; }
        public string NomePlat { get; set; }

        public int CadPlat()
        {
            string query = "insert into plataforma values(0,'" + NomePlat + "');";

            ClassConexao objCon = new ClassConexao();
            return objCon.ExecutaQuery(query);
        }

        public DataTable SearchPlat()
        {
            string query = "SELECT * FROM plataforma ORDER BY CodPlat";

            ClassConexao objCon = new ClassConexao();
            return objCon.RetornaDataTable(query);
        }
    }
}
