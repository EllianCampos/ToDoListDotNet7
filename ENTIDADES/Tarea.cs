namespace ENTIDADES
{
	public class Tarea
	{
		public int IdTarea { get; set; }
		public string Titulo { get; set; }
		public DateTime Fecha { get; set; }
		public int IdEstado { get; set; }
		public int IdCategoria { get; set; }
		public string Apuntes { get; set; }

		public Tarea () { }

		// Constructor crear tarea
		public Tarea(string titulo, DateTime fecha, int idEstado, int idCategoria, string apuntes)
		{
			this.Titulo = titulo;
			this.Fecha = fecha;
			this.IdEstado = idEstado;
			this.IdCategoria = idCategoria;
			this.Apuntes = apuntes;
		}

		// Constructor
		public Tarea(int idTarea, string titulo, DateTime fecha, int idEstado, int idCategoria, string apuntes)
		{
			this.IdTarea = idTarea;
			this.Titulo = titulo;
			this.Fecha = fecha;
            this.IdEstado = idEstado;
            this.IdCategoria = idCategoria;
            this.Apuntes = apuntes;
		}
	}
}