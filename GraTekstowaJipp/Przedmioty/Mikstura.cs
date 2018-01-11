using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraTekstowaJipp
{
    public abstract class Mikstura : Przedmiot
    {
        public int wartośćLeczenia;

        public Mikstura() { }
        public Mikstura(String nazwa, String opis, int wartośćLeczenia) : base(nazwa + wartośćLeczenia, opis)
        {
            this.wartośćLeczenia = wartośćLeczenia;
        }
    }
}
