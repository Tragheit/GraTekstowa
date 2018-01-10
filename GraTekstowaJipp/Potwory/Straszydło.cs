using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Straszydło : Postać
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

        public Straszydło() { }
        public Straszydło(String imię) : base(imię) { }
        ~Straszydło() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Straszydło"); }

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Straszydło piszczy, ale nie robi to na nikim wrażenia";
            Silnik.WyświetlDialogPotwora(informacja);
        }

        public override void Uciekaj()
        {
            String informacja = "Straszydło znika, walka zakończona";
            Silnik.WyświetlDialogPotwora(informacja);
            życiePostaci = 0;
        }
    }
}
