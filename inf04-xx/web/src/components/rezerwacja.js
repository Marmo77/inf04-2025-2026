import { useState } from "react";

function Rezerwacja() {

    let nazwy_sal = ["Sala Apollo", "Sala Mercury", "Sala Venus", "Sala Mars", "Sala Jupiter"];

    const [nazwaFirmy, setNazwaFirmy] = useState("")
    const [osobaKontaktowa, setOsobaKontaktowa] = useState("")
    const [numerSali, setNumerSali] = useState("")
    const [dataRezerwacji, setDataRezerwacji] = useState("")
    const [liczbaUczestników, setLiczbaUczestników] = useState("")

    const handleSubmit = (e) => {
        e.preventDefault();
        // console.log("workyn")
        console.log(nazwaFirmy);
        console.log(osobaKontaktowa);
        const sala = nazwy_sal[numerSali-1];
        if (sala === undefined) {
            console.log("Nieprawidłowy numer sali");
        }else{
            console.log(sala);
        }
        console.log(dataRezerwacji);
        console.log(liczbaUczestników);

        const usunWartosci = () => {
            setNazwaFirmy("")
            setOsobaKontaktowa("")
            setNumerSali("")
            setDataRezerwacji("")
            setLiczbaUczestników("")
        }
        usunWartosci()
    }

    return(
        <section>
            <h1>System rezerwacji sal konferencyjnych</h1>
            <h3>Dostępne sale: {nazwy_sal.length}</h3>
            <ul className="list-unstyled">
                {nazwy_sal.map((item, idx) => (
                    <li key={idx}>
                        {item}
                    </li>
                ))}
            </ul>
            <div className="container">
            <form onSubmit={handleSubmit}>
                <div  className="form-group mb-3">

                <label htmlFor="nazwaFirmy" className="form-label">Nazwa firmy:</label>
                <input id="nazwaFirmy" type="text" className="form-control" value={nazwaFirmy} onChange={(e) => setNazwaFirmy(e.target.value)}/>
                <label htmlFor="osobaKontaktowa" className="form-label">Osoba kontaktowa:</label>
                <input id="osobaKontaktowa" type="text" className="form-control" value={osobaKontaktowa} onChange={(e) => setOsobaKontaktowa(e.target.value)}/>
                <label htmlFor="numerSali" className="form-label">Numer sali:</label>
                <input id="numerSali" type="number" className="form-control" value={numerSali} onChange={(e) => setNumerSali(e.target.value)}/>
                <label htmlFor="dataRezerwacji" className="form-label">Data rezerwacji:</label>
                <input id="dataRezerwacji" type="date" className="form-control mb-3" value={dataRezerwacji} onChange={(e) => setDataRezerwacji(e.target.value)}/>
                <label htmlFor="liczbaUczestnikow" className="form-label">Liczba uczestników :</label>
                <input id="liczbaUczestnikow" type="number" className="form-control " value={liczbaUczestników} onChange={(e) => setLiczbaUczestników(e.target.value)}/>
                </div>
                <button type="submit" className="btn btn-primary">Zarezerwuj salę</button>
            </form>
            </div>
        </section>
    )
}
export default Rezerwacja