using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraTekstowaJipp
{
    public class MiksturaLecząca : Przedmiot
    {
        private static String nazwa = "Mikstura Lecząca";
        private static String opis = "Ta specjalna mikstura przywraca trochę zdrowia";
        public int wartośćLeczenia;

        public MiksturaLecząca(int wartośćLeczenia) :base(nazwa + wartośćLeczenia, opis) {
            this.wartośćLeczenia = wartośćLeczenia;
        }
    }
}
