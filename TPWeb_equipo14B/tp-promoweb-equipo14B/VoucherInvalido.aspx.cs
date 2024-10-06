using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace tp_promoweb_equipo14B
{
    public partial class VoucherInvalido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Voucher voucher = (Voucher)Session["voucher"];
            if (voucher.CodigoVoucher != null)
            {
              lblError.Text = "Voucher ya cargado"; 
            }
            else
            {
              lblError.Text = "Codigo de voucher inexistente";
            }

        }
        protected void btnVolver_click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


    }
}