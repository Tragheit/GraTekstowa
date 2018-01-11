using System;
using System.Collections.Generic;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public class Wojownik : Bohater
    {

        private String opis;
        public override int Życie
        {
            get { return życiePostaci - 9; }
            set { życiePostaci = value + 9; }
        }

        public override int Obrażenia {
            get { return obrażeniaPostaci - 11; }
            set { obrażeniaPostaci = value + 11; }
        }

        public Wojownik() {}
        public Wojownik(String imię) : base(imię) {}

        public override void WyświetlOpisPostaci()
        {
            opis = "Klasa Wojownik \n obrażenia:" + obrażeniaPostaci + ", życie:" + życiePostaci +
                "\n Znakomicie włada bronią, co pomaga mu w walce" + "\n";
            Silnik.WyświetlInformacje(opis);
        }
    }
}
