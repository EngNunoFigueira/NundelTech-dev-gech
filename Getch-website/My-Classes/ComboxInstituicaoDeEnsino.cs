using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxInstituicaoDeEnsino
    {
        public static List<ComboxData> GetInstituicaoDeEnsino()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoInstituicaoDeEnsino = from item in db.InstitDeEnsinos
                                                  select new ComboxData() { ID = item.ID, Codigo = item.Codigo, Descricao = item.Nome };

                    return InfoInstituicaoDeEnsino.ToList();
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