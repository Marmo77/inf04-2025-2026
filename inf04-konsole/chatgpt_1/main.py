#EGZAMIN INF04 - WARIANT 1
#Część I. Aplikacja konsolowa
#Napisz program implementujący algorytm wyszukiwania liniowego w tablicy liczb całkowitych.
#Założenia do programu:

#   Program wykonywany w konsoli
#Obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym, jeden z: C++, C#, Java, Python
#Wyszukiwanie odbywa się w tablicy 50 pseudolosowych liczb całkowitych z zakresu od 1 do 100
#Program nie wykorzystuje gotowych funkcji do wyszukiwania
#Wyszukiwana wartość jest pobierana od użytkownika
#Program wyświetla:

#   Zawartość całej tablicy, oddzieloną spacjami, poprzedzoną komunikatem
#Wszystkie pozycje (indeksy), na których znaleziono szukaną wartość
#Jeśli wartość nie zostanie znaleziona, wyświetlany jest odpowiedni komunikat


#   Wyszukiwanie odbywa się w funkcji, której argumentami są tablica i szukana wartość, funkcja zwraca tablicę pozycji lub listę pozycji
#Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych i funkcji
#Program główny powinien zawierać test działania funkcji wyszukującej

import random

class LinioweWyszukiwanie:  
      
    def szukanie(self, tablica, szukana_liczba):
        self.tablica = tablica
        self.szukana_liczba = szukana_liczba
        
        print("Tablica: ",self.tablica)
        
        lista_pozycji = []
        for idx, liczba in enumerate(self.tablica):
            
            if self.szukana_liczba == self.tablica[idx]:
                # print(f"Znaleziono liczbę na indexie: {idx}")
                lista_pozycji.append(idx)
                
        if lista_pozycji:
            print(f"Znaleziono liczbę {szukana_liczba} na pozycjach: {lista_pozycji}")
            for pozycja in lista_pozycji:
                print(f"  - indeks: {pozycja}")
        else:
            print(f"Liczba {szukana_liczba} nie została znaleziona w tablicy")
        
        return lista_pozycji
    
tablica = []
for x in range(50):
    losowa_liczba = random.randint(1,100)
    tablica.append(losowa_liczba)


solution = LinioweWyszukiwanie()
user_input = input("Podaj liczbę do znalezienia: ")
solution.szukanie(tablica, int(user_input))