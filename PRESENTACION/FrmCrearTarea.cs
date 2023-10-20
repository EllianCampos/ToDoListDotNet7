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
        LogicaCategorias logicaCategorias = new LogicaCategorias();

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

            if (cbEstado.Text.Equals(""))
            {
                errorProvider1.SetError(cbEstado, "Campo requerido");
                errorFlag = true;
            }

            if (cbCategoria.Text.Equals(""))
            {
                errorProvider1.SetError(cbCategoria, "Campos requerido");
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
            cbEstado.Items.Clear();
            foreach (Estado estado in logicaEstados.ObtenerEstados())
                cbEstado.Items.Add(estado.Nombre);

            cbCategoria.Items.Clear();
            foreach (Categoria categoria in logicaCategorias.ObtenerCategorias())
                cbCategoria.Items.Add(categoria.Nombre);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (ValidarCampos()) return;

            // Obtener el ID del estado
            List<Estado> listaEstados = logicaEstados.ObtenerEstados();
            int idEstado = listaEstados[cbEstado.SelectedIndex].IdEstado;

            // Obtener el ID de la categoría
            List<Categoria> listaCategorias = logicaCategorias.ObtenerCategorias();
            int idCategoria = listaCategorias[cbCategoria.SelectedIndex].IdCategoria;


            // Crear una nueva tarea
            if (!logicaTareas.CrearTarea(new Tarea(txtTitulo.Text, dtpFecha.Value.ToShortDateString(),
                idEstado, idCategoria, txtApuntes.Text)))
            {
                MessageBox.Show("No se ha podido crear la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LimpiarCampos();
            this.Close();
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Close();
        }
    }
}
