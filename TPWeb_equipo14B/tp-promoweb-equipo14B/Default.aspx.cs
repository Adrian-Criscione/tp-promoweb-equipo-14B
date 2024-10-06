using dominio;
using negocio;
using System;

namespace tp_promoweb_equipo14B
{
    public partial class Default : System.Web.UI.Page
    {
        VoucherNegocio vn = new VoucherNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Voucher voucher = vn.BuscarVoucher(txtVoucher.Text);

            if (voucher.CodigoVoucher != null && voucher.IdCliente == 0)
            {
                // Si el voucher es válido y no se ha utilizado, redirige a ArticulosPremios
                Session["voucher"] = voucher;
                Response.Redirect("ArticulosPremios.aspx");
            }
            else
            {
                // Si no existe el voucher o no es válido, redirige a la pantalla de VoucherInvalido
                Session["voucher"] = voucher;
                Response.Redirect("VoucherInvalido.aspx");
            }




        }

    }
}