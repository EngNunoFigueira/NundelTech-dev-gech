using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxFracturas
    {
        public static List<ComboxData> GetFractura()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoFractura = from item in db.Fracturas
                                       select new ComboxData { ID = item.ID, Codigo = item.Codigo, Descricao = item.Descricao };
                    return InfoFractura.ToList();
                }
            }
            catch
            {
                var InfoFractura = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Esta informação não está disponível" } };

                return InfoFractura.ToList();
            }
        }
    }
}