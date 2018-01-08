using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public abstract class Przedmiot
    {
        private String nazwa;
        private String opis;

        public Przedmiot() { }
        public Przedmiot(String nazwa, String opis)
        {
            this.nazwa = nazwa;
            this.opis = opis;
        }   

        public void WyświetlNazwę()
        {
            Silnik.WyświetlInformacje(nazwa);
        }

        public void WyświetlOpis()
        {
            Silnik.WyświetlInformacje(opis);
        }
    }
}
