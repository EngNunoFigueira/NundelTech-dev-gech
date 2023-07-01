using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxEstudo
    {
        public static List<ComboxData> GetEstudo()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoEstudo = from item in db.Estudos
                                     select new ComboxData() { ID = item.ID, Codigo = item.CodigoEstudo, Descricao = item.Descricao };

                    return InfoEstudo.ToList();
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