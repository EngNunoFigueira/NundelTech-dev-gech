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
    public class RegistarConsultaMedicaController : Controller
    {
       [HttpGet]
        public ActionResult DadosDaConsultaMedica()
        {
            ViewBag.Estado = ComboxEstado.GetEstado();
            ViewBag.TipoDeConsulta = ComboxTipoDeConsultaMedica.GetTipoDeConsultaMedica();
            ViewBag.Hospital = ComboxNomeDoHospitalOuCentroDeSaude.GetNomeDoHospitalOuCentroDeSaude();
           
            return View();
        }
        [HttpPost]
        public ActionResult DadosDaConsultaMedica(DadosDaMarcacaoDaConsulta model)
        {
            return View();
        }
    }
}