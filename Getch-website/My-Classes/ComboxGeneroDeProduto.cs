using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxGeneroDeProduto
    {
        public static List<ComboxData> GetGeneroDeProduto()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoGeneroDeProduto = from item in db.GeneroDeProdutos
                                              select new ComboxData() { ID = item.ID, Codigo = item.CodigoGenero, Descricao = item.Descricao };

                    return InfoGeneroDeProduto.ToList();
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