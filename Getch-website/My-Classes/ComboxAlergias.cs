using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxAlergias
    {
        public static List<ComboxData> GetAlergias()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoAlergias = from item in db.Alergias
                                       select new ComboxData { ID = item.ID, Codigo = item.Codigo, Descricao = item.Descricao };
                    return InfoAlergias.ToList();
                }
            }
            catch
            {
                var InfoAlergias = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Esta informação não está disponível" } };

                return InfoAlergias.ToList();
            }

        }
    }
}