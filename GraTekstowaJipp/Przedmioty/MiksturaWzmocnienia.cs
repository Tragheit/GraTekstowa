using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraTekstowaJipp
{
    public class MiksturaWzmocnienia : Mikstura
    {
        private static String nazwa = "Mikstura Wzmocnienia";
        private static String opis = 
            "Ta specjalna mikstura wzmacnia Twoje obrażenia " +"i regeneruje nieco zdrowia";

        public int wartośćWzmocnienia;

        public MiksturaWzmocnienia() { }

        public MiksturaWzmocnienia
            (int wartośćLeczenia,int wartośćWzmocnienia) :base(nazwa + wartośćLeczenia + wartośćWzmocnienia, opis, wartośćLeczenia)
        {
            this.wartośćWzmocnienia = wartośćWzmocnienia;
        }
    }
}
