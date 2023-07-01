using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosDeRegistoDoPadrinho
    {
        public int ID { get; set; }
        public DateTime DataAdesaoAoPrograma { get; set; }

        [Required]
        [StringLength(50)]
        ///[RegularExpression(@"{[a-zA-Z]")]
        public string Nome { get; set; }

        [Required]
        [StringLength(30)]
        //[RegularExpression(@"[a-zA-Z]")]
        public string Apelido { get; set; }

        [Required]
        public int IdSexo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDENascimento { get; set; }

        [Required]
        public int IdTipoDePadrinho { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; set; }

        public string PaginaWeb { get; set; }
        public string Facebook { get; set; }

        [Required]
        [StringLength(14)]
        [RegularExpression(@"^[0-9]+$")]
        public string TelefonePrimario { get; set; }

        [Required]
        [StringLength(14)]
        [RegularExpression(@"^[0-9]+$")]
        public string TelefoneSecundario { get; set; }

        [StringLength(30)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string Responsavel { get; set; }

        [StringLength(14)]
        [RegularExpression(@"^[0-9]+$")]
        public string TelefoneResponsavel { get; set; }

        [Required]
        public int IdParticipacao { get; set; }

        public Int32 BairroId { get; set; }
        [Required]
        public string RuaAvenida { get; set; }
        [Required]
        public string NumeroDaPorta { get; set; }
        [Required]
        public string CodigoPostal { get; set; }

    }
}