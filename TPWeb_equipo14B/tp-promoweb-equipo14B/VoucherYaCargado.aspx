<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VoucherYaCargado.aspx.cs" Inherits="tp_promoweb_equipo14B.VoucherYaCargado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center; style=text-aling">
        <div class="d-flex justify-content-center align-items-center vh-100">
  <div class="p-5 bg-light">
    <h2>El voucher ya fue cargado</h2>
    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_click" class="btn btn-primary" />       
  </div>
</div>
</asp:Content>