using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxTipoDeDocumento
    {
        public static List<ComboxData> GetTipoDeDocumento()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var Filtros = from item in db.TipoDeDocumentos
                                  select new ComboxData { ID = item.ID, Codigo = item.CodigoDocumento, Descricao = item.Descricao };
                    return Filtros.ToList();
                }
            }
            catch
            {
                var Filtros = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Esta informação não está disponível" } };

                return Filtros.ToList();
            }

        }

    }
}