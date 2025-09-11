import React, { useState } from "react";
// https://egzamin-programista.pl/arkusz-praktyczny-inf04-2023-06-03/
const Form = () => {
  const [title, setTitle]= useState("");
  const [category, setCategory] = useState()


  const handleSubmit = (e) => {
    e.preventDefault();

    const result = `tytul: ${title}; rodzaj: ${category} `

    console.log(result)
  }

  return (
    <div className="mx-auto w-50">
      <form onSubmit={handleSubmit}>
        <div className="form-group mb-3">
          <label htmlFor="title">Tytuł filmu</label>
          <input className="form-control" type="text" id="title" name="title" value={title} onChange={(event) => setTitle(event.target.value)}/>
        </div>
        <div className="form-group mb-3">
          <label htmlFor="category">Rodzaj</label>
          <select className="form-control" name="category" id="category" value={category} onChange={(event) => setCategory(event.target.value)}>
            <option value=""></option>
            <option value="1">Komedia</option>
            <option value="2">Obyczajowy</option>
            <option value="3">Sensacyjny</option>
            <option value="4">Horror</option>
          </select>
        </div>
        <button className="btn btn-primary" type="submit">Dodaj</button>
      </form>
    </div>
  );
};

export default Form;
