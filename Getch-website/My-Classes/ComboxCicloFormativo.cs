using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxCicloFormativo
    {
        public static List<ComboxData> GetCicloFormativo()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoCicloFormativo = from item in db.CicloFormativos
                                             select new ComboxData() { ID = item.ID, Codigo = item.CodigoCicloFormativo, Descricao = item.Descricao };
                    return InfoCicloFormativo.ToList();
                }
            }
            catch
            {
                var InfoPorDefeito = new List<ComboxData> { new ComboxData { ID=1, Codigo=1, Descricao= "Informação não disponível" } };
                return InfoPorDefeito.ToList();
            }
          

        }
    }
}