<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VoucherInvalido.aspx.cs" Inherits="tp_promoweb_equipo14B.VoucherInvalido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center; style=text-aling">
        <div class="d-flex justify-content-center align-items-center vh-100">
  <div class="p-5 bg-light " >
    <h2 class="fw-bold">El voucher no es valido</h2>
      <div class="fs-3 fw-bold" >
      <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
      </div>
    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_click" class="btn btn-primary mt-3"/>       
  </div>
</div>
</asp:Content>
