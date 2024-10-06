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
        public void modificarVoucher(Voucher modifVoucher)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE VOUCHERS SET IDCLIENTE = @IDCLIENTE, FECHACANJE = @FECHACANJE, IDARTICULO = @IDARTICULO WHERE CODIGOVOUCHER = @CODVOUCHER");
                datos.setearParametro("@IDARTICULO", modifVoucher.IdArticulo);
                datos.setearParametro("@FECHACANJE", modifVoucher.FechaCanje);
                datos.setearParametro("@IDCLIENTE", modifVoucher.IdCliente);
                datos.setearParametro("@CODVOUCHER", modifVoucher.CodigoVoucher);
                datos.ejecutarAccion();
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