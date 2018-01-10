using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Silnik silnik = new Silnik(60, 25);

            Wojownik wojownik = new Wojownik("Janusz");
            Łotr łotr = new Łotr("Piotr");
            Mag mag = new Mag("Adam");
            Straszydło straszydło = new Straszydło("Staszek");

            wojownik.Walcz(straszydło);

            Console.ReadKey();
        }
    }
}
