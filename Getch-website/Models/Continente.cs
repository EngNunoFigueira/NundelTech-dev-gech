using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getch_website.Models
{
    public class Continente
    {
        public int ID { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual List<Pais> Pais { get; set; }
    }
}