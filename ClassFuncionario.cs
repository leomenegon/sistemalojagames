using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaGames
{
    class ClassFuncionario
    {
        public ClassFuncionario()
        {
            CodFunc = 0;
            NomeFunc = null;
            CpfFunc = null;
            TelFunc1 = null;
            TelFunc2 = null;
            TelFunc3 = null;
            TelFunc4 = null;
            DataCadFunc = DateTime.Now;
            NomeSocFunc = null;
            StatusFunc = 1;
            EndRuaFunc = null;
            EndCityFunc = null;
            EndCepFunc = null;
            EndEstadoFunc = null;
            SexoFunc = 0;
            UserFunc = null;
            PassFunc = null;
            DataNascFunc = null;
            RgFunc = null;
            OrgEmiFunc = null;
        }

        public int CodFunc { get; set; }
        public string NomeFunc { get; set; }
        public string CpfFunc { get; set; }
        public string TelFunc1 { get; set; }
        public string TelFunc2 { get; set; }
        public string TelFunc3 { get; set; }
        public string TelFunc4 { get; set; }
        public DateTime DataCadFunc { get; set; }
        public string NomeSocFunc { get; set; }
        public string EndRuaFunc { get; set; }
        public string EndCityFunc { get; set; }
        public string EndCepFunc { get; set; }
        public string EndEstadoFunc { get; set; }
        public int SexoFunc { get; set; }
        public string UserFunc { get; set; }
        public string PassFunc { get; set; }
        public int StatusFunc { get; set; }
        public string DataNascFunc { get; set; }
        public string RgFunc { get; set; }
        public string OrgEmiFunc { get; set; }
             
        public int CadastrarFuncionario()
        {
            string query = "insert into funcionario values(0,'" + NomeFunc + "','" + NomeSocFunc + "','" + CpfFunc + "','" + RgFunc + "','" + OrgEmiFunc +  "'," + SexoFunc + ",'" + UserFunc + "','" + PassFunc + "'," + "now()" + ",'" + StatusFunc + "','" + TelFunc1 + "','" + TelFunc2 + "','" + EndRuaFunc + "','" + EndCityFunc + "','" + EndEstadoFunc + "','" + EndCepFunc + "','" + DataNascFunc + "');";

            ClassConexao objCon = new ClassConexao();
            return objCon.ExecutaQuery(query);
        }
        public DataTable SearchFuncV()
        {
            string query = "SELECT CodFuncionario,Nome FROM funcionario WHERE Status = 1;";

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
        public DataTable FuncLogin(string user, string passwd)
        {
            string query = "select CodFuncionario,Nome,User,Password from funcionario where User = '" + user + "' and Password = '" + passwd + "';";

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
    }
}
