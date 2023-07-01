using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxLocalDeEmissaoDoDocumento
    {
        public static List<ComboxData> GetLocalDeEmissaoDoDocumento()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var filtroLocalDeEmissao = from item in db.InfoDosSitiosDeEmissaoDeDocumentos
                                          select new ComboxData() { ID = item.ID, Codigo = item.CodigDocumento, Descricao = item.Descricao };

                    return filtroLocalDeEmissao.ToList();
                }
            }
            catch
            {
                var filtroLocalDeEmissao = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Informação não disponível" } };

                return filtroLocalDeEmissao.ToList();
            }
        }
    }
}