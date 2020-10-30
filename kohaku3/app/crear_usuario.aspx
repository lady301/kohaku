<%@ Page Title="" Language="C#" MasterPageFile="~/app/plantilla.Master" AutoEventWireup="true" CodeBehind="crear_usuario.aspx.cs" Inherits="kohaku3.app.crear_usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="contenedor-botones">
        <input class="boton-margin" type="button" value="Nuevo Usuario">
        <input class="boton-margin" type="submit" value="Grupos">
        <input class="boton-margin" type="submit" value="Permisos">
    </div>
    <div class="contenedor-formulario">

        <label for="Usuario">Nombre</label>
        <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
        <br />

        <label for="Nombre">Apellido</label>
        <asp:TextBox ID="txApellido" runat="server"></asp:TextBox>
        <br />

        <label for="Surname">Tipo documento:</label>
        <asp:DropDownList ID="ddTipoDocumento" runat="server" AutoPostBack="True"></asp:DropDownList>
        <br />

        <label for="Document">Documento</label>
        <asp:TextBox ID="txDocumento" runat="server"></asp:TextBox>
        <br />

        <label for="Correo">Telefono movil</label>
        <asp:TextBox ID="txTelefonoMovil" runat="server"></asp:TextBox>
        <br />

        <label for="Correo">Teleforno Fijo</label>
        <asp:TextBox ID="txTelefonoFijo" runat="server"></asp:TextBox>
        <br />

        <label for="Correo">Direccion</label>
        <asp:TextBox ID="txDireccion" runat="server"></asp:TextBox>
        <br />

        <label for="Correo">Correo</label>
        <asp:TextBox ID="txCorreo" runat="server"></asp:TextBox>
        <br />

        <label for="Grado">Rango</label>
        <asp:DropDownList ID="ddRango" runat="server" AutoPostBack="True"></asp:DropDownList>
        <br />

        <label for="Grupo">Tipo de Usuario</label>
        <asp:DropDownList ID="ddTipoUsuario" runat="server" AutoPostBack="True"></asp:DropDownList>
        <br />

        <label for="password">password</label>
        <asp:TextBox ID="txPassword" TextMode="Password"  runat="server"></asp:TextBox>
        <br />

        <label for="Repeticion Contraseña">Repeticion Contraseña</label>
        <asp:TextBox ID="txRepetirPasssword" TextMode="Password" runat="server"></asp:TextBox>

    </div>

    <div>
        <asp:Button ID="btnGuardar" CssClass="boton-guardar" runat="server" Text="Guardar" OnClick="btnGuardarUsuario_Click" />
    </div>




</asp:Content>
