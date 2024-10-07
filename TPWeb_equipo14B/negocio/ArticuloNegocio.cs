using dominio;
using System;
using System.Collections.Generic;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearConsulta("select codigo, nombre, a.descripcion, m.Descripcion as MARCAS, c.Descripcion as CATEGORIAS, precio from ARTICULOS a inner join MARCAS m on a.IdMarca = m.id inner join CATEGORIAS c on a.idcategoria = c.Id"); // aca va la consulta.
                datos.setearConsulta("SELECT A.id,A.Codigo, A.Nombre, A.Descripcion AS ArticuloDescripcion, m.id as IdMarca, M.Descripcion AS Marcas,c.Id as IdCategoria, C.Descripcion AS Categorias, A.Precio, I.ImagenUrl FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo"); // aca va la consulta.
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];

                    if (!(datos.Lector["Codigo"] is DBNull))
                    {
                        aux.CodigoArticulo = (string)datos.Lector["Codigo"];

                    }
                    if (!(datos.Lector["Nombre"] is DBNull))
                    {

                        aux.Nombre = (string)datos.Lector["Nombre"];

                    }
                    if (!(datos.Lector["ArticuloDescripcion"] is DBNull))
                    {
                        aux.Descripcion = (string)datos.Lector["ArticuloDescripcion"];
                    }

                    if (!(datos.Lector["Marcas"] is DBNull) || !(datos.Lector["IdMarca"] is DBNull))
                    {
                        aux.Marca = new Marca();
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                        aux.Marca.Descripcion = (string)datos.Lector["Marcas"];
                    }

                    if (!(datos.Lector["Categorias"] is DBNull) || !(datos.Lector["IdCategoria"] is DBNull))
                    {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                        aux.Categoria.Descripcion = (string)datos.Lector["Categorias"];
                    }

                    if (!(datos.Lector["Precio"] is DBNull))
                    {
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    }
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    }

                    lista.Add(aux);
                }
                return lista;
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
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //INSERT DE LA CONSULTA
                datos.setearConsulta("insert into ARTICULOS (codigo,nombre,Descripcion,IdMarca,IdCategoria,precio) values(@CodigoArticulo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                //SETEAR LOS VALORES A LAS VARIABLES QUE SE PASAN EN LA CONSULTA.
                datos.setearParametro("@CodigoArticulo", nuevo.CodigoArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

                //EJECUTA EL OPEN Y LA QUERY 
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
        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, idcategoria = @IdCategoria, Precio = @Precio where id = @Id");
                datos.setearParametro("@codigo", modificar.CodigoArticulo);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Descripcion", modificar.Descripcion);
                //datos.setearParametro("@Imagen", modificar.Imagen);
                datos.setearParametro("@IdMarca", modificar.Marca.Id);
                datos.setearParametro("@IdCategoria", modificar.Categoria.Id);
                datos.setearParametro("@Precio", modificar.Precio);
                datos.setearParametro("@Id", modificar.Id);

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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametro("@ID", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}

