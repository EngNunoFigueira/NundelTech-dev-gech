using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxArmazem
    {
        public static List<ComboxData> GetNomeDosArmazens()
        {
            try
            {
                using (GechDbContext db =new GechDbContext())
                {
                    var InfoArmazem = from item in db.Armazens
                                      select new ComboxData { ID = item.ID, Codigo = 0, Descricao = item.NomeDoArmazem };

                    return InfoArmazem.ToList();
                }
              
            }
            catch
            {
                var InfoArmazem = new List<ComboxData> { new ComboxData {ID=1,Codigo=0,Descricao="Esta informação não está disponível" } };

                return InfoArmazem.ToList();
            }
           
        }
    }
}