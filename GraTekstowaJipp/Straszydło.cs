using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Straszydło : Postać
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

        public Straszydło() { }
        public Straszydło(String imię) : base(imię) { }

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Twój pisk nie robi wrażenia na przeciwniku";
            Silnik.WyświetlDialogPotwora(informacja);
        }

        public override void Uciekaj()
        {
            String informacja = "Straszydło znika, walka zakończona";
            Silnik.WyświetlDialogPotwora(informacja);
            życiePostaci = 0;
        }

        public override void WyświetlOpisPostaci()
        {
            opis = "Potwór Straszydło \n obrażenia:" + obrażeniaPostaci + ", życie:" + życiePostaci;
            Silnik.WyświetlInformacje(opis);
        }

    }
}
