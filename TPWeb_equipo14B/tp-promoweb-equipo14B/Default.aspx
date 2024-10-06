<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tp_promoweb_equipo14B.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-3"></div>
            <div class="col">
                 <h1>Participá y Ganá!</h1>
                 <h3>Ingresá el código de tu voucher!</h3>
                 <div class="mb-3">
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtVoucher" />
                 </div>
                 <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnSiguiente" OnClick="btnSiguiente_Click" runat="server" />
                <div>
                 <asp:Label ID="lblError" runat="server" CssClass="text-danger" Text=""></asp:Label>
                </div>
            </div>

            <div class="col-3"></div>
           

           
        </div> 
    </div>
    
</asp:Content>
