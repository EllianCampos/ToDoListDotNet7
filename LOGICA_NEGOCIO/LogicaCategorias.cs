using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_NEGOCIO
{
	public class LogicaCategorias
	{
		Datos datos = new Datos();
		SQLiteCommand cmd;

		public Respuesta CrearCategoria(Categoria categoria)
		{
			List<Categoria> listaCategorias = ObtenerCategorias();
			try
			{
				// Validar si ya existe
				foreach (Categoria item in listaCategorias)
				{
					if (item.Nombre == categoria.Nombre)
					{
						// Validar si ya existe y esta activo
						if (item.Activo == 1)
						{
							return new Respuesta { Resultado = false, Mensaje = "La categoría ya existe" };
						}
						// Ya existe pero esta INACTIVO
						// Activarlo porque en el pasado existio
						else
						{
							// Activar la categoria
							cmd = new SQLiteCommand();
							cmd.CommandText = "UPDATE FROM Categorias SET ActivoCategoria = 1 WHERE Nombre = @nombre";
							cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
							if (datos.Ejecutar(cmd))
							{
								return new Respuesta { Resultado = true, Mensaje = "Categoría creada exitosamente" };
							}
							else
							{
								return new Respuesta { Resultado = false, Mensaje = "No se ha podido crear la categoría" };
							}
						}
					}
				}

				// Crear la nueva categoria
				cmd = new SQLiteCommand();
				cmd.CommandText = "INSERT INTO Categorias(NombreCategoria, ActivoCategoria) VALUES(@nombre, 1)";
				cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
				if (datos.Ejecutar(cmd))
				{
					return new Respuesta { Resultado = true, Mensaje = "Categoría creada exitosamente" };
				}
				else
				{
					return new Respuesta { Resultado = false, Mensaje = "No se ha podido crear la categoría" };
				}
			}
			catch (Exception)
			{
				return new Respuesta { Resultado = false, Mensaje = "No se ha podido crear la categoría" };
			}
		}

		public List<Categoria> ObtenerCategorias()
		{
			cmd = new SQLiteCommand();
			cmd.CommandText = "SELECT * FROM categorias WHERE ActivoCategoria = 1";
			DataTable dt = datos.Obtener(cmd);

			List<Categoria> listaCategorias = new List<Categoria>();
			foreach (DataRow dr in dt.Rows)
			{
				listaCategorias.Add(new Categoria(
					Convert.ToInt32(dr["IdCategoria"]),
					Convert.ToString(dr["NombreCategoria"]),
					Convert.ToInt32(dr["ActivoCategoria"])
				));
			}
			return listaCategorias;
		}

		public bool ActualizarCategoria(Categoria categoria)
		{
			cmd = new SQLiteCommand();
			cmd.CommandText = "UPDATE Categorias SET NombreCategoria = @nombre WHERE IdCategoria = @idCategoria";
			cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
			cmd.Parameters.AddWithValue("@idCategoria", categoria.IdCategoria);
			return datos.Ejecutar(cmd);
		}

		public bool EliminarCategoria(int id)
		{
			cmd = new SQLiteCommand();
			cmd.CommandText = "UPDATE Categorias SET Activo = 0 WHERE IdCategoria = @idCategoria";
			cmd.Parameters.AddWithValue("@idCategoria", id);
			return datos.Ejecutar(cmd);
		}
	}
}