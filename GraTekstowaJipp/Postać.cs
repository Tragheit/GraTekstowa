using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    public abstract class Postać : IWalczący
    {
        private String Imię;
        protected int życiePostaci;
        protected int obrażeniaPostaci;
       
        public abstract int Życie { get; set; }
        public abstract int Obrażenia { get; set; }

        public Postać()
        {
            //domyślne wartości
            Obrażenia = 2;
            Życie = 5;
        }

        public Postać(String Imię) : this(){
            this.Imię = Imię;
        }

        public String ZwróćImię()
        {
            return Imię;
        }

        public int ZwróćObrażenia()
        {
            return obrażeniaPostaci;
        }

        public int ZwróćŻycie()
        {
            return życiePostaci;
        }

        public virtual void KrzyknijNaPrzeciwnika()
        {
            Silnik.WyświetlInformacje("Przeciwnika to nie rusza...");
        }

        public virtual void Walcz(Postać przeciwnik) {
            String atakPostaci = Imię + " atakuje " + przeciwnik.Imię + " zadając " + obrażeniaPostaci;
            String atakPotwora = przeciwnik.Imię + " atakuje " + Imię + " zadając " + przeciwnik.obrażeniaPostaci;
            String potwórWygrywa = Imię + " zwyciężą ";
            String postaćWygrywa = Imię + " zwycięża ";

            while (życiePostaci > 0 || przeciwnik.życiePostaci > 0)
            {
                
                Silnik.WyświetlDialogPostaci(atakPostaci);
                przeciwnik.życiePostaci -= obrażeniaPostaci;
                System.Threading.Thread.Sleep(1500);

                if (przeciwnik is Straszydło && przeciwnik.życiePostaci <= 4)
                { przeciwnik.Uciekaj(); }

                if (przeciwnik.życiePostaci <= 0) { break; }

                Silnik.WyświetlDialogPotwora(atakPotwora);
                życiePostaci -= przeciwnik.obrażeniaPostaci;
                System.Threading.Thread.Sleep(1500);
            }

            if (życiePostaci > przeciwnik.życiePostaci)
            {
                Silnik.WyświetlInformacje(postaćWygrywa);
            } else
            {
                Silnik.WyświetlInformacje(potwórWygrywa);
            }
        }

        public virtual void Uciekaj()
        {
            String informacja = Imię + " ucieka wystraszony";
            Silnik.WyświetlDialogPostaci(informacja);
        }
    }
}
