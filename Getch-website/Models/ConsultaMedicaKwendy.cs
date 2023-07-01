using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Getch_website.Models
{
    public class ConsultaMedicaKwendy
    {
        [Required]
        public int ID { get; set; }

        public string NomeDoMedico_a { get; set; }
        public string ApelidoDoMedico_a { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDaConsulta { get; set; }
        [Required]
        public DateTime? DataDeMarcao { get; set; }
        [Required]
        public string HoraDaConsulta { get; set; }

        #region LIGACOES DE TABELAS

        public virtual NomeDoHospitalOuCentroDeSaude CentroMedicoOuHospital { get; set; }
        [Required]
        public int CentroMedicoOuHospitalId { get; set; }
        //Tipo de Consulta
        public virtual TipoDeConsultaMedica TipoDeConsultaMedica { get; set; }
        [Required]
        public int TipoDeConsultaMedicaId { get; set; }
        //Estado da Consulta
        public virtual EstadoDaConsultaMedica EstadoDaConsultaMedica { get; set; }
        [Required]
        public int EstadoDaConsultaMedicaId { get; set; }
        //Ficha Medica
        public virtual FichaMedicaDoKwendy FichaMedicaDoKwendy { get; set; }
        [Required]
        public int FichaMedicaDoKwendyId { get; set; }
        public virtual List<Medicamento> Medicamento { get; set; }
        #endregion
    }
}