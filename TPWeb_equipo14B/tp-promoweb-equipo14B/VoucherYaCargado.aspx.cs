using System;

namespace tp_promoweb_equipo14B
{
    public partial class VoucherYaCargado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVolver_click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}