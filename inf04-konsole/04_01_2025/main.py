# import random

# class Loteria:
    
#     def __init__(self, ilosc_losowan: int):
#         self.ilosc_losowan = ilosc_losowan
        
#     losowy_zestaw = []
#     wszystkie_liczby = []
    
#     def losuj(self):
#         for i in range(self.ilosc_losowan):
#             # print(i)
#             for j in range(6):
#                 while True:
#                     losowa_liczba = random.randint(1,50)
#                     if losowa_liczba not in self.losowy_zestaw:
#                         self.losowy_zestaw.append(losowa_liczba)
#                         self.wszystkie_liczby.append(losowa_liczba)
#                         break
#                     # else:
#                         # print("powtorka: ", losowa_liczba, " na ", j)
                        
                    
#             print(f'Losowanie {i}: {", ".join(str(x) for x in self.losowy_zestaw)}')
#             self.losowy_zestaw = []
#             # print(self.losowy_zestaw)
#             # print("------------")
            
#     def Wystąpienie(self):
#         for i in range(1,50):
#             wystepuje = 0
#             for j in self.wszystkie_liczby:
#                 if j == i:
#                     wystepuje += 1
#                 else:
#                     continue
#             print(f'Wystąpienie liczby {i}: {wystepuje}')
        
        
        

# # user_input = input("Ile wygenerować losowań? \n")
# # loteria = Loteria(user_input)
# loteria = Loteria(4)

# loteria.losuj()
# loteria.Wystąpienie()


# ZADANIE PO MOJEMU
# (teraz dopiero przeczytalem ze jednak jest inne polecenie (2 wymiarowa tablica :( )))

import random

class Loteria:
    
    def __init__(self, ilosc_losowan: int):
        self.ilosc_losowan = ilosc_losowan
        self.wynik_losowania = []
    
    def losuj(self):
        
        for i in range(int(self.ilosc_losowan)):
            # tworzenie tyle wewnietrznych tablic iel jest ilosci losowan
            self.wynik_losowania.append([])
            
            for j in range(6):
                while True:
                    losowa_liczba = random.randint(1,49)
                    if losowa_liczba not in self.wynik_losowania[i]:
                        self.wynik_losowania[i].append(losowa_liczba)
                        break

            
            print(f"Losowanie {i+1}: {self.wynik_losowania[i]}")
        
    def wystepuje(self):
        for i in range(1,50):
            wystepuje = 0
            for j in self.wynik_losowania:
                for liczba in j:
                    if liczba == i:
                        wystepuje+= 1
            print(f"Wystąpienie liczby: {i}: {wystepuje}")
                    
        
        
user_input = input(f"Ile wygenerować losowań?\n")
losowanie = Loteria(user_input)
losowanie.losuj()
losowanie.wystepuje()