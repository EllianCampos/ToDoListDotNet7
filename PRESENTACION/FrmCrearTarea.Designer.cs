namespace PRESENTACION
{
    partial class FrmCrearTarea
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            cbCategoria = new ComboBox();
            cbEstado = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtApuntes = new TextBox();
            btnCrear = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 57);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(298, 17);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 1;
            label1.Text = "Crear una nueva tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(142, 60);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 2;
            label2.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(142, 80);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(500, 25);
            txtTitulo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(142, 125);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Location = new Point(142, 145);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(500, 25);
            dtpFecha.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(143, 190);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 7;
            label5.Text = "Estado";
            // 
            // cbCategoria
            // 
            cbCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(143, 275);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(499, 25);
            cbCategoria.TabIndex = 9;
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(143, 210);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(499, 25);
            cbEstado.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(143, 255);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 10;
            label6.Text = "Categoría";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(143, 320);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 11;
            label7.Text = "Apuntes";
            // 
            // txtApuntes
            // 
            txtApuntes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApuntes.Location = new Point(143, 340);
            txtApuntes.Multiline = true;
            txtApuntes.Name = "txtApuntes";
            txtApuntes.Size = new Size(500, 160);
            txtApuntes.TabIndex = 12;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Green;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(342, 519);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(100, 30);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "Crear tarea";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCrearTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnCrear);
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
            Name = "FrmCrearTarea";
            Text = "Nueva Tarea";
            Load += FrmCrearTarea_Load;
            Click += FrmCrearTarea_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label5;
        private ComboBox cbCategoria;
        private ComboBox cbEstado;
        private Label label6;
        private Label label7;
        private TextBox txtApuntes;
        private Button btnCrear;
        private ErrorProvider errorProvider1;
    }
}