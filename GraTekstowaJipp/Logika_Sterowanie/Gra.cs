using System;
using SilnikGraficzny;


namespace GraTekstowaJipp
{
    class Gra
    {
        private string imięPostaci;

        public void Start()
        {
            Silnik silnikGraficzny = new Silnik();
            silnikGraficzny.UstawRozmiarOkna(90, 30);

            WybierzImię();
            Bohater postać = WybierzPostać();

            UruchomWątekPierwszy(postać);
            UruchomWątekDrugi(postać);
            UruchomWątekKońcowy();
    }

        public void WybierzImię()
        {
            Silnik.WyświetlInformacje("Podaj Swoje Imię");
            Silnik.WyświetlWybórDecyzji();
            imięPostaci = Console.ReadLine();
            Console.Clear();
        }

        public Bohater WybierzPostać()
        {
            Silnik.WyświetlInformacje("Wybierz klasę: \n");
            Silnik.WyświetlDostępneOpcje(1, "Wojownik");
            Silnik.WyświetlDostępneOpcje(2, "Mag");
            Silnik.WyświetlDostępneOpcje(3, "Łotr");

            Silnik.WyświetlInformacje("Aby uzyskać więcej informacji wpisz nazwę klasy");
            Silnik.WyświetlInformacje("Wpisz exit, aby wyjść");
            Silnik.WyświetlWybórDecyzji();

            String decyzja = Console.ReadLine();

            switch (decyzja)
            {
                case "1":
                    {
                        Console.Clear();
                        Silnik.WyświetlInformacje("Wybrano Wojownika");
                        return new Wojownik(imięPostaci);
                    }
                case "2":
                    {
                        Console.Clear();
                        Silnik.WyświetlInformacje("Wybrano Maga");
                        return new Mag(imięPostaci);
                    }
                case "3":
                    {
                        Console.Clear();
                        Silnik.WyświetlInformacje("Wybrano Łotra");
                        return new Łotr(imięPostaci);
                    }
                case "wojownik":
                    {
                        Console.Clear();
                        Bohater wojownik = new Wojownik(imięPostaci);
                        wojownik.WyświetlOpisPostaci();
                        wojownik = null;
                        WybierzPostać();
                        return null;
                    }
                case "mag":
                    {
                        Console.Clear();
                        Bohater mag = new Mag(imięPostaci);
                        mag.WyświetlOpisPostaci();
                        mag = null;
                        WybierzPostać();
                        return null;
                    }
                case "łotr":
                    {
                        Console.Clear();
                        Bohater łotr = new Łotr(imięPostaci);
                        łotr.WyświetlOpisPostaci();
                        łotr = null;
                        WybierzPostać();
                        return null;
                    }
                case "exit":
                    {
                        Environment.Exit(0);
                        return null;
                    }
                default:
                    Silnik.WyświetlInformacje("Nieprawidłowa Opcja");
                    System.Threading.Thread.Sleep(1250);
                    Console.Clear();
                    WybierzPostać();
                    return null;
            }
        }

        public void UruchomWątekPierwszy(Bohater postać)
        {

            CzyszczenieEkranu(1500);

            Silnik.WyświetlTekstyFabularne(" Powoli otwierasz oczy... Budzisz się w nieznanej Ci krainie... " +
                "\n Wiesz tylko, że nazywasz się " + imięPostaci + " oraz, że zostałeś wyrzucony z rodzinnej osady.\n");
            Silnik.WyświetlTekstyFabularne("\n Jesteś strasznie głodny, ale w okolicy nie widać żadnej wioski\n" +
                " W oddali zauważasz ogromny las, coś w nim Cię przyciąga....\n Idziesz tam z nadzieją odnalezienia jedzenia.");

            CzyszczenieEkranu(2000);

            Silnik.WyświetlTekstyFabularne(" Docierasz do lasu, z jego głębi dochodzą przerażające dźwięki, ale głód jest silniejszy\n"
                + " Wchodzisz coraz dalej, dookoła robi się ciemno..... \n dźwięki zdają się tutaj być głośniejsze....");

            CzyszczenieEkranu(2000);

            PodejmijDecyzjęWątekPierwszyA();

            Silnik.WyświetlTekstyFabularne(" Czujesz, że coś się zbliża, łapiesz za kij, który leży obok...");

            Silnik.WyświetlTekstyFabularne("\n Zostałeś zaatakowany przez Straszydło, nie masz wyjścia, musisz się bronić\n");
            Straszydło straszydło = new Straszydło("Staszek Straszek");
            postać.Walcz(straszydło);

            CzyszczenieEkranu(2000);
            
            Silnik.WyświetlTekstyFabularne(" Straszydło nie było zbyt groźne, udało Ci się je poknac\n" +
                " Musisz jednak wiedzieć, że w tym lesie może być więcej potworów...");

            CzyszczenieEkranu(2000);

            Silnik.WyświetlTekstyFabularne(" Trafiasz na ścieżkę w lesie... zastanawiasz się dokąd prowadzi\n" +
                " Zwycięstwo nad Straszytłem wzmocniło Twoje morale, ale głód pozostał...\n");

            PodejmijDecyzjęWątekPierwszyB(postać);

            Silnik.WyświetlTekstyFabularne(" Dotarłeś do groty.. przy wejściu znajdujesz resztki jedzenia\n" +
                " Ktoś tutaj niedawno był..... wchodzisz z nadzieją spotkania człowieka");

            CzyszczenieEkranu(2000);

            UruchomWątekDrugi(postać);

        }

        public void UruchomWątekDrugi(Bohater postać)
        {

        }

        public void UruchomWątekKońcowy()
        {

        }

        public void PodejmijDecyzjęWątekPierwszyA()
        {
            Silnik.WyświetlTekstyFabularne(" Co chcesz dalej zrobić?\n\n");
            Silnik.WyświetlDostępneOpcje(1, "Idź głębiej w las, zaspokojenie głodu jest najważniejsze");
            Silnik.WyświetlDostępneOpcje(2, "Wracaj, nie warto ryzykować");
            Silnik.WyświetlWybórDecyzji();

            String decyzja = Console.ReadLine();

            switch (decyzja)
            {
                case "1":
                    Silnik.WyświetlInformacje("Idziesz głębiej w las...");
                    CzyszczenieEkranu(1500);
                    break;

                case "2":
                    Silnik.WyświetlInformacje("To była zła decyzja, uciekając strasznie się męczysz....\n" +
                        " Zabrakło Ci siły na oddychanie..... Umierasz ");
                    System.Threading.Thread.Sleep(4000);
                    Environment.Exit(0);
                    break;

                default:
                    Silnik.WyświetlInformacje("Nieprawidłowa Opcja");
                    CzyszczenieEkranu(1500);
                    PodejmijDecyzjęWątekPierwszyA();
                    break;
            }
        }

        public void PodejmijDecyzjęWątekPierwszyB(Bohater postać) {
            Silnik.WyświetlTekstyFabularne(" Co chcesz dalej zrobić?\n\n");
            Silnik.WyświetlDostępneOpcje(1, "Trzymaj się ścieżki");
            Silnik.WyświetlDostępneOpcje(2, "Idź dalej prosto");
            Silnik.WyświetlWybórDecyzji();

            String decyzja = Console.ReadLine();

            switch (decyzja)
            {
                case "1":
                    Silnik.WyświetlInformacje("Ścieżka zaprowadziła Cię do groty");
                    UruchomWątekDrugi(postać);
                    CzyszczenieEkranu(1500);
                    break;

                case "2":
                    Silnik.WyświetlInformacje("Idziesz dalej prosto pomiędzy drzewami");
                    Silnik.WyświetlTekstyFabularne(" Błądzenie pomiędzy drzewami przynosi efekty...\n" +
                        " Znajdujesz miecz, teraz będziesz mógł sprawniej bronić się przed potworami");
                    Broń miecz = new Broń(2);
                    postać.DodajPrzedmiotDoEkwipunku(miecz);

                    CzyszczenieEkranu(2000);

                    Silnik.WyświetlTekstyFabularne(" Znudziło Cię błądzenie po lesie, postanawiasz wracać na ścieżkę");                    
                    CzyszczenieEkranu(1500);
                    break;

                default:
                    Silnik.WyświetlInformacje("Nieprawidłowa Opcja");
                    CzyszczenieEkranu(1500);
                    PodejmijDecyzjęWątekPierwszyB(postać);
                    break;
            }
        }
            public void CzyszczenieEkranu(int wartość)
            {
            System.Threading.Thread.Sleep(wartość);
            Console.Clear();
        }
    }
}
