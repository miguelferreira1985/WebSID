<%@ Page Title="Catalogo de Vehiculos" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatalogoVehiculos.aspx.cs" Inherits="TallerTransportePasajeros.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Catalogo de Vehiculos</h3>
    <div class="row">
        <div class="form-group col-sm-5">
            <asp:Label ID="lblMarca" runat="server" Text="Marca: "></asp:Label>
            <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group col-sm-5">
            <asp:Label ID="lblModelo" runat="server" Text="Modelo: "></asp:Label>
            <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group col-sm-5">
            <asp:Label ID="lblAnio" runat="server" Text="Año: "></asp:Label>
            <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group col-sm-5">
            <asp:Label ID="lblPlacas" runat="server" Text="Placas: "></asp:Label>
            <asp:TextBox ID="txtPlacas" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group col-sm-10">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-success" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Text="Cancelar" OnClick="btnCancelar_Click" />
        </div>
        <div class="col-sm-10">
            <asp:GridView ID="gvVehiculo" runat="server"
                CssClass="table table-bordered bs-table" OnSelectedIndexChanged="gvVehiculo_SelectedIndexChanged" OnRowCommand="gvVehiculo_RowCommand" OnRowUpdating="gvVehiculo_RowUpdating" OnRowDeleting="gvVehiculo_RowDeleting" OnRowUpdated="gvVehiculo_RowUpdated">
                <HeaderStyle BackColor="#3337ab7" Font-Bold="true" ForeColor="White" />

                <Columns>
                    <asp:CommandField EditText="Activar/Desactivar" ControlStyle-CssClass="btn btn-success" ShowEditButton="True" UpdateText="Activar/Desactivar" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="col-sm-10">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IDVehiculo" DataSourceID="SqlTransporte" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="IDVehiculo" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="IDVehiculo" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
                    <asp:BoundField DataField="Anio" HeaderText="Año" SortExpression="Anio" />
                    <asp:BoundField DataField="Placas" HeaderText="Placas" SortExpression="Placas" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:CommandField EditText="Desactivar" ShowEditButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlTransporte" runat="server" ConnectionString="<%$ ConnectionStrings:BDTransportePasajerosConnectionString %>" SelectCommand="SELECT [IDVehiculo], [Marca], [Modelo], [Anio], [Placas], [Estado] FROM [Cat_Vehiculos]" UpdateCommand="UPDATE [Cat_Vehiculos] SET [Estado]=[Estado] WHERE [IDVehiculo]=[IDVehiculo]"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
