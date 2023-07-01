using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Getch_website.Models;

namespace Getch_website.My_Classes
{
    public static class ComboxEstadoDeConservacaoDoProduto
    {
        public static List<ComboxData> GetEstadoDeConservacaoDoProduto()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoEstadoDeConservacaoDoProduto = from item in db.EstadoDeConservacaoDoProdutos
                                                           select new ComboxData() { ID = item.ID, Codigo = item.CodigoEstado, Descricao = item.Estado };

                    return InfoEstadoDeConservacaoDoProduto.ToList();
                }
            }
            catch
            {
                var InfoEstadoDeConservacaoDoProduto = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "" } };

                return InfoEstadoDeConservacaoDoProduto.ToList();
            }
        }
    }
}