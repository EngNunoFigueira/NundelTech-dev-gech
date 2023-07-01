using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxFuncao
    {
        public static List<ComboxData> GetFuncao()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoFuncao = from item in db.Funcaos
                                     select new ComboxData() { ID = item.ID, Codigo = item.CodigoFuncao, Descricao = item.Descricao };

                    return InfoFuncao.ToList();
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