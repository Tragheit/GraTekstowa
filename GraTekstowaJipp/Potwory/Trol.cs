using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Trol : Postać
    {
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

        public Trol() { }
        public Trol(String imię) : base(imię) { }
        ~Trol() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Trol"); }
    }
}
