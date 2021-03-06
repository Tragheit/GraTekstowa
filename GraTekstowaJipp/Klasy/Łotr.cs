﻿using System;
using System.Collections.Generic;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public class Łotr : Bohater
    {
        private String opis;
        public override int Życie
        {
            get { return życiePostaci - 12; }
            set { życiePostaci = value + 12; }
        }

        public override int Obrażenia
        {
            get { return obrażeniaPostaci - 8; }
            set { obrażeniaPostaci = value + 8; }
        }

        public Łotr() { }
        public Łotr(String imię) : base(imię) { }
        ~Łotr() { }

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Krzyczysz na wroga, wzmacniasz swoje morale, obrażenia rosną o 2.";
            Silnik.WyświetlDialogPostaci(informacja);
            obrażeniaPostaci += 2;
        }

        public override void WyświetlOpisPostaci()
        {
            opis = "Klasa Łotr \n obrażenia:" + obrażeniaPostaci + ", życie:" + życiePostaci +
                "\n Budzi lęk u przeciwnika, co ułatwia mu walkę" + "\n";
            Silnik.WyświetlInformacje(opis);
        }
    }
}
