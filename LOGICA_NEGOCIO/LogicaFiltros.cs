using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_NEGOCIO
{
    public class LogicaFiltros
    {
        Datos datos = new Datos();
        SQLiteCommand cmd;
        LogicaTareas logicaTareas = new LogicaTareas();

        public List<TareaMostrar> ObtenerTareasFiltradas(Dictionary<string, bool> filtrosEstados, Dictionary<string, bool> filtrosCategorias, string texto)
        {
            List<TareaMostrar> listaTareas = logicaTareas.ObtenerTareas();
            List<TareaMostrar> nuevaListaTareas = new List<TareaMostrar>();

            foreach (TareaMostrar tarea in listaTareas)
            {
                if (filtrosEstados[tarea.Estado] && filtrosCategorias[tarea.Categoria])
                {
                    if (!texto.Equals(""))
                    {
                        if (tarea.Titulo.ToLower().Contains(texto.Trim().ToLower()))
                        {
                            nuevaListaTareas.Add(tarea);
                        }
                    }
                    else
                    {
                        nuevaListaTareas.Add(tarea);
                    }
                    
                }
            }

            return nuevaListaTareas;
        }
    }
}
