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
    public class VerRequisicoesController : Controller
    {
        #region LISTA DAS REQUISICOES
        [HttpGet]
        public ActionResult VerRequisicoes()
        {
            ViewBag.EstadoDaRequisicao = ComboxEstadoDaRequisicao.GetEstadoDaRequisicao();

            List<ListaDeRequisicoes> model = new List<ListaDeRequisicoes> { new ListaDeRequisicoes { ID=1,
             NomeDoApadrinhado = "Paula", ApelidoDoApadrinhado="Ngueve",Telefone="921040819",
             NomeDoColaborador ="Sérgio", ApelidoDoColaborador="Pereira",Produto="Leite", Quantidade=1, 
             DataDeAbertura=DateTime.Now, DataDeFecho=DateTime.Now,EstadoDaRequisicao="Fechada",Descricao="Urgente"
             },
             new ListaDeRequisicoes { ID=2,
             NomeDoApadrinhado = "Nyangui", ApelidoDoApadrinhado="Kauph",Telefone="922195001",
             NomeDoColaborador ="Sérgio", ApelidoDoColaborador="Pereira",Produto="Leite", Quantidade=1,
             DataDeAbertura=DateTime.Now, DataDeFecho=DateTime.Now,EstadoDaRequisicao="Fechada",Descricao="Nomral"
           }
            };
            return View(model);
        }
        #endregion
        #region FILTRAR REGISTROS DAS REQUISICOES
        [HttpGet]
        public PartialViewResult FiltrarRequisicoes(int id)
        {
            List<ListaDeRequisicoes> model = new List<ListaDeRequisicoes>()
            {
                new ListaDeRequisicoes
                {
                    ID = 1,
                    NomeDoApadrinhado = "Claudia",
                    ApelidoDoApadrinhado = "Silva",
                    Telefone = "921040819",
                    NomeDoColaborador = "Sérgio",
                    ApelidoDoColaborador = "Pereira",
                    Produto = "Leite",
                    Quantidade = 1,
                    DataDeAbertura = DateTime.Now,
                    DataDeFecho = DateTime.Now,
                    EstadoDaRequisicao = "Fechada",
                    Descricao = "Urgente"
                },
             new ListaDeRequisicoes
             {
                 ID = 2,
                 NomeDoApadrinhado = "Pedro",
                 ApelidoDoApadrinhado = "Perreira",
                 Telefone = "923506070",
                 NomeDoColaborador = "Sérgio",
                 ApelidoDoColaborador = "Pereira",
                 Produto = "Leite",
                 Quantidade = 1,
                 DataDeAbertura = DateTime.Now,
                 DataDeFecho = DateTime.Now,
                 EstadoDaRequisicao = "Fechada",
                 Descricao = "Nomral"
             },
            new ListaDeRequisicoes
            {
                ID = 2,
                NomeDoApadrinhado = "Bento",
                ApelidoDoApadrinhado = "Fernandez",
                Telefone = "9104040506",
                NomeDoColaborador = "Sérgio",
                ApelidoDoColaborador = "Pereira",
                Produto = "Leite",
                Quantidade = 1,
                DataDeAbertura = DateTime.Now,
                DataDeFecho = DateTime.Now,
                EstadoDaRequisicao = "Fechada",
                Descricao = "Nomral"
            }
            };

            using (GechDbContext db = new GechDbContext())
            {
                #region Buscar processo em funcao do filtro selecionado pelo utilizador
                #endregion
            }


            return PartialView(model);
        }
        #endregion
        #region DETALHES DA REQUISICAO
        [HttpGet]
        public ActionResult DetalhesRequisicoes(int id)
        {
            ListaDeRequisicoes model = new ListaDeRequisicoes()
            {
                ID=1,
                NomeDoApadrinhado="Mario",
                ApelidoDoApadrinhado ="Mbope",
                Telefone="923000101",
                ApelidoDoColaborador="Neves",
                NomeDoColaborador="Daniel",
                DataDeAbertura=DateTime.Now,
                DataDeFecho = DateTime.Now,
                Produto="Leite",
                Quantidade=1,
                EstadoDaRequisicao="Fechada"
            };


            using (GechDbContext db= new GechDbContext())
            {

            }
                return View(model);
        }
        #endregion
        #region ACTUALIZAR REQUISICOES
        [HttpPost]
        public ActionResult ActualizarRequisicoes (int id, int idProduto, int idEstado, int idTiporequisicao, int qtd)
        {
            #region Recebe o id do fichero e vai a base de dados buscar os dados para apresentar ao utilizador
            using (GechDbContext db =new GechDbContext())
            {

            }
             return RedirectToAction("VerRequisicoes");
            #endregion
        }
        #endregion
    }
}