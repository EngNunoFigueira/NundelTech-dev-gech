using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosDeRegistoDoApadrinhado
    {
        public byte[] Fotografia { set; get; }
        public byte[] FotocopiaDoc { set; get; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Apelido { get; set; }
        [Required]
        public int  IdSexo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }
        [Required]
        public int IdEstadoCivil { get; set; }
        [Required]
        public string NumeroDoDocumento { get; set; }
        [Required]
        public int IdTipoDocumentoDeIndetidade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeValidadeDoDocumentoDeIdentidade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeEmissaoDoDocumentoDeIdentidade { get; set; }
        [Required]
        public string Morada { get; set; }
        [Required]
        public int IdBairro { get; set; }
        [Required]
        public int IdMunicipio { get; set; }
        [Required]
        public int IdProvincia { get; set; }
        [Required]
        public string CodigoPostal { get; set; }
        [Required]
        public string NumeroDaPorta { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string TelefoneFixo { get; set; }
        [Required]
        public string Telemovel { get; set; }
        [Required]
        public int IdEstudo             { get; set; }
        [Required]
        public int IdEstadoLaboral      { get; set; }
        [Required]
        public int IdFuncao             { get; set; }
        [Required]
        public int IdDepartamento       { get; set; }
        [Required]
        public int IdGrauDeParticipacao { get; set; }
        [Required]
        public int NumeroDeFilhos       { get; set; }
        [Required]
        public int CriancasACargo       { get; set; }
        [Required]
        public int LocalDeEmissaoDoBI   { get; set; }
        [Required]
        public string DescricaoDaParticipacao { get; set; }
    }
}