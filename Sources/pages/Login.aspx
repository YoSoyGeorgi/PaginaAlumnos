<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PaginaAlumnos.Sources.pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width-device-width, initial-scale-1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="../Css/Estilo.css"/>
    <title>Iniciar Sesión</title>
</head>
<body>
    <div class="upcontainer" align="center" style="background-color:black">
            <div class="container">
                <div class="row align-center text-justify">
                    <div class="logo">
                        <div class="section-logo">
                            <img src="../images/logo.jpg" width="50%" class="img-responsive" alt="All Mobile"/>
                            <h1>All Mobile</h1>
                            <h2>Sistema de facturación</h2>
                        </div>
                    </div>                   
                </div>
            </div>
        </div>

    <form id="Login" runat="server" class="container d-flex justify-content-center align-items-center">
        <div class="col-5">
            <div class="form-control card card-body align-items-center h3">
                <asp:Label runat="server" Text="Inicio de Sesión" Font-Size="Larger"></asp:Label>
            </div>
            <br />
            <div class="input-group">
                <asp:TextBox runat="server" CssClass="form-control" placeholder="Correo Electrónico" required="required" ID="tbemail"></asp:TextBox>
            </div>
            <br />
            <div class="input-group">
                <asp:TextBox runat="server" type="password" CssClass="form-control" placeholder="Contraseña" required="required" ID="tbpass"></asp:TextBox>
            </div>
            <br />
            <div class="input-group">
                <asp:Button runat="server" CssClass="form-control btn btn-succes" BackColor="#05ACD8" BorderColor="#ffffff" OnClick="Iniciar_Click" Text="Iniciar Sesión" ForeColor="White" />
            </div>
            <br />
            <br />
            <div align="center">
                <asp:Label runat="server" ID="lblError" class="alert-danger"></asp:Label>
                <br />
                <asp:Label runat="server" Text="¿No tienes una cuenta? Registrate"></asp:Label>
                <asp:LinkButton runat="server" Text="aqui" OnClick="Registrarse"></asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
