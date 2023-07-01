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
    public class RegistarArmazemController : Controller
    {
       [HttpGet]
        public ActionResult DadosDoArmazem()
        {
            ViewBag.EstadoDoArmazem = ComboxEstado.GetEstado();
            ViewBag.Bairro = ComboxBairro.GetBairro();

            return View();
        }
        [HttpPost]
        public ActionResult DadosDoArmazem(DadosDoArmazem model)
        {
            //Armazem NovoRegistro = new Armazem();

            //NovoRegistro.NomeDoArmazem = model.NomeDoArmazem;
            //NovoRegistro.Telefone = model.Telefone;
            //NovoRegistro.Skype = model.Skype;

            //NovoRegistro.Morada.BairroId = model.BairroId;
            //NovoRegistro.Morada.CodigoPostal = model.CodigoPostal;
            //NovoRegistro.Morada.NumeroDaPorta= model.NumeroDaPorta;
            //NovoRegistro.Morada.RuaAvenida = model.RuaAvenida;
            //NovoRegistro.DataDeAbertura = model.DataDeAbertura;
            //NovoRegistro.ColaboradorGerenteId = 100; 

            try
            {
                using (GechDbContext db = new GechDbContext())
                {

                    //var CodigoColaborador = db.Colaboradores.First(a=>a.CodigoColaborador == model.CodigoColaboradorGerente);

                    //if(CodigoColaborador != null )
                    //{
                    //    NovoRegistro.ColaboradorGerenteId = CodigoColaborador.ID;

                    //    db.Armazens.Add(NovoRegistro);
                    //    db.SaveChanges();
                    //}
                    //else
                    //{
                    //    /// Envia uma mensagem para avista a dizer que nao foi pssovel actualizar
                    //}

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