﻿using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Wiedźma : Postać
    {
        public override int Życie
        {
            get { return życiePostaci - 17; }
            set { życiePostaci = value + 17; }
        }

        public override int Obrażenia
        {
            get { return obrażeniaPostaci - 2; }
            set { obrażeniaPostaci = value + 2; }
        }

        public Wiedźma() { }
        public Wiedźma(String imię) : base(imię) { }
        ~Wiedźma() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Wiedźma"); }

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Wykrzykujesz zaklęcie, które Cię leczy i wzmacnia obrażenia";
            Silnik.WyświetlDialogPotwora(informacja);
            obrażeniaPostaci += 2;
        }
    }
}
