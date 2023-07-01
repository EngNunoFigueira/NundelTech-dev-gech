using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getch_website.Models
{
    public class Cidade
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual Pais Pais { get; set; }
        public int PaisId { get; set; }

        #region LIGACOES COM OUTRAS TABELAS
        public virtual List<AngariacaoDeProduto> AngariacaoDeProduto { get; set; }
        #endregion
    }
}