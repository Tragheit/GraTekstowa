using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Ogr : Postać
    {
        private String opis;
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

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Wyjesz w niebo, Twoje życie podwaja się";
            Silnik.WyświetlDialogPotwora(informacja);
            obrażeniaPostaci *= 2;
        }

        public override void WyświetlOpisPostaci()
        {
            opis = "Potwór Ogr \n obrażenia:" + obrażeniaPostaci + ", życie:" + życiePostaci;
            Silnik.WyświetlInformacje(opis);
        }
    }
}
