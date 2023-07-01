using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxCirugia
    {
        public static List<ComboxData> GetCirugia()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoCirugias = from item in db.Cirugias
                                       select new ComboxData { ID=item.ID, Codigo=item.Codigo, Descricao=item.Descricao};
                    return InfoCirugias.ToList();
                }
            }
            catch
            {
                var InfoCirugia = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Esta informação não está disponível" } };

                return InfoCirugia.ToList();
            }

        }
    }
}