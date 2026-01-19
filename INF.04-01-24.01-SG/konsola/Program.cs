

class Pesel
{
    private string pesel = string.Empty;

    public string PeselStr { get { return pesel; }}

    public Pesel(string pesel)
    {
        if(string.IsNullOrEmpty(pesel))
        {
            this.pesel = "55030101193";
        }
        else
        {
            this.pesel = pesel;
        }
    }

    // **********************************************************
    // nazwa funkcji:       sprawdzPlec
    // opis funkcji:        funkcja sprawdza plec osoby za pomocą jej pesel'u, dokładniej przedostatnie cyfry (parzysta: kobieta, nieparzysta: mężczyzna)
    // parametry:           pesel - string, podany pesel przez uzytkownika, lub bazowy
    // zwracany typ i opis: char - zwraca 'K' jeśli przedostatnia cyfra jest parzysta, jeśli nie jest to 'M'
    // autor:               00000000000
    // *********************************************************
    public char sprawdzPlec(string pesel) // param. wejsciowy
    {
        char przedostatnia = pesel[pesel.Length-2]; // string 0-10 = 11 cyfr peselu, pesel.Length = 11 - 1 = idx(10) = ostatnia cyfra,
                                                      // wiec pesel.Length - 2 = idx(9) = przedostania cyfra.

        if (Convert.ToInt32(przedostatnia) % 2 == 0) // jeśli parzysta
        {
            return 'K';

        }
        else
        {
            return 'M';
        }
        

    }

    public bool SprawdzSumeKontrolna(string pesel)
    {
        string wagiCyfr = "1379137913";
        int waga = 0;
        for (int i = 0; i < pesel.Length - 1; i++) // wszystkie bez ostatniego elementu
        {
            int nrWagi = int.Parse(wagiCyfr[i].ToString()); // na int przekonwertowac char ktory jest formatowany na string :X
            int nrPeselu = int.Parse(pesel[i].ToString());
            waga += nrWagi * nrPeselu;
        }
        int s = waga;
        int m = s % 10;
        int r;
        if (m == 0)
        {
            r = 0;
        }
        else
        {
            r = 10 - m;
        }
        
        if(r == int.Parse(pesel[pesel.Length - 1].ToString())) // jesli r == ostatnia cyfra peselu
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj numer pesel: \n");
        string pesel = Console.ReadLine();

        Pesel osoba = new Pesel(pesel);

        // plec
        if (osoba.sprawdzPlec(osoba.PeselStr) == 'K')
        {
            Console.WriteLine("Kobieta");
        }
        else
        {
            Console.WriteLine("Mężczyzna");
        }
        // suma kontrolna
        if (osoba.SprawdzSumeKontrolna(osoba.PeselStr))
        {
            Console.WriteLine("Poprawna suma kontrolna");
        }
        else
        {
            Console.WriteLine("Niepoprawna suma kontrolna");
        }
    }
}