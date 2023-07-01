using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxBairro
    {
        public static List<ComboxData> GetBairro()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoBairro = from item in db.Bairros
                                     select new ComboxData() { ID = item.ID, Codigo = item.Municipio.ID, Descricao = item.Nome };
                    return InfoBairro.ToList();
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