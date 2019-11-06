var KO = function () {
    personas = httpGet();
    this.persona = ko.mapping.fromJS({ nombre: '', cedula: '', nacionalidad: '', edad: 0 });
    this.actualizar = ko.mapping.fromJS(false);
    var self = this
    $("#gridContainer").on("click", ".eliminar", function () {
        var id = $(this).attr("id");
        self.eliminar(id);
    });

    $("#gridContainer").on("click", ".actualizar", function () {
        var id = $(this).attr("id");
        self.cargarPersona(id);
    });

    this.validarCampos = function () {
        nombre = document.getElementById("nombre").value;
        cedula = document.getElementById("cedula").value;
        nacionalidad = document.getElementById("nacionalidad").value;
        edad = document.getElementById("edad").value;
        return nombre !== "" && cedula !== "" && nacionalidad !== "" && edad !== "";
    }

    this.actualizarUsuarios = function () {
        const personaActualizar = JSON.parse(ko.toJSON(this.persona));
        if (this.validarCampos()) {
            httpPut(this.cedula, personaActualizar);
            personas = httpGet();
            cargarPersonas();
            this.actualizar = ko.mapping.fromJS(false, this.actualizar);
            this.persona = ko.mapping.fromJS({ nombre: '', cedula: '', nacionalidad: '', edad: 0 }, this.persona);
            $('#formularioPersonas').modal('hide');
        } else {
            this.mensajeError('Rellene todos los campos por favor');
        }
    }

    this.registrarUsuario = function () {
        const personaNueva = JSON.parse(ko.toJSON(this.persona));
        if (this.validarCampos()) {
            httpPost(personaNueva);
            this.persona = ko.mapping.fromJS({ nombre: '', cedula: '', nacionalidad: '', edad: 0 }, this.persona);
            $('#formularioPersonas').modal('hide');
            personas = httpGet();
            cargarPersonas();
        } else {
            this.mensajeError('Rellene todos los campos por favor');
        }

    }

    this.mensajeError = function (mensaje) {
        Swal.fire({
            icon: 'error',
            title: 'Error!!',
            text: mensaje
        });
    }

    self.eliminar = function (data) {
        httpDelete(data);
        personas = httpGet();
        cargarPersonas();
    }

    self.cargarPersona = function (cedula) {
        this.actualizar = ko.mapping.fromJS(true, this.actualizar);
        this.cedula = httpGetById(cedula).cedula;
        this.persona = ko.mapping.fromJS(httpGetById(cedula), this.persona);
    }

    $(function () {
        cargarPersonas();
    });

    function cargarPersonas() {
        $("#gridContainer").dxDataGrid({
            showBorders: true,
            dataSource: personas,
            filterRow: {
                visible: true
            },
            paging: {
                pageSize: 2
            },
            pager: {
                showPageSizeSelector: true,
                allowedPageSizes: [2, 4, 6]
            },
            columns: [{
                caption: "Nombre",
                dataField: "nombre",
            }, {
                dataField: "cedula",
                caption: "Cédula",
            }, {
                dataField: "nacionalidad",
                caption: "País",
            }, {
                dataField: "edad",
                caption: "Edad",
                dataType: "number",

            },
            {
                caption: "Acciones",
                cellTemplate: function (container, options) {
                    container.addClass("chart-cell");
                    var cedula = options.data.cedula;
                    text = "<div align='center'>"
                        + "<button type='button' id = '" + cedula + "'class='btn btn-success eliminar' data-bind= 'click: eliminar(" + json + ")'><span class='fas fa-trash-alt' title='eliminar'></span></button>"
                        + "<button type='button' id = '" + cedula + "'class='btn btn-success actualizar' data-toggle='modal' data-target='#formularioPersonas'><span class='fas fa-pencil-alt' title='actualizar'></span></button>"
                        + "</div>";
                    var json = JSON.stringify(options.data);
                    container.append(text);
                }
            }]
        });
    };
};

ko.applyBindings(new KO());