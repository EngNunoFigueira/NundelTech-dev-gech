using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Getch_website.Models
{
    public class Sexo
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int CodigoSexo { get; set; }

        [Required]
        public string Descricao { get; set; }

        #region LIGACOES DE TABELAS
        public virtual List<BilheteDeIdentidade> BilheteIdentidade { get; set; }
        public virtual List<CedulaPessoal> Cedula { get; set; }
        public virtual List<Padrinho> Padrinho { get; set; }
        #endregion
    }
}