using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class RequisicaoDeProduto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoApadrinhado { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [StringLength(2000)]
        //[RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string Descricao { get; set; }
        [Required]
        public DateTime? DataDeAbertura { get; set; }
        public DateTime? DataDeFecho { get; set; }
        public string artigoA { get; set; }
        public string artigoB { get; set; }
        public string artigoC { get; set; }
        public string artigoD { get; set; }
        public string artigoE { get; set; }

        #region LIGACOES DE TABELAS
        public virtual EstadoDaRequisicao EstadoDaRequisicao { get; set; }
        [Required]
        public int EstadoDaRequisicaoId { get; set; }
        #endregion

    }
}