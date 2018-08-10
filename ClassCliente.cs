using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaGames
{
    class ClassCliente
    {
        public ClassCliente()
        {
            CodCliente = 0;
            NomeCliente = null;
            CpfCliente = null;
            TelCliente1 = null;
            TelCliente2 = null;
            DataCadCliente = DateTime.Now;
            NomeSocCliente = null;
            EndRuaCliente = null;
            EndCityCliente = null;
            EndCepCliente = null;
            EndEstadoCliente = null;
            SexoCliente = 0;
            DataNascClie = DateTime.Now;
            txtSearch = null;
            StatusClie = false;
        }

        public int CodCliente { get; set; }
        public int CodClienteS { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public string CpfClienteS { get; set; }
        public string TelCliente1 { get; set; }
        public string TelCliente2 { get; set; }
        public string TelCliente3 { get; set; }
        public string TelCliente4 { get; set; }
        public DateTime DataCadCliente { get; set; }
        public string NomeSocCliente { get; set; }
        public string EndRuaCliente { get; set; }
        public string EndCityCliente { get; set; }
        public string EndCepCliente { get; set; }
        public string EndEstadoCliente { get; set; }
        public int SexoCliente { get; set; }
        public DateTime DataNascClie { get; set; }
        public string txtSearch { get; set; }
        public bool StatusClie { get; set; }
        public string EndEstadoClienteS { get; set; }
        public string RgClie { get; set; }
        public string OrgEmiClie { get; set; }
        public int StatusClieI { get; set; }

        public int CadastrarCliente()
        {
            string query = "insert into cliente values (0," + "'" + NomeCliente + "'," + "'" + CpfCliente + "','" + RgClie + "','" + OrgEmiClie + "','" + TelCliente1 + "','" + TelCliente4 + "'," + "now()" + ",'" + NomeSocCliente + "'," + SexoCliente + ",'" + EndRuaCliente + "','" + EndCityCliente + "','" + EndCepCliente + "','" + EndEstadoCliente + "','" + DataNascClie.ToString("yyyy-MM-dd") + "',1);";

            ClassConexao objCon = new ClassConexao();
            return objCon.ExecutaQuery(query);
        }
        public bool RetornClie(int cod)
        {
            string query = "select * from cliente where CodCliente = " + cod;

            ClassConexao c = new ClassConexao();
            DataTable dt = c.RetornaDataTable(query);

            if (dt.Rows.Count >= 0)
            {
                CodCliente = Convert.ToInt32(dt.Rows[0]["CodCliente"]);
                NomeCliente = Convert.ToString(dt.Rows[0]["Nome"]);
                CpfCliente = Convert.ToString(dt.Rows[0]["CPF"]);
                RgClie = Convert.ToString(dt.Rows[0]["RG"]);
                OrgEmiClie = Convert.ToString(dt.Rows[0]["OrgEmissor"]);
                TelCliente1 = Convert.ToString(dt.Rows[0]["Tel"]);
                TelCliente2 = Convert.ToString(dt.Rows[0]["Tel1"]);
                DataCadCliente = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                NomeSocCliente = Convert.ToString(dt.Rows[0]["NomeSocial"]);
                SexoCliente = Convert.ToInt32((dt.Rows[0]["Sexo"]));
                EndRuaCliente = Convert.ToString(dt.Rows[0]["Rua"]);
                EndCityCliente = Convert.ToString(dt.Rows[0]["Cidade"]);
                EndCepCliente = Convert.ToString(dt.Rows[0]["CEP"]);
                EndEstadoCliente = Convert.ToString(dt.Rows[0]["Estado"]);
                DataNascClie = Convert.ToDateTime(dt.Rows[0]["DataNasc"]);
                StatusClieI = Convert.ToInt32(dt.Rows[0]["Status"]);

                return true;
            }
            else return false;
        }
        public int DelClie()
        {
            string query = "delete from cliente where CodCliente =" + CodCliente;

            ClassConexao c = new ClassConexao();
            return c.ExecutaQuery(query);
        }
        public int AttClie()
        {
            string query = "UPDATE cliente SET Nome = '" + NomeCliente + "',NomeSocial = '" + NomeSocCliente + "',CPF = '" + CpfCliente + "',RG = '" + RgClie + "',OrgEmissor = '" + OrgEmiClie + "',Tel = '" + TelCliente1 + "',Tel1 = '" + TelCliente2 + "',CPF = '" + CpfCliente + "',Sexo = " + SexoCliente + ",Rua = '" + EndRuaCliente + "',Cidade = '" + EndCityCliente + "',CEP = '" + EndCepCliente + "',Estado = '" + EndEstadoCliente + "',DataNasc = '" + DataNascClie.ToString("yyyy-MM-dd") + "',Status = " + StatusClieI + " where CodCliente = " + CodCliente;

            ClassConexao c = new ClassConexao();
            return c.ExecutaQuery(query);
        }
        public DataTable SearchClieNome()
        {
            string query = "SELECT CodCliente as Cod,Nome,NomeSocial as 'Nome Social',CPF,Tel as Telefone,case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS Sexo,date_format(datanasc, '%d/%m/%Y') as 'Data de Nascimento' FROM cliente WHERE Nome LIKE '%" + txtSearch + "%' AND Status = 1";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchClieStatusAtiv()
        {
            string query = "SELECT CodCliente as Cod,Nome,NomeSocial as 'Nome Social',CPF,Tel as Telefone,case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS Sexo,date_format(datanasc, '%d/%m/%Y') as 'Data de Nascimento' FROM cliente WHERE Status = 1";
            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchClieStatusInat()
        {
            string query = "SELECT CodCliente as Cod,Nome,NomeSocial as 'Nome Social',CPF,Tel as Telefone,case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS Sexo,date_format(datanasc, '%d/%m/%Y') as 'Data de Nascimento' FROM cliente WHERE Status = 0";
            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchClieEst()
        {
            string query = "SELECT CodCliente as Cod,Nome,NomeSocial as 'Nome Social',CPF,Tel as Telefone,case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS Sexo,date_format(datanasc, '%d/%m/%Y') as 'Data de Nascimento' FROM cliente WHERE Estado = '" + EndEstadoClienteS + "' AND Status = 1";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchClieCod()
        {
            string query = "SELECT CodCliente as Cod,Nome,NomeSocial as 'Nome Social',CPF,Tel as Telefone,case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS Sexo,date_format(datanasc, '%d/%m/%Y') as 'Data de Nascimento' FROM cliente WHERE CodCliente = " + CodClienteS;

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchClieCpf()
        {
            string query = "SELECT CodCliente as Cod,Nome,NomeSocial as 'Nome Social',CPF,Tel as Telefone,case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS Sexo,date_format(datanasc, '%d/%m/%Y') as 'Data de Nascimento' FROM cliente WHERE CPF = '" + CpfClienteS + "'";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable rptSimples()
        {
            string query = "SELECT CodCliente,Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente',CPF as 'CpfCliente',Tel as 'TelCliente1',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable RelatorioClienteDIAMES(int dia, int mes)
        {
            string query = "SELECT CodCliente,Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente',CPF as 'CpfCliente',Tel as 'TelCliente1',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente where DAY (DataNasc) = " + dia + " and MONTH (DataNasc) = " + mes + " and Status = 1 ORDER by Nome";
            ClassConexao ObjConexao = new ClassConexao();
            return ObjConexao.RetornaDataTable(query);
        }
        public DataTable RelatorioClienteMES(int mes)
        {
            string query = "SELECT CodCliente, Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente', CPF as 'CpfCliente',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente where MONTH (DataNasc) = " + mes + " and Status = 1 ORDER by Nome";
            ClassConexao ObjConexao = new ClassConexao();
            return ObjConexao.RetornaDataTable(query);
        }
        public DataTable RelatorioClienteDATA(int dia, int mes, int ano)
        {
            string query = "SELECT CodCliente,Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente',CPF as 'CpfCliente',Tel as 'TelCliente1',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente WHERE DAY (DataNasc) = " + dia + " AND MONTH (DataNasc) = " + mes + " AND YEAR (DataNasc) = " + ano + ";";

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
        public DataTable RelatorioClienteIDADE(int idadeI, int idadeF)
        {
            string query = "SELECT CodCliente,Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente',CPF as 'CpfCliente',Tel as 'TelCliente1',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente where TIMESTAMPDIFF (YEAR, DataNasc, NOW()) between  '" + idadeI + "' and '" + idadeF + "' and Status = 1 ORDER by Nome";
            ClassConexao ObjConexao = new ClassConexao();
            return ObjConexao.RetornaDataTable(query);
        }
        public DataTable RelatorioClienteCIDADE(string cidade)
        {
            string query = "SELECT CodCliente,Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente',CPF as 'CpfCliente',Tel as 'TelCliente1',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente where Cidade = '" + cidade + "' and Status = 1 ORDER by Nome";
            ClassConexao ObjConexao = new ClassConexao();
            return ObjConexao.RetornaDataTable(query);
        }
        public DataTable RelatorioClienteMAIORDE(int idadeI)
        {
            string query = "SELECT CodCliente,Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente',CPF as 'CpfCliente',Tel as 'TelCliente1',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente where TIMESTAMPDIFF (YEAR, DataNasc, NOW())> '" + idadeI + "' and Status = 1 ORDER by Nome";
            ClassConexao ObjConexao = new ClassConexao();
            return ObjConexao.RetornaDataTable(query);
        }
        public DataTable RelatorioClienteSEXO(int s)
        {
            string query = "SELECT CodCliente,Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente',CPF as 'CpfCliente',Tel as 'TelCliente1',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente where Sexo = " + s + " and Status = 1 ORDER by Nome";
            ClassConexao ObjConexao = new ClassConexao();
            return ObjConexao.RetornaDataTable(query);
        }
        public DataTable RelatorioClienteSTATUS(int s)
        {
            string query = "SELECT CodCliente,Nome as 'NomeCliente',NomeSocial as 'NomeSocCliente',CPF as 'CpfCliente',Tel as 'TelCliente1',case when Sexo = true THEN 'Feminino' ELSE 'Masculino' END AS SexoCliente,DataNasc as 'DataNascClie' from cliente WHERE Status = " + s + " ORDER by Nome";
            ClassConexao ObjConexao = new ClassConexao();
            return ObjConexao.RetornaDataTable(query);
        }
        public DataTable SearchClieNomeV(string s)
        {
            string query = "SELECT CodCliente as Cod,Nome,NomeSocial as 'Nome Social',CPF FROM cliente WHERE Nome LIKE '%" + s + "%' AND Status = 1";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
    }
}
