using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojaGames
{
    class ClassProduto
    {
        public ClassProduto()
        {
            CodProd = 0;
            NomeProd = null;
            DescProd = null;
            CatProd = 0;
            StatusProd = 1;
            PrecoProd = 0;
            QtdeProd = 0;
            DataCadProd = DateTime.Now;
            CodPlat = 0;
        }

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
        public string txtSearch { get; set; }
        public int CodPlatS { get; set; }
        public int CatProdS { get; set; }
        public int CodProdS { get; set; }

        public int CadastrarProduto()
        {
            string query = "insert into produto values (0,'" + NomeProd + "'," + CodPlat + ",'" + DescProd + "'," + CatProd + "," + StatusProd + "," + PrecoProd + "," + QtdeProd + "," + "now());";

            ClassConexao objCon = new ClassConexao();
            return objCon.ExecutaQuery(query);
        }
        public DataTable SearchProdStatus()
        {
            string query = "SELECT produto.CodProduto as Cod,produto.Nome,plataforma.Plataforma,categoria.Nome as Categoria,produto.Preco,produto.Qtde FROM produto JOIN plataforma ON plataforma.CodPlat=produto.CodPlat JOIN categoria ON categoria.CodCategoria=produto.CodCat WHERE produto.Status=1";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchProdStatusIna()
        {
            string query = "SELECT produto.CodProduto as Cod,produto.Nome,plataforma.Plataforma,categoria.Nome as Categoria,produto.Preco,produto.Qtde FROM produto JOIN plataforma ON plataforma.CodPlat=produto.CodPlat JOIN categoria ON categoria.CodCategoria=produto.CodCat WHERE produto.Status=0";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchProdNome()
        {

            string query = "SELECT produto.CodProduto as Cod,produto.Nome,plataforma.Plataforma,categoria.Nome as Categoria,produto.Preco,produto.Qtde FROM produto JOIN plataforma ON plataforma.CodPlat=produto.CodPlat JOIN categoria ON categoria.CodCategoria=produto.CodCat WHERE produto.Status=1 AND produto.Nome LIKE '%" + txtSearch + "%';";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }

        public DataTable SearchProdPlat()
        {
            string query = "SELECT produto.CodProduto as Cod,produto.Nome,plataforma.Plataforma,categoria.Nome as Categoria,produto.Preco,produto.Qtde FROM produto JOIN plataforma ON plataforma.CodPlat=produto.CodPlat JOIN categoria ON categoria.CodCategoria=produto.CodCat WHERE produto.Status=1 AND produto.CodPlat = " + CodPlatS + ";";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchProdCat()
        {
            string query = "SELECT produto.CodProduto as Cod,produto.Nome,plataforma.Plataforma,categoria.Nome as Categoria,produto.Preco,produto.Qtde FROM produto JOIN plataforma ON plataforma.CodPlat=produto.CodPlat JOIN categoria ON categoria.CodCategoria=produto.CodCat WHERE produto.Status=1 AND produto.CodCat = " + CatProdS + ";";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public DataTable SearchProdCod(int cod)
        {
            cod = CodProdS;

            string query = "SELECT produto.CodProduto as Cod,produto.Nome,plataforma.Plataforma,categoria.Nome as Categoria,produto.Preco,produto.Qtde FROM produto JOIN plataforma ON plataforma.CodPlat=produto.CodPlat JOIN categoria ON categoria.CodCategoria=produto.CodCat WHERE produto.CodProduto = " + cod;

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public bool ReturnProd(int cod)
        {
            string query = "select * from produto where CodProduto = " + cod;
            ClassConexao cc = new ClassConexao();
            DataTable dt = cc.RetornaDataTable(query);


            if (dt.Rows.Count > 0)
            {
                CodProd = Convert.ToInt32(dt.Rows[0]["CodProduto"]);
                NomeProd = Convert.ToString(dt.Rows[0]["Nome"]);
                CodPlat = Convert.ToInt32(dt.Rows[0]["CodPlat"]);
                DescProd = Convert.ToString(dt.Rows[0]["Descricao"]);
                StatusProd = Convert.ToInt32(dt.Rows[0]["Status"]);
                PrecoProd = Convert.ToInt32(dt.Rows[0]["Preco"]);
                QtdeProd = Convert.ToInt32(dt.Rows[0]["Qtde"]);
                DataCadProd = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                CatProd = Convert.ToInt32(dt.Rows[0]["CodCat"]);

                return true;
            }
            else return false;
        }
        public int AttProd()
        {
            string query = "UPDATE produto SET Nome = '" + NomeProd + "', CodPlat = " + CodPlat + ", Descricao = '" + DescProd + "', CodCat = '" + CatProd + "', Status = " + StatusProd + ", Preco = " + PrecoProd + ", Qtde = " + QtdeProd + " WHERE CodProduto = " + CodProd + ";";

            ClassConexao objCon = new ClassConexao();
            return objCon.ExecutaQuery(query);
        }
        public int DelProd()
        {
            string query = "DELETE from produto WHERE CodProduto = " + CodProd;

            ClassConexao objCon = new ClassConexao();
            return objCon.ExecutaQuery(query);
        }
        public DataTable SearchProdNomeV(string s)
        {

            string query = "SELECT produto.CodProduto as Cod,produto.Nome,plataforma.Plataforma,categoria.Nome as Categoria,produto.Preco,produto.Qtde FROM produto JOIN plataforma ON plataforma.CodPlat=produto.CodPlat JOIN categoria ON categoria.CodCategoria=produto.CodCat WHERE produto.Status=1 AND produto.Nome LIKE '%" + s + "%';";

            ClassConexao cc = new ClassConexao();
            return cc.RetornaDataTable(query);
        }
        public bool VProdFill(int cod)
        {
            string q = "select CodProduto,Nome,Qtde,Preco from produto where CodProduto = " + cod;

            ClassConexao c = new ClassConexao();
            DataTable dt =  c.RetornaDataTable(q);

            if (dt.Rows.Count >= 0)
            {
                CodProd = (int)dt.Rows[0]["CodProduto"];
                NomeProd = (string)dt.Rows[0]["Nome"];
                QtdeProd = (int)dt.Rows[0]["Qtde"];
                PrecoProd = (decimal)dt.Rows[0]["Preco"];

                return true;
            }
            else return false;
        }
        public string VProdNome(int cod)
        {
            string q = "select Nome as Produto from produto where CodProduto = " + cod;

            ClassConexao c = new ClassConexao();
            DataTable dt = c.RetornaDataTable(q);

            if (dt.Rows.Count > 0)
            {
                NomeProd = (string)dt.Rows[0]["Produto"];
            }
            return NomeProd;
        }
        public bool VProdUpdate(int qtde, int cod)
        {
            string query = "update produto set Qtde = " + qtde + " where CodProduto = " + cod;

            ClassConexao c = new ClassConexao();
            int aux = c.ExecutaQuery(query);

            if (aux != 0) return true;
            else return false;
        }
    } 
    }

