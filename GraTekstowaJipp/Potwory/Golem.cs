using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Golem : Postać
    {
        public override int Życie
        {
            // ustawic wartosc zycia
            get { return życiePostaci - 3; }
            set { życiePostaci = value + 3; }
        }

        public override int Obrażenia
        {
            //ustawic wartosc obrazen
            get { return obrażeniaPostaci - 3; }
            set { obrażeniaPostaci = value + 3; }
        }

        public Golem() { }
        public Golem(String imię) : base(imię) { }
        ~Golem() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Golem"); }


        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Golem wydaje przerażające odgłosy, jego życie wzrasta o 10";
            Silnik.WyświetlDialogPotwora(informacja);
            życiePostaci += 10;
        }
    }
}
