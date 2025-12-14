using System;
using System.Collections;
using System.Security.Cryptography;
using System.Xml.Linq;


class LiczbyPodzielneNiepodzielne
{
    // Tablica liczb całkowitych(ma być tradycyjną tablicą, a w Python listą) -> int[]

    // ‒ Liczba elementów tablicy zapisana jako liczba całkowita.Pole
    // przechowuje faktyczną liczbę elementów.Wszystkie operacje
    // są ograniczone wartością tego pola -> przyklad: i < IloscElemTablicy;

    // ‒ Oba pola są dostępne tylko w tej klasie oraz niedostępne dla
    // klas potomnych -> private


    private readonly int IloscElemTablicy;
    private int[] LiczbyTablicy;

    //Konstruktor klasy
    public LiczbyPodzielneNiepodzielne(int rozmiarTablicy) //Przyjmuje jako argument rozmiar tablicy
    {
        //Ustawia wartość pola liczby elementów tablicy na wartość argumentu
        this.IloscElemTablicy = rozmiarTablicy;
        LiczbyTablicy = new int[IloscElemTablicy];


        // Wypełnia tablicę, będącą polem klasy, pseudolosowymi
        // liczbami całkowitymi z zakresu od 1 do 1000
        Random losowa_liczba = new Random();

        for (int i = 0; i < IloscElemTablicy; i++)
        {
            int nowa_liczba = losowa_liczba.Next(1, 1001);
            //Wypełnienie
            LiczbyTablicy[i] = nowa_liczba;
            //Console.WriteLine(LiczbyTablicy[i]);

        }
    }
    // Metody klasy
    public void WyswietlTablice()
    {
        // Wyświetlająca wszystkie elementy tablicy w postaci
        // „< index_tablicy >: < wartość >”. Nie zwraca wartości
        Console.WriteLine("Wszsystkie elementy tablicy:");
        for (int i = 0; i < IloscElemTablicy; i++)
        {
            Console.WriteLine($"{i}: {LiczbyTablicy[i]}");
        }
    }
    
    public int PierwszeWystąpienie(int szukanaLiczba)
    {
        //Wyszukująca pierwsze wystąpienie wartości, przekazanej
        //jako argument. Metoda zwraca indeks szukanego elementu
        //lub liczbę - 1, gdy elementu nie znaleziono

        for (int i = 0; i < IloscElemTablicy; i++)
        {
            if(szukanaLiczba == LiczbyTablicy[i])
            {
                //Console.WriteLine($"Znaleziono na idx: {i}, liczbe: {LiczbyTablicy[i]}");
                Console.WriteLine($"Znaleziono podaną liczbę na indeksie: {i}");
                return i;
            }
            //Console.WriteLine(LiczbyTablicy[i]);
        }

        return -1;
    }
    public int NieparzysteElementy()
    {
        Console.WriteLine("Liczby nieparzyste: ");
        int iloscNieparzystych = 0;
        for (int i = 0; i < IloscElemTablicy; i++)
        {
            if (LiczbyTablicy[i] % 2 != 0)
            {
                Console.WriteLine(LiczbyTablicy[i]);
                iloscNieparzystych++;
            }
        }
        Console.WriteLine($"Razem nieparzystych: {iloscNieparzystych}");
        return iloscNieparzystych;
    }

    public int SredniaArytmetyczna()
    {
        int sumaTablicy = 0;
        int sredniaArytemtyczna;
        for (int i = 0; i < IloscElemTablicy; i++)
        {
            sumaTablicy += LiczbyTablicy[i];
        }

        sredniaArytemtyczna = sumaTablicy / IloscElemTablicy;

        Console.WriteLine($"Średnia wszystkich elementów: {sredniaArytemtyczna}");
        return sredniaArytemtyczna;
    }
}


public class Program
{
    static void Main(string[] args)
    {

        LiczbyPodzielneNiepodzielne tablicaElementow = new LiczbyPodzielneNiepodzielne(35);

        tablicaElementow.WyswietlTablice();

        tablicaElementow.PierwszeWystąpienie(152);

        tablicaElementow.NieparzysteElementy();

        tablicaElementow.SredniaArytmetyczna();
    }
}