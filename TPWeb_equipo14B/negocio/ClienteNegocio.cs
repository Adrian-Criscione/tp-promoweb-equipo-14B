﻿using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace negocio
{
    public class ClienteNegocio
    {
        public Cliente BuscarCliente(string dni)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from CLIENTES where Documento = @Dni");
                datos.setearParametro("@Dni", dni);
                datos.ejecutarLectura();

                Cliente cliente = new Cliente();
                if (datos.Lector.Read())
                {
                    cliente.Id = datos.Lector.GetInt32(0);
                    cliente.Documento = datos.Lector.GetString(1);
                    cliente.Nombre = datos.Lector.GetString(2);
                    cliente.Apellido = datos.Lector.GetString(3);
                    cliente.Email = datos.Lector.GetString(4);
                    cliente.Direccion = datos.Lector.GetString(5);
                    cliente.Ciudad = datos.Lector.GetString(6);
                    cliente.CP = datos.Lector.GetInt32(7);
                }
                return cliente;
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
        public void agregarCliente(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO CLIENTES (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.setearParametro("@Documento", cliente.Documento);
                datos.setearParametro("@Nombre", cliente.Nombre);
                datos.setearParametro("@Apellido", cliente.Apellido);
                datos.setearParametro("@Email", cliente.Email);
                datos.setearParametro("@Direccion", cliente.Direccion);
                datos.setearParametro("@Ciudad", cliente.Ciudad);
                datos.setearParametro("@CP", cliente.CP);

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
