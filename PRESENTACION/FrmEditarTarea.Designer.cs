namespace PRESENTACION
{
    partial class FrmEditarTarea
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarTarea));
            btnGuardar = new Button();
            txtApuntes = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cbCategoria = new ComboBox();
            cbEstado = new ComboBox();
            label5 = new Label();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnDescartar = new Button();
            btnEliminar = new Button();
            errorProvider1 = new ErrorProvider(components);
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(317, 525);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 30);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApuntes
            // 
            txtApuntes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtApuntes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApuntes.Location = new Point(143, 346);
            txtApuntes.Multiline = true;
            txtApuntes.Name = "txtApuntes";
            txtApuntes.Size = new Size(500, 160);
            txtApuntes.TabIndex = 24;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(143, 326);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 23;
            label7.Text = "Apuntes";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(143, 261);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 22;
            label6.Text = "Categoría";
            // 
            // cbCategoria
            // 
            cbCategoria.Anchor = AnchorStyles.Top;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(143, 281);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(499, 25);
            cbCategoria.TabIndex = 21;
            // 
            // cbEstado
            // 
            cbEstado.Anchor = AnchorStyles.Top;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(143, 216);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(499, 25);
            cbEstado.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(143, 196);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 19;
            label5.Text = "Estado";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top;
            dtpFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Location = new Point(142, 151);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(500, 25);
            dtpFecha.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(142, 131);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 17;
            label3.Text = "Fecha";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top;
            txtTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(142, 86);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(500, 25);
            txtTitulo.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(142, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 15;
            label2.Text = "Título";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 57);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(323, 17);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "Editar una tarea";
            // 
            // btnDescartar
            // 
            btnDescartar.Anchor = AnchorStyles.Bottom;
            btnDescartar.BackColor = Color.Orange;
            btnDescartar.FlatStyle = FlatStyle.Flat;
            btnDescartar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDescartar.ForeColor = Color.White;
            btnDescartar.Location = new Point(143, 525);
            btnDescartar.Name = "btnDescartar";
            btnDescartar.Size = new Size(150, 30);
            btnDescartar.TabIndex = 26;
            btnDescartar.Text = "Descartar cambios";
            btnDescartar.UseVisualStyleBackColor = false;
            btnDescartar.Click += btnDescartar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(492, 525);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 30);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar tarea";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(648, 89);
            label4.Name = "label4";
            label4.Size = new Size(13, 17);
            label4.TabIndex = 29;
            label4.Text = "*";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(648, 219);
            label8.Name = "label8";
            label8.Size = new Size(13, 17);
            label8.TabIndex = 30;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(648, 284);
            label9.Name = "label9";
            label9.Size = new Size(13, 17);
            label9.TabIndex = 31;
            label9.Text = "*";
            // 
            // FrmEditarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(btnEliminar);
            Controls.Add(btnDescartar);
            Controls.Add(btnGuardar);
            Controls.Add(txtApuntes);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbCategoria);
            Controls.Add(cbEstado);
            Controls.Add(label5);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEditarTarea";
            Text = "Editar Tarea";
            Load += FrmEditarTarea_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button btnDescartar;
        private Button btnEliminar;
        public TextBox txtApuntes;
        public ComboBox cbCategoria;
        public ComboBox cbEstado;
        public DateTimePicker dtpFecha;
        public TextBox txtTitulo;
        private ErrorProvider errorProvider1;
        private Label label4;
        private Label label9;
        private Label label8;
    }
}