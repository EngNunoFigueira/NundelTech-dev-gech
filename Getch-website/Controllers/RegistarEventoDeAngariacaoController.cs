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
    public class RegistarEventoDeAngariacaoController : Controller
    {
        [HttpGet]
        public ActionResult DadosDoEventoDeAngariacao()
        {
            ViewBag.Municipio = ComboxMunicipio.GetMunicipio();
            ViewBag.EstadoDoEvento = ComboxEstadoDoEventoDeAngariacaoDeProduto.GetEstadoDoEventoDeAngariacaoDeProduto();

            return View(); 
        }

        [HttpPost]
        public ActionResult DadosDoEventoDeAngariacao(DadosDoEventoDeAngariacao model)
        {
            AngariacaoDeProduto NovoRegistro = new AngariacaoDeProduto();
            //Colaborador GETIdDoColaboradorDirectorDaCampanha = new Colaborador();

            try
            {
                //NovoRegistro.NomeDoEvento = model.NomeDoEvento;
                //NovoRegistro.MunicipioId = model.IdMunicipio;
                //NovoRegistro.DataDeRealiacaoDoEvento = model.DataDeRealiacaoDoEvento;
                //NovoRegistro.DataDeFechoDoEvento = model.DataDeFechoDoEvento;
                //NovoRegistro.HoraDeInicioDoEvento = model.HoraDeInicioDoEvento;
                //NovoRegistro.HoraDeFechoDoEvento = model.HoraDeFechoDoEvento;
                //NovoRegistro.ToneladasAdquiridas = 0;
                //NovoRegistro.NumeroDeParticipantes = 0;
              

                using (GechDbContext db =new GechDbContext())
                {
                    //GETIdDoColaboradorDirectorDaCampanha = db.Colaboradores.FirstOrDefault(a => a.CodigoColaborador == model.CodigoDoColaboradorGestorDoEvento);

                    //if(GETIdDoColaboradorDirectorDaCampanha != null)
                    //{
                    //    NovoRegistro.ColaboradorId = GETIdDoColaboradorDirectorDaCampanha.ID;
                    //}
                    //else
                    //{
                    //    NovoRegistro.ColaboradorId = 1000;
                    //}

                    //db.AngariacaoDeProdutos.Add(NovoRegistro);
                    //db.SaveChanges();

                }
                    return View();
            }
            catch
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            
        }
    }
}