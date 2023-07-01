using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class EstadoDeConservacaoDoProduto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int CodigoEstado { get; set; }
        [Required]
        public string Estado { get; set; }

        #region LIGAÕES COM OUTRAS TABELAS
        public virtual List<Produto> Produto { get; set; }
        #endregion
    }
}