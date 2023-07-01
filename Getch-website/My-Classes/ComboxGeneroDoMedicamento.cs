using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Getch_website.My_Classes
{
    public static class ComboxGeneroDoMedicamento
    {
        public static List<ComboxData> GetGeneroDoMedicamento()
        {
            using (GechDbContext db = new GechDbContext())
            {
                var InfoGeneroDoMedicamento = from item in db.GeneroDoMedicamentos
                                 select new ComboxData() { ID = item.ID, Codigo = item.CodigoGeneroMedicamento, Descricao = item.Descricao };

                return InfoGeneroDoMedicamento.ToList();
            }
        }
    }
}