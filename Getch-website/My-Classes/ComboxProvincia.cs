using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxProvincia
    {
        public static List<ComboxData> GetProvincia()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoProvincia = from item in db.Provincias
                                        select new ComboxData() { ID = item.ID, Codigo = 0, Descricao = item.Nome };
                    return InfoProvincia.ToList();
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