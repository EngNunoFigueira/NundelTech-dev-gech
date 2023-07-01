using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxEstadoDoProdutoEmStock
    {
        public static List<ComboxData> GetEstadoDoProdutoEmStock()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoEstadoDoProdutoEmStock = from item in db.EstadoDoProdutoEmStocks
                                                     select new ComboxData() { ID = item.ID, Codigo = item.Codigo, Descricao = item.Descricao };

                    return InfoEstadoDoProdutoEmStock.ToList();
                }
            }
            catch
            {
                var InfoEstadoDoProdutoEmStock = new List<ComboxData> { new ComboxData { ID=1, Codigo=0, Descricao="Informação não disponível"} };
                return InfoEstadoDoProdutoEmStock.ToList();
            }
           
        }
    }
}