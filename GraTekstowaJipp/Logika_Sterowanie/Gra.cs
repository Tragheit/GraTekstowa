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
                        Bohater wojownikT = new Wojownik(imięPostaci);
                        wojownikT.WyświetlOpisPostaci();
                        wojownikT = null;
                        return WybierzPostać();
                        
                    }
                case "mag":
                    {
                        Console.Clear();
                        Bohater magT = new Mag(imięPostaci);
                        magT.WyświetlOpisPostaci();
                        magT = null;
                        return WybierzPostać();
                    }
                case "łotr":
                    {
                        Console.Clear();
                        Bohater łotrT = new Łotr(imięPostaci);
                        łotrT.WyświetlOpisPostaci();
                        łotrT = null;
                        return WybierzPostać();
                    }

                case "exit":
                    {
                        Environment.Exit(0);
                        return null;
                    }

                default:
                    Silnik.WyświetlInformacje("Nieprawidłowa Opcja");
                    CzyszczenieEkranu(1500);
                    return WybierzPostać();
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

            CzyszczenieEkranu(1500);

            Straszydło straszydło = new Straszydło("Staszek Straszek");

            Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), straszydło.ZwróćObrażenia(), straszydło.ZwróćŻycie());
            postać.Walcz(straszydło);
            Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), straszydło.ZwróćObrażenia(), straszydło.ZwróćŻycie());

            CzyszczenieEkranu(2000);

            Silnik.WyświetlTekstyFabularne(" Straszydło nie było zbyt groźne, udało Ci się je pokonac\n" +
                " Musisz jednak wiedzieć, że w tym lesie może być więcej potworów...");

            CzyszczenieEkranu(2000);

            Silnik.WyświetlTekstyFabularne(" Trafiasz na ścieżkę w lesie... zastanawiasz się dokąd prowadzi\n" +
                " Zwycięstwo nad Straszytłem wzmocniło Twoje morale, ale głód pozostał...\n");

            PodejmijDecyzjęWątekPierwszyB(postać);

            Silnik.WyświetlTekstyFabularne(" Dotarłeś do groty... przy wejściu znajdujesz resztki jedzenia\n" +
                " Ktoś tutaj niedawno był..... wchodzisz z nadzieją spotkania człowieka");

            CzyszczenieEkranu(2000);

            UruchomWątekDrugi(postać);
        }

        public void UruchomWątekDrugi(Bohater postać)
        {
            Silnik.WyświetlTekstyFabularne(" W grocie jest zimno i ciemno.. nie dziwi Cię to wcale\n" +
                " Znalezione przez Ciebie resztki jedzenia dodały Ci trochę sił\n\n"+
                " Twoja przeszłość przestała mieć dla Ciebie znaczenie, w końcu i tak niewiele pamiętasz..\n"
                + " Odkryłeś w sobie potrzebę walki, czujesz, że nie możesz już bez tego żyć\n"
                + " W oddali widać niewielką smugę światła, jakby od pochodni.... Idziesz w jej stronę."
                );

            CzyszczenieEkranu(1500);

            Silnik.WyświetlTekstyFabularne(" Źródło światła okazało się być bliżej niż myślałeś,\n" +
                " Wyglądasz zza roga... ktoś tam jest... to Wiedźma, zmierza w Twoją stronę...\n");
            Silnik.WyświetlInformacje("Zostałeś zaatakowany przez Wiedźmę");

            CzyszczenieEkranu(1500);
            Wiedźma wiedźma = new Wiedźma("Czarna Wdowa");

            Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), wiedźma.ZwróćObrażenia(), wiedźma.ZwróćŻycie());
            postać.Walcz(wiedźma);
            Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), wiedźma.ZwróćObrażenia(), wiedźma.ZwróćŻycie());

            CzyszczenieEkranu(2000);

            Silnik.WyświetlTekstyFabularne(" To nie była prosta walka, jesteś mocno wyczerpany...\n" +
                " Ledwo uszedłeś z życiem, musisz się zregenerować, przy ścianie stoi skrzynka...");

            CzyszczenieEkranu(2000);
            PodejmijDecyzjęWątekDrugiA(postać);
            CzyszczenieEkranu(1500);

            Silnik.WyświetlInformacje("W Twoim ekwipunku pojawiły się nowe przedmioty\n"
                + " Efekt działania mikstur jest stały");

            CzyszczenieEkranu(2000);
            PodejmijDecyzjęWątekDrugiB(postać);
            CzyszczenieEkranu(1500);

            Silnik.WyświetlTekstyFabularne(" W pokoju wiedźmy znajdują się drewniane drzwi...\n"
                + " otwierasz je ostrożnie, wchodzisz do małego słabo oświetlonego pomieszczenia\n"
                + " Nie ma tutaj nic po za tabliczką z napisem \"Odważni Schodami w górę...\"\n"
                + " Nie zastanawiasz się długo, czujesz się bohaterem... \n wspinasz się po schodach");

            CzyszczenieEkranu(1500);

            Silnik.WyświetlTekstyFabularne(" Schody doprowadziły Cię do korytarza...\n"
                + " Możesz iść w lewo lub w prawo..., nie ma innej drogi");

            CzyszczenieEkranu(2000);
            PodejmijDecyzjęWątekDrugiC(postać);
            CzyszczenieEkranu(1500);

            Silnik.WyświetlInformacje("Ta droga wyglada obiecująco");
            CzyszczenieEkranu(1500);

            Silnik.WyświetlTekstyFabularne(" Idziesz dalej prosto... na samym końcu korytarza widzisz drzwi\n"
                + " Jesteś bohaterem, bez wahania je otwierasz i wchodzisz do środka...\n"
                + " Trafiasz na rodzinę troli przy kolacji, modlisz się, żeby to była ich ostatnia wieczerza\n"
                + " Ojciec rodziny biegnie na Ciebie z maczugą...");

            CzyszczenieEkranu(1500);
            Trol trol = new Trol("Trol Internetowy");

            Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), trol.ZwróćObrażenia(), trol.ZwróćŻycie());
            postać.Walcz(trol);
            Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), trol.ZwróćObrażenia(), trol.ZwróćŻycie());

            CzyszczenieEkranu(1500);

            Silnik.WyświetlInformacje("Pokonano Trola");
            Silnik.WyświetlTekstyFabularne(" Rodzina Trola jeszcze przed walką wyszła z pokoju, nie przejmujesz się nimi..\n"
                + " Spoglądasz na maczugę... takiej broni jeszcze nie miałeś, \n ale na własnej skórze poczułeś jej potęgę..\n" 
                + " Podnosisz ją i kierujesz się ku kolejnemu pomieszczeniu...");

            Broń maczuga = new Broń(11);
            postać.UżyjPrzedmiotu(maczuga);

            CzyszczenieEkranu(2000);
            UruchomWątekKońcowy(postać);
        }

        public void UruchomWątekKońcowy(Bohater postać)
        {
            Silnik.WyświetlTekstyFabularne(" To pomieszczenie to ślepy zaułek... nie wyjdziesz stąd\n"
                + " Na Twoje szczęście jest tu pełno jedzenia, ktoś chyba przygotował ucztę...\n i o niej zapomniał...\n");

            CzyszczenieEkranu(1500);

            Silnik.WyświetlTekstyFabularne(" Już planowałeś zasiadać do stołu, aż tu nagle w drzwiach staje Ogromny Golem\n"
                + " Wyraźnie nie podoba mu się fakt, że przeszkodziłeś mu w kolacji...\n"
                + " Jest większy niż wszystkie potwory, które spotkałeś wcześniej \n na swojej drodzę, ale nagroda...\n");

            Golem golem = new Golem("Jakiś Kamień");

            CzyszczenieEkranu(1500);

            Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), golem.ZwróćObrażenia(), golem.ZwróćŻycie());
            postać.Walcz(golem);
            Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), golem.ZwróćObrażenia(), golem.ZwróćŻycie());

            CzyszczenieEkranu(2000);

            Silnik.WyświetlTekstyFabularne(" Nie było łatwo, ale dzięki wcześniejszym decyzjom udało Ci się\n"
                + " Teraz pozostaje tylko usiąść przy stole i rozkoszować się ciepłą strawą...\n");

            Silnik.WyświetlInformacje("Zaspokoiłeś Swój głód..... Misja wypełniona");
            Silnik.WyświetlKomunikatWygrana();

            CzyszczenieEkranu(5000);
            Environment.Exit(0);

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
                    CzyszczenieEkranu(1500);
                    break;

                case "2":
                    Silnik.WyświetlInformacje("Idziesz dalej prosto pomiędzy drzewami");
                    Silnik.WyświetlTekstyFabularne(" Błądzenie pomiędzy drzewami przynosi efekty...\n" +
                        " Znajdujesz miecz, teraz będziesz mógł sprawniej bronić się przed potworami");
                    Broń miecz = new Broń(2);
                    postać.UżyjPrzedmiotu(miecz);

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

        public void PodejmijDecyzjęWątekDrugiA(Bohater postać)
        {
            Silnik.WyświetlTekstyFabularne(" Co chcesz dalej zrobić?\n\n");
            Silnik.WyświetlDostępneOpcje(1, "Przeszukaj skrzynię po prawo");
            Silnik.WyświetlDostępneOpcje(2, "Idź dalej, nie potrzebujesz uzdrowienia");
            Silnik.WyświetlDostępneOpcje(3, "Przeszukaj skrzynię po lewo");
            Silnik.WyświetlWybórDecyzji();

            String decyzja = Console.ReadLine();

            switch (decyzja)
            {
                case "1":
                    {
                        CzyszczenieEkranu(1500);
                        Silnik.WyświetlInformacje("W skrzyni jest pełno składników...\n"
                            + " Wśród nich znajdujesz miksturę leczącą i miksturę wzmocnienia\n");

                        MiksturaLecząca miksturaLecząca = new MiksturaLecząca(10);
                        MiksturaWzmocnienia miksturaWzmocnienia = new MiksturaWzmocnienia(7, 3);
                        postać.DodajPrzedmiotDoEkwipunku(miksturaLecząca);
                        postać.DodajPrzedmiotDoEkwipunku(miksturaWzmocnienia);
                        postać.UżyjPrzedmiotu(miksturaLecząca);
                        postać.UżyjPrzedmiotu(miksturaWzmocnienia);
                        break;
                    }

                case "2":
                    { 
                    CzyszczenieEkranu(1500);
                    Silnik.WyświetlInformacje("To nie był dobry ruch, nie starcza Ci sił na dalszą drogę\n"
                        + " Wykrwawiasz się w komnacie Wiedźmy...");

                    Silnik.WyświetlKomunikatPrzegrana();
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                        break;
                        }
                case "3":
                    {
                        CzyszczenieEkranu(1500);
                        Silnik.WyświetlInformacje("Znajdujesz miksturę leczenia, świetnie");
                        MiksturaLecząca miksturaLecząca = new MiksturaLecząca(10);
                        MiksturaLecząca miksturaLecząca2 = new MiksturaLecząca(5);
                        MiksturaLecząca mix = miksturaLecząca + miksturaLecząca2;

                        postać.UżyjPrzedmiotu(mix);
                        postać.DodajPrzedmiotDoEkwipunku(miksturaLecząca);
                        break;
                    }
                default:
                    Silnik.WyświetlInformacje("Nieprawidłowa Opcja");
                    CzyszczenieEkranu(1500);
                    PodejmijDecyzjęWątekDrugiA(postać);
                    break;
            }
        }

        public void PodejmijDecyzjęWątekDrugiB(Bohater postać) {
            Silnik.WyświetlTekstyFabularne(" Co chcesz dalej zrobić?\n\n");
            Silnik.WyświetlDostępneOpcje(1, "Wypij mikstury");
            Silnik.WyświetlDostępneOpcje(2, "Trzymaj je na później");
            Silnik.WyświetlWybórDecyzji();

            String decyzja = Console.ReadLine();

            switch (decyzja)
            {
                case "1":
                    Silnik.WyświetlInformacje("Mikstury znacznie Cię wzmacniają");                   
                    CzyszczenieEkranu(1500);
                    break;

                case "2":
                    Silnik.WyświetlInformacje("Zza roga wybiega ogromny Ogr.. nie jesteś przygotowany na walkę z nim\n");
                    Ogr ogr = new Ogr("Shrek");

                    Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), ogr.ZwróćObrażenia(), ogr.ZwróćŻycie());
                    postać.Walcz(ogr);
                    Silnik.WyświetlStatystyki(postać.ZwróćObrażenia(), postać.ZwróćŻycie(), ogr.ZwróćObrażenia(), ogr.ZwróćŻycie());

                    Silnik.WyświetlTekstyFabularne(" Robiłeś co mogłeś, ale przeciwnik był za silny..");
                    Silnik.WyświetlKomunikatPrzegrana();
                    Environment.Exit(0);
                    break;

                default:
                    Silnik.WyświetlInformacje("Nieprawidłowa Opcja");
                    CzyszczenieEkranu(1500);
                    PodejmijDecyzjęWątekDrugiB(postać);
                    break;
            }
        }
        public void PodejmijDecyzjęWątekDrugiC(Bohater postać) {
            Silnik.WyświetlTekstyFabularne(" Co chcesz dalej zrobić?\n\n");
            Silnik.WyświetlDostępneOpcje(1, "Idź w prawo");
            Silnik.WyświetlDostępneOpcje(2, "Idź w lewo");
            Silnik.WyświetlWybórDecyzji();

            String decyzja = Console.ReadLine();

            switch (decyzja)
            {
                case "1":
                    Silnik.WyświetlInformacje("Podłoga zaczyna trzeszczeć... zarywa się, spadasz 10 pięter..");
                    Silnik.WyświetlKomunikatPrzegrana();
                    CzyszczenieEkranu(1500);
                    Environment.Exit(0);
                    break;

                case "2":
                    Silnik.WyświetlInformacje("Skręcasz w lewo...");
                    break;

                default:
                    Silnik.WyświetlInformacje("Nieprawidłowa Opcja");
                    CzyszczenieEkranu(1500);
                    PodejmijDecyzjęWątekDrugiB(postać);
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
