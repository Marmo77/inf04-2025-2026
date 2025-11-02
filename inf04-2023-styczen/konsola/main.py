class Algorytm:
    def __init__(self) -> None:
        pass
    
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
    # print(sol.nwd(52,128))

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



