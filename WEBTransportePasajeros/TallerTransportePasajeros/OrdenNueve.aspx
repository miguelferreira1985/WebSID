<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrdenNueve.aspx.cs" Inherits="TallerTransportePasajeros.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2><%: Title %>.</h2>
    <h3>Catalogo de Vehiculos</h3>
    <div class="row">
        <div class="form-group col-sm-5 text-custom">
            <asp:Label ID="lbl2" Font-Size="XX-Large" runat="server" Text="Num. Servicio: "></asp:Label>
            <asp:Label ID="lblNumeroOrden" Font-Size="XX-Large" Font-Bold="true" BackColor="Red" runat="server" Text=""></asp:Label>
        </div>
        <div class="form-group col-sm-6">
            <asp:Label ID="lblMarca" runat="server" Text="Empleado: "></asp:Label>
            <asp:DropDownList ID="dlEmpleado" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <div class="form-group col-sm-6">
            <asp:Label ID="lblModelo" runat="server" Text="Vehiculo: "></asp:Label>
            <asp:DropDownList ID="dlVehiculo" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <div class="form-group col-sm-5">
            <asp:Label ID="lblAnio" runat="server" Text="Kilometraje: "></asp:Label>
            <asp:TextBox ID="txtKilometraje" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group col-sm-5">
            <asp:Label ID="lblPlacas" runat="server" Text="Observaciones: "></asp:Label>
            <asp:TextBox ID="txtObservaciones" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group col-sm-10">
            <asp:Button ID="btnGenerarOrden" runat="server" CssClass="btn btn-success" Text="Generar Orden" OnClick="btnGenerarOrden_Click" />
            <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Text="Cancelar Orden" />
        </div>
        <div class="form-group col-sm-5">
            <asp:Label ID="Label1" runat="server" Text="Servicio: "></asp:Label>
            <asp:DropDownList ID="dlServicio" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <div class="form-group col-sm-10">
            <asp:Button ID="btnAgregar" runat="server" CssClass="btn btn-success" Text="Agregar Servicio" OnClick="btnAgregar_Click" />
            <asp:Button ID="btnTerminar" CssClass="btn btn-danger" runat="server" Text="Terminar Orden" />
        </div>
    </div>
</asp:Content>
