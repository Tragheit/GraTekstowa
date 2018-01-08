using System;

namespace GraTekstowaJipp
{
    public class Broń : Przedmiot
    {
        public int Obrażenia { get; set; }
        private static String nazwa = "Miecz";
        private static String opis = "Miecz - wzmacnia twoje obrażenia";

        public Broń(int obrażenia) : base(nazwa + obrażenia, opis)
        {
            this.Obrażenia = obrażenia;
        }
    }
}
