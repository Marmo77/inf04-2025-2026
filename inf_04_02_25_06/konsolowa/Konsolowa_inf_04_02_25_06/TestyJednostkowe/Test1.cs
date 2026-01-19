namespace TestyJednostkowe
{
    [TestClass]
    public sealed class TestySzyfru
    {
        [TestMethod]
        public void DanePodstawoweKluczDodatniKluczMniejszyodDlugosci()
        {
            Szyfr szyfr = new Szyfr();

            string tekstWejscie = "abc";
            int kluczWejscie = 3;

            string oczekiwaneWyjscie = "def";

            Assert.AreEqual(oczekiwaneWyjscie,szyfr.SzyfrCezara(tekstWejscie,kluczWejscie));
        }
        [TestMethod]
        public void ZawijanieLiteryPozaDlugoscAlfabetu()
        {
            Szyfr szyfr = new Szyfr();

            string tekstWejscie = "xyz";
            int kluczWejscie = 3;

            string oczekiwaneWyjscie = "abc";

            Assert.AreEqual(oczekiwaneWyjscie, szyfr.SzyfrCezara(tekstWejscie, kluczWejscie));
        }
        [TestMethod]
        public void OdszyfrowanieKluczujemny()
        {
            Szyfr szyfr = new Szyfr();

            string tekstWejscie = "def";
            int kluczWejscie = -3;

            string oczekiwaneWyjscie = "abc";

            Assert.AreEqual(oczekiwaneWyjscie, szyfr.SzyfrCezara(tekstWejscie, kluczWejscie));
        }
        [TestMethod]
        public void KluczWiekszyNizDlugoscAlfabetu()
        {
            Szyfr szyfr = new Szyfr();

            string tekstWejscie = "abc";
            int kluczWejscie = 29;

            string oczekiwaneWyjscie = "def";

            Assert.AreEqual(oczekiwaneWyjscie, szyfr.SzyfrCezara(tekstWejscie, kluczWejscie));
        }
        [TestMethod]
        public void SpacjaWTekscie()
        {
            Szyfr szyfr = new Szyfr();

            string tekstWejscie = "ab cd";
            int kluczWejscie = 2;

            string oczekiwaneWyjscie = "cd ef";

            Assert.AreEqual(oczekiwaneWyjscie, szyfr.SzyfrCezara(tekstWejscie, kluczWejscie));
        }
    }
}
