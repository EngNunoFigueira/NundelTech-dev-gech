using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Getch_website.Models
{
    public class AngariacaoDeProduto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string NomeDoEvento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeRealiacaoDoEvento { get; set; }
        [Required]
        public string HoraDeInicioDoEvento { get; set; }
        [Required]
        public DateTime? DataDeFechoDoEvento { get; set; }

        [Required]
        public string HoraDeFechoDoEvento { get; set; }
        public decimal ToneladasAdquiridas { get; set; }
        public int NumeroDeParticipantes { get; set; }

        #region LIGACOES DE TABELAS
        public virtual Cidade Cidade { get; set; }
        [Required]
        public int CidadeId { get; set; }
        public virtual EstadoDoEventoDeAngariacaoDeProduto EstadoDoEventoDeAngariacaoDeProduto { get; set; }
        [Required]
        public int EstadoDoEventoDeAngariacaoDeProdutoId { get; set; }
        public virtual List<Produto> Produto { get; set; }
        #endregion 
    }

}