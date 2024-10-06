<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormularioRegistro.aspx.cs" Inherits="tp_promoweb_equipo14B.FormularioRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-3"></div>
        <div class="col">
            <div class="mb-3">
                <label for="txtDNI" class="form-label">DNI</label>
                <asp:TextBox runat="server" AutoPostBack ="true" CssClass="form-control" ID="txtDNI" OnTextChanged="txtDNI_TextChanged" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre" />
            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtApellido" />
            </div>
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" />
            </div>
            <div class="mb-3">
                <label for="txtDireccion" class="form-label">Dirección</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtDireccion" />
            </div>
            <div class="mb-3">
                <label for="txtCiudad" class="form-label">Ciudad</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCiudad" />
            </div>
            <div class="mb-3">
                <label for="txtCP" class="form-label">CP</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCP" />
            </div>
            <%--<div class="mb-3">
                <label for="ddlProvincias" class="form-label">Provincia</label>
                <asp:DropDownList ID="ddlProvincias" CssClass="form-select" runat="server">
                    <asp:ListItem Text="Buenos Aires" />
                    <asp:ListItem Text="CABA" />
                    <asp:ListItem Text="Catamarca" />
                    <asp:ListItem Text="Chaco" />
                    <asp:ListItem Text="Chubut" />
                    <asp:ListItem Text="Córdoba" />
                    <asp:ListItem Text="Corrientes" />
                    <asp:ListItem Text="Entre Rios" />
                    <asp:ListItem Text="Formosa" />
                    <asp:ListItem Text="Jujuy" />
                    <asp:ListItem Text="La Pampa" />
                    <asp:ListItem Text="La Rioja" />
                    <asp:ListItem Text="Mendoza" />
                    <asp:ListItem Text="Misiones" />
                    <asp:ListItem Text="Neuquén" />
                    <asp:ListItem Text="Rio Negro" />
                    <asp:ListItem Text="Salta" />
                    <asp:ListItem Text="San Juan" />
                    <asp:ListItem Text="San Luis" />
                    <asp:ListItem Text="Santa Cruz" />
                    <asp:ListItem Text="Santa Fe" />
                    <asp:ListItem Text="Santiago del Estero" />
                    <asp:ListItem Text="Tierra del Fuego" />
                    <asp:ListItem Text="Tucumán" />
                </asp:DropDownList>
            </div>--%>
            <div class="mb-3">
                <asp:CheckBox Text="Acepto los términos y condiciones." runat="server" />
            </div>



            <asp:Button Text="Participar!" ID="btnParticipar" CssClass="btn btn-primary" OnClick="btnParticipar_Click" runat="server" />

        </div>
        <div class="col-3"></div>

    </div>



</asp:Content>
