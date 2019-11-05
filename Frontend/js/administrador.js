
var ClickCounterViewModel = function () {
    this.personas = ko.observableArray([
        { nombre: 'Camilo', cedula: '1234', nacionalidad: 'Colombia', edad: 20 },
        { nombre: 'Camila', cedula: '12346', nacionalidad: 'Colombia', edad: 22 },
        { nombre: 'Ariel', cedula: '543434', nacionalidad: 'Argentina', edad: 24 }
    ]);

    this.persona = {};
    this.registrarUsuario = function () {
        this.personas.push(this.persona);
        alert("Usuario registrado");
    }
};

ko.applyBindings(new ClickCounterViewModel());


