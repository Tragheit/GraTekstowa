using System;
using SilnikGraficzny;

namespace GraTekstowaJipp
{
    class Straszydło : Postać
    {
        public override int Życie
        {   
            get { return życiePostaci - 4; }
            set { życiePostaci = value + 4; }
        }

        public override int Obrażenia
        {
            get { return obrażeniaPostaci - 1; }
            set { obrażeniaPostaci = value + 1; }
        }

        public Straszydło() { }
        public Straszydło(String imię) : base(imię) { }
        ~Straszydło() { System.Diagnostics.Trace.WriteLine("Wywołano destruktor w klasie Straszydło"); }

        public override void KrzyknijNaPrzeciwnika()
        {
            String informacja = "Straszydło piszczy, ale nie robi to na nikim wrażenia";
            Silnik.WyświetlDialogPotwora(informacja);
        }

        public override void Uciekaj()
        {
            String informacja = "Straszydło znika, walka zakończona";
            Silnik.WyświetlDialogPotwora(informacja);
            życiePostaci = 0;
        }
    }
}
