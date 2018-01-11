using System;

namespace GraTekstowaJipp
{
    public class MiksturaLecząca : Mikstura
    {
        private static String nazwa = "Mikstura Lecząca";
        private static String opis = "Ta specjalna mikstura przywraca trochę zdrowia";
       
        public MiksturaLecząca() { }
        public MiksturaLecząca(int wartośćLeczenia) :base(nazwa + wartośćLeczenia, opis, wartośćLeczenia) { }

        public static MiksturaLecząca operator +(MiksturaLecząca miksturaPierwsza, MiksturaLecząca miksturaDruga)
        {
            return new MiksturaLecząca(miksturaPierwsza.wartośćLeczenia + miksturaDruga.wartośćLeczenia);
        }
    }
}
