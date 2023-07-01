using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxProduto
    {
        public static List<GetTodosProdutos> GetProduto()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoProduto = from item in db.Produtos
                                      select new GetTodosProdutos { ID = item.ID, Nome = item.NomeDoproduto };

                    return InfoProduto.ToList();
                }

            }
            catch
            {
                var InfoProduto = new List<GetTodosProdutos> { new GetTodosProdutos { ID = 1, Nome = "Esta informação não está disponível" } };
                return InfoProduto.ToList();
            }
          
        }
        
    }
}