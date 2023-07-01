using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class DadosDoEventoDeAngariacao
    {
     
        [Required]
        public string NomeDoEvento { get; set; }

        [Required]
        public int IdMunicipio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeRealiacaoDoEvento { get; set; }

        [Required]
        public string HoraDeInicioDoEvento { get; set; }

        public int NumeroDeParticipantes { get; set; }

        [Required]
        public DateTime DataDeFechoDoEvento { get; set; }

        [Required]
        public string HoraDeFechoDoEvento { get; set; }

        public decimal ToneladasAdquiridas { get; set; }

        [Required]
        public string CodigoDoColaboradorGestorDoEvento { get; set; }
        [Required]
        public int EstadoDoEventoDeAngariacaoDeProdutosId { get; set; }

    }
}