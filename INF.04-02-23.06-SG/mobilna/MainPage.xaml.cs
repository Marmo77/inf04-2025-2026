namespace INF._04_02_23._06_SG
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void HandleSliderChange(object sender, ValueChangedEventArgs e)
        {
            int RozmiarCzcionki = (int)e.NewValue;
            RozmiarTekstu.Text = $"Rozmiar: {RozmiarCzcionki}";

            Cytaty.FontSize = RozmiarCzcionki;
        }

        private string[] cytatyTablica = ["Dzien dobry", "Good morning", "Buenos dias"];
        private int indeksCytatu = 1;

        private void Button_Clicked(object sender, EventArgs e)
        {


            indeksCytatu = indeksCytatu + 1;
            
            switch (indeksCytatu)
            {
                case 1:
                    Cytaty.Text = cytatyTablica[0];        
                    break;
                case 2:
                    Cytaty.Text = cytatyTablica[1];
                    break;
                case 3:
                    Cytaty.Text = cytatyTablica[2];
                    indeksCytatu = 0;
                    break;
                default:
                    break;

            }

        }
    }
}
