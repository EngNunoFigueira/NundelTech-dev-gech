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
    public class RegistarApadrinhadoController : Controller
    {
        [HttpGet]
        public ActionResult DadosDoapadrinhado()
        {
            ViewBag.Sexo = ComboxSexo.GetSexo();
            ViewBag.TipoDeDocumento = ComboxDocumento.GetDocumento();
            ViewBag.Provincia = ComboxProvincia.GetProvincia();
            ViewBag.Municipio = ComboxMunicipio.GetMunicipio();
            ViewBag.Bairro = ComboxBairro.GetBairro();
            ViewBag.EstadoCivil = ComboxEstadoCivil.GetEstadoCivil();
            ViewBag.Estudo = ComboxEstudo.GetEstudo();
            ViewBag.Funcao = ComboxFuncao.GetFuncao();
            ViewBag.Departamento = ComboxDepartamento.GetDepartamento();
            ViewBag.GrauDeParticipacao = ComboxGraudDeParticipacao.GetGraudDeParticipacao();
            ViewBag.LocalDeEmissaoDoDocumento = ComboxLocalDeEmissaoDoDocumento.GetLocalDeEmissaoDoDocumento();
            return View();
        }
        [HttpPost]
        public ActionResult DadosDoapadrinhado (DadosDeRegistoDoApadrinhado model)
        {
            Apadrinhado NovoRegistro = new Apadrinhado();
            #region DADOS DO BI
            //NovoRegistro.BilheteDeIdentidade.Nome = model.Nome;
            //NovoRegistro.BilheteDeIdentidade.Apelido = model.Apelido;
            //NovoRegistro.BilheteDeIdentidade.Idade = model.Idade;
            //NovoRegistro.BilheteDeIdentidade.SexoId = model.IdSexo;
            //NovoRegistro.BilheteDeIdentidade.EstadoCivilId = model.IdEstadoCivil;
            //NovoRegistro.BilheteDeIdentidade.DataDeNascimento = model.DataDeNascimento;
            //NovoRegistro.BilheteDeIdentidade.NumeroDoDocumento = model.NumeroDoDocumento;
            //NovoRegistro.BilheteDeIdentidade.TipoDocumentoDeIndetidadeId = model.IdTipoDocumentoDeIndetidade;
            //NovoRegistro.BilheteDeIdentidade.DataDeEmissaoDoDocumentoDeIdentidade = model.DataDeEmissaoDoDocumentoDeIdentidade;
            //NovoRegistro.BilheteDeIdentidade.DataDeValidadeDoDocumentoDeIdentidade = model.DataDeValidadeDoDocumentoDeIdentidade;
            //NovoRegistro.BilheteDeIdentidade.DataDeValidadeDoDocumentoDeIdentidade = model.DataDeValidadeDoDocumentoDeIdentidade;
            //NovoRegistro.BilheteDeIdentidade.DataDeValidadeDoDocumentoDeIdentidade = model.DataDeValidadeDoDocumentoDeIdentidade;
            //NovoRegistro.BilheteDeIdentidade.Moarada.RuaAvenida = model.Morada;
            //NovoRegistro.BilheteDeIdentidade.Moarada.BairroId= model.IdBairro;
            //NovoRegistro.BilheteDeIdentidade.Moarada.CodigoPostal = model.CodigoPostal;
            //NovoRegistro.BilheteDeIdentidade.Moarada.NumeroDaPorta = model.NumeroDaPorta;
            #endregion
            #region DADOS DE CONTACTOS
            NovoRegistro.Contacto.Email = model.Email;
            NovoRegistro.Contacto.TelefonePrimario = model.Telemovel;
            NovoRegistro.Contacto.TelemovelSecundario = model.TelefoneFixo;
            #endregion
            #region DADOS LABORAIS E ACADEMICOS
            //NovoRegistro.EstudoId = model.IdEstudo;
            //NovoRegistro.EstadoLaboralId = model.IdEstadoLaboral;
            //NovoRegistro.DepartamentoId = model.IdDepartamento;
            //NovoRegistro.FuncaoId = model.IdFuncao;
            #endregion
            #region OUTROS DADOS IMPORTANTES PARA O PERFIL DO UTILIZADOR
            //NovoRegistro.GrauDeParticipacaoId = model.IdGrauDeParticipacao;
            //NovoRegistro.NumeroDeFilhos = model.NumeroDeFilhos;
            //NovoRegistro.CriancasACargo = model.CriancasACargo;
            //NovoRegistro.DataDeEntrada = DateTime.Now;
            #endregion

            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                   // db.Apadrinhados.Add(NovoRegistro);
                   // db.SaveChanges();
                }
                return View();
            }
            catch
            {
                return View("~/Views/Shared/Error.cshtml");
            }
          
        }
    }
}