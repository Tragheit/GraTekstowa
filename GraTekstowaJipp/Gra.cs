using System;
using SilnikGraficzny;

namespace GraTekstowaJipp

{
    class Gra
    {
        private string imięPostaci;

        public void start()
        {
            Silnik silnikGraficzny = new Silnik(60, 25);

            Silnik.WyświetlInformacje("Podaj Swoje Imię: ");
            imięPostaci = Console.ReadLine();

            Silnik.WyświetlInformacje("Wybierz klasę: \n 1. Wojownik \n 2. Mag \n 3. Łotr");
            Silnik.WyświetlInformacje("Aby uzyskać więcej informacji wpisz: 4 + ID Postaci.");

            int decyzja = Console.Read();

            switch (decyzja)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 41:
                    Wojownik wojownik = new Wojownik(imięPostaci);
                    wojownik.WyświetlOpisPostaci();
                    break;
                case 42:
                    Mag mag = new Mag(imięPostaci);
                    mag.WyświetlOpisPostaci();
                    break;
                case 43:
                    Łotr łotr = new Łotr(imięPostaci);
                    łotr.WyświetlOpisPostaci();
                    
                    break;
            
            }
            

        }
        
    }
}
