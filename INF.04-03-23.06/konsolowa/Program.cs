
//ARKUSZ:
//https://egzamin-programista.vercel.app/practice/inf04/INF.04-03-23.06-SG/INF.04-03-23.06-SG.pdf


//******************************************************
//    nazwa klasy: Film
//    pola:        tytul - przechowuje nazwe filmu.
//                 liczbaWypozyczne -  przechowuje liczby wypozyczen.

//    metody:  Wypozycz, nic nie zwraca, uzywając funkcji zwiększamy liczbe Wypożyczeń o 1
//    informacje:  
//    autor:       Marmo77 (nie bierz pod uwage)
//*****************************************************
class Film
{
    private string tytul = "";
    private int liczbaWypozyczne = 0;

    public string Tytul {
        get { return tytul; } 
        set { tytul = value;}
    }
    public int LiczbaWypozyczen { 
        get { return liczbaWypozyczne; }
    }


    public void Wypozycz()
    {
        this.liczbaWypozyczne += 1;
    }

}



public class Program
{
    static void Main(string[] args)
    {

        Film film1 = new Film();

        film1.Tytul = "Jak wytresować smoka"; //setter

        Console.WriteLine(film1.Tytul); //getter

        Console.WriteLine($"Liczba wypożyczeń przed metodą: {film1.LiczbaWypozyczen}");
        film1.Wypozycz();
        Console.WriteLine($"Liczba wypożyczeń po metodą: {film1.LiczbaWypozyczen}");

    }
}

// ARKUSZ:
// https://egzamin-programista.vercel.app/practice/inf04/INF.04-03-23.06-SG/INF.04-03-23.06-SG.pdf