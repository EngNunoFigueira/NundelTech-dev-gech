using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class EstadoDoProdutoEmStock
    {
        [Required]
        public int ID { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}