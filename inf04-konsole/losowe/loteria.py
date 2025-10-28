import random



class Loteria:


    def __init__(self, ilosc_losowan) -> None:
        self.ilosc_losowan = ilosc_losowan

    def losowanie(self) -> list:
        wyniki = []
        for _ in range(self.ilosc_losowan):
            zbior_losowych = []
            zbior = [x for x in range(1,50)]
            for _ in range(6):
                losowa_liczba = random.choice(zbior)
                zbior_losowych.append(losowa_liczba)
                zbior.remove(losowa_liczba)

            wyniki.append(zbior_losowych)
        return wyniki
    
    # **********************************************
    # nazwa funkcji:        wypisz_losowania
    # opis funkcji:         funkcja drukuje/wyświetla liczby przypisane do danego numeru losowania, korzysta z pętli przechodząc przez wszystkie zbiory wyników.
    # parametry:            wyniki - tablica dwuwymiarowa, która zawiera wyniki losowań
    # zwracany typ i opis:  brak
    # autor:                xyz
    # ***********************************************
    def wypisz_losowania(self, wyniki):
        print("Zestaw wylosowanych liczb:")
        for idx, item in enumerate(wyniki):
            wynStr = str(item).split("[")[1].split("]")[0].replace(",", "")
            print(f"Losowanie {idx+1}: {wynStr}")

    def wystapienia_liczb(self, wyniki) -> None:
        wystapienia = {}

        for lista in wyniki:
            for item in lista:
                if item not in wystapienia:
                    wystapienia[item] = 1
                else:
                    wystapienia[item] += 1
        for i in range(1,50):
            if i in wystapienia:
                print(f"Wystąpienie liczby {i}: {wystapienia[i]}")
            else:
                print(f"Wystąpienie liczby {i}: 0")

        


if __name__ == "__main__":
    user_input = input("Ile wygenerować losowań?\n")

        
    loteria = Loteria(int(user_input))
    wynik = loteria.losowanie()
    loteria.wypisz_losowania(wyniki=wynik)
    loteria.wystapienia_liczb(wyniki=wynik)