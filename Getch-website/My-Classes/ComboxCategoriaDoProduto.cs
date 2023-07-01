using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxCategoriaDoProduto
    {
        public static List<ComboxData> GetCategoriaProduto()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoCategoriaProduto = from item in db.CategoriaDoProdutos
                                               select new ComboxData() { ID = item.ID, Codigo = item.codigo, Descricao = item.categoria };

                    return InfoCategoriaProduto.ToList();
                }
            }
            catch
            {
                var InfoCategoriaProduto = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Informação não disponível" } };

                return InfoCategoriaProduto.ToList();
            }
        }
            
    }
}