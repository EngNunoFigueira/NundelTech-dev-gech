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
    public class RegistrarRequisicaoController : Controller
    {
        [HttpGet]
        public ActionResult DadosDaRequisicao()
        {
            ViewBag.Produtos = ComboxProduto.GetProduto();
            ViewBag.EstadoDaRequisicao = ComboxEstadoDaRequisicao.GetEstadoDaRequisicao();

            return View();
        }

        [HttpPost]
        public ActionResult DadosDaRequisicao(DadosRequisicaoDeProdutos model)
        {
            RequisicaoDeProduto NovoRegistro = new RequisicaoDeProduto();
            Apadrinhado GETIApadrinhado = new Apadrinhado();
          //  Colaborador GETIdColaborador = new  Colaborador();

            //NovoRegistro.Descricao = model.Descricao;
            //NovoRegistro.DataDeAbertura = model.DataDeAbertura;
            //NovoRegistro.DataDeFecho = model.DataDeFecho;
            //NovoRegistro.ProdutoId = model.IdDoProduto;
            //NovoRegistro.Quantidade = model.Quantidade;
            //NovoRegistro.IdEstadoDaRequisicao = model.IdEstadoDaRequisicao;

         
          
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                   // GETIdColaborador = db.Colaboradores.FirstOrDefault(a => a.CodigoColaborador == model.CodigoColaborador);
                   // GETIApadrinhado = db.Apadrinhados.FirstOrDefault(a => a.BilheteDeIdentidade.Apelido == model.ApelidoApadrinhado && a.BilheteDeIdentidade.Nome == model.NomeApadrinhado|| a.Contacto.TelefonePrimario==model.TelefoneApadrinhado);

                   // if (GETIdColaborador != null)
                   // {
                   //     NovoRegistro.ColaboradorId = GETIdColaborador.ID;
                   // }
                   // else
                   // {
                   //     NovoRegistro.ColaboradorId = 1000;
                   // }
                   //if (GETIApadrinhado !=null)
                   // {
                   //     NovoRegistro.ApadrinhadoId = GETIApadrinhado.ID;

                   //     db.RequisicaoDeProdutos.Add(NovoRegistro);
                   //     db.SaveChanges();
                   // }

                }

          
            }
            catch
            {

            }

            return View();
        }
    }
}