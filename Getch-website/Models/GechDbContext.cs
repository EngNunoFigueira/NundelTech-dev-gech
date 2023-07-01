using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Getch_website.Models
{
    public class GechDbContext : DbContext
    {
        public DbSet<Continente> Continentes         { get; set; }
        public DbSet<Pais> Paiss                     { get; set; }
        public DbSet<Provincia> Provincias           { get; set; }
        public DbSet<Municipio> Municipios           { get; set; }
        public DbSet<Bairro> Bairros                 { get; set; }
        public DbSet<TipoDePadrinho> TipoDePadrinhos { get; set; }
       

        #region Dados PADRINHO 27-04-2019 last change 30-05-2021
        public DbSet<Padrinho> Padrinhos                     { get; set; }
        public DbSet<MoradaDoPadrinho> MoradaDoPadrinhos     { get; set; }
        public DbSet<ContactoDoPadrinho> ContactoDoPadrinhos { get; set; }
   
        #endregion


        #region Dados BASICOS
        public DbSet<Apadrinhado> Apadrinhados { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Estudo> Estudos { get; set; }
        public DbSet<GrauDeParticipacao> GrauDeParticipacoes { get; set; }
        #endregion

        #region Dados BI 
        public DbSet<BilheteDeIdentidade> BilheteDeIdentidades { get; set; }
        public DbSet<InfoDosSitiosDeEmissaoDeDocumento> InfoDosSitiosDeEmissaoDeDocumentos { get; set; }
        public DbSet<EstadoCivil> EstadoCivils { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<Morada> Moradas { get; set; }
        #endregion

        #region Dados HISTORICO LABORAL
        public DbSet<HistoricoLaboral> HistoricoLaborals { get; set; }
        public DbSet<EstadoLaboral> EstadoLaborals { get; set; }
        public DbSet<Funcao> Funcaos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        #endregion

        #region Dados MEDICOS
        public DbSet<ConsultaMedica> ConsultaMedicas { get; set; }
        public DbSet<FichaMedicaDoAPadrinhado> FichaMedicaDoAPadrinhados { get; set; }
        public DbSet<TipoDeConsultaMedica> TipoDeConsultaMedicas { get; set; }
        public DbSet<NomeDoHospitalOuCentroDeSaude> NomeDoHospitalOuCentroDeSaudes { get; set; }
        public DbSet<EstadoDaConsultaMedica> EstadoDaConsultaMedicas { get; set; }
        #endregion

        #region Dados PRODUTO
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<GeneroDeProduto> GeneroDeProdutos { get; set; }
        public DbSet<GeneroDoMedicamento> GeneroDoMedicamentos { get; set; }
        public DbSet<CategoriaDoProduto> CategoriaDoProdutos { get; set; }
        public DbSet<EstadoDeConservacaoDoProduto> EstadoDeConservacaoDoProdutos { get; set; }
        #endregion

        #region ANGARIAÇÃO DE PRODUTOS
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<AngariacaoDeProduto> AngariacaoDeProdutos { get; set; }
        #endregion

        #region Dados REQUISICAO
        public DbSet<RequisicaoDeProduto> RequisicaoDeProdutos { get; set; }
        public DbSet<EstadoDaRequisicao> EstadoDaRequisicaos { get; set; }
        #endregion

        #region Dados ARMAZEM
         public DbSet<Armazem> Armazens { get; set; }
        #endregion

        #region KWENDY
        public DbSet<Kwendy> Kwendys { get; set; }
        public DbSet<SituacaoFamiliar> SituacaoFamiliars { get; set; }
        public DbSet<CedulaPessoal> CedulaPessoals { get; set; }
        #endregion
        #region FICHA MEDICA 
        public DbSet<FichaMedicaDoKwendy> FichaMedicaDoKwendys { get; set; }
        public DbSet<ConsultaMedicaKwendy> ConsultaMedicaKwendys { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        #endregion

        #region ACOMPANHAMENTO ESCOLAR
        public DbSet<PlanoCurricular> PlanoCurriculars { get; set; }
        public DbSet<UnidadeCurricular> UnidadeCurriculars { get; set; }
        public DbSet<Aproveitamento> Aproveitamentos { get; set; }
        public DbSet<InstitDeEnsino> InstitDeEnsinos { get; set; }
        public DbSet<NivelDeEnsino> NivelDeEnsinos { get; set; }
        public DbSet<NomeDisciplina> NomeDisciplinas { get; set; }
        #endregion

        #region RECEITA MEDICA
        //public DbSet<KreceitaMedica> KreceitaMedicas { get; set; }
        //public DbSet<KestadoDaReceitaMedica> KestadoDaReceitaMedicas { get; set; }
        ////MEDICACAO
        //public DbSet<kMedicacao> kMedicacaos { get; set; }
        //public DbSet<kMedicamento> kMedicamentos { get; set; }
        //public DbSet<KDoseMedica> KDoseMedicas { get; set; }
        //public DbSet<KResultadoDaMedicao> KResultadoDaMedicaos { get; set; }
        //public DbSet<KestadoDaMedicacao> KestadoDaMedicacaos { get; set; }
        #endregion

        #region  COMBOX
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Alergia> Alergias { get; set; }
        public DbSet<Cirugia> Cirugias { get; set; }
        public DbSet<Fractura> Fracturas { get; set; }
        public DbSet<PaisDeOrigem> PaisDeOrigens { get; set; }
        public DbSet<CicloFormativo> CicloFormativos { get; set; }
        public DbSet<TipoDeDocumento> TipoDeDocumentos { get; set; }
        public DbSet<DoencasHereditaria> DoencasHereditarias { get; set; }
        //public DbSet<UnidadeCurricular> UnidadesCurriculares { get; set; }
        public DbSet<TipoSemestralOuAnual> TipoSemestralOuAnuals { get; set; }
        public DbSet<FiltroParaDadosDosMenor> FiltroParaDadosDosMenors { get; set; }
        public DbSet<FiltroParaDadosPadrinho> FiltroParaDadosPadrinhos { get; set; }
        public DbSet<EstadoDoProdutoEmStock> EstadoDoProdutoEmStocks { get; set; }
        public DbSet<NomeDeUnidadesCurricular> NomeDeUnidadesCurriculares { get; set; }
        public DbSet<FiltrosParaSelecaoDeDadosDeAdulto> FiltrosParaSelecaoDeDadosDeAdultos { get; set; }
        public DbSet<EstadoDoEventoDeAngariacaoDeProduto> EstadoDoEventoDeAngariacaoDeProdutos { get; set; }
       
        #endregion  

    }
}