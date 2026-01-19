namespace Desktopowa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void KliknietoOK(object sender, EventArgs e)
        {
            string kolor = "";
            if (koNiebieski.IsChecked == true)
            {
                kolor = koNiebieski.Content.ToString();
            }
            else if (koZielony.IsChecked == true) 
            {
                kolor = koZielony.Content.ToString();
            }
            else if (koPiwne.IsChecked == true)
            {
                kolor = koPiwne.Content.ToString();
            }

            if(!string.IsNullOrEmpty(Imie.Text) || !string.IsNullOrEmpty(Nazwisko.Text))
            {
                DisplayAlert("Zatwierdzono", $"{Imie.Text} {Nazwisko.Text} kolor oczu {kolor}", "OK");
            }
            else
            {
                DisplayAlert("Odrzucono","Wprowadź dane","OK");
            }

        }

        private void ZmianaNumeru(object sender, FocusEventArgs e)
        {
            string nrZdj = NumerZdj.Text;

            if(nrZdj == "111")
            {
                OsobaOdcisk.Source = "a_odcisk.jpg";
                OsobaZdjecie.Source = "a_zdjecie.jpg";
            }
            else if(nrZdj == "222")
            {
                OsobaOdcisk.Source = "b_odcisk.jpg";
                OsobaZdjecie.Source = "b_zdjecie.jpg";
            }
            else if(nrZdj == "333")
            {
                OsobaOdcisk.Source = "c_odcisk.jpg";
                OsobaZdjecie.Source = "c_zdjecie.jpg";
            }
            else
            {
                OsobaOdcisk.Source = "";
                OsobaZdjecie.Source = "";
            }
        }
    }
}
