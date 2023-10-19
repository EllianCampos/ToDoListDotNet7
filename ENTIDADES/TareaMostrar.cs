using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class TareaMostrar
    {
        public int IdTarea { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Categoria { get; set; }
        public string Apuntes { get; set; }

        public TareaMostrar() { }

        public TareaMostrar(int idTarea, string titulo, DateTime fecha, string estado, string categoria, string apuntes)
        {
            IdTarea = idTarea;
            Titulo = titulo;
            Fecha = fecha;
            Estado = estado;
            Categoria = categoria;
            Apuntes = apuntes;
        }
    }
}
