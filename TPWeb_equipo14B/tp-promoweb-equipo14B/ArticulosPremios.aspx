<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArticulosPremios.aspx.cs" Inherits="tp_promoweb_equipo14B.ArticulosPremios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Articulos para seleccionar</h3>


            <div class="row">
                <asp:Repeater runat="server" ID="repRepetidor">
                    <ItemTemplate>
                        <div class="col-md-4 mb-4 article-card">
                            <div class="card shadow-sm border-dark mx-auto h-100 d-flex flex-column" style="width: 18rem; min-height: 100%;">
                                <img class="card-img-top" src='<%# Eval("Imagen") %>' alt="Card image cap" style="object-fit: contain; height: 200px; padding: 10px;" />
                                <div class="card-body d-flex flex-column">
                                    <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                    <p class="card-text"><%# Eval("Descripcion") %></p>
                                    <p class="card-text flex-grow-1"></p>
                                    <div class="mt-auto">
                                        <asp:Button
                                            ID="btnElegir"
                                            runat="server"
                                            Text='<%# ObtenerTextoBoton(Container.ItemIndex) %>'
                                            CssClass="btn btn-primary btn-block mb-2"
                                            Style="background-color: #007bff; color: white;" OnClick="btnElegir_Click" CommandArgument='<%# Eval("Id") %>' />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>

</asp:Content>
