using System;
using dominio;
using negocio;

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
            try
            {
                if ( voucher.FechaCanje == null)
                {
                    // Si el voucher es válido y no se ha utilizado, redirige a ArticulosPremios
                    Session["voucher"] = voucher;
                    Response.Redirect("ArticulosPremios.aspx");
                }
                else if (voucher.CodigoVoucher != null && voucher.IdCliente != null && voucher.FechaCanje != null && voucher.IdArticulo != null)
                {
                    // Si el voucher ya ha sido utilizado, redirige a la pantalla de VoucherYaCargado
                    Response.Redirect("VoucherYaCargado.aspx");
                }
                else
                {
                    // Si no existe el voucher o no es válido, redirige a la pantalla de VoucherInvalido
                    Response.Redirect("VoucherInvalido.aspx");
                }

            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}