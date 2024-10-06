using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_promoweb_equipo14B
{
    public partial class VoucherInvalido : System.Web.UI.Page
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