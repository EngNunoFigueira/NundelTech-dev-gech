using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Getch_website.Models
{
    public class HistoricoLaboral
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(1000)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string RelatorioDeObservacoes { get; set; }

        [Required]
        [Range(0,1000000)]
        public double SalarioMaximoQueTeve { get; set; }

        [Required]
        [Range(0, 1000000)]
        public double SalarioActual { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeInicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeFim { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoApadrinhado { get; set; }
        
        public virtual EstadoLaboral EstadoLaboral { get; set; }
        [Required]
        public int EstadoLaboralId { get; set; }
        public virtual Funcao Funcao { get; set; }
        [Required]
        public int FuncaoId { get; set; }
        public virtual Departamento Departamento { get; set; }
        [Required]
        public int DepartamentoId { get; set; }

    }
}