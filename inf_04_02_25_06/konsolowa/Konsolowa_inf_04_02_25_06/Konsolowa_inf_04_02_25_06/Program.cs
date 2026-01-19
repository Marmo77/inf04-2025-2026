
public class Szyfr
{
    public string SzyfrCezara(string tekst, int klucz)
    {
        tekst = tekst.ToLower();
        string zaszyfrowany = string.Empty;

        string alfabet = "abcdefghijklmnopqrstuvwxyz";

        // dla kazdej literki w (str)tekst znajdujemy index w (str)alfabet, przesuwamy o (int)klucz, i dodajemy += do zaszyfrowany.
        for (int i = 0; i < tekst.Length; i++) 
        {
            // znalezienie indexu litery w alfabecie
            int literaIndex = alfabet.IndexOf(tekst[i]);

            // przesuniecie o (int)klucz
            int nowyIndex = (literaIndex + klucz) % alfabet.Length; // modulo ogranicza aby nie wyjsc poza dlugosci alfabetu
            if (nowyIndex < 0) // jesli (int)klucz jest na minusie - to sie cofamy od poczatku alfabetu
            {
                nowyIndex = nowyIndex + alfabet.Length;
            }

            if (tekst[i] == ' ') // jesli jest spacja to nie przesuwamy
            {
                zaszyfrowany += " ";
            }
            else
            {
                zaszyfrowany += alfabet[nowyIndex];
            }
            //Console.WriteLine($"litera: {tekst[i]} , idx: {literaIndex}, nowy idx: {nowyIndex}");
        }

        return zaszyfrowany;
    }
}



class Program
{
    static void Main(string[] args)
    {

        Szyfr cezar = new Szyfr();

        Console.WriteLine("Podaj tekst do zaszyfrowania: ");
        string tekst = Console.ReadLine();
        Console.WriteLine("Podaj klucz do przesunięcia: ");
        int klucz = int.Parse(Console.ReadLine());

        string zaszyfr = cezar.SzyfrCezara(tekst, klucz);
        Console.WriteLine(zaszyfr);
    }
}