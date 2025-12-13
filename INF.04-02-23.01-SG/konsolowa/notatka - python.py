# https://egzamin-programista.vercel.app/practice/inf04/INF.04-02-23.01-SG/INF.04-02-23.01-SG.pdf

class notatka:
    
    __identyfikator: int = 0
    __liczba_notatek = 0
    _tytul: str = ""
    _tresc: str = ""
    
    def __init__(self, tytul: str, tresc: str):
        self._tytul = tytul
        self._tresc = tresc
        
        # za kazdym constructem
        notatka.__liczba_notatek += 1
        self.__identyfikator = notatka.__liczba_notatek
        
        
    def wyswietl_notatke(self):
        print("------ NOTATKA -------")
        print(f"TYTUŁ: {self._tytul}")
        print(f"TREŚĆ: \n{self._tresc}")
        print("----------------------")
        
        
    # def __repr__(self):
    #     return f'"{self._tytul}"; "{self._tresc}"; {self.__liczba_notatek}; {self.__identyfikator}'
    
    def diagnostyka_notatki(self):
        print("------ DIAGNOSTYKA -----")
        # print(notatka.__repr__(self=self))
        # jeśli pole jest statyczny to sie odwloujemy przez nazwe klasy nie 
        print(f'{self._tytul}; {self._tresc}; {notatka.__liczba_notatek}; {self.__identyfikator}')
        print("------------------------")
        

if __name__ == "__main__":
    
    notatka1 = notatka("Czy jest React?", "W tym roku nie ma reacta na egzaminie.")
    notatka2 = notatka("Kosmici na ziemi", "Czy kosmici przylecą na ziemie w 2025 roku ?")
    
    notatka1.wyswietl_notatke()
    notatka2.wyswietl_notatke()
    
    notatka1.diagnostyka_notatki()
    notatka2.diagnostyka_notatki()