using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxSexo
    {
        public static List<ComboxData> GetSexo()
        {
            using (GechDbContext db= new GechDbContext())
            {
                try {
                    var InfoSexo = from item in db.Sexos
                                   select new ComboxData() { ID = item.ID, Codigo = item.CodigoSexo, Descricao = item.Descricao };

                    return InfoSexo.ToList();
                }
                catch
                {
                    var InfoSexo = new List<ComboxData>
                    {
                        new ComboxData { ID = 0, Codigo = 1, Descricao = "Masculino" },
                        new ComboxData { ID = 0, Codigo = 1, Descricao = "Femenino" }
                    };

                    return InfoSexo.ToList();
                }
               
          }
        }
    }
}