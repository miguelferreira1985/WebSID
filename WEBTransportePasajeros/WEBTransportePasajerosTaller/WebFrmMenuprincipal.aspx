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
    <nav class="navbar navbar-inverse navbar-fixed-top">
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
                <li><i class="glyphicon glyphicon-wrench"></i></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <li><a href="#"><span class="glyphicon glyphicon-log-in"></span>Cerrar Sesion</a></li>
            </ul>
        </div>
    </nav>
</body>
</html>
