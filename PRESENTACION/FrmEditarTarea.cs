using ENTIDADES;
using LOGICA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
	public partial class FrmEditarTarea : Form
	{
		LogicaTareas logicaTareas = new LogicaTareas();
		public int idTarea;

		public FrmEditarTarea()
		{
			InitializeComponent();
		}

		// Validar campos 
		public bool ValidarCampos()
		{
			bool errorFlag = false;
			errorProvider1.Clear();

			if (txtTitulo.Text.Equals(""))
			{
				errorProvider1.SetError(txtTitulo, "Campo requerido");
				errorFlag = true;
			}

			if (errorFlag) { return true; } else { return false; }
		}

		private void txtApuntes_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnCrear_Click(object sender, EventArgs e)
		{

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			// Validar campos
			if (ValidarCampos()) return;

			// Crear una nueva tarea
			if (!logicaTareas.ActualizarTarea(new Tarea(idTarea, txtTitulo.Text, dtpFecha.Value,
				cbEstado.Text, cbCategoria.Text, txtApuntes.Text)))
			{
				MessageBox.Show("No se han podido guardar los cambios de la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (!logicaTareas.EliminarTarea(idTarea))
			{
				MessageBox.Show("No se ha podido eliminar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Close();
		}
	}
}
