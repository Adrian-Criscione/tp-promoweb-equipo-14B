using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            try
            {
                // Intentar obtener el idArticulo de la sesión
                int idArticulo = (int)(Session["idArticulo"] ?? throw new InvalidOperationException("El idArticulo no está establecido."));

                DateTime fechaActual = DateTime.Now;

                Voucher voucher = (Voucher)Session["voucher"];
                VoucherNegocio voucherNegocio = new VoucherNegocio();
                ClienteNegocio negocio = new ClienteNegocio();
                Cliente resultado = negocio.BuscarCliente(txtDNI.Text);

                // Asignar el IdArticulo al voucher
                voucher.IdArticulo = idArticulo;
                voucher.FechaCanje = fechaActual;

                if (!ValidarTerminos())
                {
                    if (resultado.Id == 0)
                    {
                        generarCliente();
                        resultado = negocio.BuscarCliente(txtDNI.Text);
                        voucher.IdCliente = resultado.Id;
                    }
                    else
                    {
                        voucher.IdCliente = resultado.Id;
                    }

                    voucherNegocio.modificarVoucher(voucher);
                    Response.Redirect("Gracias.aspx", false);
                }
            }
            catch (InvalidOperationException ex)
            {
                // Manejar el caso donde idArticulo no está establecido
                lblErrorParticipar.Text = ex.Message; // Muestra un mensaje específico al usuario
            }
            catch (Exception ex)
            {
                // Manejar cualquier otra excepción que pueda ocurrir
                lblErrorParticipar.Text = "Error al procesar la participación: " + ex.Message;
                
            }
        }
        protected void generarCliente()
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteNegocio negocio = new ClienteNegocio();

                // Asignar valores a las propiedades del cliente
                cliente.Documento = txtDNI.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Email = txtEmail.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Ciudad = txtCiudad.Text;
                cliente.CP = Convert.ToInt32(txtCP.Text);

                // Llamar al método para agregar el cliente
                negocio.agregarCliente(cliente);
            }
            catch (FormatException ex)
            {
                // Manejar el error de formato (por ejemplo, si CP no es un número)
                lblErrorCP.Text = "Error: El código postal debe ser un número válido.";
                // También puedes registrar el error o tomar otras acciones si es necesario
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro tipo de excepción
                lblErrorParticipar.Text = "Error al generar el cliente: " + ex.Message;
                // Aquí también puedes registrar el error si es necesario
            }
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

            ValidarSoloNumeros(txtDNI, lblErrorDNI);
        }
        private void ValidarSoloNumeros(TextBox textBox, Label labelError)
        {
            int result;
            if (!int.TryParse(textBox.Text, out result))
            {
                labelError.Text = "Por favor, ingrese solo números.";
                textBox.Text = "";  // Limpiar el campo si la entrada no es válida
            }
            else
            {
                labelError.Text = "";  // Limpiar el mensaje de error si la entrada es válida
            }
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloTexto(txtNombre, lblErrorNombre);
        }
        private void ValidarSoloTexto(TextBox textBox, Label labelError)
        {
            // Expresión regular que solo permite letras (mayúsculas, minúsculas) y espacios
            string pattern = @"^[a-zA-Z\s]+$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, pattern))
            {
                labelError.Text = "Por favor, ingrese solo letras.";
                textBox.Text = "";  // Limpiar el campo si la entrada no es válida
            }
            else
            {
                labelError.Text = "";  // Limpiar el mensaje de error si la entrada es válida
            }
        }

        protected void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloTexto(txtApellido, lblErrorApellido);
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidarEmail(txtEmail, lblErrorEmail);
        }
        private void ValidarEmail(TextBox textBox, Label labelError)
        {
            // Expresión regular para validar un email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, pattern))
            {
                labelError.Text = "Por favor, ingrese un email válido.";
                textBox.Text = "";  // Limpiar el campo si el email no es válido
            }
            else
            {
                labelError.Text = "";  // Limpiar mensaje de error si el email es válido
            }
        }

        protected void txtCP_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtCP, lblErrorCP);
        }
        protected bool ValidarTerminos()
        {
            // Limpiar mensajes de error
            lblErrorTerminos.Text = "";

            // Validar si el CheckBox está marcado
            if (!chkTerminos.Checked)
            {
                lblErrorTerminos.Text = "Debes aceptar los términos y condiciones.";
                return false; // Retorna false si no está marcado
            }

            return true; // Retorna true si está marcado
        }
    }
}