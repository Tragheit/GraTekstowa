using System;
using System.Collections.Generic;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public class Łotr : Postać
    {
        private String opis;
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

        private List<Przedmiot> Ekwipunek = new List<Przedmiot>();

        public Łotr() { }
        public Łotr(String imię) : base(imię) { }
        ~Łotr() { };

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
            Silnik.WyświetlInformacje("Uleczyłeś się o: " + miksturaLecząca.wartośćLeczenia);
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

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Krzyczysz na wroga, wzmacniasz swoje morale, obrażenia rosną o 2.";
            Silnik.WyświetlDialogPostaci(informacja);
            obrażeniaPostaci += 2;
        }

        public override void WyświetlOpisPostaci()
        {
            opis = "Klasa Łotr \n obrażenia:" + obrażeniaPostaci + ", życie:" + życiePostaci;
            Silnik.WyświetlInformacje(opis);
        }
    }
}
