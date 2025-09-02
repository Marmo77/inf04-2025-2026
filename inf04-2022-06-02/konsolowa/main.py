class Osoba:
    # obiektowe nie idzie mi aż tak dobrze i ai troche pomogło :D

    counter = 0 # static 

    #prywatne pola
    def __init__(self, id=0, imie=""):
        self.__id = id
        self.__imie = imie
        Osoba.counter += 1


    def kopiuj(self, inna_osoba):
        self.__id = inna_osoba.__id
        self.__imie = inna_osoba.__imie


    def powitanie(self, imie_innej_osoby):
        if self.__imie:
            print(f"Cześć {imie_innej_osoby}, mam na imie {self.__imie}")
        else:
            print("Brak danych")


# zad. III + test czy wszystko działa
print("-----------------------")
print(f"Liczba zarejestrowanych osób to {Osoba.counter}")
o1 = Osoba() # konstruktor bezparametrowy
print("-----------------------")
id_input = int(input("Podaj id: "))
imie_input = input("Podaj imię: ")
print("-----------------------")
o2 = Osoba(id_input, imie_input) #konstruktor z dwoma parametrami podawany przez użytkownika inputem

o3 = Osoba()
o3.kopiuj(o2)

# powitania
o1.powitanie("Jan")
o2.powitanie("Jan")
o3.powitanie("Jan")

print(f"Liczba zarejestrowanych osób to {Osoba.counter}")
print("-----------------------")