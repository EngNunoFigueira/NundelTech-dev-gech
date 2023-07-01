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
    public class RegistarKwendyController : Controller
    {
        [HttpGet]
        public ActionResult GETDadosParaRegistarKwendy()
        {
            #region  DADOS DA COMBOX ENVIADO A VISTA
            ViewBag.Sexo = ComboxSexo.GetSexo();
            ViewBag.CicloFormativo = ComboxCicloFormativo.GetCicloFormativo();
            ViewBag.InstituicaoDeEnsino = ComboxInstituicaoDeEnsino.GetInstituicaoDeEnsino();
            ViewBag.TipoDeDocumento = ComboxDocumento.GetDocumento();
            ViewBag.Provincia = ComboxProvincia.GetProvincia();
            ViewBag.Municipio = ComboxMunicipio.GetMunicipio();
            ViewBag.Bairro = ComboxBairro.GetBairro();
            ViewBag.EstadoCivil = ComboxEstadoCivil.GetEstadoCivil();
            ViewBag.GraudDeParticipacao = ComboxGraudDeParticipacao.GetGraudDeParticipacao();
            ViewBag.LocalDeEmissaoDoDocumento = ComboxLocalDeEmissaoDoDocumento.GetLocalDeEmissaoDoDocumento();
            #endregion

            return View();
        }

        [HttpPost]
        public ActionResult DadosDoKwendy(DadosDeRegistroDoKwendy model)
        {
            //AcompanhamentoEscolar NovoRegistro = new AcompanhamentoEscolar();
            //#region DADOS DO BI
            //NovoRegistro.Crianca.BilheteDeIdentidade.Nome = model.Nome;
            //NovoRegistro.Crianca.BilheteDeIdentidade.Apelido = model.Apelido;
            //NovoRegistro.Crianca.BilheteDeIdentidade.Idade = model.Idade;
            //NovoRegistro.Crianca.BilheteDeIdentidade.DataDeNascimento = model.DataDeNascimento;
            //NovoRegistro.Crianca.BilheteDeIdentidade.Sexo.ID = model.Sexo;
            //NovoRegistro.Crianca.BilheteDeIdentidade.EstadoCivil.ID = model.EstadoCivil;
            //NovoRegistro.Crianca.BilheteDeIdentidade.NumeroDoDocumento = model.NumeroDoDocumento;
            //NovoRegistro.Crianca.BilheteDeIdentidade.TipoDocumento.ID = model.TipoDocumentoDeIndetidade;
            //NovoRegistro.Crianca.BilheteDeIdentidade.DataDeEmissaoDoDocumentoDeIdentidade = model.DataDeEmissaoDoDocumentoDeIdentidade;
            //NovoRegistro.Crianca.BilheteDeIdentidade.DataDeValidadeDoDocumentoDeIdentidade = model.DataDeValidadeDoDocumentoDeIdentidade;

            //NovoRegistro.Crianca.BilheteDeIdentidade.Moarada.RuaAvenida = model.Morada;
            //NovoRegistro.Crianca.BilheteDeIdentidade.Moarada.NumeroDaPorta = model.NumeroDaPorta;
            //NovoRegistro.Crianca.BilheteDeIdentidade.Moarada.BairroId = model.NomeDoBairro;
            //NovoRegistro.Crianca.BilheteDeIdentidade.Moarada.CodigoPostal = model.CodigoPostal;
  
            //NovoRegistro.Crianca.BilheteDeIdentidade.FotocopiaDoc = model.FotocopiaDoc;
            //NovoRegistro.Crianca.BilheteDeIdentidade.Fotografia = model.Fotografia;
            //#endregion
            //#region DADOS INSERIDOS PELO SERVIDOR
            //NovoRegistro.Crianca.ApadrinhadoId = 1;
            //NovoRegistro.Crianca.CodigoKwendy = model.CodigoKwendy;
            //NovoRegistro.Crianca.DataDeEntrada= model.DataDeEntrada;
            //#endregion
            //#region OUTROS DADOS
            //NovoRegistro.Crianca.GrauDeParticipacao.ID = model.IdGrauDeParticipacao;
            //#endregion

            #region DADOS DO ACOMPANHAMENTO ESCOLAR
            //NovoRegistro.InstituicaoDeEnsinoId = model.IdInstituicaoDeEnsino;
            //NovoRegistro.AnoDeCurso = model.AnoDeCurso;
            //NovoRegistro.AnoLectivo = model.AnoLectivo;
            //NovoRegistro.CicloFormativoId = model.IdCicloFormativo;
            //NovoRegistro.ClasseQueFrequenta = model.ClasseQueFrequenta;
            #endregion
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    //db.AcompanhamentoEscolares.Add(NovoRegistro);
                    //db.SaveChanges();
                }
                return View();
            }
            catch
            {
                return View("~/Views/Shared/Error.cshtml");
            }
      
        }

        [HttpGet]
        public PartialViewResult DadosDoKwendyVerificadoDepoisDeVerificarResponsavel(string EmailDoPai, string TelefoneDoPai, string NomeDoPai, string ApelidoDoPai)
        {
            #region  DADOS DA COMBOX ENVIADO A VISTA
            ViewBag.Sexo = ComboxSexo.GetSexo();
            ViewBag.CicloFormativo = ComboxCicloFormativo.GetCicloFormativo();
            ViewBag.InstituicaoDeEnsino = ComboxInstituicaoDeEnsino.GetInstituicaoDeEnsino();
            ViewBag.TipoDeDocumento = ComboxDocumento.GetDocumento();
            ViewBag.Provincia = ComboxProvincia.GetProvincia();
            ViewBag.Municipio = ComboxMunicipio.GetMunicipio();
            ViewBag.Bairro = ComboxBairro.GetBairro();
            ViewBag.EstadoCivil = ComboxEstadoCivil.GetEstadoCivil();
            ViewBag.GraudDeParticipacao = ComboxGraudDeParticipacao.GetGraudDeParticipacao();
            #endregion

            DadosDeRegistroDoKwendy model = new DadosDeRegistroDoKwendy();
            model.NomeResponsavel = "Bartolo";
            model.ApelidoResponsavel = "Franzioline";
            model.Email = "bartolo@gmail.com";
            model.TelefonePrimario = "9549554312";
            model.Sexo = 1;
            model.IdCicloFormativo = 1;
            model.IdInstituicaoDeEnsino = 2;
            model.TipoDocumentoDeIndetidade = 1;
            model.NomeDoMunicipio = 1;
            model.NomeDaProvincia = 1;
            model.NomeDoBairro = 1;
            model.NomeDoMunicipio = 1; ;
            model.EstadoCivil = 1;
            model.IdGrauDeParticipacao = 1;
            model.IdInstituicaoDeEnsino = 1;

        

            //try
            //{
            //    using (GechDbContext db = new GechDbContext())
            //    {
            //        model.NomeResponsavel = "Bartolo";
            //        model.ApelidoResponsavel = "Franzioline";
            //        model.Email = "bartolo@gmail.com";
            //        model.TelefonePrimario = "9549554312";
            //        // Vamos consultar os dados na base de dados e devolver o resultado com as credencias do progenitor
            //       // return PartialView(model);
            //    }
            //}
            //catch (Exception e)
            //{
            //    // return RedirectToAction("DadosDoKwendy");
            //    model.NomeResponsavel = "DEU MERDA VELHO";
            //    return PartialView(model);
            //}
            return PartialView(model);
        }
    }
}