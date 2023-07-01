using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxGraudDeParticipacao
    {
        public static List<ComboxData> GetGraudDeParticipacao()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoGraudDeParticipacao = from item in db.GrauDeParticipacoes
                                                  select new ComboxData() { ID = item.ID, Codigo = item.CodigoParticipacao, Descricao = item.Descricao };

                    return InfoGraudDeParticipacao.ToList();
                }
            }
            catch
            {
                var InfoPorDefeito = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 1, Descricao = "Informação não disponível" } };
                return InfoPorDefeito.ToList();
            }
        }
    }
}