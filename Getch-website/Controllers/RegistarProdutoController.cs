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
    public class RegistarProdutoController : Controller
    {
      [HttpGet]
        public ActionResult DadodoProduto()
        {
            ViewBag.Armazem = ComboxArmazem.GetNomeDosArmazens();
            ViewBag.GeneroDeProduto = ComboxGeneroDeProduto.GetGeneroDeProduto();
            ViewBag.CategoriaDoProduto= ComboxCategoriaDoProduto.GetCategoriaProduto();
            ViewBag.EstadoDeConservacaoDoProduto = ComboxEstadoDeConservacaoDoProduto.GetEstadoDeConservacaoDoProduto();
            ViewBag.EstadoDoEventoDeAngariacaoDeProduto = ComboxEstadoDoEventoDeAngariacaoDeProduto.GetEstadoDoEventoDeAngariacaoDeProduto();
            ViewBag.ComboxEstadoDoProdutoEmStock = ComboxEstadoDoProdutoEmStock.GetEstadoDoProdutoEmStock();

            return View();
        }
        [HttpPost]
        public ActionResult DadodoProduto(DadosDeRegistoDoProduto model)
        {
            Produto NovoProduto = new Produto();

            Padrinho GetIdPadringoEmail       = new Padrinho();
            Padrinho GetIdPadringoPorTelefone = new Padrinho();
            Padrinho GetIdPadringoPorApelido  = new Padrinho();
            Padrinho GetIdPadringoPorNome     = new Padrinho();

            try
            {
                //NovoProduto.NomeDoproduto = model.NomeDoproduto;
                //NovoProduto.QuantidadeKg = model.QuantidadeKg;
                //NovoProduto.UnidadesCaixas = model.UnidadesCaixas;
                //NovoProduto.UnidadesPacotes = model.UnidadesPacotes;
                //NovoProduto.DataDeValidade = model.DataDeValidade;
                //NovoProduto.GeneroDeProdutoId = model.IdGeneroDeProduto;
                //NovoProduto.CategoriaDoProdutoId = model.IdCategoriaDoProduto;
                //NovoProduto.EstadoDoProdutoId = model.IdEstadoDoProduto;
                //NovoProduto.EstadoDeConservacaoDoProdutoId = model.IdEstadoDeConservacaoDoProduto;
                //NovoProduto.DataDeRegisto = model.DataDeRegisto;
                //NovoProduto.ArmazenId = model.IdArmazen;
                //NovoProduto.DoadorAnonimo = model.Anonimo;
                //NovoProduto.EventoId = model.IdAngariacaoDeProduto;
             

                using (GechDbContext db = new GechDbContext())
                {
                    //if (model.Anonimo != true)
                    //{
                    //    if ((model.NomePadrinho != ""))    {  GetIdPadringoPorApelido = db.Padrinhos.FirstOrDefault(a => a.Apelido == model.ApelidoPadrinho); }
                    //    if ((model.ApelidoPadrinho != "")) {  GetIdPadringoPorNome = db.Padrinhos.FirstOrDefault(a => a.Apelido == model.NomeDoproduto); }
                    //    if(GetIdPadringoPorApelido.ID== GetIdPadringoPorNome.ID)
                    //    {
                    //        NovoProduto.PadrinhoId = GetIdPadringoPorApelido.ID;
                    //    }
                    //    else
                    //    {
                    //        if ((model.PadrinhoEmail != ""))
                    //        {
                    //            GetIdPadringoEmail = db.Padrinhos.FirstOrDefault(a => a.Apelido == model.PadrinhoEmail);
                    //            NovoProduto.PadrinhoId = GetIdPadringoEmail.ID;
                    //        }
                    //        else
                    //        {
                    //            if ((model.PadrinhoTelefone != ""))
                    //            {
                    //                GetIdPadringoPorTelefone = db.Padrinhos.FirstOrDefault(a => a.Apelido == model.PadrinhoTelefone);
                    //                NovoProduto.PadrinhoId = GetIdPadringoPorTelefone.ID;
                    //            }
                    //        }
                    //    }
                    //}
                    //db.Produtos.Add(NovoProduto);
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