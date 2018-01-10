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
            get { return życiePostaci - 2; }
            set { życiePostaci = value + 2; }
        }

        public override int Obrażenia
        {
            get { return obrażeniaPostaci - 5; }
            set { obrażeniaPostaci = value + 5; }
        }

        private List<Przedmiot> Ekwipunek = new List<Przedmiot>();

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
