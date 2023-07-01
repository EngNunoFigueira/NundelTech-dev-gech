using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosDaMarcacaoDaConsulta
    {
        [Required]
        [StringLength(9)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string IdKwendy { get; set; }

        [Required]
        public int IdTipoDeConsultaMedica { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDaConsulta { get; set; }

        [Required]
        public string HoraDaConsulta { get; set; }

        [Required]
        public int NomeDoHospitalOuCentroDeSaudeId { get; set; }

        public string NomeDoMedico_a { get; set; }
        public string ApelidoDoMedico_a { get; set; }

        [Required]
        public int EstadoId { get; set; }

        public DateTime DataDeMarcao { get; set; }
    }
}