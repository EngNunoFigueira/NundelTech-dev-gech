using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Getch_website.Models;
using System.Web.Mvc;
using Getch_website.My_Classes;
using Getch_website.Model_View;
using Getch_website.Model_Consulta;


namespace Getch_website.Controllers
{
    public class VerStockController : Controller
    {
        #region Ver lista de produtos em Stock
        [HttpGet]
        public ActionResult ProdutosEmSotck()
        {
            List<ListDeProdutosEmStock> model =new List<ListDeProdutosEmStock>()
                {
                   new ListDeProdutosEmStock
                   {
                     ID =1,
                     NomeDoArmazem ="Vila Flor",
                     NomeDoProduto="Arroz",
                     CategoriaDoProduto="Aliemntar",
                     GeneroDoProduto="Cereais",
                     KilosPorUnidade=50,
                     Quantidade=12439,
                     Unidades=500,
                     DataDeEntraDoArmazem=DateTime.Now,
                     DataDeValidade=DateTime.Now,
                     TelefoneDoArmazem="925879209"
                   },
                    new ListDeProdutosEmStock
                    {
                        ID = 2,
                        NomeDoArmazem = "Vila Flor",
                        NomeDoProduto = "Feijão",
                        CategoriaDoProduto = "Aliemntar",
                        GeneroDoProduto = "Cereais",
                        KilosPorUnidade = 50,
                        Quantidade = 12439,
                        Unidades = 500,
                        DataDeEntraDoArmazem = DateTime.Now,
                        DataDeValidade = DateTime.Now,
                        TelefoneDoArmazem = "925879209"
                    },
                    new ListDeProdutosEmStock
                    {
                        ID = 3,
                        NomeDoArmazem = "Vila Flor",
                        NomeDoProduto = "Trigo",
                        CategoriaDoProduto = "Aliemntar",
                        GeneroDoProduto = "Cereais",
                        KilosPorUnidade = 50,
                        Quantidade = 12439,
                        Unidades = 500,
                        DataDeEntraDoArmazem = DateTime.Now,
                        DataDeValidade = DateTime.Now,
                        TelefoneDoArmazem = "925879209"
                    }
                };
            return View(model);
        }
        #endregion

        #region Aplicar Filtros a produtos
        [HttpGet]
        public PartialViewResult AplicarFitroListaDeStock(int id)
        {
            return PartialView();
        }
        #endregion

        #region Actualizar Filha de Dados do Produto
        [HttpGet]
        public ActionResult FichaDoProduto(int id)
        {
            #region Busca o produto em referencia na base dados e mostra ao utilizador
            //DadosDeRegistoDoProduto

            ListDeProdutosEmStock model = new ListDeProdutosEmStock();
            model.ID = id;
            model.DataDeValidade = DateTime.Now;
            model.CategoriaDoProduto = "Alimentar";
            model.DataDeEntraDoArmazem = DateTime.Now;
            model.GeneroDoProduto = "Fresco";
            model.KilosPorUnidade = 32000;
            model.NomeDoProduto = "Frango do campo";
            model.Quantidade = 1000;
            model.TelefoneDoArmazem = "92330120101";
            model.KilosPorUnidade = 10;
            model.NomeDoArmazem = "Vila Flor";
            model.Unidades = 10;
            
            #endregion

            return PartialView("FichaDoProduto", model);
        }
        [HttpPost]
        public ActionResult FichaDoProduto(FichaDoProduto model)
        {
            return View();
        }
        #endregion
    }
}