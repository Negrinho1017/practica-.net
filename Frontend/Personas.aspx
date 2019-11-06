<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" MasterPageFile="~/Site.Master" CodeBehind="Personas.aspx.cs" Inherits="Frontend.Personas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>DevExtreme Demo</title>
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />
        <link rel="stylesheet" type="text/css" href="https://cdn3.devexpress.com/jslib/19.2.3/css/dx.common.css" />
        <link rel="stylesheet" type="text/css" href="https://cdn3.devexpress.com/jslib/19.2.3/css/dx.light.css" />
        <script src="https://cdn3.devexpress.com/jslib/19.2.3/js/dx.all.js"></script>
        <link rel="stylesheet" type="text/css" href="css/personas.css">
    </head>
    <body class="dx-viewport" runat="server">
        <div class="demo-container panel">
            <button class="btn btn-success crear" type="button" data-toggle='modal' data-target='#formularioPersonas'>Crear</button>
            <div id="gridContainer"></div>
        </div>
    </body>

    <div id="formularioPersonas" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Modal Header</h4>
                </div>
                <div class="modal-body">
                    <form class="form-inline panel col-md-12" data-bind='submit: actualizarUsuarios'>
                        <div class="form-group col-md-3">
                            <label for="nombre">Nombre:</label><br />
                            <input type="text" class="form-control" placeholder="Nombre" id="nombre" data-bind='value: persona.nombre' />
                        </div>
                        <div class="form-group col-md-3">
                            <label for="cedula">Cédula:</label><br />
                            <input type="text" class="form-control" placeholder="Cédula" id="cedula" data-bind='value: persona.cedula, disable: actualizar' />
                        </div>
                        <div class="form-group col-md-3">
                            <label for="nacionalidad">Nacionalidad:</label><br />
                            <input type="text" class="form-control" placeholder="Nacionalidad" id="nacionalidad" data-bind='value: persona.nacionalidad' />
                        </div>
                        <div class="form-group col-md-3">
                            <label for="edad">Edad:</label><br />
                            <input type="number" class="form-control" placeholder="Edad" id="edad" data-bind='value: persona.edad' />
                        </div>
                    </form>
                </div>
                <div class="modal-footer">
                    <span data-bind="if: actualizar">
                        <button type="submit" class="btn btn-success" data-bind='click: actualizarUsuarios'>Actualizar usuario</button></span>
                    <span data-bind="ifnot: actualizar">
                        <button type="submit" class="btn btn-success" data-bind='click: registrarUsuario'>Registrar usuario</button></span>
                    <button class="btn btn-success" data-dismiss="modal">Cancelar</button>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="js/servicios.js"></script>
    <script type="text/javascript" src="js/personas.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>
    </html>
</asp:Content>
