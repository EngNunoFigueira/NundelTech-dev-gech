using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxTipoDeConsultaMedica
    {
        public static List<ComboxData> GetTipoDeConsultaMedica()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoTipoDeConsultaMedica = from item in db.TipoDeConsultaMedicas
                                                   select new ComboxData { ID = item.ID, Codigo = item.CodigoConsultaMedica, Descricao = item.Descricao };

                    return InfoTipoDeConsultaMedica.ToList();
                }
                    
            }
            catch
            {
                var InfoTipoDeConsultaMedica = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Esta informação não está disponível" } };

                return InfoTipoDeConsultaMedica.ToList();
            }
        }

    }
}