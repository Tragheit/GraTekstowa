using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Silnik silnik = new Silnik(60, 25);            
            Wojownik janusz = new Wojownik("Janusz");
            Wojownik rysiek = new Wojownik("Rysiek");
            Mag adam = new Mag("Adam");

            rysiek.WyświetlOpisPostaci();
            adam.WyświetlOpisPostaci();
            
            Console.ReadKey();
            Console.Clear();
            rysiek.Walcz(adam);

            
           
            Console.ReadKey();
        }
    }
}
