using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Objetos Buque

            Buque buque1 = new Buque("35899", "BuqueEstrella", "Chile", 10, 5, 4000);
            Buque buque2 = new Buque("35877", "BuqueParaiso", "Argentina", 20, 10, 4500);

            ///Objetos Container

            Container container = new Container(); //Instancia sin valores ingresados
            Container container1 = new Container("0001", "AA1", 100, 100, true, 80, buque1);
            Container container2 = new Container("002", "AA2", 200, 110, true, 85, buque2);
            Container container3 = new Container("003", "AA3", 250, 115, false, 90, buque2);
            Container container4 = new Container("004", "AA4", 200, 120, false, 90, buque1);
        }
    }
}
