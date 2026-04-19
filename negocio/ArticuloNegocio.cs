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
        public List<Articulo> lista()
        {
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, IdCategoria, Precio FROM ARTICULOS A, MARCAS M WHERE A.IdMarca = M.Id");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = (int)datos.Lector["Id"];
					aux.Codigo = (string)datos.Lector["Codigo"];
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
					aux.Marca = new Marca();
					aux.Marca.Id = (int)datos.Lector["IdMarca"];
					aux.Marca.Descripcion = (string)datos.Lector["Marca"];
					//aux.IdCategoria = (Categoria)datos.Lector["IdCategoria"];
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
		
    }
}
