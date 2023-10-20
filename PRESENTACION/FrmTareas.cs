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
    public partial class FrmTareas : Form
    {
        FrmCrearTarea frmCrearTarea = new FrmCrearTarea();
        FrmEditarTarea frmEditarTarea = new FrmEditarTarea();
        FrmConfig frmConfig = new FrmConfig();
        LogicaTareas logicaTareas = new LogicaTareas();
        LogicaEstados logicaEstados = new LogicaEstados();
        LogicaCategorias logicaCategorias = new LogicaCategorias();
        LogicaFiltros logicaFiltros = new LogicaFiltros();

        List<Estado> listaEstados;
        List<Categoria> listaCategorias;

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

        public void Filtrar()
        {
            // Crear los diccionarios
            Dictionary<string, bool> filtrosEstados = new Dictionary<string, bool>();
            Dictionary<string, bool> filtrosCategorias = new Dictionary<string, bool>();

            // Cargar todos los valores en falso
            List<Estado> listaEstados = logicaEstados.ObtenerEstados();
            List<Categoria> listaCategorias = logicaCategorias.ObtenerCategorias();
            foreach (Estado estado in listaEstados)
                filtrosEstados.Add(estado.Nombre, false);
            foreach (Categoria categoria in listaCategorias)
                filtrosCategorias.Add(categoria.Nombre, false);

            // Cargar en true los valores que este activos
            foreach (var item in chklbEstados.CheckedItems)
                filtrosEstados[item.ToString()] = true;
            foreach (var item in chklbCategorias.CheckedItems)
                filtrosCategorias[item.ToString()] = true;


            dgvTareas.DataSource = null;
            dgvTareas.DataSource = logicaFiltros.ObtenerTareasFiltradas(filtrosEstados, filtrosCategorias, txtBuscar.Text);
            dgvTareas.Columns["IdTarea"].Visible = false;
        }

        public void CargarFiltros()
        {
            // Cargar los estados en el CheackedListBox
            chklbEstados.Items.Clear();
            listaEstados = logicaEstados.ObtenerEstados();
            foreach (Estado estado in listaEstados)
            {
                chklbEstados.Items.Add(estado.Nombre, true);
            }

            // Cargar las categorias en el CheackedListBox
            chklbCategorias.Items.Clear();
            listaCategorias = logicaCategorias.ObtenerCategorias();
            foreach (Categoria categoria in listaCategorias)
            {
                chklbCategorias.Items.Add(categoria.Nombre, true);
            }
        }

        private void FrmTareas_Load(object sender, EventArgs e)
        {
            CargarFiltros();
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
            frmEditarTarea.ShowDialog();
            MostrarTareas();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfig.ShowDialog();
            MostrarTareas();
            CargarFiltros();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void chklbEstados_SelectedValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void chklbEstados_MouseClick(object sender, MouseEventArgs e)
        {
            Filtrar();
        }

        private void chklbCategorias_MouseClick(object sender, MouseEventArgs e)
        {
            Filtrar();
        }

        private void chklbCategorias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Filtrar();
        }

        private void chklbCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void chklbEstados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Filtrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarFiltros();
            MostrarTareas();
        }
    }
}
