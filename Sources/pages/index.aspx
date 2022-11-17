<%@ Page Title="" Language="C#" MasterPageFile="~/Sources/pages/webmaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PaginaAlumnos.Sources.pages.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container d-flex justify-content-center">
            <div class="col-14">
                <div class="form-control card card-body">
                    <div class="row justify-content-center">
                        <asp:Label runat="server" CssClass="row justify-content-center h3">Facturación</asp:Label>
                    </div>
                    <fieldset>
                        <asp:Label runat="server" Cssclass="row justify-content-center h5">Ingresa tus datos fiscales.</asp:Label>
                        <div class="input-group">
                            <asp:Label ID="label1" CssClass="form-control" runat="server" Text="RFC:"></asp:Label>
                            <asp:TextBox ID="tbRFC" CssClass="form-control" runat="server" placeholder="RFC"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label5" CssClass="form-control" runat="server" Text="Razón Social:"></asp:Label>
                            <asp:DropDownList ID="lbrs" runat="server">
                                <asp:ListItem align="center">Seleccione</asp:ListItem>
                                <asp:ListItem>Persona física</asp:ListItem>
                                <asp:ListItem>Moral</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label3" CssClass="form-control" runat="server" Text="Nombre de la Razón social:"></asp:Label>
                            <asp:TextBox ID="tbnrs" CssClass="form-control" runat="server" placeholder="Nombre"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label2" CssClass="form-control" runat="server" Text="Dirección:"></asp:Label>
                            <asp:TextBox ID="tbdir" CssClass="form-control" runat="server" placeholder="Dirección"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label6" CssClass="form-control" runat="server" Text="Código Postal:"></asp:Label>
                            <asp:TextBox ID="tbcp" CssClass="form-control" runat="server" placeholder="CP"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label7" CssClass="form-control" runat="server" Text="Ciudad:"></asp:Label>
                            <asp:TextBox ID="tbciudad" CssClass="form-control" runat="server" placeholder="Ciudad"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label8" CssClass="form-control" runat="server" Text="Estado:"></asp:Label>
                            <asp:TextBox ID="tbestado" CssClass="form-control" runat="server" placeholder="Estado"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label9" CssClass="form-control" runat="server" Text="Teléfono:"></asp:Label>
                            <asp:TextBox ID="tbcel" CssClass="form-control" runat="server" placeholder="Teléfono"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label10" CssClass="form-control" runat="server" Text="Correo:"></asp:Label>
                            <asp:TextBox ID="tbcorreo" CssClass="form-control" runat="server" placeholder="Correo"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label4" CssClass="form-control" runat="server" Text="Concepto:"></asp:Label>
                            <asp:DropDownList ID="lbconcepto" runat="server">
                                <asp:ListItem align="center">Seleccione</asp:ListItem>
                                <asp:ListItem>Adquisición de mercancias</asp:ListItem>
                                <asp:ListItem>Gastos en general</asp:ListItem>
                                <asp:ListItem>Equipo de computo y accesorios</asp:ListItem>
                                <asp:ListItem>Comunicaciones teléfonicas</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label11" CssClass="form-control text-center" runat="server" Text="Recibo de pago"></asp:Label>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:FileUpload ID="ticket" CssClass="form-control form-control-sm" runat="server" />
                        </div>
                        
                    </fieldset>
                    <br/>
                    <asp:Label runat="server" CssClass="alert-danger" ID="lblerror"></asp:Label>
                    <br/>
                    <div class="row">
                        <asp:Button runat="server" CssClass="form-control btn btn-success" BackColor="#05ACD8" BorderColor="#ffffff" Text="Completar Solicitud" OnClick="registrar_fact"/>
                        <hr />
                    </div>
                </div>
            </div>
    </div>
</asp:Content>
