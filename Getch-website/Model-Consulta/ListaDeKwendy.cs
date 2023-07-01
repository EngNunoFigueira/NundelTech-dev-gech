using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Getch_website.Models;
using System.Web.Mvc;
using Getch_website.My_Classes;
using Getch_website.Model_View;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Model_Consulta
{
    public class ListaDeKwendy
    {
        [Required]
        public int ID { set; get; }
        [Required]
        public byte[] Fotografia { set; get; }
        [Required]
        public byte[] FotocopiaDoc { set; get; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Apelido { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public int Idade { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }
        [Required]
        public string EstadoCivil { get; set; }
        [Required]
        public string NumeroDoDocumento { get; set; }
        [Required]
        public string TipoDocumentoDeIndetidade { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeValidadeDoDocumentoDeIdentidade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeEmissaoDoDocumentoDeIdentidade { get; set; }

        [Required]
        public string Morada { get; set; }
        [Required]
        public string NomeDoBairro { get; set; }
        [Required]
        public string NomeDoMunicipio { get; set; }
        [Required]
        public string NomeDaProvincia { get; set; }
        [Required]
        public string CodigoPostal { get; set; }
        [Required]
        public string NumeroDaPorta { get; set; }
        [Required]
        public string DescricaoDaParticipacao { get; set; }

        #region INFORMACAO DO RESPONSAVEL
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
   
        #endregion
    }
}