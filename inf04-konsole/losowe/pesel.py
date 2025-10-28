class WeryfikacjaPeselu:
    def __init__(self, pesel: str = "55030101193") -> None:
        self.pesel = pesel

    def wypiszDane(self) -> None:

        if self.sprawdz_plec() == "K":
            print("Kobieta")
        else:
            print("Mężczyzna")

        if self.suma_kontrolna():
            print("Suma kontrolna jest Zgodna.")
        else:
            print("Suma kontrolna nie jest zgodna")

    def sprawdz_plec(self) -> str:
        if int(self.pesel[-2]) % 2 == 0:
            return "K"
        else:
            return "M"

    def suma_kontrolna(self) -> bool:
        wagi = [1,3,7,9,1,3,7,9,1,3,0] # 0 po to aby ostatnia liczba = 0 zawsze, bo nie jest brana pod uwage w sumie.
        s = 0
        for idx, cyfra in enumerate(self.pesel):
            s += wagi[idx] * int(cyfra)
        m = s % 10
        if m == 0:
            r = 0
        else:
            r = 10-m
        if r == int(self.pesel[-1]):
            return True
        else:
            return False

if __name__ == "__main__":
    pesel_uzytkownika = input("Podaj numer PESEL:\n")

    if pesel_uzytkownika == "":
        Weryfikacja_peselu = WeryfikacjaPeselu()
    else:
        Weryfikacja_peselu = WeryfikacjaPeselu(pesel_uzytkownika)
    Weryfikacja_peselu.wypiszDane()



