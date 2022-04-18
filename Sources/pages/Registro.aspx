<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="PaginaAlumnos.Sources.pages.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width-device-width, initial-scale-1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <title>Registro</title>
</head>
<body>
    <form id="registro" runat="server">
        <div class="container d-flex justify-content-center">
            <div class="col-8">
                <div class="form-control card card-body">
                    <div class="row justify-content-center">
                        <asp:Label runat="server" CssClass="row justify-content-center h3">Registro</asp:Label>
                    </div>
                    <fieldset>
                        <legend class="row justify-content-center">Datos personales</legend>
                        <div class="input-group">
                            <asp:Label ID="label1" CssClass="form-control" runat="server" Text="Nombre:"></asp:Label>
                            <asp:TextBox ID="tbNombre" CssClass="form-control" runat="server" placeholder="Nombre"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label2" CssClass="form-control" runat="server" Text="Apellido:"></asp:Label>
                            <asp:TextBox ID="tbapp" CssClass="form-control" runat="server" placeholder="Apellido"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label3" CssClass="form-control" runat="server" Text="Número de control:"></asp:Label>
                            <asp:TextBox ID="tbnum" CssClass="form-control" runat="server" placeholder="ej. 17140321"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label4" CssClass="form-control" runat="server" Text="Correo Electrónico:"></asp:Label>
                            <asp:TextBox ID="tbemail" CssClass="form-control" runat="server" placeholder="ej. patata@hotmail.com"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label5" CssClass="form-control" runat="server" Text="Carrera:"></asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem align="center">Seleccione</asp:ListItem>
                                <asp:ListItem>Ing. Sistemas Computacionales</asp:ListItem>
                                <asp:ListItem>Ing. Mecatronica</asp:ListItem>
                                <asp:ListItem>Ing. Mecanica</asp:ListItem>
                                <asp:ListItem>Ing. Materiales</asp:ListItem>
                                <asp:ListItem>Ing. Electrica</asp:ListItem>
                                <asp:ListItem>Ing. Electronica</asp:ListItem>
                                <asp:ListItem>Ing. Gestión Empresarial</asp:ListItem>
                                <asp:ListItem>Ing. Logistica</asp:ListItem>
                                <asp:ListItem>Ing. Industrial</asp:ListItem>
                                <asp:ListItem>Arquitectura</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label6" CssClass="form-control" runat="server" Text="Contraseña:"></asp:Label>
                            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                        </div>
                        <br/>
                        <div class="input-group">
                            <asp:Label ID="label7" CssClass="form-control" runat="server" Text="Repetir contraseña:"></asp:Label>
                            <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" TextMode="Password" placeholder="Repetir contraseña"></asp:TextBox>
                        </div>
                    </fieldset>
                    <br/>
                    <asp:Label runat="server" CssClass="alert-danger" ID="lblerror"></asp:Label>
                    <br/>
                    <div class="row">
                        <asp:Button runat="server" CssClass="form-control btn btn-success" BackColor="#EC8013" BorderColor="#EC8013" Text="Completar Registro" />
                        <hr />
                        <asp:Button runat="server" CssClass="form-control btn btn-warning" BackColor="#EC8013" BorderColor="#EC8013" Text="Cancelar" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
