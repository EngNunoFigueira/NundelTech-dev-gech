using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.My_Classes
{
    public static class ComboxEstadoDoEventoDeAngariacaoDeProduto
    {
        public static List<ComboxData> GetEstadoDoEventoDeAngariacaoDeProduto()
        {
            try
            {
                using (GechDbContext db = new GechDbContext())
                {
                    var InfoEstadoDoEventoDeAngariacaoDeProduto = from item in db.EstadoDoEventoDeAngariacaoDeProdutos
                                                                  select new ComboxData() { ID = item.ID, Codigo = item.Codigo, Descricao = item.Evento };

                    return InfoEstadoDoEventoDeAngariacaoDeProduto.ToList();
                }
            }
            catch
            {
                var InfoEstadoDoEventoDeAngariacaoDeProduto = new List<ComboxData> { new ComboxData {ID=1,Codigo=0,Descricao="Informação não disponível" } };

                return InfoEstadoDoEventoDeAngariacaoDeProduto.ToList();
            }
         
        }
    }
}