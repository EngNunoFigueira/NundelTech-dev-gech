using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Getch_website.Models
{
    public class Apadrinhado
    {
        #region DADOS BASICOS DO BI
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoApadrinhado { get; set; }   

        public byte[] FotocopiaDoc { set; get; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeEntrada { get; set; }

        [Required]
        [Range(0,100)]
        public int NumeroDeFilhos { get; set; }

        [Required]
        [Range(0, 100)]
        public int CriancasACargo { get; set; }
        #endregion

        #region LIGACOES COM OUTRAS TABELAS

        public virtual Estudo Estudo { get; set; }
        [Required]
        public int EstudoId { get; set; }

        public virtual GrauDeParticipacao GrauDeParticipacao { get; set; }
        [Required]
        public int GrauDeParticipacaoId { get; set; }

        public virtual Contacto Contacto { get; set; }
        public virtual BilheteDeIdentidade BilheteDeIdentidade { get; set; }
        public virtual FichaMedicaDoAPadrinhado FichaMedicaDoAPadrinhado { get; set; }
        public virtual List<Kwendy> Kwendy { get; set; }

        #endregion
    }

}