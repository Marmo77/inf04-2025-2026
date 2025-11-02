class Algorytm:
    def __init__(self) -> None:
        pass
    


    # **********************************************
    # nazwa funkcji:            nwd
    # opis funkcji:             funkcja szuka najwiekszego wspolnego dzielnika według algorytmu euklidesa.
    # parametry:                a - jedna z liczb podawanych przez użytkownika ( musi być dodatnia (a > 0) )
    #                           b - jedna z liczb podawanych przez użytkownika ( musi być dodatnia (a > 0) )
    # zwracany typ i opis:      int - największy wspólny dzielnik liczb a i b podanych przez użytkownika
    # autor:                    XYZ
    # ***********************************************
    def nwd(self, a: int, b: int) -> int: #najwiekszy wspolny dzielnik
        while True:
            if a != b:
                if (a > b):
                    a = a-b
                    continue
                else:
                    b = b-a
                    continue
            else:
                return a


if __name__ == "__main__":

    nwd_algorytm = Algorytm()
    
    while True:
        try:
            a = int(input("Podaj liczbę a: "))
            b = int(input("Podaj liczbę b: "))
            if a > 0 and b > 0:
                print(nwd_algorytm.nwd(a,b))
                break
            else:
                print("Któraś z liczb nie jest dodatnia")
                break
        except ValueError:
            print("Nie podano liczby!")
            break



