<%@ Page Title="" Language="C#" MasterPageFile="~/Sources/pages/webmaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PaginaAlumnos.Sources.pages.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container d-flex justify-content-center">
            <div class="col-8">
                <div class="form-control card card-body">
                    <div class="row justify-content-center">
                        <asp:Label runat="server" CssClass="row justify-content-center h3">Solicitar Factura</asp:Label>
                    </div>
                    <fieldset>
                        <legend class="row justify-content-center">Ingresa tus datos</legend>
                        <div class="input-group">
                            <asp:Label ID="label1" CssClass="form-control" runat="server" Text="RFC:"></asp:Label>
                            <asp:TextBox ID="tbRFC" CssClass="form-control" runat="server" placeholder="RFC"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label2" CssClass="form-control" runat="server" Text="Dirección:"></asp:Label>
                            <asp:TextBox ID="tbDir" CssClass="form-control" runat="server" placeholder="Dirección"></asp:TextBox>
                        </div> 
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label3" CssClass="form-control" runat="server" Text="Recibo de pago:"></asp:Label>
                            <asp:FileUpload ID="ticket" runat="server" />
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label4" CssClass="form-control" runat="server" Text="Ficha de pago:"></asp:Label>
                            <asp:FileUpload ID="Ficha" runat="server" Width="848px"/>
                        </div>
                        <br/>
                    </fieldset>
                    <br/>
                    <asp:Label runat="server" CssClass="alert-danger" ID="lblerror"></asp:Label>
                    <br/>
                    <div class="row">
                        <asp:Button runat="server" CssClass="form-control btn btn-success" BackColor="#EC8013" BorderColor="#EC8013" Text="Completar Solicitud"/>
                        <hr />
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
