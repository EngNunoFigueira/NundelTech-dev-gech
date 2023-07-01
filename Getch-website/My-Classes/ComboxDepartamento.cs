using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxDepartamento
    {
        public static List<ComboxData> GetDepartamento()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoDepartamento = from item in db.Departamentos
                                           select new ComboxData() { ID = item.ID, Codigo = item.CodigoDepartamento, Descricao = item.Descricao };

                    return InfoDepartamento.ToList();
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