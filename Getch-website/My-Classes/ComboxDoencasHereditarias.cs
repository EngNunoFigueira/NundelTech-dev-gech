using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxDoencasHereditarias
    {
        public static List<ComboxData> GetDoencasHereditarias()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoDoencasHereditarias = from item in db.DoencasHereditarias
                                       select new ComboxData { ID = item.ID, Codigo = item.Codigo, Descricao = item.Descricao };
                    return InfoDoencasHereditarias.ToList();
                }
            }
            catch
            {
                var InfoDoencasHereditarias = new List<ComboxData> { new ComboxData { ID = 1, Codigo=0, Descricao="Esta informação não está disponível" } };

                return InfoDoencasHereditarias.ToList();
            }
           
        }
    }
}