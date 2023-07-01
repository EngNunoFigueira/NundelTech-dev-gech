using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class ListaDeApadrinhados
    {
        public int ID { get; set; }
        public byte[] Fotografia { set; get; }
        public byte[] FotocopiaDoc { set; get; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string NumeroDoDocumento { get; set; }
        public string TipoDocumentoDeIndetidade { get; set; }
        public DateTime DataDeValidadeDoDocumentoDeIdentidade { get; set; }
        public DateTime DataDeEmissaoDoDocumentoDeIdentidade { get; set; }
        public string Morada { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public string NumeroDaPorta { get; set; }
        public string Email { get; set; }
        public string TelefoneFixo { get; set; }
        public string Telemovel { get; set; }
        public string Estudo { get; set; }
        public string EstadoLaboral { get; set; }
        public string Funcao { get; set; }
        public string Departamento { get; set; }
        public string GrauDeParticipacao { get; set; }
        public int NumeroDeFilhos { get; set; }
        public int CriancasACargo { get; set; }
        public string DescricaoDaParticipacao { get; set; }
    }
}