using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gra gra = new Gra();
            gra.Start();

            Console.ReadKey();

        }
    }
}
