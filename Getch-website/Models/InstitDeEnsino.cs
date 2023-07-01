using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Getch_website.Models
{
    public class InstitDeEnsino
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        public string Nome { get; set; }

        #region LIGACOES DE TABELAS
        public virtual List<PlanoCurricular> PlanoCurricular { get; set; }
        #endregion
    }
}