using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;
using Microsoft.AspNetCore.Http;

namespace SistemaVendas.Controllers
{
    public class VendaController : Controller
    {
        private IHttpContextAccessor httpContext;

        //recebe o contexto http via injeção de dependencia
        public VendaController(IHttpContextAccessor HttpContextAccessor)
        {
            httpContext = HttpContextAccessor;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ListaVendas = new VendaModel().ListagemVendas();
            return View();
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            CarregarDados();
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(VendaModel venda)
        {
            venda.Vendedor_Id = httpContext.HttpContext.Session.GetString("IdUsuarioLogado");
            venda.Inserir();
            CarregarDados();
            return View();
        }

        public void CarregarDados()
        {
            ViewBag.ListaClientes = new VendaModel().RetornaListaClientes();
            ViewBag.ListaVendedor = new VendaModel().RetornaListaVendedor();
            ViewBag.ListaProdutos = new VendaModel().RetornaListaProdutos();
        }

    }
}