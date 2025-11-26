class Urzadzenia:
    def komunikat(self, wiadomosc):
        print(wiadomosc)


class Pralka(Urzadzenia):
    def __init__(self, nr_programu: int = 0) -> None:
        self.__nr_programu = nr_programu

    def ustaw_nr_programu(self, nowy_numer: int) -> int:

        if 12 >= nowy_numer >= 1:
            self.__nr_programu = nowy_numer
            self.komunikat("Program został ustawiony")
        else:
            self.__nr_programu = 0
            self.komunikat("Podano niepoprawny numer programu")

        return self.__nr_programu



class Odkurzacz(Urzadzenia):
    def __init__(self, __stan_odkurzacza: bool = False):
        self.__stan_odkurzacza = __stan_odkurzacza

    def on(self) -> None:
        if not self.__stan_odkurzacza:
            self.__stan_odkurzacza = True
            self.komunikat("Odkurzacz włączono")


    def off(self) -> None:
        if self.__stan_odkurzacza:
            self.__stan_odkurzacza = False
            self.komunikat("Odkurzacz wyłączono")

    

pralka = Pralka()

#nr programu
nr = int(input("Podaj numer prania 1...12\n"))
pralka.ustaw_nr_programu(nr)

odkurz = Odkurzacz()

#trzykrotne powtórzenie
odkurz.on()
odkurz.on()
odkurz.on()

#komunikat
odkurz.komunikat("Odkurzacz wyładował się")

#wyłączenie
odkurz.off()

# https://egzamin-programista.vercel.app/practice/inf04/INF.04-02-25.01-SG/INF.04-02-25.01-SG.pdf