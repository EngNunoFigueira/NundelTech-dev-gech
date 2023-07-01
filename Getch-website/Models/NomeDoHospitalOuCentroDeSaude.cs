using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class NomeDoHospitalOuCentroDeSaude
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int CodigoHospital { get; set; }

        #region LIGACOES DE TABELAS
        public virtual List<ConsultaMedica> ConsultasMedicaParaApadrinhado { get; set; }
        #endregion
    }
}