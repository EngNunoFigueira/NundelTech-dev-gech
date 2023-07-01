using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxEstadoDaRequisicao
    {
        public static List<ComboxData> GetEstadoDaRequisicao()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoEstadoDaRequisicao = from item in db.EstadoDaRequisicaos
                                                 select new ComboxData() { ID = item.ID, Codigo = item.codigoEstado, Descricao = item.requisicao };

                    return InfoEstadoDaRequisicao.ToList();
                }
            }
            catch
            {
                var InfoEstadoDaRequisicao = new List<ComboxData> { new ComboxData { ID = 1,Codigo=0, Descricao="Esta informação nãoestá disponível" } };

                return InfoEstadoDaRequisicao.ToList();
            }
        }

    }
}