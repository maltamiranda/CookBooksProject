using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBooks.Deposito1
{
    class GestorHStock
    {
        static List<HStock>  historicos = new List<HStock>();

        public static void crearHistorico(String movimiento, int cantidad, String usuario) 
        {
            historicos.Add(new HStock(movimiento, cantidad, usuario, DateTime.Now));
        }

        public static List<HStock> getHistoricos() 
        {
            return historicos;
        }
    }
}
