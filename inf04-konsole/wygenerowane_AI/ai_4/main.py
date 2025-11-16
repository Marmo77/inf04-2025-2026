from multiprocessing import Value


class AnalizaPogody:
    def __init__(self, temperatury) -> None:
        self.temperatury = temperatury

    def oblicz_temperatury(self):
        srednia = 0
        najwyzsza_temp = max(self.temperatury)
        najniza_temp = min(self.temperatury)
        for i in self.temperatury:
            srednia += i
        srednia = srednia / len(self.temperatury)

        print(f"Średnia temperatura: {round(srednia,2)}")
        print(f"Najwyższa temperatura: {najwyzsza_temp}")
        print(f"Najniższa temperatura: {najniza_temp}")


if __name__ == "__main__":
    while True:
        try:
            przedzial  = int(input("Podaj liczbę dni których podasz temperature (3-14):\n"))

            if przedzial <= 14 and przedzial >= 3:
                temperatury_arr = []
                for i in range(przedzial):
                    try:
                        temperatura = float(input(f"Temperatura dnia {i+1}: "))
                        temperatury_arr.append(temperatura)
                    except ValueError:
                        break
                print("Wprowadzone temperatury:")
                print(temperatury_arr)
                pogoda = AnalizaPogody(temperatury_arr)
                pogoda.oblicz_temperatury()
                
                #od nowa
                kolejne = input("Czy chcesz wykonać kolejne obliczenia? (t/n): ")
                if kolejne == "t":
                    continue
                elif kolejne == "n":
                    break
                else:
                    break

            else:
                print("Podano bledny przedział!")


        except ValueError:
            print("Nie podano liczby!")