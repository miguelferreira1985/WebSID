<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatalogoServicios.aspx.cs" Inherits="TallerTransportePasajeros.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <h2><%: Title %>.</h2>
    <h3>Catalogo de Refacciones</h3>
    <div class="row">
        <div class="form-group col-sm-5">
            <asp:Label ID="lblModelo" runat="server" Text="Servicio: "></asp:Label>
            <asp:TextBox ID="txtServicio" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group col-sm-5">
            <asp:Label ID="lblAnio" runat="server" Text="Descripcion: "></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group col-sm-10">
            <asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="btnGuardar_Click"  />
            <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
        </div>
        <div class="col-sm-10">
            <asp:GridView ID="gvServicios" runat="server"
                CssClass="table table-bordered bs-table">
                <HeaderStyle BackColor="#3337ab7" Font-Bold="true" ForeColor="White" />

                <Columns>
                    <%-- Botones de Eliminar y editar  --%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
                        <ItemTemplate>
                            <asp:Button ID="btnDesactivarVehiculo" CssClass="btn btn-danger" runat="server" Text="Desactivar" />
                            <asp:Button ID="btnEditarVehiculo" runat="server" CssClass="btn btn-info" Text="Editar" />
                        </ItemTemplate>

<HeaderStyle Width="200px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:CommandField HeaderText="Actualizar" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
