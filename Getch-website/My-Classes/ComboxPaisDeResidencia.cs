using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxPaisDeResidencia
    {
        public static List<ComboxData> GetPaisDeResidencial()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoPaisDeOrigem = from item in db.PaisDeOrigens
                                           select new ComboxData { ID = item.ID, Codigo = item.Codigo, Descricao = item.Descricao };

                    return InfoPaisDeOrigem.ToList();
                }
            }
            catch
            {
                var InfoPaisDeOrigem = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 1, Descricao = "Informação não disponíivel" } };
                return InfoPaisDeOrigem.ToList();
            }
        }
    }
}



