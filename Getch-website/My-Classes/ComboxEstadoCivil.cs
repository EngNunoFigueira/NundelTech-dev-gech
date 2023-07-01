using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxEstadoCivil
    {
        public static List<ComboxData> GetEstadoCivil()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {

                    var InfoEstadoCivil = from item in db.EstadoCivils
                                          select new ComboxData() { ID = item.ID, Codigo = item.CodigoEstadoCivil, Descricao = item.Descricao };
                    return InfoEstadoCivil.ToList();
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