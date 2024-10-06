<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArticulosPremios.aspx.cs" Inherits="tp_promoweb_equipo14B.ArticulosPremios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-3"></div>
            <div class="col">
                <h1>Articulos y Premios</h1>
                <h3>Estos son los articulos y premios disponibles</h3>
                <div class="mb-3">
                    <asp:GridView ID="gvArticulosPremios" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                            <asp:BoundField DataField="Puntos" HeaderText="Puntos" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            <div class="col-3"></div>
        </div>
    </div>
</asp:Content>
