import random

class KlasaSortowan:

    def sortowanie_babelkowe(self, tablica: list[int]):
        for i in range(len(tablica)):
            for j in range((len(tablica)-i-1)):
                if tablica[j] > tablica[j+1]:
                    tablica[j], tablica[j+1] = tablica[j+1], tablica[j]
                    
        
        print(", ".join(str(x) for x in tablica))

            


        # print(tablica)


tablica_do_sortowania = [random.randint(0,1000) for _ in range(100)]

sortowanie = KlasaSortowan()
sortowanie.sortowanie_babelkowe(tablica=tablica_do_sortowania)


