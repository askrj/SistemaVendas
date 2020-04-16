using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class RelatorioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Vendas()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Vendas(RelatorioModel relatorio)
        {
            if (relatorio.DataIni.Year == 1)
            {
                ViewBag.ListaVendas = new VendaModel().ListagemVendas();
            }
            else
            {
                string DataIni = relatorio.DataIni.ToString("yyy/MM/dd");
                string DataFim = relatorio.DataFim.ToString("yyy/MM/dd");
                ViewBag.ListaVendas = new VendaModel().ListagemVendas(DataIni, DataFim);
            }
           
            return View();
        }

        public IActionResult Grafico()
        {
            List<GraficoProdutos> lista = new GraficoProdutos().RetornaGrafico();
            string valores = "";
            string labels = "";
            string cores = "";

            var random = new Random();
            //percorre lista de itens para compor o grafico

            for (int i = 0; i < lista.Count; i++)
            {
                valores += lista[i].QtdeVendido.ToString() + ",";
                labels += "'" + lista[i].DescricaoProduto.ToString() + "',";

                //escolher aleatoriamente as cores para compor o grafico pizza
                cores += "'" + String.Format("#{0:X6}", random.Next(0x1000000)) + "',";

            }

            ViewBag.Valores = valores;
            ViewBag.Labels = labels;
            ViewBag.Cores = cores;

            return View();
        }
    }
}