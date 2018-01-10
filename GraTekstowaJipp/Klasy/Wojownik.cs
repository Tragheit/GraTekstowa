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
            get { return życiePostaci - 3; }
            set { życiePostaci = value + 3; }
        }

        public override int Obrażenia {
            get { return obrażeniaPostaci - 3; }
            set { obrażeniaPostaci = value + 3; }
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
