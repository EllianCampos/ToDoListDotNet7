using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;
using LOGICA_NEGOCIO;

namespace PRESENTACION
{
    public partial class FrmConfig : Form
    {
        LogicaEstados logicaEstados = new LogicaEstados();
        LogicaCategorias logicaCategorias = new LogicaCategorias();
        List<Estado> listaEstados;
        List<Categoria> listaCategorias;
        int idEstadoEditando = 0;
        int idCategoriaEditando = 0;

        public FrmConfig()
        {
            InitializeComponent();
        }

        // Mostrar estados
        public void MostrarEstados()
        {
            lsbEstados.Items.Clear();
            listaEstados = logicaEstados.ObtenerEstados();
            foreach (Estado estado in listaEstados)
            {
                lsbEstados.Items.Add(estado.Nombre);
            }
        }

        // Mostrar categorias
        public void MostrarCategorias()
        {
            lsbCategorias.Items.Clear();
            listaCategorias = logicaCategorias.ObtenerCategorias();
            foreach (Categoria categoria in listaCategorias)
            {
                lsbCategorias.Items.Add(categoria.Nombre);
            }
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            txtEstados.Visible = false;
            txtCategorias.Visible = false;
            MostrarEstados();
            MostrarCategorias();
        }

        // Resetear cuando se da click en fondo
        private void FrmConfig_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblTitulo.Focus();
            txtEstados.Visible = false;
            txtCategorias.Visible = false;
            for (int i = 0; i < lsbEstados.Items.Count; i++)
            {
                lsbEstados.SetSelected(i, false);
            }
            for (int i = 0; i < lsbCategorias.Items.Count; i++)
            {
                lsbCategorias.SetSelected(i, false);
            }
            btnAgregarEstado.Enabled = true;
            btnEditarEstado.Enabled = true;
            btnAgregarCategoria.Enabled = true;
            btnEditarCategoria.Enabled = true;
        }

        // Agregar Estado
        private void btnAgregarEstado_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Mostrar el campo de texto
            if (txtEstados.Visible == false)
            {
                txtEstados.Visible = true;
                txtEstados.Focus();
                btnEditarEstado.Enabled = false;
                return;
            }

            // Validar el campo de texto
            if (txtEstados.Text.Trim() == "")
            {
                MessageBox.Show(
                    "El Nombre no puede quedar en blanco",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtEstados.Focus();
                errorProvider1.SetError(txtEstados, "Campo requerido");
                return;
            }

            // Crear el nuevo estado
            Respuesta respuesta = logicaEstados.CrearEstado(new Estado(txtEstados.Text));

            if (!respuesta.Resultado)
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstados.Clear();
                txtEstados.Visible = false;
                btnEditarEstado.Enabled = true;
                return;
            }

            // Pasos finales
            txtEstados.Clear();
            txtEstados.Visible = false;
            MostrarEstados();
            lsbEstados.Focus();
            btnEditarEstado.Enabled = true;
        }

        // Editar Estado
        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Validar si se selecciono un item del listbox
            if (lsbEstados.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona un estado para editar",
                    "Acción requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lsbEstados.Focus();
                return;
            }

            // Mostrar el campo de texto con el contenido
            if (txtEstados.Visible == false)
            {
                // Obtener el id del item seleccionado
                int indiceSeleccionado = lsbEstados.SelectedIndex;
                idEstadoEditando = listaEstados[indiceSeleccionado].IdEstado;
                
                // Mostrar el nombre del item seleccionado
                txtEstados.Visible = true;
                txtEstados.Text = listaEstados[indiceSeleccionado].Nombre;
                txtEstados.Focus();
                btnAgregarEstado.Enabled = false;
                return;
            }

            // Validar el campo de texto
            if (txtEstados.Text.Trim() == "")
            {
                MessageBox.Show(
                    "El Nombre no puede quedar en blanco",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtEstados.Focus();
                errorProvider1.SetError(txtEstados, "Campo requerido");
                return;
            }

            // Editar
            if (!logicaEstados.ActualizarEstado(new Estado(idEstadoEditando, txtEstados.Text)))
            {
                MessageBox.Show(
                    "No se ha podido Editar el estado",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEstados.Clear();
                txtEstados.Visible = false;
                btnAgregarEstado.Enabled = true;
                return;
            }

            // Pasos finales
            txtEstados.Clear();
            txtEstados.Visible = false;
            MostrarEstados();
            lsbEstados.Focus();
            btnAgregarEstado.Enabled = true;
        }

        // Eliminar Estado
        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            // Validar si se selecciono un item del listbox
            if (lsbEstados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un estado para Eliminar", "Acción requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lsbEstados.Focus();
                return;
            }

            // Confirmar que desea eliminar
            DialogResult dialogResult = MessageBox.Show(
                "¿Esta seguro que desea Eliminar el estado?",
                "Confirque que desea Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Obtener el id del estado seleccionado
            int indiceSeleccionado = lsbEstados.SelectedIndex;
            int idEstado = listaEstados[indiceSeleccionado].IdEstado;

            // Eliminar el estado
            if (!logicaEstados.EliminarEstado(idEstado))
            {
                MessageBox.Show(
                    "No se ha podido Eliminar el estado",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Pasos finales 
            MostrarEstados();
            lsbEstados.Focus();
        }

        // Agregar Categoria
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Mostrar el campo de texto
            if (txtCategorias.Visible == false)
            {
                txtCategorias.Visible = true;
                txtCategorias.Focus();
                btnEditarCategoria.Enabled = false;
                return;
            }

            // Validar el campo de texto
            if (txtCategorias.Text.Trim() == "")
            {
                MessageBox.Show(
                    "El Nombre no puede quedar en blanco",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtCategorias.Focus();
                errorProvider1.SetError(txtCategorias, "Campo requerido");
                return;
            }

            // Crear la nueva categoria
            Respuesta respuesta = logicaCategorias.CrearCategoria(new Categoria(txtCategorias.Text));

            if (!respuesta.Resultado)
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategorias.Clear();
                txtCategorias.Visible = false;
                btnEditarCategoria.Enabled = true;
                return;
            }

            // Pasos finales
            txtCategorias.Clear();
            txtCategorias.Visible = false;
            MostrarCategorias();
            txtCategorias.Focus();
            btnEditarCategoria.Enabled = true;
        }

        // Editar Categoria
        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Validar si se selecciono un item del listbox
            if (lsbCategorias.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona una categoria para editar",
                    "Acción requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lsbEstados.Focus();
                return;
            }

            // Mostrar el campo de texto con el contenido
            if (txtCategorias.Visible == false)
            {
                // Obtener el id del item seleccionado
                int indiceSeleccionado = lsbCategorias.SelectedIndex;
                idCategoriaEditando = listaCategorias[indiceSeleccionado].IdCategoria;
                // Mostrar el nombre del item seleccionado
                txtCategorias.Visible = true;
                txtCategorias.Text = listaCategorias[indiceSeleccionado].Nombre;
                txtCategorias.Focus();
                btnAgregarCategoria.Enabled = false;
                return;
            }

            // Validar el campo de texto
            if (txtCategorias.Text.Trim() == "")
            {
                MessageBox.Show(
                    "El Nombre no puede quedar en blanco",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtCategorias.Focus();
                errorProvider1.SetError(txtCategorias, "Campo requerido");
                return;
            }

            // Editar
            if (!logicaCategorias.ActualizarCategoria(new Categoria(idCategoriaEditando, txtCategorias.Text)))
            {
                MessageBox.Show(
                    "No se ha podido Editar el la categoria",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCategorias.Clear();
                txtCategorias.Visible = false;
                btnAgregarCategoria.Enabled = true;
                return;
            }

            // Pasos finales
            txtCategorias.Clear();
            txtCategorias.Visible = false;
            MostrarCategorias();
            lsbCategorias.Focus();
            btnAgregarCategoria.Enabled = true;
        }

        // Eliminar Categoria
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            // Validar si se selecciono un item del listbox
            if (lsbCategorias.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una categoría para Eliminar", "Acción requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lsbCategorias.Focus();
                return;
            }

            // Confirmar que desea eliminar
            DialogResult dialogResult = MessageBox.Show(
                "¿Esta seguro que desea Eliminar la categoría?",
                "Confirque que desea Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;

            // Obtener el id del estado seleccionado
            int indiceSeleccionado = lsbCategorias.SelectedIndex;
            int idEstado = listaCategorias[indiceSeleccionado].IdCategoria;

            // Eliminar el estado
            if (!logicaCategorias.EliminarCategoria(idEstado))
            {
                MessageBox.Show(
                    "No se ha podido Eliminar la categoría",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Pasos finales 
            MostrarCategorias();
            lsbCategorias.Focus();
        }
    }
}
