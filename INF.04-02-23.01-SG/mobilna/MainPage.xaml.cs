using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Notes { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Notes = new ObservableCollection<string>
            {
                "Zakupy: chleb, masło, ser",
                "Do zrobienia: obiad, umyć podłogi",
                "weekend: kino, parking",
                "spacer z psem",
            };

            BindingContext = this;
        }

        private void DopiszDoListy(object sender, EventArgs e)
        {

            string notatka = TrescNotatki.Text;

            if (!string.IsNullOrEmpty(notatka) )
            {
                Notes.Add(notatka);
                TrescNotatki.Text = "";
            }

            //    Notes.Add(notatka);

            //    TrescNotatki.Text = "";

            //    string notatki = "";

            //    for (int i=0; i < Notes.Count; i++)
            //    {
            //        notatki += $" | {Notes[i]}";
            //    }

            //    DisplayAlert("HEJ", notatki, "Cancel");

        }
    }
}
