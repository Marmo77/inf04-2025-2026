using System;



public class Ksiazka
{
    protected string tytul = "";
    protected string autor = "";
    protected int rok = 0;
    protected int liczbaStron = 0;
    protected bool wypozyczona;

    public Ksiazka(string tytul, string autor, int rok, int liczbaStron)
    {
        this.tytul = tytul;
        this.autor = autor;
        if(2025 > rok && rok > 1000)
        {
            this.rok = rok;
        }
        if (liczbaStron > 0)
        {
            this.liczbaStron = liczbaStron;
        }

        wypozyczona = false;
    }

    public string PobierzTytul()
    {
        return tytul;
    }
    public string PobierzAutora()
    {
        return autor;
    }
    public int PobierzRok()
    {
        return rok;
    }
    public int PobierzLiczbeStron()
    {
        return liczbaStron;
    }
    public bool CzyWypozyczona()
    {
        return wypozyczona;
    }

    public void Wypozycz()
    {
        if (!wypozyczona)
        {
            this.wypozyczona = true;
        }
        else
        {
            Console.WriteLine("Książka jest już wypożyczona");
        }
    }

    public void Zwroc()
    {
        if (wypozyczona)
        {
            this.wypozyczona = false;
        }
        else
        {
            Console.WriteLine("Książka nie była wypożyczona");
        }
    }

    public string PobierzInformacje()
    {
        string status = wypozyczona ? "Wypożyczona" : "Dostępna";
        string informacje = $"Tytuł: {this.tytul}, Autor: {this.autor}, Rok: {this.rok}, Strony: {this.liczbaStron}, Status: {status}";


        return informacje;
    }

    public bool CzyGrubsza(Ksiazka innaKsiazka)
    {
        if(this.liczbaStron > innaKsiazka.liczbaStron)
        {
            return true;
        }
        else
        {
            return true;
        }
    }

}

public class Biblioteka
{

    private Ksiazka[] ksiazki;
    private int LiczbaKsiazek;

    public Biblioteka()
    {
        ksiazki = new Ksiazka[50];
        LiczbaKsiazek = 0;
    }

    public void DodajKsiazke(Ksiazka ksiazka)
    {
        for(int i =0; i< ksiazki.Length; i++)
        {
            if (ksiazki[i] == null)
            {
                //Console.WriteLine("PUSTA na idx" + i);
                ksiazki[i] = ksiazka;
                break;
            }
            else if (i == ksiazki.Length - 1) // jesli idx petli jest na ostatniej pozycji
            {
                Console.WriteLine("Biblioteka jest pełna");
                break;
            }
            
        }
        LiczbaKsiazek++;
    }
    public void WyswietlWszystkieKsiazki()
    {
        Console.WriteLine("------ WSZYSTKIE KSIĄŻKI W BIBLIOTECE -----");
        for (int i = 0; i < LiczbaKsiazek; i++)
        {
                Console.WriteLine($"Index: {i}, Książka: {ksiazki[i].PobierzInformacje()}");
        }
    }
    public void WyswietlDostepneKsiazki()
    {
        Console.WriteLine("------ WSZYSTKIE DOSTĘPNE KSIĄŻKI W BIBLIOTECE -----");
        for (int i = 0; i < LiczbaKsiazek; i++)
        {
            if (!ksiazki[i].CzyWypozyczona())
            {
                Console.WriteLine($"Index: {i}, Książka: {ksiazki[i].PobierzInformacje()}");
            }
        }
    }

    public Ksiazka ZnajdzPoTytule(string tytul)
    {
        for (int i = 0; i < LiczbaKsiazek; i++)
        {
            if(tytul.ToLower() == ksiazki[i].PobierzTytul().ToLower())
            {
                //Console.WriteLine("Znaleziono książke o takim tytule na idx: " + i);
                return ksiazki[i];
            }
        }

        return null;
    }

    public int LiczKsiazkiAutora(string autor)
    {
        int liczbaKsiazekAutora = 0;
        for(int i = 0; i < LiczbaKsiazek; i++)
        {
            if(autor.ToLower() == ksiazki[i].PobierzAutora().ToLower())
            {
                liczbaKsiazekAutora++;
            }
        }
        return liczbaKsiazekAutora;
    }


    public float SredniaLiczbaStron()
    {
        if (LiczbaKsiazek != 0)
        {
            float sredniaKsiazek = 0;
            for (int i = 0; i < LiczbaKsiazek; i++)
            {
                sredniaKsiazek += ksiazki[i].PobierzLiczbeStron();
            }
            return sredniaKsiazek / LiczbaKsiazek;
        }
        else
        {
            return 0;
        }
    }

    public Ksiazka ZnajdzNajgrubsza()
    {
        if (LiczbaKsiazek == 0)
        {
            return null;
        }

        Ksiazka najgrubsza = ksiazki[0];
        for (int i = 1; i < LiczbaKsiazek; i++)
        {
            if (ksiazki[i].PobierzLiczbeStron() > najgrubsza.PobierzLiczbeStron())
            {
                najgrubsza = ksiazki[i];
            }
            //Console.WriteLine($"{i}: {ksiazki[i].PobierzLiczbeStron()}");
        }

        return najgrubsza;
    }

}

public class Program
{
    static void Main(string[] args)
    {

        Ksiazka ksiega1 = new Ksiazka("Mistrz i Małgorzata", "Michaił Bułhakow", 1967, 544);
        Ksiazka ksiega2 = new Ksiazka("Zbrodnia i kara", "Fiodor Dostojewski", 1866, 671);
        Ksiazka ksiega3 = new Ksiazka("Władca Pierścieni", "J.R.R. Tolkien", 1954, 1178);
        Ksiazka ksiega4 = new Ksiazka("1984", "George Orwell", 1949, 328);
        Ksiazka ksiega5 = new Ksiazka("Hobbit", "J.R.R. Tolkien", 1937, 310);

        Biblioteka bibliotekaSzkolna = new Biblioteka();
        ksiega2.Wypozycz();

        Ksiazka[] listaKsiazek = [ksiega1, ksiega2, ksiega3, ksiega4, ksiega5];

        for (int i =0; i < listaKsiazek.Length; i++)
        {
            bibliotekaSzkolna.DodajKsiazke(listaKsiazek[i]);
        }



        bibliotekaSzkolna.WyswietlWszystkieKsiazki();

        bibliotekaSzkolna.WyswietlDostepneKsiazki();

        Console.WriteLine(bibliotekaSzkolna.ZnajdzPoTytule("aDams Palace"));

        Console.WriteLine(bibliotekaSzkolna.LiczKsiazkiAutora("Piotrek"));

        Console.WriteLine(bibliotekaSzkolna.SredniaLiczbaStron());

        bibliotekaSzkolna.ZnajdzNajgrubsza();
    }
}




