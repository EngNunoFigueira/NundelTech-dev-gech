using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxTipoDePadrinho
    {
        public static List<ComboxData> GetTipoDePadrinho()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoTipoDePadrinho = from item in db.TipoDePadrinhos
                                             select new ComboxData { ID = item.ID, Codigo = item.Codigo, Descricao = item.Descricao };

                    return InfoTipoDePadrinho.ToList();
                }

            }
            catch
            {
                var InfoTipoDePadrinho = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 1, Descricao = "Informação não disponível" } };

                return InfoTipoDePadrinho.ToList();
            }
        }
    }
}