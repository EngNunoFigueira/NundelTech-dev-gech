using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Getch_website.Models
{
    public class Medicamento
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string medicamento { get; set; }
        [Required]
        public string dose { get; set; }
        [Required]
        public string duracao { get; set; }
        [Required]
        public string recomendacoes { get; set; }

        #region LIGACOES COM OUTRAS TABELAS
        public virtual ConsultaMedicaKwendy ConsultaMedicaKwendy { get; set; }
        [Required]
        public int ConsultaMedicaKwendyId { get; set; }
        #endregion
    }
}