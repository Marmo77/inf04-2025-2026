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
            return True
        return None
    def wyplata(self, kwota):
        if kwota > 0 and self.saldo >= kwota:
            self.saldo -= kwota
            return True
        return False

    def pobierzSaldo(self):
        return self.saldo


Marek = KontoBankowe("2130120321045912", "Marek", "Ziemniak", 250.32)

Marek.wyswietl()

Marek.wplata(250)
print(f"Saldo po wplacie: {Marek.pobierzSaldo()}")

Marek.wyplata(120)
print(f"Saldo po wyplacie: {Marek.pobierzSaldo()}")


