using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class ConsultaMedica
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoApadrinhado { get; set; }

        public string NomeDoMedico_a { get; set; }
        public string ApelidoDoMedico_a { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDaConsulta { get; set; }
        [Required]
        public DateTime? DataDeMarcao { get; set; }
        [Required]
        public string HoraDaConsulta { get; set; }

        #region LIGACOES COM OUTRAS TABELAS
        public virtual NomeDoHospitalOuCentroDeSaude NomeDoHospitalOuCentroDeSaude { get; set; }
        [Required]
        public int NomeDoHospitalOuCentroDeSaudeId { get; set; }

        public virtual TipoDeConsultaMedica TipoDeConsultaMedica { get; set; }
        [Required]
        public int TipoDeConsultaMedicaId { get; set; }

        public virtual EstadoDaConsultaMedica EstadoDaConsultaMedica { get; set; }
        [Required]
        public int EstadoDaConsultaMedicaId { get; set; }

        public virtual Apadrinhado Apadrinhado { get; set; }
        [Required]
        public int ApadrinhadoId { get; set; }
        #endregion
    }
}