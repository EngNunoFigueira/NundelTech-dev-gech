using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Getch_website.My_Classes
{
    public class ComboxAplicarFiltrosListaAdultos
    {
        public static List<ComboxData> GetFiltrosListaAdultos()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var FiltrosAdultos = from item in db.FiltrosParaSelecaoDeDadosDeAdultos
                                       select new ComboxData { ID = item.ID, Codigo = item.Codigo, Descricao = item.Descricao };
                    return FiltrosAdultos.ToList();
                }
            }
            catch
            {
                var FiltrosAdultos = new List<ComboxData> { new ComboxData { ID = 1, Codigo = 0, Descricao = "Esta informação não está disponível" } };

                return FiltrosAdultos.ToList();
            }
        }
    
    }
}