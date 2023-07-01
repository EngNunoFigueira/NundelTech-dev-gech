using Getch_website.Model_Consulta;
using Getch_website.Model_View;
using Getch_website.Models;
using Getch_website.My_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Getch_website.Controllers
{
    public class VerApadrinhadosController : Controller
    {
        #region MOSTRAR REGISTROS DE APADRINHADOS
        [HttpGet]
        public ActionResult ListaDeApdrinhados()
        {
            ViewBag.FiltrosContactosDeAdultos = ComboxAplicarFiltrosListaAdultos.GetFiltrosListaAdultos();

            List<ListaDeApadrinhados> ListaDeApadrinhados = new List<ListaDeApadrinhados> { new ListaDeApadrinhados { ID=1,
            Nome="Rogerio", Apelido="Rocha", Idade=87, Sexo="M", EstadoCivil="Solteiro", NumeroDoDocumento="23949LDGF",
            TipoDocumentoDeIndetidade="BI", DataDeValidadeDoDocumentoDeIdentidade=DateTime.Now, DataDeEmissaoDoDocumentoDeIdentidade=DateTime.Now,
            DataDeNascimento=DateTime.Now, Morada="Baia Azul", Bairro="Vila flor", CodigoPostal="1000-013", Municipio="Benguela",
            Provincia="Luanda", NumeroDaPorta="10B", TelefoneFixo="2224901023", Telemovel="91710901", Email="rrocha@gmail.com", EstadoLaboral="Empregado",
            Departamento="Comercial", Funcao="Gestor", Estudo="Médio", NumeroDeFilhos=2, CriancasACargo=2, GrauDeParticipacao="100%"} };

            return View(ListaDeApadrinhados);
        }
        #endregion
        #region DETALHES DA FICHA PESSOAL DO APADRINHADO
        [HttpGet]
        public ActionResult DetalhesPessoalDoApadrinho(int id)
        {
            ListaDeApadrinhados model = new ListaDeApadrinhados();
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                   // var model = db.Apadrinhados.Where(a => a.ID == id).FirstOrDefault();
                    return PartialView(model);
                }
            }
            catch
            {
            }
            return View();
        }
        #endregion
        #region CONSULTAR FICHA MEDICA DO ADULTO APADRINHADO
        [HttpGet]
        public ActionResult FichaMedicaDoApadrinho(int id)
        {
            FichaMedicaDoApadrinhado model = new FichaMedicaDoApadrinhado();

            return PartialView("FichaMedicaDoApadrinho", model);
        }
        #endregion
        #region ACTUALIZAR FICHA PESSOAL DE APADRINHADO INSCRITO
        [HttpPost]
        public ActionResult ActualizarFichaDeApadrinhado(int id, int idMorada,int idProvincia, int IdMunicipio,int idTipodocumento,string idNumerodocumento, int idValidade,int idEmissao, string idCorreio, string idTelefone, string idTelemovel, int idNumerofilhos)
        {
            return RedirectToAction("ListaDeApdrinhados");
        }
        #endregion
        #region APLICAR FILTROS A LISTA DE REGISTROS DOS APADRINHADOS
        public PartialViewResult FiltrarRegistrosDeApadrinhados(int id) 
        {
            #region Vamos a base de dados aplicar filtros aos dados e voltar a mostrar
            List<ListaDeApadrinhados> model = new List<ListaDeApadrinhados>()
            {
                new ListaDeApadrinhados
                {
                    ID=1,
                    Nome="Paulo", Apelido="Rocha", Idade=87, Sexo="M", EstadoCivil="Solteiro", NumeroDoDocumento="23949LDGF",
                    TipoDocumentoDeIndetidade="BI", DataDeValidadeDoDocumentoDeIdentidade=DateTime.Now, DataDeEmissaoDoDocumentoDeIdentidade=DateTime.Now,
                    DataDeNascimento=DateTime.Now, Morada="Baia Azul", Bairro="Vila flor", CodigoPostal="1000-013", Municipio="Benguela",
                    Provincia="Luanda", NumeroDaPorta="10B", TelefoneFixo="2224901023", Telemovel="91710901", Email="rrocha@gmail.com", EstadoLaboral="Empregado",
                    Departamento="Comercial", Funcao="Gestor", Estudo="Médio", NumeroDeFilhos=2, CriancasACargo=2, GrauDeParticipacao="100%"
                },
                new ListaDeApadrinhados
                {
                    ID=2,
                    Nome="Margarida", Apelido="Pinto", Idade=87, Sexo="M", EstadoCivil="Solteiro", NumeroDoDocumento="23949LDGF",
                    TipoDocumentoDeIndetidade="BI", DataDeValidadeDoDocumentoDeIdentidade=DateTime.Now, DataDeEmissaoDoDocumentoDeIdentidade=DateTime.Now,
                    DataDeNascimento=DateTime.Now, Morada="Baia Azul", Bairro="Vila flor", CodigoPostal="1000-013", Municipio="Benguela",
                    Provincia="Luanda", NumeroDaPorta="10B", TelefoneFixo="2224901023", Telemovel="91710901", Email="rrocha@gmail.com", EstadoLaboral="Empregado",
                    Departamento="Comercial", Funcao="Gestor", Estudo="Médio", NumeroDeFilhos=2, CriancasACargo=2, GrauDeParticipacao="100%"
                },
                new ListaDeApadrinhados
                {
                    ID=3,
                    Nome="Angelo", Apelido="Cunha", Idade=87, Sexo="M", EstadoCivil="Solteiro", NumeroDoDocumento="23949LDGF",
                    TipoDocumentoDeIndetidade="BI", DataDeValidadeDoDocumentoDeIdentidade=DateTime.Now, DataDeEmissaoDoDocumentoDeIdentidade=DateTime.Now,
                    DataDeNascimento=DateTime.Now, Morada="Baia Azul", Bairro="Vila flor", CodigoPostal="1000-013", Municipio="Benguela",
                    Provincia="Luanda", NumeroDaPorta="10B", TelefoneFixo="2224901023", Telemovel="91710901", Email="rrocha@gmail.com", EstadoLaboral="Empregado",
                    Departamento="Comercial", Funcao="Gestor", Estudo="Médio", NumeroDeFilhos=2, CriancasACargo=2, GrauDeParticipacao="100%"
                },

            };
            return PartialView(model);
            #endregion
        }
       #endregion
    }
}
           