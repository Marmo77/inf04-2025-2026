// ARKUSZ:
// https://egzamin-programista.vercel.app/practice/inf04/INF.04-02-23.06-SG/INF.04-02-23.06-SG.pdf


using System;

public class Sortowanie
{
    public void SortowanieBabelkowe(List<int> tablica)
    {
        string CiagTablicy = "";

        //SORTOWANIE BABELKOWE
        for (int i = 0; i < tablica.Count; i++)
        {
            //Console.WriteLine(tablica[i]);
            for (int j = 0; j < tablica.Count -1; j++)
            {
                if (tablica[j] > tablica[j + 1]) // jeśli < to sorotwanie malejace by bylo
                {
                    //Console.WriteLine(tablica[j] + " > " + tablica[j+1]);
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                }
            }
        }
        // WYPISZ PO PRZECINKU
        for (int i = 0; i < tablica.Count; i++)
        {
            if (i == tablica.Count - 1) // ostatni element nie ma , na koncu
            {
                CiagTablicy += $"{tablica[i].ToString()}";
            }
            else
            {
                CiagTablicy += $"{tablica[i].ToString()}, ";
            }
        }
        Console.WriteLine(CiagTablicy);
    }
}


public class Program
{
    static void Main(string[] args)
    {
        List<int> LosoweLiczby = new List<int>();
        Random ran_num = new Random();

        for (int i = 0; i < 100; i++)
        {
            //LosoweLiczby.Add(ran_num.Next(1,101)); // ! Na egzaminie nie ma określonego range'a.
            LosoweLiczby.Add(ran_num.Next());
        }

        Sortowanie algorytmSortowania = new Sortowanie();

        Console.WriteLine("---- POSORTOWANA TABLICA ----");
        algorytmSortowania.SortowanieBabelkowe(LosoweLiczby);
    }
}




// ARKUSZ:
// https://egzamin-programista.vercel.app/practice/inf04/INF.04-02-23.06-SG/INF.04-02-23.06-SG.pdf
// Marmo77