using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDADES;

namespace LOGICA_NEGOCIO
{
	public class LogicaEstados
	{
		Datos datos = new Datos();
		SQLiteCommand cmd;

		public Respuesta CrearEstado(Estado estado)
		{
			List<Estado> listaEstados = ObtenerEstados();
			try
			{
				// Validar si ya existe
				foreach (Estado item in listaEstados)
				{
					if (item.Nombre == estado.Nombre)
					{
						// Validar si ya existe y esta activo
						if (item.Activo == 1)
						{
							return new Respuesta { Resultado = false, Mensaje = "El estado ya existe" };
						}
						// Ya existe pero esta INACTIVO
						// Activarlo porque en el pasado existio
						else
						{
							// Activar el estado
							cmd = new SQLiteCommand();
							cmd.CommandText = "UPDATE FROM Estados SET Activo = 1 WHERE NombreEstado = @nombre";
							cmd.Parameters.AddWithValue("@nombre", estado.Nombre);
							if (datos.Ejecutar(cmd))
							{
								return new Respuesta { Resultado = true, Mensaje = "Estado creado exitosamente" };
							}
							else
							{
								return new Respuesta { Resultado = false, Mensaje = "No se ha podido crear el estado" };
							}
						}
					}
				}

				// Crear el nuevo estado
				cmd = new SQLiteCommand();
				cmd.CommandText = "INSERT INTO Estados(NombreEstado, ActivoEstado) VALUES(@nombre, 1)";
				cmd.Parameters.AddWithValue("@nombre", estado.Nombre);
				if (datos.Ejecutar(cmd))
				{
					return new Respuesta { Resultado = true, Mensaje = "Estado creado exitosamente" };
				}
				else
				{
					return new Respuesta { Resultado = false, Mensaje = "No se ha podido crear el estado" };
				}
			}
			catch (Exception)
			{
				return new Respuesta { Resultado = false, Mensaje = "No se ha podido crear el estado" };
			}
		}

		public List<Estado> ObtenerEstados()
		{
			cmd = new SQLiteCommand();
			cmd.CommandText = "SELECT * FROM Estados WHERE ActivoEstado = 1";
			DataTable dt = datos.Obtener(cmd);

			List<Estado> listaEstados = new List<Estado>();	
			foreach (DataRow dr in dt.Rows)
			{
				listaEstados.Add(new Estado(
					Convert.ToInt32(dr["IdEstado"]), 
					Convert.ToString(dr["NombreEstado"]),
					Convert.ToInt32(dr["ActivoEstado"])
				));
			}
			return listaEstados;
		}	

		public bool ActualizarEstado(Estado estado)
		{
			cmd = new SQLiteCommand();
			cmd.CommandText = "UPDATE Estados SET NombreEstado = @nombre WHERE IdEstado = @idEstado";
			cmd.Parameters.AddWithValue("@nombre", estado.Nombre);
			cmd.Parameters.AddWithValue("@idEstado", estado.IdEstado);
			return datos.Ejecutar(cmd);
		}

		public bool EliminarEstado(int id)
		{
			cmd = new SQLiteCommand();
			cmd.CommandText = "UPDATE Estados SET ActivoEstado = 0 WHERE IdEstado = @idEstado";
			cmd.Parameters.AddWithValue ("@idEstado", id);	
			return datos.Ejecutar(cmd);	
		}
	}
}
