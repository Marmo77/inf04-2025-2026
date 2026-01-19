
//using System;

//class Uzytkownik
//{
//    private string uzytkownik;
//    private string haslo;
//    private bool jestAktywne;

//    public Uzytkownik(string login, string haslo, bool aktywne)
//    {
//        this.uzytkownik = login;
//        this.haslo = haslo;
//        this.jestAktywne = aktywne;
//    }
//    public string PokazLogin { get { return this.uzytkownik; } }
//    public bool Aktywne { get { return this.jestAktywne; } }

//    //public string PokazLogin()
//    //{
//    //    return this.uzytkownik;
//    //}


//    //public bool InformacjeOAktywnosci()
//    //{
//    //    return this.jestAktywne;
//    //}

//    public bool SprawdzPoprawnoscHasla(string haslo)
//    {
//        if (this.haslo == haslo)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }

//    virtual public void PokazUzytkownika()
//    {
//        string aktywne = jestAktywne ? "Konto jest aktywne" : "Konto nie jest aktywne";

//        Console.WriteLine($"Login: {this.uzytkownik}, Aktywność: {aktywne}");
//    }


//}

//class Administrator : Uzytkownik
//{
//    private string rolaAdministratora = string.Empty;

//    public Administrator(string login, string haslo, bool aktywne, string rolaAdministratora) : base(login, haslo, aktywne)
//    {

//        this.rolaAdministratora = rolaAdministratora;

//    }


//    override public void PokazUzytkownika()
//    {
//        string aktywne = Aktywne ? "Konto jest aktywne" : "Konto nie jest aktywne";

//        Console.WriteLine($"Login: {PokazLogin}, Aktywność: {Aktywne}, rola administratora: {rolaAdministratora}");
//    }
//}



//class Program
//{
//    static void Main(string[] args)
//    {

//        //Uzytkownik user1 = new Uzytkownik("Jan21", "Janek2021", true);

//        //Administrator admin1 = new Administrator("AdminKrzys2", "KrzychuPP", true, "Zarządzanie Systemem Baz Danych");

//        //Console.WriteLine("--------------------");
//        //Console.WriteLine(user1.SprawdzPoprawnoscHasla("Janek2115"));
//        //Console.WriteLine(user1.SprawdzPoprawnoscHasla("Janek2021"));
//        //Console.WriteLine("--------------------");

//        //user1.PokazUzytkownika();
//        //Console.WriteLine("--------------------");
//        //admin1.PokazUzytkownika();

//        // komunikacja:

//        Console.WriteLine("---------------");
//        Console.Write("Podaj Login: ");
//        string login = Console.ReadLine();
//        Console.Write("Podaj hasło: ");
//        string haslo = Console.ReadLine();
//        Console.Write("Czy konto ma być aktywne (t/n): ");
//        bool aktywne;
//        if (Console.ReadLine() == "t") {
//            aktywne = true;
//        }
//        else
//        {
//            aktywne = false;
//        };

//        Console.Write("Czy konto ma być administratora? (t/n): ");
//        bool admin;
//        string rolaAdministratora = string.Empty;
//        if (Console.ReadLine() == "t")
//        {
//            admin = true;
//            Console.Write("Rola Admnistratora: ");
//            rolaAdministratora = Console.ReadLine();
//        }
//        else
//        {
//            admin = false;
//        };

//        Uzytkownik Osoba1;

//        if (admin)
//        {
//            Osoba1 = new Administrator(login, haslo, aktywne, rolaAdministratora);
//        }
//        else
//        {
//            Osoba1 = new Uzytkownik(login, haslo, aktywne);
//        }

//        Osoba1.PokazUzytkownika();

//        Console.WriteLine("Podaj hasło ponownie: ");
//        string ponowneHaslo = Console.ReadLine();

//        if (Osoba1.SprawdzPoprawnoscHasla(ponowneHaslo))
//        {
//            Console.WriteLine("Poprawnie Zweryfikowano!");
//        }
//        else
//        {
//            Console.WriteLine("Bledne hasło! blad weryfikacji.");
//        }


//    }
//}


// ZADANIE 1:
//class Egzamin
//{
//    private int[] liczbyCalkowite;
//    private int liczbaElementowTablicy;

//    public Egzamin(int liczbaElementowTablicy)
//    {
//        this.liczbaElementowTablicy = liczbaElementowTablicy;

//        liczbyCalkowite = new int[liczbaElementowTablicy];

//        for (int i = 0; i < liczbaElementowTablicy; i++)
//        {
//            Console.Write($"Podaj liczbę o idx {i}: ");
//            if (int.TryParse(Console.ReadLine(), out int liczba)) // jeśli liczba jest poprawna
//            {
//                liczbyCalkowite[i] = (liczba);
//            }
//            else
//            {
//                liczbyCalkowite[i] = 0; // jeśli nie podano liczby tylko inny waartość
//            }
//        }
//    }

//    public void PokazTablice()
//    {
//        string tablicaStr = "";

//        //Metoda z for:

//        //for(int i = 0; i< liczbaElementowTablicy; i++) 
//        //{
//        //    if(i == liczbaElementowTablicy-1)
//        //    {
//        //        tablicaStr += liczbyCalkowite[i];
//        //    }
//        //    else
//        //    {
//        //        tablicaStr += $"{liczbyCalkowite[i]}, ";
//        //    }
//        //}


//        //Metoda z While:
//        int i = 0;
//        do
//        {
//            if (i == liczbaElementowTablicy - 1)
//            {
//                tablicaStr += liczbyCalkowite[i];
//            }
//            else
//            {
//                tablicaStr += $"{liczbyCalkowite[i]}, ";
//            }

//            i++;
//        } while (i < liczbaElementowTablicy);

//        Console.WriteLine(tablicaStr);
//    }

//    public void Posortuj()
//    {

//        // sorotwanie babelkowe O(n^2)
//        for (int i = 0; i < liczbaElementowTablicy - 1; i++)
//        {
//            for (int j = 0; j < liczbaElementowTablicy - 1 - i; j++)
//            {
//                if (liczbyCalkowite[j] < liczbyCalkowite[j + 1])
//                {
//                    int temp = liczbyCalkowite[i];
//                    liczbyCalkowite[i] = liczbyCalkowite[j + 1];
//                    liczbyCalkowite[j + 1] = temp;
//                }
//            }
//        }
//    }

//    public float ObliczSrednia()
//    {
//        float srednia = 0;
//        foreach (int liczba in liczbyCalkowite)
//        {
//            srednia = (float)liczba;
//        }
//        srednia = srednia / liczbaElementowTablicy;

//        return srednia;
//    }

//    public void ZliczParzysteNieparzyste()
//    {
//        int parzyste = 0;
//        int nieparzyste = 0;
//        foreach (int liczba in liczbyCalkowite)
//        {
//            if (liczba % 2 == 0)
//            {
//                parzyste += 1;
//            }
//            else
//            {
//                nieparzyste += 1;
//            }
//        }
//        Console.WriteLine($"Parzyste: {parzyste}, Nieparzyste: {nieparzyste}");
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Liczba elementów tablicy: ");
//        int liczbaElementow = int.Parse(Console.ReadLine());


//        Egzamin tablicaEgzaminu = new Egzamin(liczbaElementow);

//        tablicaEgzaminu.PokazTablice();

//        tablicaEgzaminu.Posortuj();
//        tablicaEgzaminu.PokazTablice();

//        Console.WriteLine($"Średnia arytmetyczna: {tablicaEgzaminu.ObliczSrednia()}");

//        tablicaEgzaminu.ZliczParzysteNieparzyste();

//    }
//}

// ZADANIE 2:

//public enum status
//{
//    aktywny,
//    spiacy,
//    martwy
//}
//public class Bazowa
//{
//    private string nazwa;
//    private readonly int identyfikator;
//    status status;
//    private static int licznikUtworzonychObiektow;

//    static public void LicznikObietkow()
//    {
//        Console.WriteLine(licznikUtworzonychObiektow);
//    }

//    public Bazowa(string nazwa, status status)
//    {
//        this.nazwa = nazwa;
//        this.status = status;
//        Random nowyId = new Random();
//        this.identyfikator = nowyId.Next();

//        licznikUtworzonychObiektow++;
//    }

//    public string Nazwa { get { return nazwa; } set {nazwa = value; } }
//    public int Identyfikator { get; }
//    public status Status { get; set; }

//    public void Informacje()
//    {
//        Console.WriteLine($"Nazwa: {nazwa}, Identyfikator: {identyfikator}, status: {status}");
//    }

//    public void ZmienStatus(status nowyStatus)
//    {
//        status = nowyStatus;
//        Console.WriteLine("Zmieniono status");
//    }

//    public void Informacje(bool Otwarta)
//    {
//        if (Otwarta)
//        {
//            Console.WriteLine($"{nazwa} jest Otwarta i ma id: {identyfikator}. :D");

//        }
//        else
//        {
//            Console.WriteLine($"niestety {nazwa} jest już zamknieta. :(");
//        }
//    }

//}

//class Program
//{

//    static void Main(string[] args)
//    {
//        Console.WriteLine("dziala");

//        List<Bazowa> obiekty = new List<Bazowa>();

//        obiekty.Add(new Bazowa("Bomba", status.spiacy));
//        obiekty.Add(new Bazowa("Mirasola", status.martwy));
//        obiekty.Add(new Bazowa("Hitman", status.aktywny));

//        Bazowa.LicznikObietkow();


//        foreach(Bazowa o in obiekty)
//        {
//            o.Informacje();
//        }
//    }
//}

// ZADANIE 3:

class Aplikacja
{
    string nazwa;
    int wLiczbowa;

    public Aplikacja(string nazwa, int wLiczbowa)
    {
        this.nazwa = nazwa;
        this.wLiczbowa = wLiczbowa;
    }

    public string Nazwa
    {
        get { return nazwa; }
        set { nazwa = value; }
    }

    public int WLiczbowa
    {
        get { return wLiczbowa; }
        set { wLiczbowa = value; }
    }

   public virtual void Informacje()
    {
        Console.WriteLine($"Nazwa: {nazwa}, wartość liczbowa: {wLiczbowa}");
    }
}

class Aktywowane : Aplikacja
{
    bool jestAktywne;

    public Aktywowane(string nazwa, int wLiczbowa, bool jestAktywne): base(nazwa, wLiczbowa)
    {
        this.jestAktywne = jestAktywne;
    }

    public override void Informacje()
    {
        string czyAktywne = jestAktywne ? "Tak" : "Nie";
        Console.WriteLine($"Nazwa: {Nazwa}, wartość liczbowa: {WLiczbowa}, Aktywne: {czyAktywne}");
    }
}




class Program
{
    int[,] tablica2d = new int[4,2];

    static void Main(string[] args)
    {
        Console.WriteLine("dupa");
        Console.WriteLine("---------------------");



        Console.WriteLine("---------------------");

        Aplikacja ob = new Aplikacja("Nazwa", 4);

        Console.WriteLine(ob.Nazwa);
        Console.WriteLine(ob.WLiczbowa);
        ob.Informacje();

        Aktywowane aktyw = new Aktywowane("nazwa", 24, false);
        Aktywowane aktyw2 = new Aktywowane("nazwa", 24, true);
        aktyw.Informacje();
        aktyw2.Informacje();
    }
}