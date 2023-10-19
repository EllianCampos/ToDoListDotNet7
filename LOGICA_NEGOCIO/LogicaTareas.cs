using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SQLite;
using System.Data;
using System.Threading;
using DATOS;
using ENTIDADES;

namespace LOGICA_NEGOCIO
{
	public class LogicaTareas
	{
		Datos datos = new Datos();

		public bool CrearTarea(Tarea tarea)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "INSERT INTO Tareas(TituloTarea, FechaTarea, IdEstado, IdCategoria, " +
				"ApuntesTarea) VALUES(@titulo, @fecha, @idEstado, @idCategoria, @apuntes)";
			cmd.Parameters.AddWithValue("@titulo", tarea.Titulo);
			cmd.Parameters.AddWithValue("@fecha", tarea.Fecha);
			cmd.Parameters.AddWithValue("@idEstado", tarea.IdEstado);
			cmd.Parameters.AddWithValue("@idCategoria", tarea.IdCategoria);
			cmd.Parameters.AddWithValue("@apuntes", tarea.Apuntes);

			return datos.Ejecutar(cmd);
		}

		public List<TareaMostrar> ObtenerTareas()
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "SELECT * FROM Tareas t, Categorias c, Estados e WHERE t.IdCategoria = c.IdCategoria AND t.IdEstado = e.IdEstado";
			DataTable dt = datos.Obtener(cmd);

			List<TareaMostrar> listaTareas = new List<TareaMostrar>();
			foreach (DataRow row in dt.Rows)
			{
				listaTareas.Add(new TareaMostrar(
						Convert.ToInt32(row["IdTarea"]),
						Convert.ToString(row["TituloTarea"]),
						Convert.ToDateTime(row["FechaTarea"]),
						Convert.ToString(row["NombreEstado"]),
						Convert.ToString(row["NombreCategoria"]),
						Convert.ToString(row["ApuntesTarea"])
					));
			}
			return listaTareas;
		}

        public Tarea ObtenerTarea(int id)
		{
			// Obtener la tarea
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT * FROM Tareas WHERE IdTarea = @idTarea";
			cmd.Parameters.AddWithValue("@idTarea", id);
            DataTable dt = datos.Obtener(cmd);

			// Validar si encontro la tarea
			if (dt.Rows.Count == 0) 
			{ 
				return new Tarea(); 
			}

			// Crear el objeto tarea
			DataRow row = dt.Rows[0];
			Tarea tarea = new Tarea
			{
				IdTarea = id,
				Titulo = row["TituloTarea"].ToString(),
				Fecha = Convert.ToDateTime(row["FechaTarea"]),
				IdEstado = Convert.ToInt32(row["IdEstado"]),
				IdCategoria = Convert.ToInt32(row["IdCategoria"]),
				Apuntes = row["ApuntesTarea"].ToString()
			};

			return tarea;
        }


        public bool ActualizarTarea(Tarea tarea)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "UPDATE Tareas SET TituloTarea = @titulo, FechaTarea = @fecha, " +
                "IdEstado = @idEstado, IdCategoria = @idCategoria, ApuntesTarea = @apuntes " +
				"WHERE IdTarea = @idtarea";
			cmd.Parameters.AddWithValue("@titulo", tarea.Titulo);
			cmd.Parameters.AddWithValue("@fecha", tarea.Fecha);
            cmd.Parameters.AddWithValue("@idEstado", tarea.IdEstado);
            cmd.Parameters.AddWithValue("@idCategoria", tarea.IdCategoria);
            cmd.Parameters.AddWithValue("@apuntes", tarea.Apuntes);
			cmd.Parameters.AddWithValue("@idtarea", tarea.IdTarea);

			return datos.Ejecutar(cmd);
		}

		public bool EliminarTarea(int idTarea)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "DELETE FROM Tareas WHERE IdTarea = @idTarea";
			cmd.Parameters.AddWithValue("@idTarea", idTarea);

			return datos.Ejecutar(cmd);
		}
	}
}