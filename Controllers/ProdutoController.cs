using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ListaProduto = new ProdutoModel().ListaTodosProdutos();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            if (id!= null)
            {
                //carrega registro do Vendedor na viewbag
                ViewBag.Produto = new ProdutoModel().RetornarProdutos(id);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                produto.Gravar();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Excluir(int id)
        {
            ViewData["IdExcluir"] = id;
            return View();
        }

        public IActionResult ExcluirVendedor(int id)
        {
            new ProdutoModel().Excluir(id);
            return View();
        }

    }
}