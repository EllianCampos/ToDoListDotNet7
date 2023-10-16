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
        LogicaEstados logicaEstados = new LogicaEstados();
        LogicaCategorias logicaCategorias = new LogicaCategorias();
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

        private void FrmEditarTarea_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            foreach (Estado estado in logicaEstados.ObtenerEstados())
                cbEstado.Items.Add(estado.Nombre);

            cbCategoria.Items.Clear();
            foreach (Categoria categoria in logicaCategorias.ObtenerCategorias())
                cbCategoria.Items.Add(categoria.Nombre);
        }

        private void FrmEditarTarea_Load_1(object sender, EventArgs e)
        {

        }
    }
}
