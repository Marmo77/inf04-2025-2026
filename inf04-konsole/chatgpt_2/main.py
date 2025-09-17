# Część I. Aplikacja konsolowa
# Napisz program implementujący algorytm sortowania przez wybieranie (selection sort) dla tablicy liczb rzeczywistych.
# Założenia do programu:

# Program wykonywany w konsoli
# Obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym, jeden z: C++, C#, Java, Python
# Sortowanie odbywa się malejąco, nie wykorzystuje gotowych funkcji do sortowania
# Sortowana jest tablica 20 pseudolosowych liczb rzeczywistych z zakresu od 0.0 do 50.0
# Wszystkie elementy tablicy przed i po sortowaniu są wyświetlane na ekranie z dokładnością do 2 miejsc po przecinku, oddzielone przecinkami, poprzedzone znaczącymi komunikatami
# Sortowanie odbywa się w funkcji, której argumentem jest tablica, funkcja nie zwraca wartości
# Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych i funkcji
# Program główny powinien zawierać test działania funkcji sortującej

import random

tablica = []

for x in range(20):
    tablica.append(round(random.random() * 50, 2))


class Sortowanie:

    def sortowanie_przez_wybieranie(self, tablica):
        self.tablica = tablica

        # ------- Sortowanie Bąbelkowe ------
        # for i in range(len(self.tablica)):
        #     for j in range(len(self.tablica)-1):
        #         if self.tablica[j] < self.tablica[j+1]:
        #             temp  = self.tablica[j]
        #             self.tablica[j] = self.tablica[j+1]
        #             self.tablica[j+1] = temp
        # return tablica 


        # ---------- Select Sort ------------
        posortwana_tablica = []
        for idx in range(len(self.tablica)):
            najwieksza_liczba = max(self.tablica)
            posortwana_tablica.append(najwieksza_liczba)
            self.tablica.remove(najwieksza_liczba)

        print("Posortowana Tablica:",posortwana_tablica)
    




solution = Sortowanie()

print("Tablica przed sortowaniem: ", tablica)

solution.sortowanie_przez_wybieranie(tablica)