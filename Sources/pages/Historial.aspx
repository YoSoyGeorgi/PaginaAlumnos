<%@ Page Title="" Language="C#" MasterPageFile="~/Sources/Pages/webmaster.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="PaginaAlumnos.Sources.Pages.Historial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Historial
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row justify-content-center">
        <asp:Label runat="server" CssClass="row justify-content-center h2">Historial</asp:Label>
    </div>

    <div class="container row" style="align-items: center; justify-content: center;">
        <div class="table">
            <asp:GridView runat="server" ID="Historial_Usuarios" class="table table-borderless table-hover">
                <Columns>
                    <asp:TemplateField HeaderText="Descargar">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Descargar" CssClass="btn form-control btn-dark" ID="btndescarga" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>


    </div>
    <!--<table ID="tabla" class="table table-bordered" runat="server">
        <thead class="table-dark">
            <tr>
              <th>Folio</th>
              <th>RFC</th>
              <th>Status</th>
              <th>Descargar</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><asp:Label runat="server" ID="lbfolio"></asp:Label></td>
                <td><asp:Label runat="server" ID="lbRFC"></asp:Label></td>
                <td><asp:Label runat="server" ID="lbstat"></asp:Label></td>
                <td><asp:Button runat="server" CssClass="btn btn-secondary" Text="Descarga"></asp:Button></td>
            </tr>
        </tbody>

    </table> -->
</asp:Content>
