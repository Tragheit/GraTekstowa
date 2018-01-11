using System;
using System.Collections.Generic;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public class Mag : Bohater
    {

        private String opis;
        public override int Życie
        {
            get { return życiePostaci -162; }
            set { życiePostaci = value + 16; }
        }

        public override int Obrażenia
        {
            get { return obrażeniaPostaci - 6; }
            set { obrażeniaPostaci = value + 6; }
        }

        public Mag() { }
        public Mag(String imię) : base(imię) { }

        public override void WyświetlOpisPostaci()
        {
            opis = "Klasa Mag \n obrażenia:" + obrażeniaPostaci + ", życie:" + życiePostaci +
                "\n Efekty leczące są u niego efektywniejsze" + "\n";
            Silnik.WyświetlInformacje(opis);
        }
    }
}
