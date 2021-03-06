﻿using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Golem : Postać
    {
        public override int Życie
        {
            get { return życiePostaci - 98; }
            set { życiePostaci = value + 98; }
        }

        public override int Obrażenia
        {
            get { return obrażeniaPostaci - 0; }
            set { obrażeniaPostaci = value + 0; }
        }

        public Golem() { }
        public Golem(String imię) : base(imię) { }
        ~Golem() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Golem"); }


        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Golem wydaje przerażające odgłosy, jego życie wzrasta o 10";
            Silnik.WyświetlDialogPotwora(informacja);
            życiePostaci += 10;
        }
    }
}
