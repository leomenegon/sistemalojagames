using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaGames
{
    class ClassRelatorioV
    {
        public ClassRelatorioV()
        {

        }
        //VENDA
        public decimal ValorV { get; set; }
        public int Venda { get; set; }
        public DateTime Data { get; set; }
        public int Cliente { get; set; }
        public int Vendedor { get; set; }
        public int PDesconto { get; set; }
        public string Obs { get; set; }
        public string ErroV { get; set; }
        public string FormaPgto { get; set; }
        public decimal VDesconto { get; set; }
        public int CodVenda { get; set; }

        //CARRINHO
        public int Carrinho { get; set; }
        public decimal Valor { get; set; }
        public int Qtde { get; set; }
        public int Produto { get; set; }
        public int CodV { get; set; }
        public string Erro { get; set; }
        public string Descricao { get; set; }

        //PRODUTO
        public int CodProd { get; set; }
        public string NomeProd { get; set; }
        public string DescProd { get; set; }
        public int CatProd { get; set; }
        public string CatProdCon { get; set; }
        public int StatusProd { get; set; }
        public decimal PrecoProd { get; set; }
        public int QtdeProd { get; set; }
        public DateTime DataCadProd { get; set; }
        public int CodPlat { get; set; }

        //CLIENTE
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public string TelCliente1 { get; set; }
        public string TelCliente2 { get; set; }
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
        public string RgFunc { get; set; }
        public string OrgEmiFunc { get; set; }

        //FUNCIONÁRIO
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
        public string RgClie { get; set; }
        public string OrgEmiClie { get; set; }

        public DataTable RptTeste()
        {
            string query = "select venda.CodVenda as CodV,funcionario.Nome as Vendedor,cliente.Nome as Cliente,venda.Data,produto.Nome as Produto,carrinho.Qtde,carrinho.Valor,venda.ValorTotal as ValorV,venda.desconto as VDesconto from venda join cliente on cliente.CodCliente = venda.CodCliente join funcionario on funcionario.CodFuncionario = venda.CodFuncionario join carrinho on carrinho.Venda = venda.CodVenda join produto on produto.CodProduto = carrinho.Produto";

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
        public DataTable RptCod(int cod)
        {
            string query = "select venda.CodVenda as CodV,funcionario.Nome as Vendedor,cliente.Nome as Cliente,venda.Data,produto.Nome as Produto,carrinho.Qtde,carrinho.Valor,venda.ValorTotal as ValorV,venda.desconto as VDesconto from venda join cliente on cliente.CodCliente = venda.CodCliente join funcionario on funcionario.CodFuncionario = venda.CodFuncionario join carrinho on carrinho.Venda = venda.CodVenda join produto on produto.CodProduto = carrinho.Produto where cliente.CodCliente = " + cod;

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
        public DataTable RptCodV(int cod)
        {
            string query = "select venda.CodVenda as CodV,funcionario.Nome as Vendedor,cliente.Nome as Cliente,venda.Data,produto.Nome as Produto,carrinho.Qtde,carrinho.Valor,venda.ValorTotal as ValorV,venda.desconto as VDesconto from venda join cliente on cliente.CodCliente = venda.CodCliente join funcionario on funcionario.CodFuncionario = venda.CodFuncionario join carrinho on carrinho.Venda = venda.CodVenda join produto on produto.CodProduto = carrinho.Produto where venda.CodVenda = " + cod;

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
        public DataTable RptDataBet(DateTime dataI, DateTime dataF)
        {
            string query = "select venda.CodVenda as CodV,funcionario.Nome as Vendedor,cliente.Nome as Cliente,venda.Data,produto.Nome as Produto,carrinho.Qtde,carrinho.Valor,venda.ValorTotal as ValorV,venda.desconto as VDesconto from venda join cliente on cliente.CodCliente = venda.CodCliente join funcionario on funcionario.CodFuncionario = venda.CodFuncionario join carrinho on carrinho.Venda = venda.CodVenda join produto on produto.CodProduto = carrinho.Produto where cast(venda.Data as date) between '" + dataI.ToString("yyyy-MM-dd") + "' and '" + dataF.ToString("yyyy-MM-dd") + "'";

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
        public DataTable RptDataBetFunc(DateTime dataI, DateTime dataF, int cod)
        {
            string query = "select venda.CodVenda as CodV,funcionario.Nome as Vendedor,cliente.Nome as Cliente,venda.Data,produto.Nome as Produto,carrinho.Qtde,carrinho.Valor,venda.ValorTotal as ValorV,venda.desconto as VDesconto from venda join cliente on cliente.CodCliente = venda.CodCliente join funcionario on funcionario.CodFuncionario = venda.CodFuncionario join carrinho on carrinho.Venda = venda.CodVenda join produto on produto.CodProduto = carrinho.Produto where cast(venda.Data as date) between '" + dataI.ToString("yyyy-MM-dd") + "' and '" + dataF.ToString("yyyy-MM-dd") + "' AND funcionario.CodFuncionario = " + cod;

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
        public DataTable RptCodF(int cod)
        {
            string query = "select venda.CodVenda as CodV,funcionario.Nome as Vendedor,cliente.Nome as Cliente,venda.Data,produto.Nome as Produto,carrinho.Qtde,carrinho.Valor,venda.ValorTotal as ValorV,venda.desconto as VDesconto from venda join cliente on cliente.CodCliente = venda.CodCliente join funcionario on funcionario.CodFuncionario = venda.CodFuncionario join carrinho on carrinho.Venda = venda.CodVenda join produto on produto.CodProduto = carrinho.Produto where funcionario.CodFuncionario = " + cod;

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
        public DataTable RptDataBetClie(DateTime dataI, DateTime dataF, int cod)
        {
            string query = "select venda.CodVenda as CodV,funcionario.Nome as Vendedor,cliente.Nome as Cliente,venda.Data,produto.Nome as Produto,carrinho.Qtde,carrinho.Valor,venda.ValorTotal as ValorV,venda.desconto as VDesconto from venda join cliente on cliente.CodCliente = venda.CodCliente join funcionario on funcionario.CodFuncionario = venda.CodFuncionario join carrinho on carrinho.Venda = venda.CodVenda join produto on produto.CodProduto = carrinho.Produto where cast(venda.Data as date) between '" + dataI.ToString("yyyy-MM-dd") + "' and '" + dataF.ToString("yyyy-MM-dd") + "' AND cliente.CodCliente = " + cod;

            ClassConexao c = new ClassConexao();
            return c.RetornaDataTable(query);
        }
    }
}
