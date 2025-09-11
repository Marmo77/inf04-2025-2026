
"""
nazwa klasy: film
pola:   tytul - przechowuje nazwe filmu
        liczba_wypozyczen - przechowuje liczbe wypozyczen
metody: set_tytul, None - ustawia tytul filmu
        get_tytul, str - zwraca tytul filmu
        get_liczba_wypozyczen, int - zwraca liczbe wypożyczeń
        inkrementuj_liczba_wypozyczen, None - inkrementuje liczbę wypożyczeń o 1
informacje: Klasa reprezentuje film w systemie wirtualniej wypożyczalnie
autor: ja
"""

class Film:
    # metody: get,set,increment
    def __init__(self):
        self._tytul = ""
        self._liczba_wypozyczen = 0
        
        
    def set_tytul(self, tytul):
        if len(tytul) <= 20:
            self._tytul = tytul
            print(self._tytul)
        else:
            raise ValueError("Tytul moze miec maksymalnie 20 znaków.")
        
    def get_tytul(self):
        return self._tytul
    
    def get_liczba_wypozyczen(self):
        return self._liczba_wypozyczen
    
    def inkrementuj_liczba_wypozyczen(self):
        self._liczba_wypozyczen += 1
            
film = Film()

print("Poczatkowy tytul:", film.get_tytul())
print("Poczatkowa liczba wypozyczen:", film.get_liczba_wypozyczen())


film.set_tytul("Indiana Johns 3")
print("Tytul po ustawieniu:", film.get_tytul())


# print("Liczba wypozyczen:", film.get_liczba_wypozyczen())
print("Liczba wypozyczen przed inkrementacja:", film.get_liczba_wypozyczen())
film.inkrementuj_liczba_wypozyczen()
print("Liczba wypozyczen po inkrementacji:", film.get_liczba_wypozyczen())