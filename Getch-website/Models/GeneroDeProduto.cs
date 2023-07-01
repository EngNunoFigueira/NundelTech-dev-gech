using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class GeneroDeProduto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int CodigoGenero { get; set; }
        [Required]
        public string Descricao { get; set; }
        #region LIGAÕES COM OUTRAS TABELAS
        public virtual List<Produto> Produto { get; set; }
        #endregion
    }
}