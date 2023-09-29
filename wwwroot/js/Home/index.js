function AddApp() {
  const self = this;
  $("#ModalAddApp").modal("show");
}

formApp.onsubmit = (e)=>{
e.preventDefault();
const formData = new FormData(formApp);
for (const pair of formData.entries()) {
  console.log(pair);
  console.log(`${pair[0]}, ${pair[1]}`);
  if (pair[1] == "") {
    alert("Agregar datos..");
    return false;
  }
}
axios.post('Home/CreateAppregister', formApp)
  .then(function (response) {
    console.log(response);
    formData.reset();
  })
  .catch(function (error) {
    console.log(error);
  });
}