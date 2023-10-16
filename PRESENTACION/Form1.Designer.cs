namespace PRESENTACION
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            label4 = new Label();
            label2 = new Label();
            cbCategoria = new ComboBox();
            groupBox2 = new GroupBox();
            dtpFechaFinal = new DateTimePicker();
            dtpFechaInicial = new DateTimePicker();
            label3 = new Label();
            cbEstado = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 161);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(554, 91);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 51);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar filtros";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(554, 46);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 25);
            txtBuscar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(631, 24);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 4;
            label4.Text = "Buscar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 24);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 2;
            label2.Text = "Estado";
            // 
            // cbCategoria
            // 
            cbCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(6, 113);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(200, 25);
            cbCategoria.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpFechaFinal);
            groupBox2.Controls.Add(dtpFechaInicial);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(212, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 95);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rango de fechas";
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaFinal.Location = new Point(6, 62);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(324, 25);
            dtpFechaFinal.TabIndex = 1;
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaInicial.Location = new Point(6, 27);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(324, 25);
            dtpFechaInicial.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 91);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 3;
            label3.Text = "Categoría";
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(6, 46);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(200, 25);
            cbEstado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Label label4;
        private Label label2;
        private ComboBox cbCategoria;
        private GroupBox groupBox2;
        private DateTimePicker dtpFechaFinal;
        private DateTimePicker dtpFechaInicial;
        private Label label3;
        private ComboBox cbEstado;
    }
}