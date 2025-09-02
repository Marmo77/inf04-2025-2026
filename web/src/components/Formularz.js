import React, {useState} from 'react';
// ARKUSZ : https://egzamin-programista.pl/arkusz-praktyczny-inf04-2022-06-02/
export const Formularz = () => {
    const tablica = [
        {
            kurs: "Programowanie w C#"
        },
        {
            kurs:"Angular dla początkujących"
        },
        {
            kurs:"Kurs Django"
        }
    ];
    // tablice mozna bylo zrobic na kilka sposobów np. 
    // const tablica = ["1","2"...]
    // const [tablica, setTablica] = useState(["1","2","3"])

    const [pelneImie, setPelneImie] = useState("");
    const [nrKursu, setNrKursu] = useState();


    const handleButton = () => {
        console.log(pelneImie)
        if(nrKursu > 0 && nrKursu <= tablica.length){
            const kurs = tablica[nrKursu-1].kurs;
            console.log(kurs)
        }
        else{
            console.log("Nieprawidłowy numer kursu")
        }
    }
    return (
        <>        
        <section>
            <h2>Liczba kursów: {tablica.length}</h2>
            <ol>
                {tablica.map((item, i) => (
                    <li key={i}>{item.kurs}</li>
                ))}
            </ol>
            <form >
                <div className='form-group mb-3'>
                    <label htmlFor='pelneImie'>Imię i nazwisko:</label>
                    <input className='form-control' type='text' value={pelneImie} onChange={(e) => (setPelneImie(e.target.value))} id='pelneImie'/>
                </div>
                <div className='form-group mb-3'>
                    <label htmlFor='nrKursu'>Numer kursu:</label>
                    <input className='form-control' type='number' id='nrKursu' value={nrKursu} onChange={(e) => (setNrKursu(e.target.value))}/>
                </div>
                <button type='button' className='btn btn-primary' onClick={handleButton}>Zapisz do kursu</button>
            </form>
        </section>
        </>
    )
}