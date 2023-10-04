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
							cmd.CommandText = "UPDATE FROM estados SET Nombre Activo = 1 WHERE Nombre = @nombre";
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
				cmd.CommandText = "INSERT INTO estados(Nombre, Activo) VALUES(@nombre, 1)";
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
			cmd.CommandText = "SELECT Id_Estado, Nombre, Activo FROM estados WHERE Activo = 1";
			DataTable dt = datos.Obtener(cmd);

			List<Estado> listaEstados = new List<Estado>();	
			foreach (DataRow dr in dt.Rows)
			{
				listaEstados.Add(new Estado(
					Convert.ToInt32(dr["Id_Estado"]), 
					Convert.ToString(dr["Nombre"]),
					Convert.ToInt32(dr["Activo"])
				));
			}
			return listaEstados;
		}	

		public bool ActualizarEstado(Estado estado)
		{
			cmd = new SQLiteCommand();
			cmd.CommandText = "UPDATE estados SET Nombre = @nombre WHERE Id_Estado = @idEstado";
			cmd.Parameters.AddWithValue("@nombre", estado.Nombre);
			cmd.Parameters.AddWithValue("@idEstado", estado.IdEstado);
			return datos.Ejecutar(cmd);
		}


		public bool EliminarEstado(int id)
		{
			cmd = new SQLiteCommand();
			cmd.CommandText = "UPDATE estados SET Activo = 0 WHERE Id_Estado = @idEstado";
			cmd.Parameters.AddWithValue ("@idEstado", id);	
			return datos.Ejecutar(cmd);	
		}
	}
}
