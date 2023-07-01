using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxDocumento
    {
        public static List<ComboxData> GetDocumento()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var filtroTipoDeDocumento = from item in db.TipoDeDocumentos
                                          select new ComboxData() { ID = item.ID, Codigo = item.CodigoDocumento, Descricao = item.Descricao };

                    return filtroTipoDeDocumento.ToList();
                }
            }
            catch
            {
                var filtroTipoDeDocumento = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 1, Descricao = "Informação não disponível" } };

                return filtroTipoDeDocumento.ToList();
            }
        }
    }
}