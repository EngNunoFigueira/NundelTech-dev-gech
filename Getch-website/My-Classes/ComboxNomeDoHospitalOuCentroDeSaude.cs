using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxNomeDoHospitalOuCentroDeSaude
    {
        public static List<ComboxData> GetNomeDoHospitalOuCentroDeSaude()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoNomeDoHospitalOuCentroDeSaude = from item in db.NomeDoHospitalOuCentroDeSaudes
                                                            select new ComboxData() { ID = item.ID, Codigo = item.CodigoHospital, Descricao = item.Nome };

                    return InfoNomeDoHospitalOuCentroDeSaude.ToList();
                }
            }
            catch
            {
                var InfoNomeDoHospitalOuCentroDeSaude = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Esta informação não está disponível" } };
                return InfoNomeDoHospitalOuCentroDeSaude.ToList();
            }
            
        }
    }
}