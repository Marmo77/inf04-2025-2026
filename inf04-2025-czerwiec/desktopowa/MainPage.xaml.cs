namespace inf04_2025_czerwiec
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void Suwak_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var r_value = (int)SuwakR.Value;
            var g_value = (int)SuwakG.Value;
            var b_value = (int)SuwakB.Value;

            WartoscR.Text = r_value.ToString();
            WartoscG.Text = g_value.ToString();
            WartoscB.Text = b_value.ToString();


            Podglad.Fill = Color.FromRgb(r_value, g_value, b_value);
  
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var r_value = (int)SuwakR.Value;
            var g_value = (int)SuwakG.Value;
            var b_value = (int)SuwakB.Value;

            WartosciPobrane.Text = $"{r_value}, {g_value}, {b_value}";
            WartosciPobrane.BackgroundColor = Color.FromRgb(r_value, g_value, b_value);
        }
    }
}
