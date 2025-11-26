import random



class AlgorytmSzukajacy:
    
    def wypelnienie_tablicy(self, rozmiar_tab = 50):
        tablica = [random.randint(1,100) for _ in range(rozmiar_tab)]
        return tablica

    def szukanie_z_wartownikiem(self, tablica, sz_wartosc):
        n = len(tablica)
        tablica.append(sz_wartosc)

        i = 0
        while tablica[i] != sz_wartosc:
            i += 1

        tablica.pop()

        if i == n:
            return -1

        else:
            return i 

    
            
tab = AlgorytmSzukajacy()
tablica = tab.wypelnienie_tablicy(50)

x = 32

indeks =  tab.szukanie_z_wartownikiem(tablica,x)

print(", ".join(str(x) for x in tablica))

if indeks == -1:
    print(f"NIE WYSTEPUJE")
else:
    print(f"WYSTEPUJE na indeskie {indeks}")



# n = 60
# tablica_elementow = [random.randint(1,100) for _ in range(n)]
# print(elementy_tab)

# sol = AlgorytmSzukajacy()


# # liczba wyszukiwana (user input):
# # wyszukiwana = int(input("Szukana liczba:\n"))

# sol.przeszukaj(10)












# https://egzamin-programista.vercel.app/practice/inf04/INF.04-01-22.06-SG/INF.04-01-22.06-SG.pdf