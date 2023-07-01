using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Getch_website.Models;
using System.Web.Mvc;
using Getch_website.My_Classes;
using Getch_website.Model_View;

namespace Getch_website.Controllers
{
    public class RegistarAcompanhmanetoEscolarController : Controller
    {
        [HttpGet]
        public ActionResult DadosDoAcompamentoEscolar()
        {
            ViewBag.CicloFormativo = ComboxCicloFormativo.GetCicloFormativo();
            ViewBag.InstituicaoDeEnsino = ComboxInstituicaoDeEnsino.GetInstituicaoDeEnsino();
            return View();
        }
        [HttpPost]
        public ActionResult DadosDoAcompamentoEscolar(DadosDoAcompanhamentoEscolar model)
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {   // cria o primeiro registo do AcompanhamentoEscolar na BDA
                    // guardar as informacoes na base de dados da disciplina recebida....
                }
            }
            catch
            {

            }
            return RedirectPermanent("/RegistarDisciplina/DadosDaDisciplina/");
        }

        [HttpPost]
        public ActionResult ComprovarDadosDoKwendy(string CodigoDeUtilizador, string NomeDeUtilizador, string ApelidoDeUtilizador)
        {
            ViewBag.CicloFormativo = ComboxCicloFormativo.GetCicloFormativo();
            ViewBag.InstituicaoDeEnsino = ComboxInstituicaoDeEnsino.GetInstituicaoDeEnsino();
          
            try
            {
                using (GechDbContext db = new GechDbContext())
                {   
                    // cria o primeiro registo do AcompanhamentoEscolar na BDA
                    // guardar as informacoes na base de dados da disciplina recebida....

                    DadosDoAcompanhamentoEscolar model = new DadosDoAcompanhamentoEscolar();

                    return View(model);
                                    }
            }
            catch
            {

            }
            return View();
        }

    }
}
