using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
	public class Categoria
	{
		public int IdEstado { get; set; }
		public string Nombre { get; set; }
		public int Activo { get; set; }

		public Categoria(string nombre)
		{
			Nombre = nombre;
		}

		public Categoria(int idEstado, string nombre)
		{
			IdEstado = idEstado;
			Nombre = nombre;
		}

		public Categoria(int idEstado, string nombre, int activo)
		{
			IdEstado = idEstado;
			Nombre = nombre;
			Activo = activo;
		}
	}
}
