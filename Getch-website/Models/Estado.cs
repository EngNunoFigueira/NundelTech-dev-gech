using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Getch_website.Models
{
    public class Estado
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public int CodigoEstado { get; set; }
    }
}