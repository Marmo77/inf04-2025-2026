using System;

//EGZAMIN: https://egzamin-programista.vercel.app/practice/inf04/INF.04-02-23.01-SG/INF.04-02-23.01-SG.pdf


//**********************************************
// klasa: Notatka
// opis: klasa reprezentuje utworzone notatki, ich tytul z trescia, identyfikator, oraz laczna sume utworzonych notatek.
// pola:    licznik_notatek - liczbę łączną utworzonych notatek,
//          identyfiktator - indywidualny idedtyfikator dla każdej notatki,
//          tytul - tytuł notatki,
//          tresc - treść notatki,
// autor: Marmo77
//************************************************
public class Notatka {

    //‒ statyczne numeryczne licznika notatek do zliczania utworzonych notatek
    //‒ numeryczne do zapisu unikalnego identyfikatora
    //‒ dwa tekstowe do zapisu tytułu notatki i treści notatki

    private static int licznik_notatek = 0;
    private int identyfikator; // Dostęp do wszystkich pól jest ograniczony do wnętrza klasy notatka, przy czym pola identyfikatora
    protected string tytul;    // i licznika nie są dostępne dla klas potomnych, a pola tekstowe są dostępne dla klas potomnych
    protected string tresc;


    public Notatka(string tytul, string tresc)
    {
        //ustawić pola tytułu i treści równe parametrom
        this.tytul = tytul;
        this.tresc = tresc;

        // inkrementować licznik notatek
        //‒ ustawić pole identyfikatora równe licznikowi notatek
        licznik_notatek += 1;
        identyfikator = licznik_notatek;

    }


    //Klasa notatka zawiera dwie metody bezparametrowe i niezwracające wartości,

    //metodę wyświetlenia tytułu i treści notatki
    public void wyswietl_notatke()
    {
        Console.WriteLine("-------------- NOTATKA -------------");
        Console.WriteLine($"Tytuł: {this.tytul}\nTreść: \n{this.tresc}"); // lepiej uzywac this.tytul czy tytul ?
        Console.WriteLine("------------------------------------");
    }

    //metodę diagnostyczną wypisującą zawartości wszystkich pól oddzielone od siebie średnikami
    public void diagnostyka_notatki()
    {
        Console.WriteLine("----------- DIAGNOSTYKA ------------");
        Console.WriteLine($"{this.tytul}; {this.tresc}; {this.identyfikator}; {Notatka.licznik_notatek}"); // Notatka. , ponieważ static field
        Console.WriteLine("------------------------------------");
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Program główny powinien zawierać test działania aplikacji polegający na utworzeniu dwóch notatek
        // z dowolnymi(znaczącymi) danymi(źródło danych jest dowolne: stała napisowa, literał lub pobrane
        // z klawiatury) oraz uruchomieniu dla każdej z nich obu metod
        Notatka notatka1 = new Notatka("Kosmici", "Czy kosmici przylecą na ziemie w 2026 roku?");
        Notatka notatka2 = new Notatka("UFC w Polsce", "UFC będzie w Polsce! To znaczy... nie wiem, mam taką nadzieje.");

        notatka1.wyswietl_notatke();
        notatka1.diagnostyka_notatki();

        notatka2.wyswietl_notatke();
        notatka2.diagnostyka_notatki();
    }
}

//EGZAMIN: https://egzamin-programista.vercel.app/practice/inf04/INF.04-02-23.01-SG/INF.04-02-23.01-SG.pdf

