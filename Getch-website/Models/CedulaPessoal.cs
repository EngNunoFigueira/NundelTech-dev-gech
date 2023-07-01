using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Getch_website.Models
{
    public class CedulaPessoal
    {
        [ForeignKey("Kwendy")]
        public int CedulaPessoalId { get; set; }

        #region DADOS BASICOS DA CEDULA PESSOAL
        [Required]
        [StringLength(70)]
        public string Nome { get; set; }
        [Required]
        [StringLength(70)]
        public string Apelido { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeNascimento { get; set; }
        [Required]
        public string NumeroDoDocumento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeEmissaoDoDocumentoDeIdentidade { get; set; }

        //[Required]
        public byte[] Fotografia { set; get; }
        //[Required]
        public byte[] FotocopiaDoc { set; get; }
        #endregion

        #region LIGACOES DE TABELAS
        public virtual Sexo Sexo { get; set; }
        [Required]
        public int SexoId { get; set; }

        public virtual TipoDeDocumento TipoDeDocumento { get; set; }
        [Required]
        public int TipoDeDocumentoId { get; set; }

        public virtual InfoDosSitiosDeEmissaoDeDocumento LocalDeEmissaoDaCedula { get; set; }
        [Required]
        public int LocalDeEmissaoDaCedulaId { get; set; }

        public virtual Kwendy Kwendy { get; set; }
        #endregion
    }
}