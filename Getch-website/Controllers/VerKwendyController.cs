using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Getch_website.Models;
using System.Web.Mvc;
using Getch_website.My_Classes;
using Getch_website.Model_View;
using Getch_website.Model_Consulta;
using System.Threading;

namespace Getch_website.Controllers
{
    public class VerKwendyController : Controller
    {
        #region LISTA DE REGISTRO DE KWENDY
        [HttpGet]
        public ActionResult ListaDeKwendy()
        {
            ViewBag.FiltrosContactosDeCriancas = ComboxAplicarFiltroDadosCrianca.GetFiltroParaCrianca();

            List<ListaDeKwendy> model = new List<ListaDeKwendy> { new ListaDeKwendy { ID=1,
            Nome ="Gildo", Apelido="Ganga", Sexo="Masculino",EstadoCivil="Solteiro",
            Idade=9,NumeroDoDocumento="AG48LH22",TipoDocumentoDeIndetidade="BI",DataDeValidadeDoDocumentoDeIdentidade=DateTime.Now,
            DataDeNascimento=DateTime.Now, CodigoPostal="100-046", NomeDoMunicipio="Alavalade", NomeDaProvincia="Luanda", TelefonePrimario="925 30 50 10",
            Email="gildo_ganga@hotmail.com",ApelidoResponsavel="Ganga", NomeResponsavel="Ana", CodigoResponsavel="ABN231A", DataDeEmissaoDoDocumentoDeIdentidade=DateTime.Now,
            NomeDoBairro="Pedra Azul", Morada="Mar verde", NumeroDaPorta ="70A", DescricaoDaParticipacao="100%"
            }, new ListaDeKwendy { ID=2,
            Nome ="Carla", Apelido="Nelumba", Sexo="Femenino",EstadoCivil="Solteiro",
            Idade=9,NumeroDoDocumento="AG48LH22",TipoDocumentoDeIndetidade="BI",DataDeValidadeDoDocumentoDeIdentidade=DateTime.Now,
            DataDeNascimento=DateTime.Now, CodigoPostal="100-046", NomeDoMunicipio="Alavalade", NomeDaProvincia="Benguela", TelefonePrimario="923 05 00 10",
            Email="gildo_ganga@hotmail.com",ApelidoResponsavel="Ganga", NomeResponsavel="Ana", CodigoResponsavel="ABN231A", DataDeEmissaoDoDocumentoDeIdentidade=DateTime.Now,
            NomeDoBairro="Pedra Azul", Morada="Mar verde", NumeroDaPorta ="102 B", DescricaoDaParticipacao="100%"
            }};

            return View(model);
        }
        #endregion
        #region ACTUALIZACAO DA FICHA INDIVUAL
        [HttpGet]
        public ActionResult ActualizarFichaDoKwendy(int id)
        {
            ListaDeKwendy model = new ListaDeKwendy()
            {
                ID = 1,
                Nome = "António Filipe",
                Apelido = "Brito",
                DataDeNascimento = DateTime.Now,
                Idade = 13,
                Sexo = "Masculino",
                EstadoCivil = "Solteiro",
                NumeroDoDocumento = "000490LDAF021",
                TipoDocumentoDeIndetidade = "BI",
                DataDeEmissaoDoDocumentoDeIdentidade = DateTime.Now,
                DataDeValidadeDoDocumentoDeIdentidade = DateTime.Now,
                Morada = "Rui Biologo Pedro Lara",
                NomeDoBairro = "Alvalade",
                NomeDoMunicipio = "Maianga",
                NomeDaProvincia = "Luanda",
                NumeroDaPorta = "124B",
                CodigoPostal = "1001-024",
                Email = "100afb@bjc.ao",
                TelefonePrimario = "957200011",
                CodigoResponsavel = "2011AFB08",
                ApelidoResponsavel = "Brito",
                NomeResponsavel = "Alberto",
                DescricaoDaParticipacao = "98%"

            };
            return PartialView("ActualizarFichaDoKwendy", model);
        }

        [HttpPost]
        public ActionResult ActualizarFichaDoKwendy(ListaDeKwendy model)
        {
            #region Vamos guardar esses dados na base de dados e voltamos para a lista
            #endregion
            // return RedirectToRoute("/VerKwendy/ListaDeKwendy/");
            return RedirectToAction("ListaDeKwendy");
            // 
        }
        #endregion
        #region MOSRA A FICHA MEDICA DO KWENDY 
        [HttpGet]
        public ActionResult FichaMedicaDoKwendy(int id)
        {
            Model_Consulta.FichaMedicaDoKwendy model = new Model_Consulta.FichaMedicaDoKwendy();

            //DadosRegistoDaFichaMedica MODEL = new DadosRegistoDaFichaMedica();
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    model.Alergias = "Sim";
                    model.Altura = 170;
                    model.PesoActual = 56;
                }
            }
            catch
            {
                return View(); //Vamos enviar o Redirect para a action lista de criancas
            }

            return base.PartialView("FichaMedicaDoKwendy", model);
        }
        #endregion
        #region FICHA INDIVUAL DA CRIANCA PARA SER ACTUALIZADA
        [HttpGet]
        public ActionResult FichaDoKwendy(int id)
        {
            DadosDeRegistroDoKwendy BFichaDoKwendyParaActualiza = new DadosDeRegistroDoKwendy();

            ListaDeKwendy model = new ListaDeKwendy() {
                ID = 1,
                Nome = "António Filipe",
                Apelido = "Brito",
                DataDeNascimento = DateTime.Now,
                Idade = 13,
                Sexo = "Masculino",
                EstadoCivil = "Solteiro",
                NumeroDoDocumento = "000490LDAF021",
                TipoDocumentoDeIndetidade = "BI",
                DataDeEmissaoDoDocumentoDeIdentidade = DateTime.Now,
                DataDeValidadeDoDocumentoDeIdentidade= DateTime.Now,
                Morada="Rui Biologo Pedro Lara",
                NomeDoBairro= "Alvalade",
                NomeDoMunicipio="Maianga",
                NomeDaProvincia="Luanda",
                NumeroDaPorta="124B",
                CodigoPostal="1001-024",
                Email="100afb@bjc.ao",
                TelefonePrimario="957200011",
                CodigoResponsavel="2011AFB08",
                ApelidoResponsavel= "Brito",
                NomeResponsavel= "Alberto",
                DescricaoDaParticipacao="98%"
              
            };
           
            using (GechDbContext db =new GechDbContext())
            {
                //var FichaDoKwendyParaActualiza = db.Kwendys.First(t =>t.ID==id);
            }
                return PartialView("FichaDoKwendy", model);
        }
        #endregion
        #region APLICAR FILTROS A LISTA PARA SELECCIONAR DETERMINADOS REGISTROS
        public PartialViewResult FiltrarRegistrosDeMenores(int id)
        {
            List<ListaDeKwendy> model = new List<ListaDeKwendy> { new ListaDeKwendy { ID=1,
            Nome ="Ana", Apelido="Bastos", Sexo="Masculino",EstadoCivil="Casada",
            Idade=9,NumeroDoDocumento="AG48LH22",TipoDocumentoDeIndetidade="BI",DataDeValidadeDoDocumentoDeIdentidade=DateTime.Now,
            DataDeNascimento=DateTime.Now, CodigoPostal="100-046", NomeDoMunicipio="Alavalade", NomeDaProvincia="Luanda", TelefonePrimario="925 30 50 10",
            Email="ana.bastos@gmail.com",ApelidoResponsavel="Ganga", NomeResponsavel="Ana", CodigoResponsavel="ABN231A", DataDeEmissaoDoDocumentoDeIdentidade=DateTime.Now,
            NomeDoBairro="Pedra Azul", Morada="Mar verde", NumeroDaPorta ="70A", DescricaoDaParticipacao="100%"
            }, new ListaDeKwendy { ID=2,
            Nome ="Carla", Apelido="Cristina", Sexo="Veloso",EstadoCivil="Casada",
            Idade=9,NumeroDoDocumento="AG48LH22",TipoDocumentoDeIndetidade="BI",DataDeValidadeDoDocumentoDeIdentidade=DateTime.Now,
            DataDeNascimento=DateTime.Now, CodigoPostal="100-046", NomeDoMunicipio="Alavalade", NomeDaProvincia="Benguela", TelefonePrimario="923 05 00 10",
            Email="crisvelos@hotmail.com",ApelidoResponsavel="Ganga", NomeResponsavel="Ana", CodigoResponsavel="ABN231A", DataDeEmissaoDoDocumentoDeIdentidade=DateTime.Now,
            NomeDoBairro="Pedra Azul", Morada="Mar verde", NumeroDaPorta ="102 B", DescricaoDaParticipacao="100%"
            }};

            return PartialView(model);
        }
        #endregion
    }

}