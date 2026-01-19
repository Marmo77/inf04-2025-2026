namespace TestyJednostkowe
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void PoprawneWypisanieNazwyGet()
        {
            Bazowa baza = new Bazowa("Nazwa", status.martwy);


            string oczekiwany = "Nazwa";

            string wynik = baza.Nazwa;

            Assert.AreEqual(oczekiwany,wynik);
        }
    }
}
