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
    public class RegistarDisciplinaController : Controller
    {
       #region DISCIPLINAS GERICAS 
        [HttpGet]
        public ActionResult DadosDaDisciplina()
        {
              ViewBag.SemestralOuAnul = ComboxSemestralOuAnual.GetTipoDisciplinaSemestralOuAnual();
              ViewBag.NomesDeUC = ComboxNomeDeUC.GetNomesDeUCs();
              return View();
        }
        [HttpPost]
        public ActionResult DadosDaDisciplina( DadosDaDisciplina model)
        {
            return View();
        }
        #endregion

        #region DISCIPLINAS ENSINO PRIMARIO 1-4 CLASSE

        [HttpGet]
        public ActionResult DisciplinasEnsinoPrimario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisciplinasEnsinoPrimario(int id)
        {
           return View();
        }

        #endregion

        #region ENSINO BASICO 5 - 7 CLASSE

        [HttpGet]
        public ActionResult DisciplinasBasico()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisciplinasBasico(int id)
        {
            return View();
        }

        #endregion

        #region ENSINO BASICO 7 - 9 CLASSE
        [HttpGet]
        public ActionResult DisciplinasTerceiroNivel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisciplinasTerceiroNivel(int id)
        {
            return View();
        }
        #endregion
    }
}