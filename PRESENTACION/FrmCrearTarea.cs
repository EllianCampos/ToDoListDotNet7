using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_NEGOCIO;
using ENTIDADES;

namespace PRESENTACION
{
	public partial class FrmCrearTarea : Form
	{
		LogicaTareas logicaTareas = new LogicaTareas();
		LogicaEstados logicaEstados = new LogicaEstados();

		public FrmCrearTarea()
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

		// Limpiar campos 
		public void LimpiarCampos()
		{
			txtTitulo.Clear();
			cbEstado.Text = "";
			cbCategoria.Text = "";
			txtApuntes.Text = "";
		}

		private void FrmCrearTarea_Load(object sender, EventArgs e)
		{
			MessageBox.Show("hola");
			//cbEstado.DataSource = logicaEstados.ObtenerEstados();
			foreach (var item in logicaEstados.ObtenerEstados())
			{
				MessageBox.Show("ahhh" + item);
			}
		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			// Validar campos
			if (ValidarCampos()) return;

			// Crear una nueva tarea
			if (!logicaTareas.CrearTarea(new Tarea(txtTitulo.Text, dtpFecha.Value,
				cbEstado.Text, cbCategoria.Text, txtApuntes.Text)))
			{
				MessageBox.Show("No se ha podido crear la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			LimpiarCampos();
			this.Close();
		}

		private void FrmCrearTarea_Click(object sender, EventArgs e)
		{
			foreach (var item in logicaEstados.ObtenerEstados())
			{
				MessageBox.Show("ahhh" + item);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
			////MessageBox.Show("hola");
			////List<string> list = logicaEstados.ObtenerEstados();
			////foreach (var item in list)
			////{
			////	MessageBox.Show("ahhh" + item);
			////}
		}
	}
}
