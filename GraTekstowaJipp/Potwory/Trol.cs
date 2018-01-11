using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Trol : Postać
    {
        public override int Życie
        {
            // ustawic wartosc zycia
            get { return życiePostaci - 25; }
            set { życiePostaci = value + 25; }
        }

        public override int Obrażenia
        {
            //ustawic wartosc obrazen
            get { return obrażeniaPostaci - 8; }
            set { obrażeniaPostaci = value + 8; }
        }

        public Trol() { }
        public Trol(String imię) : base(imię) { }
        ~Trol() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Trol"); }
    }
}
