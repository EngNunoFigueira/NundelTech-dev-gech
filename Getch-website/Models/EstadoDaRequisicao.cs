using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class EstadoDaRequisicao
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int codigoEstado { get; set; }
        [Required]
        public string requisicao { get; set; }

        #region LIGACOES DE TABELAS 
        public virtual List<RequisicaoDeProduto> RequisicaoDeProduto { get; set; }
        #endregion
    }
}