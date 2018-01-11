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

        public List<Przedmiot> Ekwipunek = new List<Przedmiot>();

        public void WyświetlEkwipunek()
        {

            Silnik.WyświetlInformacje("Ekwipunek: \n");
            foreach (Przedmiot element in Ekwipunek)
            {
                element.WyświetlNazwę();
            }
        }

        public void DodajPrzedmiotDoEkwipunku(Mikstura przedmiot)
        {
            Ekwipunek.Add(przedmiot);
        }

        public void UżyjPrzedmiotu(MiksturaLecząca miksturaLecząca)
        {
            życiePostaci += miksturaLecząca.wartośćLeczenia;
            Silnik.WyświetlInformacje("\n Uleczyłeś się o: " + miksturaLecząca.wartośćLeczenia);
            Ekwipunek.Remove(miksturaLecząca);
        }

        public void UżyjPrzedmiotu(Broń broń)
        {
            obrażeniaPostaci += broń.Obrażenia;
            Silnik.WyświetlInformacje("\n Broń wzmacnia twoje obrażenia o: " + broń.Obrażenia);
        }

        public void UżyjPrzedmiotu(MiksturaWzmocnienia miksturaWzmocnienia)
        {
            życiePostaci += miksturaWzmocnienia.wartośćLeczenia;
            obrażeniaPostaci += miksturaWzmocnienia.wartośćWzmocnienia;
            Silnik.WyświetlInformacje
                ("\n Twoje życie wzrosło o: " + miksturaWzmocnienia.wartośćLeczenia +
                " ,a Twoje obrażenia wzrosły o: " + miksturaWzmocnienia.wartośćWzmocnienia);
            Ekwipunek.Remove(miksturaWzmocnienia);
        }

        public abstract void WyświetlOpisPostaci();
    }
}
