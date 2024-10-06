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
                if (voucher.CodigoVoucher != null)
                {
                    Session["voucher"] = voucher;
                    Response.Redirect("ArticulosPremios.aspx");
                    //ponerle una label en la ventana que se abre 


                }
                else
                {
                    //lblError.Text = "Voucher inexistente";
                    Response.Redirect("VoucherInvalido.aspx");
                    //ponerle una lbl en la ventana que se abre
                }

            }
            catch (Exception)
            {

                throw;
            }
           

        }
    }
}