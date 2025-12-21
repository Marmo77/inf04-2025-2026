class Product
{
    string nazwa;
    double cena;
    string kategoria;

    public string Nazwa { get { return nazwa; } set { nazwa = value; } }
    public double Cena { get { return cena; } }

    public Product(string nazwa, double cena, string kategoria)
    {
        this.nazwa = nazwa;
        this.cena = cena;
        this.kategoria = kategoria;
    }

    public void Informacja()
    {
        Console.WriteLine($"Nazwa: {this.nazwa}, Cena: {this.cena}, kategoria: {this.kategoria}");
    }
}


class Customer
{
    string imie;
    string email;

    public string Imie { get { return imie; } }


    public Customer(string imie, string email)
    {
        this.imie = imie;
        this.email = email;
    }

    public void Informacja()
    {
        Console.WriteLine($"Klient: {this.imie}, email: {this.email}");
    }
}

class OrderItem
{
    protected Product produkt;
    protected int ilosc;
    public OrderItem(Product produkt, int ilosc)
    {
        this.produkt = produkt;
        this.ilosc = ilosc;
    }

    public double kosztProduktu { get { return produkt.Cena; } }

    public Product Produkt { get { return produkt; } }
    public string NazwaProduktu { get { return produkt.Nazwa; } }
    public int Ilosc { get { return ilosc; } }

}

class OrderList
{
    Customer klient;
    OrderItem przedmiot;

    public double kosztZakupow = 0;

    List<OrderItem> listaZakupow = new List<OrderItem>();

    public OrderList(Customer klient)
    {
        this.klient = klient;
    }


    public void DodajDoKoszyka(OrderItem nowy_przedmiot)
    {
        listaZakupow.Add(nowy_przedmiot);
        Console.WriteLine($"Dodano do koszyka {klient.Imie}a: {nowy_przedmiot.NazwaProduktu} w ilości: {nowy_przedmiot.Ilosc}");
    }

    public double KosztZamowienia() // zwraca sume + podatek
    {
        if (listaZakupow.Count <= 0) return 0;

        double sumaBezPodatku = 0;
        double sumaZPodatkiem = 0;
        for (int i = 0; i < listaZakupow.Count; i++)
        {
            double kosztProduktu = listaZakupow[i].kosztProduktu * listaZakupow[i].Ilosc;

            sumaBezPodatku += Math.Round(kosztProduktu, 2);
        }
        sumaZPodatkiem = Math.Round(sumaBezPodatku * 1.23, 2);

        //Console.WriteLine($"Całkowity koszt bez podatku: {Math.Round(sumaBezPodatku, 2)}");
        Console.WriteLine($"Całkowity koszt z podatkiem: {sumaZPodatkiem}");
        this.kosztZakupow = sumaZPodatkiem;
        return kosztZakupow;
    }

    public double CzyRabat()
    {
        if(kosztZakupow >= 1000)
        {
            kosztZakupow = kosztZakupow * 0.90;
            Console.WriteLine("Tak, dostałeś rabat -10%.");

            Console.WriteLine($"Aktualny koszt zakupów po rabacie: {kosztZakupow}");
            return kosztZakupow;
        }
        else
        {
            Console.WriteLine("Nie, nie spełniasz wymagań na rabat (min. 1000 zł)");
            Console.WriteLine($"Aktualny koszt zakupów: {kosztZakupow}");
            return kosztZakupow;
        }
    }

}





class Program
{
    static void Main(string[] args)
    {

        // WYPOSAŻENIE SKLEPU
        Product portfel = new Product("portfel LV", 319.99, "galanteria");
        Product mebloscianka = new Product("Mebloscianka Roman", 454.99, "Meble");
        Product telewizor = new Product("Samsung OLED 48cali", 1860.45, "Elektronika");
        Product buty = new Product("Nike AJ 5 High", 799.99, "Obuwie");

        List<Product> produktyWSklepie = new List<Product>([portfel, mebloscianka, telewizor, buty]);
        // Pułka sklepowa
        Console.WriteLine("----------------- PUŁKA SKLEPOWA -----------------");
        for(int i = 0; i < produktyWSklepie.Count; i++)
        {
            produktyWSklepie[i].Informacja();
        }
        Console.WriteLine("--------------------------------------------------");

        // LISTA CO MA KUPIC ANRZEJ
        //List<Product> zakupy_andrzeja = new List<Product>([portfel, mebloscianka, telewizor, buty]);
        //for(int i = 0; i < zakupy_andrzeja.Count; i++)
        //{
        //    zakupy_andrzeja[i].Informacja();
        //}


        // OSOBA W SKLEPIE (KLIENT)

        Customer Andrzej = new Customer("Andrzej", "akmiecik_420@wp.pl");
        Andrzej.Informacja();

        // CO KLIENT WKŁADA DO KOSZYKA (Zakupy na święta)
        OrderItem portfele = new OrderItem(portfel, 2);
        OrderItem telewiozory = new OrderItem(telewizor, 3);
        OrderItem skoki = new OrderItem(buty, 1);

        // KOSZYK ANDRZEJA
        OrderList koszykAndrzeja = new OrderList(Andrzej);
        koszykAndrzeja.DodajDoKoszyka(new OrderItem(portfel, 1)); // 2 warianty dodawania
        koszykAndrzeja.DodajDoKoszyka(portfele);
        //koszykAndrzeja.DodajDoKoszyka(telewiozory);

        Console.WriteLine("Kwota do wydania:");
        koszykAndrzeja.KosztZamowienia();
        // Andrzej pyta o rabat
        Console.WriteLine("--- Czy mogę dostać jakis rabat? ---");
        koszykAndrzeja.CzyRabat();

    }
}