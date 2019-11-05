<%@ Page Title="ProductList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Frontend.ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table">
        <thead>
            <tr>
                <th>Cédula</th>
                <th>Nombre</th>
                <th>Nacionalidad</th>
                <th>Edad</th>
            </tr>
        </thead>
        <tbody data-bind="foreach: personas">
            <tr>
                <td data-bind="text: cedula"></td>
                <td data-bind="text: nombre"></td>
                <td data-bind="text: nacionalidad"></td>
                <td data-bind="text: edad"></td>
            </tr>
        </tbody>
    </table>
    

    <link rel="stylesheet" type="text/css" href="css/personas.css">

    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#myModal">Registrar</button>

    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Modal Header</h4>
                </div>
                <div class="modal-body">
                    <form class="form-inline panel col-md-12" data-bind='submit: registrarUsuario'>
                        <div class="form-group col-md-3">
                            <label for="nombre">Nombre:</label><br />
                            <input type="text" class="form-control" placeholder="Nombre" id="nombre" data-bind='value: persona.nombre' />
                        </div>
                        <div class="form-group col-md-3">
                            <label for="cedula">Cédula:</label><br />
                            <input type="text" class="form-control" placeholder="Cédula" id="cedula" data-bind='value: persona.cedula' />
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
                    <button type="submit" class="btn btn-success" data-bind='click: registrarUsuario' data-dismiss="modal">Registrar usuario</button>
                    <button class="btn btn-success" data-dismiss="modal">Cancelar</button>
                </div>
            </div>
        </div>
    </div>
    <script src="js/administrador.js"></script>
</asp:Content>
