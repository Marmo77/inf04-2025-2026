using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Desktopowa
{
    public partial class MainPage : ContentPage
    {
        List<string> ImionaKlientow = new List<string> { "Jan", "Bartek", "Marek" };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = ImionaKlientow;
        }


        private void Zaszyfruj(object sender, EventArgs e)
        {
            string kluczString = Klucz.Text;
            string TekstDoSzyfrowania = Tekst.Text.ToLower();
            

            if (string.IsNullOrEmpty(kluczString) || string.IsNullOrEmpty(TekstDoSzyfrowania))
            {
                return;
            }

            int kluczSzyfrowania;
            int.Parse(kluczString);

            if(int.TryParse(kluczString, out int klucz)) // jeśli klucz jest liczba calkowita
            {
                kluczSzyfrowania = klucz;
            }
            else
            {
                kluczSzyfrowania = klucz;
            }

            string alfabet = "abcdefghijklmnopqrstuvwxyz";
            string zaszyfrowany = string.Empty;

            for (int i = 0; i < TekstDoSzyfrowania.Length; i++)
            {
                // znalezienie indexu litery w alfabecie
                int literaIndex = alfabet.IndexOf(TekstDoSzyfrowania[i]);

                // przesuniecie o (int)klucz
                int nowyIndex = (literaIndex + klucz) % alfabet.Length; // modulo ogranicza aby nie wyjsc poza dlugosci alfabetu
                if (nowyIndex < 0) // jesli (int)klucz jest na minusie - to sie cofamy od poczatku alfabetu
                {
                    nowyIndex = nowyIndex + alfabet.Length;
                }

                if (TekstDoSzyfrowania[i] == ' ') // jesli jest spacja to nie przesuwamy
                {
                    zaszyfrowany += " ";
                }
                else
                {
                    zaszyfrowany += alfabet[nowyIndex];
                }
                //Console.WriteLine($"litera: {tekst[i]} , idx: {literaIndex}, nowy idx: {nowyIndex}");
            }

            TekstWyjscie.Text = zaszyfrowany;

        }

        private void ZapiszTekst(object sender, EventArgs e)
        {
            string nazwaPliku = "ZaszyfrowanyTekst.txt";

            string sciezka = Path.Combine(FileSystem.AppDataDirectory, nazwaPliku);

            File.WriteAllTextAsync(sciezka, TekstWyjscie.Text);

            DisplayAlert("Zapisano", $"Plik został zapisany w {sciezka}", "OK");
        }
    }
}
