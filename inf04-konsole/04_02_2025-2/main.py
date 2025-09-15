class SzyfrCezara:
    
    alfabet = 'abcdefghijklmnopqrstuvwxyz'
    
    def __init__(self, tekst: str, klucz: int)-> str:
        self.tekst = str(tekst)
        self.klucz = int(klucz)
    
    def Szyfruj(self):
        zaszyfrowany_tekst = ""
        
        # for idx in range(len(self.alfabet)):
        #     for j in self.tekst:
        #         if j == " ":
        #             zaszyfrowany_tekst+= " "
                    
        #         elif j == self.alfabet[idx]:
        #             nowy_index = idx + self.klucz
        #             if nowy_index > len(self.alfabet)-1:
        #                 zaszyfrowany_tekst+=self.alfabet[nowy_index % len(self.alfabet)]
        #             else:
        #                 zaszyfrowany_tekst+=self.alfabet[nowy_index]
                    
        for char in self.tekst:
            if char == " ":
                zaszyfrowany_tekst+= " "
            else:
                idx = self.alfabet.index(char)
                new_idx = (idx + self.klucz) % len(self.alfabet)
                zaszyfrowany_tekst+= self.alfabet[new_idx]
                    
        return zaszyfrowany_tekst
        
        

    
szyfr = SzyfrCezara("abc", 3)

# print(szyfr.Szyfruj())


if __name__ == "__main__":
    tekst = input("Podaj tekst do zaszyfrowania: ")
    klucz = input("Podaj klucz szyfrowania: ")
    
    szyfr = SzyfrCezara(tekst, klucz)
    
    print("Zaszyfrowany tekst:",szyfr.Szyfruj())