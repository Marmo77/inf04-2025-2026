class Klasa:
    
    samogloski = "aąeęiouóyAĄEĘIOUÓY"

    def samogloski_licz(self, tekst: str):
        if tekst == "" or tekst == None:
            return 0 
        count = 1
        for znak in tekst:
            if znak in self.samogloski:
                # print("znak: ",znak, "liczba: ",count)
                count += 1
        return count

    def usun_powtorzenia(self, tekst: str):
        bez_powtorzen = ""
        if tekst == "" or tekst == None:
            return ""
        for i in range(len(tekst)):
            if (i+1 > len(tekst)-1):
                bez_powtorzen += tekst[i] # explain
                break
            else:
                if tekst[i] == tekst[i+1]:
                    pass
                else:
                    bez_powtorzen += tekst[i]
                
        return bez_powtorzen


klasa = Klasa()
user_input = input("Podaj tekst: ")

print(klasa.samogloski_licz(user_input))
print(klasa.usun_powtorzenia(user_input))