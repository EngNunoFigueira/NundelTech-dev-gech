using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class CategoriaDoProduto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int codigo { get; set; }
        [Required]
        public string categoria { get; set; }

        #region LIGAÕES COM OUTRAS TABELAS
        public virtual List<Produto> Produto { get; set; }
        #endregion
    }
}