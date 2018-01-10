using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraTekstowaJipp
{
    public class MiksturaWzmocnienia : Przedmiot
    {
        private static String nazwa = "Mikstura Wzmocnienia";
        private static String opis = 
            "Ta specjalna mikstura wzmacnia Twoje obrażenia " +"i regeneruje nieco zdrowia";

        public int WartośćWzmocnieniaZdrowia { get; set; }
        public int WartośćWzmocnieniaObrażeń { get; set; }

        public MiksturaWzmocnienia() { }

        public MiksturaWzmocnienia
            (int WZdrowie,int WObrażenia) :base(nazwa + WZdrowie + WObrażenia, opis)
        {
            this.WartośćWzmocnieniaObrażeń = WObrażenia;
            this.WartośćWzmocnieniaZdrowia = WZdrowie;
        }
    }
}
