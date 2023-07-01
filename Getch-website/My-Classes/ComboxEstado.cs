using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxEstado
    {
        public static List<ComboxData> GetEstado()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {

                    var InfoEstado = from item in db.Estados
                                     select new ComboxData() { ID = item.ID, Codigo = item.CodigoEstado, Descricao = item.Descricao };

                    return InfoEstado.ToList();
                }
            }
            catch
            {
                var InfoEstado = new List<ComboxData> { new ComboxData { ID=1, Codigo=0, Descricao="Esta informação não está disponível"} };

                return InfoEstado.ToList();
            }
           
        }
    }
}