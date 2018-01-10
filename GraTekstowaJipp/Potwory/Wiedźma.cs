using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Wiedźma : Postać
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

        public Wiedźma() { }
        public Wiedźma(String imię) : base(imię) { }
        ~Wiedźma() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Wiedźma"); }

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Wykrzykujesz zaklęcie, które Cię leczy i wzmacnia obrażenia";
            Silnik.WyświetlDialogPotwora(informacja);
            obrażeniaPostaci += 2;
        }
    }
}
