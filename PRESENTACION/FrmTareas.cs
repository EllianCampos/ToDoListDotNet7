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
	public partial class FrmTareas : Form
	{
		FrmCrearTarea frmCrearTarea = new FrmCrearTarea();
		FrmEditarTarea frmEditarTarea = new FrmEditarTarea();
		FrmConfig frmConfig = new FrmConfig();
		LogicaTareas logicaTareas = new LogicaTareas();

		public FrmTareas()
		{
			InitializeComponent();
		}

		public void MostrarTareas()
		{
			dgvTareas.DataSource = null;
			dgvTareas.DataSource = logicaTareas.ObtenerTareas();
			dgvTareas.Columns["IdTarea"].Visible = false;
		}

		private void FrmTareas_Load(object sender, EventArgs e)
		{
			MostrarTareas();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			frmCrearTarea.ShowDialog();
			MostrarTareas();
		}

		private void dgvTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			frmEditarTarea.idTarea = Convert.ToInt32(dgvTareas.Rows[e.RowIndex].Cells["IdTarea"].Value);
			frmEditarTarea.txtTitulo.Text = Convert.ToString(dgvTareas.SelectedRows[0].Cells[1].Value);
			frmEditarTarea.dtpFecha.Value = Convert.ToDateTime(dgvTareas.SelectedRows[0].Cells[2].Value);
			frmEditarTarea.cbEstado.Text = Convert.ToString(dgvTareas.SelectedRows[0].Cells[3].Value);
			frmEditarTarea.cbCategoria.Text = Convert.ToString(dgvTareas.SelectedRows[0].Cells[4].Value);
			frmEditarTarea.txtApuntes.Text = Convert.ToString(dgvTareas.SelectedRows[0].Cells[5].Value);
			frmEditarTarea.ShowDialog();
			MostrarTareas();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnConfig_Click(object sender, EventArgs e)
		{
			frmConfig.ShowDialog();
			MostrarTareas();
		}
	}
}
