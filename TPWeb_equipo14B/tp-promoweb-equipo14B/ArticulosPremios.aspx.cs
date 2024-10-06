using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;


namespace tp_promoweb_equipo14B
{
    public partial class ArticulosPremios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        protected void cargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista = negocio.listar();

            var listaSinDuplicados = lista.GroupBy(a => a.CodigoArticulo)
                                          .Select(g => g.First())
                                          .ToList();

            repRepetidor.DataSource = listaSinDuplicados;
            repRepetidor.DataBind();
        }

        protected string ObtenerTextoBoton(int index)
        {
            switch (index)
            {
                case 0:
                    return "Quiero este!";
                case 1:
                    return "No este!";
                case 2:
                    return "Mejor este!";
                default:
                    return "Seleccionar";
            }
        }
    }
}