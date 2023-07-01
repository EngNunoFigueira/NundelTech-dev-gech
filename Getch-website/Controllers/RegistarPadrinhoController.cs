using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Getch_website.Models;
//using Getch_website.Model_Views;
using System.Web.Mvc;
using Getch_website.My_Classes;
using Getch_website.Model_View;

namespace Getch_website.Controllers
{
    public class RegistarPadrinhoController : Controller
    {
       
        [HttpGet]
        public ActionResult DadosDoPadrinho()
        {

            using (GechDbContext db = new GechDbContext())
            {
                var Nome = db.Padrinhos.Where(a => a.ID ==1);
               // var Nome = db.Padrinhos.FirstOrDefault();
            }
            ViewBag.Sexo = ComboxSexo.GetSexo();
            ViewBag.Bairro = ComboxBairro.GetBairro();
            ViewBag.TipoDePadrinho = ComboxTipoDePadrinho.GetTipoDePadrinho();
            ViewBag.GrauDeParticipacao = ComboxGraudDeParticipacao.GetGraudDeParticipacao();

            return View();
        }
        [HttpPost]
        public ActionResult DadosDoPadrinho(DadosDeRegistoDoPadrinho model)
        {
            try
            {
                Padrinho NovoRegistro = new Padrinho();

                NovoRegistro.Nome = model.Nome;
                NovoRegistro.Apelido = model.Apelido;
                NovoRegistro.IdSexo = model.IdSexo;
                NovoRegistro.DataDENascimento = model.DataDENascimento;
                //NovoRegistro.Email = model.Email;
                //NovoRegistro.Facebook = model.Facebook;
                //NovoRegistro.TelefonePrimario = model.TelefonePrimario;
                //NovoRegistro.TelefoneSecundario = model.TelefoneSecundario;
                //NovoRegistro.TelefoneResponsavel = model.TelefoneResponsavel;
                NovoRegistro.TipoDePadrinhoId = model.IdTipoDePadrinho;

                //NovoRegistro.Morada.CodigoPostal 
                //NovoRegistro.Morada.RuaAvenida 
                //NovoRegistro.Morada.NumeroDaPorta 
                //NovoRegistro.Morada.BairroId 

                NovoRegistro.GrauDeParticipacaoId = model.IdParticipacao;

                using (GechDbContext db = new GechDbContext())
                {
                    //db.Padrinhos.Add(NovoRegistro);
                    //db.SaveChanges();
                }

                return View();
            }
            catch
            {
                return View();
            }
          
        }
    }
}