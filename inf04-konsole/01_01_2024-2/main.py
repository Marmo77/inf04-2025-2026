class Liczenie:

    #nie uzywamy self, poniewaz musza to byc staticmethod (wedlug polecania)

    @staticmethod
    def licz_samogloski(tekst: str) -> int:
        samogloski = "aąeęiouóyAĄEĘIOUÓY"

        liczba_samoglosek = 0
        if tekst == "" or tekst == None:
            return liczba_samoglosek

        for i in tekst:
            if i in samogloski:
                liczba_samoglosek += 1
        return liczba_samoglosek

    @staticmethod
    def usuwaj_powtorki(tekst: str) -> str:
        # tekst = "da"
        lancuch: str = ""
        
        if tekst == "" or tekst == None:
            return lancuch

        

        for i in range(len(tekst)):
            if i < len(tekst)-1:
                if tekst[i] != tekst[i+1]:
                    lancuch+= tekst[i]
            else:
                lancuch+= tekst[i]

        return lancuch



if __name__ == "__main__":
    print("Program do operacji na łańcuchach tekstowych\n")

    tekst = input("Podaj tekst: ")

    liczba_samoglosek = Liczenie.licz_samogloski(tekst)
    tekst_bez_powtorek = Liczenie.usuwaj_powtorki(tekst)
    print("--------------------------------------")
    print("\nPodany tekst:", tekst)
    print("Wyniki:")
    print(f"Liczba samogłosek: {liczba_samoglosek}")
    print(f"Tekst bez powtórzeń: {tekst_bez_powtorek}")