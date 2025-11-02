namespace inf04_2023_styczen
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void WypiszDane(object sender, EventArgs e)
        {
            string imieUser = imie.Text;
            string nazwiskoUser = nazwisko.Text;

            string wiadomosc = $"Dane użytkownika: {imieUser} {nazwiskoUser}";
            DisplayAlert("Alert", wiadomosc, "OK");
        }
    }
}
