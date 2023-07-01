using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxNomeDeUC
    {
        public static List<ComboxData> GetNomesDeUCs()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoNomesDeUC = from item in db.NomeDeUnidadesCurriculares
                                        select new ComboxData() { ID = item.ID, Codigo = item.Codigo, Descricao = item.Nome };

                    return InfoNomesDeUC.ToList();
                }
            }
            catch
            {
                var InfoNomesDeUC = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 1, Descricao = "Informação não disponível" } };

                return InfoNomesDeUC.ToList();
            }
        }
    }
}