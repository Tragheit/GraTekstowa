using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Ogr : Postać
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

        public Ogr() { }
        public Ogr(String imię) : base(imię) { }
        ~Ogr() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Ogr"); }

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Ogr wyje w niebo, Twoje życie podwaja się";
            Silnik.WyświetlDialogPotwora(informacja);
            obrażeniaPostaci *= 2;
        }
    }
}
