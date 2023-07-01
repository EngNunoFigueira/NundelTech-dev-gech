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
    public class ActualizarPlanoCurricularController : Controller
    {
        #region MOSTRA ACOMAPNHAMENTOS ESCOLARES DE TODAS AS CRIANCAS
        [HttpGet]
        public ActionResult DadosDoAcompanhmaentoEscolar()
        {
            ViewBag.UnidadeCurricular = ComboxNomeDeUC.GetNomesDeUCs();

            List<ListaPlanoDeEstudo> model = new List<ListaPlanoDeEstudo>()
            {
                //new ListaPlanoDeEstudo {ID=1,NomeDaCrianca="Andrea", ApelidoDaCrianca="Ramos",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMEL",ClasseQueFrequenta="12º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 },
                //new ListaPlanoDeEstudo {ID=1,NomeDaCrianca="Mauro", ApelidoDaCrianca="Filipe",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMIL",ClasseQueFrequenta="9º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 },
                new ListaPlanoDeEstudo {ID=3,NomeDaCrianca="Vera", ApelidoDaCrianca="Ferreira",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMEL",ClasseQueFrequenta="10º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 }
            };

            try
            {
                using (GechDbContext db= new GechDbContext() )
                {
                    // Temos que fazer uma consulta a base de dados para carregar esses dados da TABELA AcompanhamentoEscolar.
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
           
        }
        #endregion

        #region APLICAR FILTROS A TABELA DE ACOMAPNHAMENTOS ESCOLARES 
        [HttpGet]
        [OutputCache(Duration = 0)]
        public ActionResult AplicarFiltrosAcompanhamentoEscolar(int id)
        {
            List<ListaPlanoDeEstudo> RefreshModel = new List<ListaPlanoDeEstudo>()
            {
                new ListaPlanoDeEstudo {ID=1,NomeDaCrianca="Andrea", ApelidoDaCrianca="Ramos",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMEL",ClasseQueFrequenta="12º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 },
                new ListaPlanoDeEstudo {ID=2,NomeDaCrianca="Mauro", ApelidoDaCrianca="Filipe",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMIL",ClasseQueFrequenta="9º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 },
                new ListaPlanoDeEstudo {ID=3,NomeDaCrianca="Vera", ApelidoDaCrianca="Ferreira",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMEL",ClasseQueFrequenta="10º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 }
            };

            return PartialView("~/Views/ActualizarPlanoCurricular/AplicarFiltrosAcompanhamentoEscolar.cshtml", RefreshModel);
        }
        #endregion

        #region ACTUALIZAR PLANO CURRICULAR DE CADA ESTUDANTE
        [HttpPost]
        public ActionResult ActualizarPlanoCurricular(int idACE,int idUC, int NOTAPS, int NOTASS, int NOTAFN) //(int idACE)//
        {
            PlanoCurricular model = new PlanoCurricular();

            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    // Vamos usar o id para encontrar os dados
                }

               // return View(model);
               return RedirectToAction("DadosDoAcompanhmaentoEscolar");
            }
            catch 
            {
                return View(model);
            };
           
        }
        #endregion

        #region DETALHES DO PLANO ESCOLAR
        [HttpGet]
        public ActionResult DetalhesDoPlanoEscolar(int id)
        {
            List<NotasIndividuaisDoPanoCurricular> model = new List<NotasIndividuaisDoPanoCurricular>()
            {
                new NotasIndividuaisDoPanoCurricular {ID=1,
                    NomeDaCrianca ="Paulo",
                    ApelidoDaCrianca ="Juazy",
                    AnoLectivo =2018,
                    ClasseQueFrequenta ="7º",
                    DescricaoInstituicaoDeEnsino ="N. Kiluanje",
                    DescricaoCicloFormativo="II",
                    NomeDaDisciplina="Física",
                    NotaPrimeiroSemestre=12,
                    NotaSegundoSemestre=15, 
                    NotaTerceiroSemestre=17 
                  },
                    new NotasIndividuaisDoPanoCurricular {ID=1,
                    NomeDaCrianca ="Paulo",
                    ApelidoDaCrianca ="Juazy",
                    AnoLectivo =2018,
                    ClasseQueFrequenta ="7º",
                    DescricaoInstituicaoDeEnsino ="N. Kiluanje",
                    DescricaoCicloFormativo="II",
                    NomeDaDisciplina="Matematíca",
                    NotaPrimeiroSemestre=12,
                    NotaSegundoSemestre=15,
                    NotaTerceiroSemestre=17
                  },
                    new NotasIndividuaisDoPanoCurricular {ID=1,
                    NomeDaCrianca ="Paulo",
                    ApelidoDaCrianca ="Juazy",
                    AnoLectivo =2018,
                    ClasseQueFrequenta ="7º",
                    DescricaoInstituicaoDeEnsino ="N. Kiluanje",
                    DescricaoCicloFormativo="II",
                    NomeDaDisciplina="Português",
                    NotaPrimeiroSemestre=12,
                    NotaSegundoSemestre=15,
                    NotaTerceiroSemestre=17
                  }
            };

            using (GechDbContext db = new GechDbContext())
            {

            }
            return PartialView(model);
        }
        #endregion


        #region HISTORICO ACADEMICO
        [HttpGet]
        public ActionResult HistoricoDoPlanoCurricularDoAnoEmCurso(int id)
        {
            List<ListaPlanoDeEstudo> RefreshModel = new List<ListaPlanoDeEstudo>()
            {
                new ListaPlanoDeEstudo {ID=1,NomeDaCrianca="Andrea", ApelidoDaCrianca="Ramos",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMEL",ClasseQueFrequenta="12º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 },
                new ListaPlanoDeEstudo {ID=2,NomeDaCrianca="Mauro", ApelidoDaCrianca="Filipe",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMIL",ClasseQueFrequenta="9º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 },
                new ListaPlanoDeEstudo {ID=3,NomeDaCrianca="Vera", ApelidoDaCrianca="Ferreira",AnoLectivo=2017, DescricaoCicloFormativo="Ensino Médio",DescricaoInstituicaoDeEnsino="IMEL",ClasseQueFrequenta="10º",NotaPrimeiroSemestre=0,NotaSegundoSemestre=0,NotaTerceiroSemestre=0,TaxaAproveitamento=0 }
            };

            return PartialView("~/Views/ActualizarPlanoCurricular/AplicarFiltrosAcompanhamentoEscolar.cshtml", RefreshModel);
        }
        #endregion

    }
}