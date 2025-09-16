
import "bootstrap/dist/css/bootstrap.min.css";
import Form from './components/Form';

import './index.css';

function App() {
  return (
    <>
    <Form />
    <div>
      <select className="d-flex gap-2 flex-wrap align-items-center">
        <option value=""></option>
        <option value="1">Komedia</option>
        <option value="2">Obyczajowy</option>
        <option value="3">Sensacyjny</option>
        <option value="4">Horror</option>
      </select>
    </div>
    </>
  );
}

export default App;
