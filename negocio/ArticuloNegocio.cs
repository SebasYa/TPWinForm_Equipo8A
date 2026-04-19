using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

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
				datos.setearConsulta("SELECT A.Id, Codigo ,Nombre ,A.Descripcion ,IdMarca ,IdCategoria ,M.Descripcion Marca ,C.Descripcion Categoria ,I.ImagenUrl ,Precio FROM ARTICULOS A, IMAGENES I, CATEGORIAS C, MARCAS M WHERE C.Id = A.IdCategoria AND M.Id = A.IdMarca AND I.IdArticulo = A.Id");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
					aux.IdMarca = new Marca(); 
					aux.IdMarca.Id = (int)datos.Lector["IdMarca"];
                    aux.IdMarca.Descripcion = (string)datos.Lector["Marca"];
                    aux.IdCategoria = new Categoria();
                    aux.IdCategoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.IdCategoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = new Imagen();
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];


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
                datos.setearConsulta(@"INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
                                       VALUES (@codigo, @nombre, @descripcion, @IdMarca, @IdCategoria, @Precio);
                                       SELECT SCOPE_IDENTITY();");

                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.IdMarca.Id);
                datos.setearParametro("@IdCategoria", nuevo.IdCategoria.Id);
                datos.setearParametro("@precio", nuevo.Precio);


                //int idArticulo = Convert.ToInt32(datos.ejecutarScalar());
                int idArticulo = (int)datos.ejecutarScalar();

                datos.setearConsulta(@"INSERT INTO IMAGENES (ImagenUrl, IdArticulo)
                                       VALUES (@imagen, @IdArticulo)");

                datos.setearParametro("@imagen", nuevo.ImagenUrl);
                datos.setearParametro("@IdArticulo", idArticulo);

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

       /* public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad where Id = @id");
                datos.setearParametro("@numero", articulo.Numero);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@desc", articulo.Descripcion);
                datos.setearParametro("@img", articulo.Imagen);
                datos.setearParametro("@idTipo", articulo.Tipo.Id);
                datos.setearParametro("@idDebilidad", articulo.Debilidad.Id);
                datos.setearParametro("@id", articulo.Id);

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
        }*/
    }
}
