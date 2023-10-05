using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
	public class Categoria
	{
		public int IdCategoria { get; set; }
		public string Nombre { get; set; }
		public int Activo { get; set; }

		public Categoria(string nombre)
		{
			Nombre = nombre;
		}

		public Categoria(int idCategoria, string nombre)
		{
            IdCategoria = idCategoria;
			Nombre = nombre;
		}

		public Categoria(int idCategoria, string nombre, int activo)
		{
            IdCategoria = idCategoria;
			Nombre = nombre;
			Activo = activo;
		}
	}
}
