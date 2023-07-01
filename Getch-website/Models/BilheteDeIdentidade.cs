using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Getch_website.Models
{
    public class BilheteDeIdentidade
    {
        [ForeignKey("Apadrinhado")]
        public int BilheteDeIdentidadeId { get; set; }
        public byte[] Fotografia { set; get; }

        #region DADOS BASICOS DO BI
        [Required]
        [StringLength(30)]
        //[RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string Nome { get; set; }
        [Required]
        //[RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string Apelido { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeValidadeDoDocumentoDeIdentidade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeNascimento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeEmissaoDoDocumentoDeIdentidade { get; set; }
        [Required]
        public string NumeroDoDocumento { get; set; }
        #endregion

        #region LIGACOES DE TABELAS
        public virtual Sexo Sexo { get; set; }
        [Required]
        public int SexoId { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        [Required]
        public int EstadoCivilId { get; set; }
        public virtual TipoDeDocumento TipoDocumento { get; set; }
        [Required]
        public int TipoDocumentoId { get; set; }
        public virtual InfoDosSitiosDeEmissaoDeDocumento LocalDeEmissaoDoBI { get; set; }
        [Required]
        public int LocalDeEmissaoDoBiId { get; set; }
        public virtual Morada Morada { get; set; }
        [Required]
        public int MoradaId { get; set; }
        public virtual Apadrinhado Apadrinhado { get; set; }
        #endregion
    }
}