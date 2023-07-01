using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosDeRegistroDoKwendy
    {
        #region BILHETE DE IDENTIDADE DO KWENDY
        [Required]
        public int ID { set; get; }
        [Required]
        public byte[] Fotografia { set; get; }
        [Required]
        public byte[] FotocopiaDoc { set; get;}
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Apelido { get; set; }
        [Required]
        public int Sexo { get; set; }
        [Required]
        public decimal Idade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }
        [Required]
        public int EstadoCivil { get; set; }
        [Required]
        public string NumeroDoDocumento { get; set; }
        [Required]
        public int TipoDocumentoDeIndetidade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeValidadeDoDocumentoDeIdentidade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeEmissaoDoDocumentoDeIdentidade { get; set; }
        [Required]
        public string Morada { get; set; }
        [Required]
        public int NomeDoBairro { get; set; }
        [Required]
        public int NomeDoMunicipio { get; set; }
        [Required]
        public int NomeDaProvincia { get; set; }
        [Required]
        public string CodigoPostal    { get; set; }
        [Required]
        public string NumeroDaPorta   { get; set; }
     
        #endregion

        #region INFORMACAO DO RESPONSAVEL PARA COMPROVAR DADOS
        [Required]
        public string CodigoResponsavel { get; set; }
        [Required]
        public string NomeResponsavel { get; set; }
        [Required]
        public string ApelidoResponsavel { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string TelefonePrimario { get; set; }
        [Required]
        public string TelemovelSecundario { get; set; }
        #endregion

        #region ACOMPANHAMENTO ESOCLAR & DADOS DO PALNO DE ESTUDOS
        [Required]
        public int AnoDeCurso { get; set; }
        [Required]
        public int AnoLectivo { get; set; }
        [Required]
        public int IdCicloFormativo { get; set; }
        [Required]
        public int IdInstituicaoDeEnsino { get; set; }
        [Required]
        public int ClasseQueFrequenta { get; set; }

        #endregion

        #region DADOS DE CONTROLO DO APADRINHADO MENOR DE IDADE
        [Required]
        [StringLength(9)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoKwendy { get; set; }
        [Required]
        public DateTime DataDeEntrada { get; set; }
        [Required]
        public int IdGrauDeParticipacao { get; set; }
        #endregion
    }
}