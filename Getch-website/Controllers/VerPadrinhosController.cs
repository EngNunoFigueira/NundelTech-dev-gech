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
    public class VerPadrinhosController : Controller
    {
        #region LISTA DE TODOS PADRINHOS
        [HttpGet]
        public ActionResult VerPadrinhos()
        {
            ViewBag.ComboxFiltroPadrinho = ComboxAplicarFiltroDadosPadrinho.GetFiltroParaApadrinhado();

            List<ListaDePadrinhos> Model = new List<ListaDePadrinhos>()
            {
                new ListaDePadrinhos {ID=1, NomeDoPadrinho="Paulo",
                    ApelidoDoPadrinho ="Coutinho",
                    Telefone ="923100030",
                    DataDeAdesao =DateTime.Now,
                    Email ="cmacedo@hotmail.com",
                    GrauDeParticipacao="95%",
                   Provincia="Luanda",
                   TipoDePadrinho="ET"},
                 new ListaDePadrinhos {ID=1, NomeDoPadrinho="Bernado",
                    ApelidoDoPadrinho ="Carvalho",
                    Telefone ="923301121",
                    DataDeAdesao =DateTime.Now,
                    Email ="bernado@hotmail.com",
                    GrauDeParticipacao="55%",
                   Provincia="Luanda",
                   TipoDePadrinho="RG"}
            };

            return View(Model);
        }
        #endregion
        [HttpPost]
        public ActionResult AplicarFiltrosListaPadrinhos(int id)
        {
            ViewBag.ComboxFiltroPadrinho = ComboxAplicarFiltroDadosPadrinho.GetFiltroParaApadrinhado();

            List<ListaDePadrinhos> ModelActualizado = new List<ListaDePadrinhos>()
            {
                new ListaDePadrinhos {ID=1, NomeDoPadrinho="Dilma",
                    ApelidoDoPadrinho ="Gatuna",
                    Telefone ="923301121",
                    DataDeAdesao =DateTime.Now,
                    Email ="gatuna@hotmail.com",
                    GrauDeParticipacao="85%",
                   Provincia="Brasil",
                   TipoDePadrinho="RJ"}
            };
            return PartialView("AplicarFiltrosListaPadrinhos",ModelActualizado);
        }

        [HttpGet]
        public ActionResult ActualizarFichaDePadrinho(int id)
        {
            using (GechDbContext db =new GechDbContext())
            {
                // Vamos a base de dados consultar os dados do padrinho com o ID enviado e devolver
            }
            return View();
        }
        [HttpPost]
        public ActionResult ActualizarFichaDePadrinho(DadosDeRegistoDoPadrinho model)
        {
            using (GechDbContext db = new GechDbContext())
            {
                // Vamos salvar as alteraoes na base de dados.
            }
            return View();
        }
    }
}