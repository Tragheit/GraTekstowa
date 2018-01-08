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

        public void WyświetlImię()
        {
            Silnik.WyświetlInformacje(Imię);
        }

        public virtual void KrzyknijNaPrzeciwnika()
        {
            Silnik.WyświetlInformacje("Przeciwnika to nie rusza...");
        }

        public abstract void WyświetlOpisPostaci();

        public virtual void Walcz(Postać postać) {
            String atakPostaci = Imię + " atakuje " + postać.Imię + " zadając " + obrażeniaPostaci;
            String atakPotwora = postać.Imię + " atakuje " + Imię + " zadając " + postać.obrażeniaPostaci;
            String potwórWygrywa = Imię + " zabija " + postać.Imię;
            String postaćWygrywa = Imię + " zabija " + postać.Imię;

            while (życiePostaci > 0 || postać.życiePostaci > 0)
            {
                Silnik.WyświetlDialogPostaci(atakPostaci);
                postać.życiePostaci -= obrażeniaPostaci;

                if(postać.życiePostaci <= 0) { break; }

                Silnik.WyświetlDialogPotwora(atakPotwora);
                życiePostaci -= postać.obrażeniaPostaci;
            }

            if (życiePostaci > postać.życiePostaci)
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
