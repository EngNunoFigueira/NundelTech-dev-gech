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
    public class VerEventosMarcadosController : Controller
    {
        #region Lista de Eventos Marcados
        [HttpGet]
        public ActionResult EventosMarcados()
        {
            List<ListaDeEventos> Eventos = new List<ListaDeEventos>()
            {
                new ListaDeEventos
                {
                    ID =1,
                    NomeDoEvento ="Sorriso Azul",
                    DataDeRealizacao =DateTime.Now,
                    EstadoDoEvento ="Em curso",
                    HoraRealizada ="10:00",
                    Provincia ="Benguela",
                    Municipio ="Baia Farta",
                    ApelidoDoResponsavel="Carvalho",
                    NomeDoResponsavel="Jacinto",
                    NumeroDeParticipantes=2345,
                    ToneladasAdquiridas=120
                },
                 new ListaDeEventos
                {
                    ID =1,
                    NomeDoEvento ="Sorriso Azul",
                    DataDeRealizacao =DateTime.Now,
                    EstadoDoEvento ="Em curso",
                    HoraRealizada ="10:00",
                    Provincia ="Luanda",
                    Municipio ="Cazenga",
                    ApelidoDoResponsavel="Carvalho",
                    NomeDoResponsavel="Jacinto",
                    NumeroDeParticipantes=2345,
                    ToneladasAdquiridas=120
                },
                  new ListaDeEventos
                {
                    ID =1,
                    NomeDoEvento ="Sorriso Azul",
                    DataDeRealizacao =DateTime.Now,
                    EstadoDoEvento ="Em curso",
                    HoraRealizada ="10:00",
                    Provincia ="Malanje",
                    Municipio ="Panga Panga",
                    ApelidoDoResponsavel="Carvalho",
                    NomeDoResponsavel="Jacinto",
                    NumeroDeParticipantes=2345,
                    ToneladasAdquiridas=120
                }
            };

            return View(Eventos);
        }
        #endregion

        #region APLICAR FILTROS A LISTA DE REGISTROS DOS EVENTOS MARCADOS
        [HttpGet]
        public PartialViewResult AplicarFiltrosAListaDeEventos(int id)
        {
            List<ListaDeEventos> Eventos = new List<ListaDeEventos>()
            {
               new ListaDeEventos
               {
                        ID = 100,
                NomeDoEvento = "Feliz Natal",
                DataDeRealizacao = DateTime.Now,
                EstadoDoEvento = "Em curso",
                HoraRealizada = "10:00",
                Provincia = "Luanda",
                Municipio = "Maianga",
                ApelidoDoResponsavel = "Pedro",
                NomeDoResponsavel = "Pais",
                NumeroDeParticipantes =0,
                ToneladasAdquiridas = 0

                }
           
            };

            return PartialView(Eventos);
        }
        #endregion

        #region VER DETALHES DO EVENTO CRIADO DE ANGARIACAO DE FUNDOS
        [HttpGet]
        public ActionResult DetalhesDoEvento(int id)
        {
            ListaDeEventos Eventos = new ListaDeEventos();

            using (GechDbContext db=new GechDbContext())
            {
            }
            return View(Eventos);
        }
        #endregion

        #region ACTUALIZAR DADOS DO EVENTO DE ANGARIAÃO DE FUNDOS 
        [HttpPost]
        public ActionResult ActualizarDadosDosEventosMarcados(int id, int Idprovincia, int Idmunicipio, int Ehora,string EnomeEvento, double Etoneladas, double Enumeropessoas)
        {
            return RedirectToAction("EventosMarcados");
        }
        #endregion
    }
}