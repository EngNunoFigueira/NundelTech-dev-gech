using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class Aproveitamento
    {
        public int ID { get; set; }
        [Required]
        public int codigo { get; set; }
        [Required]
        public string aproveitamento { get; set; }

        #region LIGACOES DE TABELAS
        public virtual List<UnidadeCurricular> PlanoCurricular { get; set; }
        #endregion
    }
}