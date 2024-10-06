﻿using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_promoweb_equipo14B
{
    public partial class FormularioRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           




        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            int idArticulo;
            idArticulo = (int)Session["idArticulo"];

            DateTime fechaActual = DateTime.Now;

            Voucher voucher = new Voucher();
            voucher = (Voucher)Session["voucher"];
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            ClienteNegocio negocio = new ClienteNegocio();
            Cliente resultado = negocio.BuscarCliente(txtDNI.Text);

            voucher.IdArticulo = idArticulo;
            voucher.FechaCanje = fechaActual;

       
                voucher.IdCliente = resultado.Id;
                  
            voucherNegocio.modificarVoucher(voucher);
        }


 

        protected void txtDNI_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            ClienteNegocio cliente = new ClienteNegocio();
            Cliente buscado = new Cliente();
            buscado = cliente.BuscarCliente(dni);

            if (buscado.Documento == dni)
            {
                txtApellido.Text = buscado.Apellido;
                txtNombre.Text = buscado.Nombre;
                txtEmail.Text = buscado.Email;
                txtDireccion.Text = buscado.Direccion;
                txtCiudad.Text = buscado.Ciudad;
                txtCP.Text = buscado.CP.ToString();
            }
        }
    }
}