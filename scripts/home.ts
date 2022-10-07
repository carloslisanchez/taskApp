class Home {
    nombres: string;
    constructor(public nombre: string, public apellido: string) {
        this.nombres = nombre + " " + apellido;
    }
}