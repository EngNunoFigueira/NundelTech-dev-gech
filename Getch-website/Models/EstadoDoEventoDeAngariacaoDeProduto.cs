using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Getch_website.Models
{
    public class EstadoDoEventoDeAngariacaoDeProduto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Evento { get; set; }

        #region LIGAÇÃO COM OUTRAS TABELAS
        public List<AngariacaoDeProduto> AngariacaoDeProduto { get; set; }
        #endregion

    }
}