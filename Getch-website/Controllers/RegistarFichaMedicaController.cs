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
    public class RegistarFichaMedicaController : Controller
    {
       [HttpGet]
        public ActionResult DadosDaFichaMedica()
        {
            ViewBag.Cirugia = ComboxCirugia.GetCirugia();
            ViewBag.Fractura = ComboxFracturas.GetFractura();
            ViewBag.Alergia = ComboxAlergias.GetAlergias();
            ViewBag.DoencasHereditarias = ComboxDoencasHereditarias.GetDoencasHereditarias();

            return View();
        }
        [HttpPost]
        public ActionResult DadosDaFichaMedica(DadosRegistoDaFichaMedica model)
        {
            Kwendy GETIdKwendy = new Kwendy();
            FichaMedicaDoKwendy NovoRegistro = new FichaMedicaDoKwendy();

            NovoRegistro.Altura = model.Altura;
            NovoRegistro.PesoActual = model.PesoActual;
            NovoRegistro.RelatorioMedico = model.RelatorioMedico;

            NovoRegistro.Alergias = model.Alergias;
            NovoRegistro.PrimeiraAlergia = model.PrimeiraAlergia;
            NovoRegistro.SegundaAlergia = model.SegundaAlergia;
            NovoRegistro.TerceiraAlergia = model.TerceiraAlergia;
            NovoRegistro.QuartaAlergia = model.QuartaAlergia;

            NovoRegistro.CirugiasRealizadas = model.CirugiasRealizadas;
            NovoRegistro.PrimeiraCirugia = model.PrimeiraCirugia;
            NovoRegistro.SegundaCirugia = model.SegundaCirugia;
            NovoRegistro.TerceiraCirugia = model.TerceiraCirugia;
            NovoRegistro.QuartaCirugia = model.QuartaCirugia;

            NovoRegistro.Fracturas = model.Fracturas;
            NovoRegistro.Perna = model.Perna;
            NovoRegistro.Bracos = model.Cabeca;
            NovoRegistro.Coluna = model.Coluna;
            NovoRegistro.Bracos = model.Bracos;

            NovoRegistro.ProblemasDeVisao = model.ProblemasDeVisao;
            NovoRegistro.GraduacaoActual = model.GraduacaoActual;

            NovoRegistro.EstadoPsicologico = model.EstadoPsicologico;
            NovoRegistro.DataAbertura = model.DataAbertura;
        
            try
            {
                using (GechDbContext db= new GechDbContext())
                {
                    //  GETIdKwendy= db.Kwendys.FirstOrDefault(a => a.CodigoKwendy == model.CodigoUtente);

                    //if (GETIdKwendy!=null)
                    //{
                    //    NovoRegistro.KwendyId = GETIdKwendy.ID;
             
                    //    db.FichaMedicas.Add(NovoRegistro);
                    //    db.SaveChanges();

                    //}
                    //else
                    //{

                    //}
                }
            }
            catch
            {

            }

            return View();
        }
    }
}