class LiczbaPierwsza:
    # def __init__(self) -> None:

# *******************************************************
#  nazwa funkcji:               sito
#  parametry wejściowe:         granica - przechowuje podany zakres do którego 
#                               ma sprawdzać liczby pierwsze
#                               liczbyPierwsze - zakres liczb <2,100> od 2 do 100
#  wartość zwracana:            brak
#  informacje:                  funkcja przechodzi przez wszystkie liczby z danego zakresu
#                               jeśli liczba jest mniejsza niż pierwiastek z górnej granicy to
#                               sprawdzamy czy dzielenie danej liczby przez element jest == 0 jesli tak to usuwamy go z listy
#                               ponieważ nie jest liczbą pierwszą.
#  autor:                       xyz
# ****************************************************

    def sito(self) -> None:
        granica = 100
        liczbyPierwsze = [int(x) for x in range(2,granica+1)]

        for i in liczbyPierwsze:
            if i < granica**0.5:

                for liczba in liczbyPierwsze:
                    if liczba != i and liczba % i == 0:
                        liczbyPierwsze.remove(liczba)
        # print(liczbyPierwsze)
        print("Liczby pierwsze")
        print(self.wypisz_liczby_pierwsze(liczbyPierwsze=liczbyPierwsze))

    def wypisz_liczby_pierwsze(self, liczbyPierwsze: list[int]):
        liczby = (str(", ").join(str(x) for x in liczbyPierwsze))
        return liczby

        

sol = LiczbaPierwsza()
sol.sito()

