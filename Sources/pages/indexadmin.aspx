<%@ Page Title="" Language="C#" MasterPageFile="~/Sources/Pages/admin.Master" AutoEventWireup="true" CodeBehind="indexadmin.aspx.cs" Inherits="PaginaAlumnos.Sources.Pages.indexadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    ADMIN
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row justify-content-center">
        <asp:Label runat="server" CssClass="row justify-content-center h2">Solicitudes</asp:Label>
    </div>
    <div class="container row" style="align-items: center; justify-content: center;">
        <div class="table">
            <asp:GridView runat="server" ID="Historial" class="table table-borderless table-hover">
                <Columns>
                    <asp:TemplateField HeaderText="Cargar zip">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Descargar" CssClass="btn form-control btn-dark" ID="cargarfact" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
