using dominio;
using System;

namespace negocio
{
    public class VoucherNegocio
    {


        public Voucher BuscarVoucher(string codigo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {


                datos.setearConsulta("SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo from VOUCHERS where CodigoVoucher = @Codigo");
                datos.setearParametro("@Codigo", codigo);
                datos.ejecutarLectura();

                Voucher voucher = new Voucher();
                if (datos.Lector.Read())
                {
                    voucher.CodigoVoucher = datos.Lector.GetString(0);
                    try
                    {
                        //voucher.CodigoVoucher = datos.Lector.GetString(0);
                        voucher.IdCliente = datos.Lector.GetInt32(1);
                        voucher.FechaCanje = datos.Lector.GetDateTime(2);
                        voucher.IdArticulo = datos.Lector.GetInt32(3);

                    }
                    catch (Exception)
                    {

                    }
                }
                return voucher;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}