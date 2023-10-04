namespace ENTIDADES
{
	public class Tarea
	{
		public int IdTarea { get; set; }
		public string Titulo { get; set; }
		public DateTime Fecha { get; set; }
		public string Estado { get; set; }
		public string Categoria { get; set; }
		public string Apuntes { get; set; }

		// Constructor crear tarea
		public Tarea(string titulo, DateTime fecha, string estado, string categoria, string apuntes)
		{
			this.Titulo = titulo;
			this.Fecha = fecha;
			this.Estado = estado;
			this.Categoria = categoria;
			this.Apuntes = apuntes;
		}

		// Constructor
		public Tarea(int idTarea, string titulo, DateTime fecha, string estado, string categoria, string apuntes)
		{
			this.IdTarea = idTarea;
			this.Titulo = titulo;
			this.Fecha = fecha;
			this.Estado = estado;
			this.Categoria = categoria;
			this.Apuntes = apuntes;
		}
	}
}