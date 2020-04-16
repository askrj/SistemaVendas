using SistemaVendas.Uteis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class RelatorioModel
    {
        public DateTime DataIni { get; set; }
        public DateTime DataFim { get; set; }
    }

    public class GraficoProdutos
    {
        public double QtdeVendido { get; set; }
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }

        public List<GraficoProdutos> RetornaGrafico()
        {
            DAL objDAL = new DAL();

            string sql = "SELECT SUM(QTDE_PRODUTO) AS QTDE, P.NOME AS PRODUTO FROM itens_venda I INNER JOIN produto P ON I.Produto_id = P.id GROUP BY P.nome";
            DataTable dt = objDAL.RetDataTable(sql);

            List<GraficoProdutos> lista = new List<GraficoProdutos>();
            GraficoProdutos item;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new GraficoProdutos();
                    item.QtdeVendido = double.Parse(dt.Rows[i]["qtde"].ToString());
                    item.DescricaoProduto = dt.Rows[i]["produto"].ToString();
            

                lista.Add(item);
            }

            return lista;
        }
    }
}
