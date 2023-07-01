using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxMunicipio
    {
        public static List<ComboxData> GetMunicipio()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfotMunicipio = from item in db.Municipios
                                         select new ComboxData() { ID = item.ID, Codigo = 0, Descricao = item.Nome };
                    return InfotMunicipio.ToList();
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