using Newtonsoft.Json;
using SistemaVendas.Uteis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class VendaModel
    {
        public string Id { get; set; }

        public string Data { get; set; }
        public string Cliente_Id { get; set; }
        public string Vendedor_Id { get; set; }

        public double Total { get; set; }
        public string Nome { get; set; }
        public double Preco_Unitario { get; set; }
        public double Qtd_Vendida { get; set; }

        public string ListaProdutos { get; set; }


        public List<VendaModel> RetornarListagemVendas(string DataIni, string DataFim)
        {
            List<VendaModel> lista = new List<VendaModel>();
            VendaModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT v1.id, v1.data, v1.total, v2.nome as vendedor, c.nome as cliente from " +
                "venda v1 inner join vendedor v2 on v1.vendedor_id = v2.id inner join cliente c " +
                "on v1.cliente_id = c.id " +
                $"where v1.data >='{DataIni}' and v1.data <='{DataFim}'order by data, total";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new VendaModel
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Data = DateTime.Parse(dt.Rows[i]["data"].ToString()).ToString("dd/MM/yyyy"),
                    Total = double.Parse(dt.Rows[i]["total"].ToString()),
                    Cliente_Id = dt.Rows[i]["cliente"].ToString(),
                    Vendedor_Id = dt.Rows[i]["vendedor"].ToString(),
                };
                lista.Add(item);
            }
            return lista;
        }

        public List<VendaModel> ListagemVendas(string DataIni, string DataFim)
        {
            return RetornarListagemVendas(DataIni, DataFim);
        }

        public List<VendaModel> ListagemVendas()
        {
            return RetornarListagemVendas("1900/01/01","2200/12/31");
        }

        public List<ClienteModel> RetornaListaClientes()
        {
            return new ClienteModel().ListaTodosClientes();
        }

        public List<VendedorModel> RetornaListaVendedor()
        {
            return new VendedorModel().ListaTodosVendedores();
        }

        public List<ProdutoModel> RetornaListaProdutos()
        {
            return new ProdutoModel().ListaTodosProdutos();
        }

        public List<VendaModel> RetornarProdutosVendidos(string Nome, string DataIni, string DataFim)
        {
            List<VendaModel> lista = new List<VendaModel>();
            VendaModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT SELECT v.data , iv.qtde_produto, iv.preco_produto, v.total, p.nome FROM " +
                "venda v inner join itens_venda iv on v.id = iv.venda_id inner join produto p " +
                "on iv.produto_id = p.id " +
                $"where v.data >='{DataIni}' and v.data <='{DataFim}' and p.nome {Nome} order by data, total";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new VendaModel
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Data = DateTime.Parse(dt.Rows[i]["data"].ToString()).ToString("dd/MM/yyyy"),
                    Total = double.Parse(dt.Rows[i]["total"].ToString()),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    Preco_Unitario = double.Parse(dt.Rows[i]["preco_unitario"].ToString()),
                    Qtd_Vendida = double.Parse(dt.Rows[i]["Qtd_Vendida"].ToString()),

                };
                lista.Add(item);
            }
            return lista;
        }

        public void Inserir()
        {
            DAL objDAL = new DAL();

            //Inseri venda

            string dataVenda = DateTime.Now.Date.ToString("yyyy/MM/dd");

            string sql = "insert into venda(data, total, vendedor_id, cliente_id) " +
                $"values('{dataVenda}',{Total.ToString().Replace(",", ".")},{Vendedor_Id},{Cliente_Id})";
                objDAL.ExecutarComandoSQL(sql);

            //Recupera venda

            sql = $"select id from venda where data='{dataVenda}' and vendedor_id={Vendedor_Id} and cliente_id={Cliente_Id} order by id desc limit 1";
            DataTable dt = objDAL.RetDataTable(sql);
            string id_venda = dt.Rows[0]["id"].ToString();


            //Serializa o Json da lista de produtos para gravalos na tabela intemvendas

            List<ItemVendaModel> lista_produtos = JsonConvert.DeserializeObject<List<ItemVendaModel>>(ListaProdutos);
            for (int i = 0; i < lista_produtos.Count; i++)
            {
                sql = "insert into itens_venda(venda_id,produto_id, Qtde_Produto, preco_produto) " +
                $"values({id_venda},{lista_produtos[i].CodigoProduto.ToString()}, " +
                $"{lista_produtos[i].QtdProduto.ToString()}, " +
                $"{ lista_produtos[i].PrecoUnitario.ToString().Replace(",", ".")})";

                objDAL.ExecutarComandoSQL(sql);

                //baixa produto no estoque
                sql = " update produto " +
                    $" set quantidade_estoque = (quantidade_estoque - " + int.Parse(lista_produtos[i].QtdProduto.ToString()) + ")" +
                    $" where id = {lista_produtos[i].CodigoProduto.ToString()}";
                objDAL.ExecutarComandoSQL(sql);
            }


        }
    }
}
