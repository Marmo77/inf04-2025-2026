# ARKUSZ --> https://egzamin-programista.pl/arkusz-praktyczny-inf04-2024-01-02/

#
import random

class Sortowanie:
    
        
    def sortowanie_babelowe(self, tablica):
        self.tablica = tablica
        
        for i in range(len(self.tablica)):
            # for i ustala to do kazdego elemetnu czyli dla i = 0 (start) bierze pierwszy element tablicy j[0] i sprawdza z j[1] i je zamienia czyli 0 idzie na 1 a 1 idzie na 0
            # nastepnie koniec petli i sprawdzamy i = 1 i sprawdzamy j[1] z j[2] itd. kazdy element tablicy jesli nastepny jest wiekszy zamieniasz, jesli nie jest to zostawiasz (juz posortowane)
            for j in range(len(self.tablica)-1):
                if self.tablica[j] > self.tablica[j+1]: # tablica i na pierwszym elemencie sprawdza i 
                    temp = self.tablica[j]
                    self.tablica[j] = self.tablica[j+1]
                    self.tablica[j+1] = temp
        return tablica
solution = Sortowanie()

tablica = []
for i in range(100):
    tablica.append(random.randint(0,100))

print(solution.sortowanie_babelowe(tablica))
print()