using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Ogr : Postać
    { 
        public override int Życie
        {
            get { return życiePostaci - 3000; }
            set { życiePostaci = value + 3000; }
        }

        public override int Obrażenia
        {
            get { return obrażeniaPostaci - 3000; }
            set { obrażeniaPostaci = value + 3000; }
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
