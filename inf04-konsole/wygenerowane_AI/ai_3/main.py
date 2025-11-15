from time import sleep


class KontoBankowe:
    def __init__(self, numer_konta: str, imie: str, nazwisko: str, saldo: float):
        self.numer_konta = numer_konta
        self.imie = imie
        self.nazwisko = nazwisko
        self.saldo = saldo
    
    def wyswietl(self):
        print(f"Numer konta : {self.numer_konta}")
        print(f"Właściciel: {self.imie} {self.nazwisko}")
        print(f"Saldo: {self.saldo}")

    def wplata(self, kwota):
        if kwota > 0:
            self.saldo += kwota
            print("Wplata dokonana")
            return True
        return None
    def wyplata(self, kwota):
        if kwota > 0 and self.saldo >= kwota:
            self.saldo -= kwota
            print("Wyplata zrbiona")
            return True
        return False

    def pobierzSaldo(self):
        return self.saldo


# Marek = KontoBankowe("2130120321045912", "Marek", "Ziemniak", 250.32)

# Marek.wyswietl()

# Marek.wplata(250)
# print(f"Saldo po wplacie: {Marek.pobierzSaldo()}")

# Marek.wyplata(120)
# print(f"Saldo po wyplacie: {Marek.pobierzSaldo()}")

if __name__ == "__main__": 

    while True:
        try:
            
            # za duzo roboty zrobie poprostu jedno konto bez szukania

            # liczba_kont = int(input("Ile kont utworzyć? (2-10):\n"))
            
            # if liczba_kont >= 1 and liczba_kont <= 10:
            #     konta = []
                # for i in range(liczba_kont):
            nr_konta = str(input("Numer Konta: "))
            imie = str(input("Imie: "))
            nazwisko = str(input("Nazwisko: "))
            saldo = float(input("Saldo: "))
            konto = KontoBankowe(nr_konta, imie, nazwisko, saldo if saldo >= 0 else 0)
            break # bo poprawne dane to ski
            
        
        except ValueError:
            print("Nie podano liczby z zakresu")
            continue

    while True:
        print("Wczytywanie Menu...")
        sleep(3)
        print("------ MENU ------")
        print("1 – Wyświetl szczegóły konta")
        print("2 – Wpłata na konto")
        print("3 – Wypłata z konta")
        print("4 – Czy moje konto jest na minus?")
        print("5 – Zakończ program")
        try:
            opcja = int(input("Którą opcje wybrać?\n"))
            if opcja == 1:
                if nr_konta != None:
                    konto.wyswietl()
                else:
                    print("Nie znaleziono konta")
                    break
            elif opcja == 2:
                kwota = int(input("Kwota wplaty: "))
                konto.wplata(kwota)
            elif opcja == 3:
                kwota = int(input("Kwota wyplaty: "))
                konto.wyplata(kwota=kwota)
            elif opcja == 4:
                if konto.saldo < 0:
                    print("Twoje konto jest poniżej 0 :( ")
                else:
                    print("Nie, twoje konto dalej jest na plus :D ")
            elif opcja == 5:
                break

        except ValueError: 
            print("Nie podano liczby")
            continue