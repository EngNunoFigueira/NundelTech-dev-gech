using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Models
{
    public class Padrinho
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoPadrinho { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string Nome { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string Apelido { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ? DataDENascimento { get; set; }

        public DateTime ? DataAdesaoAoPrograma { get; set; }

        #region LIGACOES COM OUTRAS TABELAS
        [Required]
        public virtual Sexo Sexo { get; set; }
        public int IdSexo { get; set; }

        [Required]
        public virtual GrauDeParticipacao GrauDeParticipacao { get; set; }
        public int GrauDeParticipacaoId { get; set; }

        [Required]
        public virtual TipoDePadrinho TipoDePadrinho { get; set; }
        public int TipoDePadrinhoId { get; set; }

        public virtual Morada Morada { get; set; }
        public virtual ContactoDoPadrinho ContactoDoPadrinho { get; set; }

        #endregion

    }
}