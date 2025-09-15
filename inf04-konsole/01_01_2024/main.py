class Pesel:
    def __init__(self, pesel:str = "55030101193"):
        self.pesel = pesel
        
        #  ? Parametrem wejściowym obu funkcji jest zmienna przechowująca numer PESEL
        # czy __init__ czy każda funkcja ma osobno brać pesel
    def sprawdzenie_plci(self):
        plec = self.pesel[-2] 

        # moja metoda na uzyskanie plec :
            # moja logika - len(self.pesel)-2 -wyjaśnienie: -1 last digit -> (len(self.pesel) = 11, len of string is 0-10) self.pesel len is 11 -1 => 10 so its last digit (0-10), -2 is equal 9 from -9 so its penultimate digit
        if int(plec) % 2 == 0:
            plec = "K"
        else:
            plec = "M"
        
        if plec == "K":
            print("Kobieta")
        else:
            print("Mężczyzna")
        return plec
        
    
    def sprawdzenie_sumy(self)-> bool:
        wagi = [
            1,
            3,
            7,
            9,
            1,
            3,
            7,
            9,
            1,
            3
        ]
        idx = 0
        S = 0
        
        for waga in wagi:
            S += int(self.pesel[idx]) * waga
            idx +=1
            
        M = S % 10
        
        if M == 0:
            R = 0
        else:
            R = 10-M
        
        if R == int(self.pesel[-1]):
            return True
        else:
            return False
        
        

user_input = input("Podaj numer PESEL (enter = domyślny): ")
if user_input: 
    pesel = Pesel(user_input)
else:
    pesel = Pesel()

pesel.sprawdzenie_plci()
if pesel.sprawdzenie_sumy():
    print("Suma kontrolna jest poprawna")
else:
    print("Suma kontrolna jest błędna")