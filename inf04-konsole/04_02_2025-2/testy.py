import unittest
from main import SzyfrCezara

class Testy(unittest.TestCase):
    
    def test_klucz_dodatni(self):
        szyfr = SzyfrCezara("abc", 3)
        self.assertEqual(szyfr.Szyfruj(), "def")
        
    def test_zawijanie_tekstu(self):
        szyfr = SzyfrCezara("xyz", 3)
        self.assertEqual(szyfr.Szyfruj(), "abc")
        
    def test_klucz_ujemny(self):
        szyfr = SzyfrCezara("def", -3)
        self.assertEqual(szyfr.Szyfruj(), "abc")
        
    def test_klucz_wiekszy_od_alfabety(self):
        szyfr = SzyfrCezara("abc", 29)
        self.assertEqual(szyfr.Szyfruj(), "def")
        
    def test_spacja_w_tekscie(self):
        szyfr = SzyfrCezara("ab cd", 2)
        self.assertEqual(szyfr.Szyfruj(), "cd ef")
        
        
if __name__ == "__main__":
    unittest.main()