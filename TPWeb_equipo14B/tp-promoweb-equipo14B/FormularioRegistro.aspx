<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormularioRegistro.aspx.cs" Inherits="tp_promoweb_equipo14B.FormularioRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-3"></div>
        <div class="col">
            <div class="mb-3">
                <label for="txtDNI" class="form-label">DNI</label>
                <asp:TextBox runat="server" AutoPostBack="true" CssClass="form-control" ID="txtDNI" OnTextChanged="txtDNI_TextChanged" CausesValidation="False" />
                <asp:Label runat="server" ID="lblErrorDNI" ForeColor="Red"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre" AutoPostBack="True" OnTextChanged="txtNombre_TextChanged" CausesValidation="False" />
                <asp:Label runat="server" ID="lblErrorNombre" ForeColor="Red"></asp:Label>

            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox runat="server" CssClass="form-control" AutoPostBack="True" ID="txtApellido" OnTextChanged="txtApellido_TextChanged" />
                <asp:Label runat="server" ID="lblErrorApellido" ForeColor="Red"></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" CssClass="form-control" AutoPostBack="True" ID="txtEmail" OnTextChanged="txtEmail_TextChanged" />
                <asp:Label runat="server" ID="lblErrorEmail" ForeColor="Red"></asp:Label>
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
                <asp:TextBox runat="server" CssClass="form-control" AutoPostBack="True" ID="txtCP" OnTextChanged="txtCP_TextChanged" />
                <asp:Label runat="server" ID="lblErrorCP" ForeColor="Red"></asp:Label>
            </div>
            <div class="mb-3">
                <asp:CheckBox ID="chkTerminos" Text="Acepto los términos y condiciones." runat="server" />
                <asp:Label runat="server" ID="lblErrorTerminos" ForeColor="Red"></asp:Label>
            </div>
            <asp:Label runat="server" ID="lblErrorParticipar" ForeColor="Red"></asp:Label>
            <asp:Button Text="Participar!" ID="btnParticipar" CssClass="btn btn-primary" OnClick="btnParticipar_Click" runat="server" />

        </div>
        <div class="col-3"></div>

    </div>



</asp:Content>
