<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFrmMenuprincipal.aspx.cs" Inherits="WEBTransportePasajerosTaller.WebFrmMenuprincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Taller de Servicio</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <!-- Our Custom CSS -->
    <link rel="stylesheet" href="Css/Custom.css" />

      <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <nav class="navbar navbar-inverse ">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Taller de Servicio</a>
            </div>
            <ul class="nav navbar-nav">
                <li class="active"><a href="#">Inicio</a></li>
                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Catalogos <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="#">Categoria de Refacciones</a></li>
                        <li><a href="#">Presentacion</a></li>
                        <li><a href="#">Refacciones</a></li>
                        <li><a href="#">Vehiculos</a></li>
                    </ul>
                </li>
                <li><a href="#">Pedidos</a></li>
                <li><a href="#">Servicios</a></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <li><a href="#"><span class="glyphicon glyphicon-log-in"></span>Cerrar Sesion</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
        <div class="jumbotron text-center">
            <h2>Catalogo de Vehiculos</h2>
        </div>
        <form class="form-horizontal" id="frmVehivulos" runat="server">
            <div class="form-group">
                <asp:Label ID="Label1" CssClass="control-label col-sm-2" runat="server" Text="Marca: "></asp:Label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtMarca" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" CssClass="control-label col-sm-2" runat="server" Text="Modelo:"></asp:Label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtModelo" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" CssClass="control-label col-sm-2" runat="server" Text="Año:"></asp:Label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtAnio" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" CssClass="control-label col-sm-2" runat="server" Text="Placas: "></asp:Label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtPlaca" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" CssClass="control-label col-sm-2" runat="server" Text="Fecha de Alta:"></asp:Label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtfechaAlta" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group col-sm-8">

            <asp:Button ID="btnGuardar" CssClass="btn btn-success"  runat="server" Text="Guardar" />
            <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server" Text="Cancelar" />
            </div>
        </form>
    </div>
</body>
</html>
