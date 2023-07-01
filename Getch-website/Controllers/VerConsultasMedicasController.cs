using System.Linq;
using System.Web;
using Getch_website.Models;
using System.Web.Mvc;
using Getch_website.My_Classes;
using Getch_website.Model_View;
using Getch_website.Model_Consulta;
using System.Collections.Generic;
using System;

namespace Getch_website.Controllers
{
    public class VerConsultasMedicasController : Controller
    {
        #region LISTA DE UTENTES PARA CONSULTAS
        [HttpGet]
        public ActionResult ConsultaMedica()
        {
            List <ListaDeConsultasMedicas> Model = new List<ListaDeConsultasMedicas> { new ListaDeConsultasMedicas
            { ID=1,
              NomeKwendy ="Maria",
              ApelidoKwendy ="Luaty",
              TelefoneKwendy="923110021",
              NomeDoHospital="Coração de Jesus Glorioso",
              HoraDaConsulta="10h30",
              DataDaConsulta=DateTime.Now,
              NomeDoMedico="Marcia",
              ApelidoDoMedico="Lianze",
              DataDeMarcao=DateTime.Now,
              EstadoDaConsulta="Em espera"
            }
            };
            return View(Model);
        }
        #endregion

        #region  APLICAR FILTROS A LISTA DAS CONSULTAS
        [HttpGet]
        public ActionResult AplicarFiltroRegistrosConsultaMedica(int idProcesso)
        {
            List<ListaDeConsultasMedicas> ModelActualizado = new List<ListaDeConsultasMedicas>();
            return PartialView("AplicarFiltroRegistrosConsultaMedica", ModelActualizado);
        }
        #endregion

        #region ACTUALIZAR DADOS DA CONSULTA MEDICA DO UTENTE
        [HttpPost]
        public ActionResult ActualizarDadosDaConsultaMedica(int id, int idHospital, int idEstado, string hora, string NomeMedico, int data, int idConsulta)
        {
            #region BUSCAR OS DADOS NA DBA E MOSTRAR AO UTILIZADOR PARA ACTAULIZAR

            DadosDaMarcacaoDaConsulta model = new DadosDaMarcacaoDaConsulta();
            using (GechDbContext db = new GechDbContext())
            {
               // var Bairro = db.Bairros.FirstOrDefault(a=>a.ID==1);
            }
               
            #endregion

            return RedirectToAction("ConsultaMedica");
        }
        #endregion

        #region DETALHES DA MARCAÇÃO DA CONSULTA DO UTENTE
        [HttpGet]
        public ActionResult DetalhesDaConsultaMedica(int id)
        {
            #region GUARDAR AS ACTUALIZACOES NA DBA

            ListaDeConsultasMedicas model = new ListaDeConsultasMedicas();

            using (GechDbContext db = new GechDbContext())
            {

            }
                #endregion

                return View(model);
        }
        #endregion
    }
}

