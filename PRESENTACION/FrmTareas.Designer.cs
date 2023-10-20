namespace PRESENTACION
{
    partial class FrmTareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareas));
            panel1 = new Panel();
            btnConfig = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvTareas = new DataGridView();
            btnAgregar = new Button();
            groupBox1 = new GroupBox();
            chklbCategorias = new CheckedListBox();
            btnLimpiar = new Button();
            chklbEstados = new CheckedListBox();
            txtBuscar = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 57);
            panel1.TabIndex = 0;
            // 
            // btnConfig
            // 
            btnConfig.Image = Properties.Resources.settings;
            btnConfig.Location = new Point(12, 9);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(28, 28);
            btnConfig.TabIndex = 8;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(320, 17);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 1;
            label1.Text = "Gestor de tareas";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dgvTareas);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 230);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(760, 319);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tareas";
            // 
            // dgvTareas
            // 
            dgvTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(6, 24);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.RowTemplate.Height = 25;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.Size = new Size(748, 257);
            dgvTareas.TabIndex = 10;
            dgvTareas.CellDoubleClick += dgvTareas_CellDoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(679, 287);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 26);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar tarea";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(chklbCategorias);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(chklbEstados);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 161);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // chklbCategorias
            // 
            chklbCategorias.FormattingEnabled = true;
            chklbCategorias.Location = new Point(212, 41);
            chklbCategorias.Name = "chklbCategorias";
            chklbCategorias.Size = new Size(200, 104);
            chklbCategorias.TabIndex = 11;
            chklbCategorias.MouseClick += chklbCategorias_MouseClick;
            chklbCategorias.SelectedValueChanged += chklbCategorias_SelectedValueChanged;
            chklbCategorias.MouseDoubleClick += chklbCategorias_MouseDoubleClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(418, 72);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(336, 33);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar filtros";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // chklbEstados
            // 
            chklbEstados.FormattingEnabled = true;
            chklbEstados.Location = new Point(6, 41);
            chklbEstados.Name = "chklbEstados";
            chklbEstados.Size = new Size(200, 104);
            chklbEstados.TabIndex = 10;
            chklbEstados.MouseClick += chklbEstados_MouseClick;
            chklbEstados.SelectedValueChanged += chklbEstados_SelectedValueChanged;
            chklbEstados.MouseDoubleClick += chklbEstados_MouseDoubleClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(418, 41);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(336, 25);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(418, 21);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 4;
            label4.Text = "Buscar por título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 21);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 2;
            label2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(219, 21);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 3;
            label3.Text = "Categoría";
            // 
            // FrmTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTareas";
            Text = "Mis Tareas";
            Load += FrmTareas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView dgvTareas;
        private Button btnAgregar;
        private Button btnConfig;
        private GroupBox groupBox1;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Label label4;
        private Label label2;
        private Label label3;
        private CheckedListBox chklbEstados;
        private CheckedListBox chklbCategorias;
    }
}