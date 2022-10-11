import { useState } from "react";
// import App from './App';
const App = () => {
  const [text, setText] = useState("");
  const [number, setNumber] = useState("");
  const [error, setError] = useState("");
  const [todos, setTodos] = useState
    ([
      { id: 1, name: "Divya", contact: 9876543321 },
      { id: 2, name: "Deepa", contact: 9098976543 },
    ]);
  const removeTodo = (id) => {
    let newTodos = todos.filter((todo) => todo.id !== id);
    setTodos(newTodos)
  };

  const addTodo = () => {
    if (text.length <= 0) {
      setError("Item cannot be empty");
    } else {
      setTodos([...todos, { id: todos.length + 1, name: text, contact: number }]);
      setText("");
      setNumber("");
      setError("");
    }
  };

  return (
    <>
      <h1>Todo Application</h1>
      <div>
        <p>
          <label>Enter YourName:</label>
          <input type="text"
            value={text}
            onChange={(event) => {
              setText(event.target.value);
            }} />
          <span>{Error}</span>
        </p>
        <p>
          <label>Enter Your contact:</label>
          <input type="number"
            value={number}
            onChange={(event1) => {
              setNumber(event1.target.value);
            }} />
          <span>{Error}</span>
        </p>
        <button onClick={() => addTodo()}>ADD</button>
      </div>
      <h3>Todo Names And contact</h3>

      {todos.map((todo) => {
        return (
          <p key={todo.id}>
            {todo.name}
            {todo.contact}
            <span>
              <button onClick={() => removeTodo(todo.id)}>Remove</button>
            </span>
          </p>
        );
      })}
    </>
  );

  
}


export default App;
