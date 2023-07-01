using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public class ComboxSemestralOuAnual
    {
        public static List<ComboxData> GetTipoDisciplinaSemestralOuAnual()
        {
            try
            {
                using (GechDbContext db=new GechDbContext())
                {
                    var InfoTipoDisciplinaSemestralOuAnual = from item in db.TipoSemestralOuAnuals
                                                             select new ComboxData { ID=item.ID, Codigo=item.Codigo, Descricao=item.Descricao};

                    return InfoTipoDisciplinaSemestralOuAnual.ToList();
                }
            }
            catch
            {
                var InfoTipoDisciplinaSemestralOuAnual = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Esta informação não está disponível" } };

                return InfoTipoDisciplinaSemestralOuAnual.ToList();
            }
        }
    }
}