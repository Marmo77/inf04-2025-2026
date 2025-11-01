import random

class Losowanie:
    def __init__(self, zestawy) -> None:
        self.zestawy = zestawy

    def losuj(self):
        self.losowe_zestawy = []
        for _ in range(self.zestawy):
            zestaw_liczb = [x for x in range(1,50)]
            wylosowany_zestaw = []
            for _ in range(6):
                losowa_liczba = random.choice(zestaw_liczb)
                wylosowany_zestaw.append(losowa_liczba)
                zestaw_liczb.remove(losowa_liczba)
            self.losowe_zestawy.append(wylosowany_zestaw)
            # self.losowe_zestawy.append([random.randint(1,49) for _ in range(6)]) # jeśli mogly by sie powtorzyć

        return self.losowe_zestawy
    # **********************************************
    # nazwa funkcji:                 wypisz
    # opis funkcji:                  funkcja wypisuje wylosowane zestawy liczb, przechodzi pętlą przez wszystkie wylosowane zestawy, zamienia list na str usuwjąc "," i "[]", 
    #                                następnie wypisuje (printuje) wylosowane zestawy.
    # parametry:                     brak
    # zwracany typ i opis:           brak
    # autor:                         XYZ
    # ***********************************************
    def wypisz(self):
        print("Zestawy wylosowanych liczb:")
        for idx, num in enumerate(self.losowe_zestawy, start=1):
            tabela_na_tekst = str(num).replace(",", "").split("[")[1].split("]")[0]
            print(f"Losowanie {idx}:", tabela_na_tekst)

    def wystapienia(self):
        powtorki: dict = {}

        for idx in range(1,50):
            powtorki[idx] = 0
        for i in self.losowe_zestawy:
            for j in i:
                powtorki[j] += 1

        for idx, _ in enumerate(powtorki):
            num = powtorki[idx+1]
            print(f"Wystąpienie liczby {idx+1}: {num}")

if __name__ == "__main__":

    ilosc_zestawow = int(input("Ile wygenerować losowań?\n"))
    loteria = Losowanie(ilosc_zestawow)


    loteria.losuj()
    loteria.wypisz()
    loteria.wystapienia()
