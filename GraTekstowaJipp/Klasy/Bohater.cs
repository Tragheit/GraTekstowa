using System;
using System.Collections.Generic;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public abstract class Bohater : Postać
    {
        public override int Życie
        {
            get { return życiePostaci - 2; }
            set { życiePostaci = value + 2; }
        }

        public override int Obrażenia
        {
            get { return obrażeniaPostaci - 5; }
            set { obrażeniaPostaci = value + 5; }
        }

        public Bohater() { }
        public Bohater(String imię) : base(imię) {}
        ~Bohater() { }

        private List<Przedmiot> Ekwipunek = new List<Przedmiot>();

        public void WyświetlEkwipunek()
        {

            Silnik.WyświetlInformacje("Ekwipunek: \n");
            foreach (Przedmiot element in Ekwipunek)
            {
                element.WyświetlNazwę();
            }
        }

        public void DodajPrzedmiotDoEkwipunku(Przedmiot przedmiot)
        {
            Ekwipunek.Add(przedmiot);
        }

        public void UżyjPrzedmiotu(MiksturaLecząca miksturaLecząca)
        {
            życiePostaci += miksturaLecząca.wartośćLeczenia;
            Silnik.WyświetlInformacje("Uleczyłeś się o: " + miksturaLecząca.wartośćLeczenia + 3);
            Ekwipunek.Remove(miksturaLecząca);
        }

        public void UżyjPrzedmiotu(Broń broń)
        {
            obrażeniaPostaci += broń.Obrażenia;
            Silnik.WyświetlInformacje("Broń wzmacnia twoje obrażenia o: " + broń.Obrażenia);
        }

        public void UżyjPrzedmiotu(MiksturaWzmocnienia miksturaWzmocnienia)
        {
            życiePostaci += miksturaWzmocnienia.WartośćWzmocnieniaZdrowia;
            obrażeniaPostaci += miksturaWzmocnienia.WartośćWzmocnieniaObrażeń;
            Silnik.WyświetlInformacje
                ("Twoje życie wzrosło o: " + miksturaWzmocnienia.WartośćWzmocnieniaZdrowia +
                ",a Twoje obrażenia wzrosły o: " + miksturaWzmocnienia.WartośćWzmocnieniaObrażeń);
            Ekwipunek.Remove(miksturaWzmocnienia);
        }





        public abstract void WyświetlOpisPostaci();
    }
}
