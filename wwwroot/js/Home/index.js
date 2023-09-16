function AddApp() {
    console.log("Procesando informacion");
    axios.post('/user', {
        firstName: 'Fred',
        lastName: 'Flintstone'
      })
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
}

formApp.onsubmit = (e)=>{
e.preventDefault();
const formData = new FormData(formApp);
for (const pair of formData.entries()) {
  console.log(`${pair[0]}, ${pair[1]}`);
}

console.log("Procesando informacion");
axios.post('Home/CreateAppregister', formApp)
  .then(function (response) {
    console.log(response);
  })
  .catch(function (error) {
    console.log(error);
  });
}