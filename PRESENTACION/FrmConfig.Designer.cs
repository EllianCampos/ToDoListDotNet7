namespace PRESENTACION
{
	partial class FrmConfig
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
			lblTitulo = new Label();
			label2 = new Label();
			lsbEstados = new ListBox();
			btnEliminarEstado = new Button();
			btnAgregarEstado = new Button();
			label3 = new Label();
			btnAgregarCategoria = new Button();
			btnEliminarCategoria = new Button();
			txtEstados = new TextBox();
			errorProvider1 = new ErrorProvider(components);
			btnEditarEstado = new Button();
			lsbCategorias = new ListBox();
			txtCategorias = new TextBox();
			btnEditarCategoria = new Button();
			label1 = new Label();
			comboBox1 = new ComboBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.DodgerBlue;
			panel1.Controls.Add(lblTitulo);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(767, 57);
			panel1.TabIndex = 2;
			// 
			// lblTitulo
			// 
			lblTitulo.Anchor = AnchorStyles.Top;
			lblTitulo.AutoSize = true;
			lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblTitulo.ForeColor = Color.White;
			lblTitulo.Location = new Point(323, 17);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(120, 20);
			lblTitulo.TabIndex = 1;
			lblTitulo.Text = "Configuración";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top;
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(244, 77);
			label2.Name = "label2";
			label2.Size = new Size(159, 16);
			label2.TabIndex = 3;
			label2.Text = "Estados de las tareas";
			// 
			// lsbEstados
			// 
			lsbEstados.Anchor = AnchorStyles.Top;
			lsbEstados.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lsbEstados.FormattingEnabled = true;
			lsbEstados.ItemHeight = 16;
			lsbEstados.Location = new Point(244, 96);
			lsbEstados.Name = "lsbEstados";
			lsbEstados.Size = new Size(278, 84);
			lsbEstados.TabIndex = 5;
			// 
			// btnEliminarEstado
			// 
			btnEliminarEstado.Anchor = AnchorStyles.Top;
			btnEliminarEstado.Image = Properties.Resources.trash;
			btnEliminarEstado.Location = new Point(494, 186);
			btnEliminarEstado.Name = "btnEliminarEstado";
			btnEliminarEstado.Size = new Size(28, 28);
			btnEliminarEstado.TabIndex = 6;
			btnEliminarEstado.UseVisualStyleBackColor = true;
			btnEliminarEstado.Click += btnEliminarEstado_Click;
			// 
			// btnAgregarEstado
			// 
			btnAgregarEstado.Anchor = AnchorStyles.Top;
			btnAgregarEstado.Image = Properties.Resources.add_circle;
			btnAgregarEstado.Location = new Point(244, 185);
			btnAgregarEstado.Name = "btnAgregarEstado";
			btnAgregarEstado.Size = new Size(28, 28);
			btnAgregarEstado.TabIndex = 7;
			btnAgregarEstado.UseVisualStyleBackColor = true;
			btnAgregarEstado.Click += btnAgregarEstado_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top;
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(244, 261);
			label3.Name = "label3";
			label3.Size = new Size(178, 16);
			label3.TabIndex = 8;
			label3.Text = "Categorías de las tareas";
			// 
			// btnAgregarCategoria
			// 
			btnAgregarCategoria.Anchor = AnchorStyles.Top;
			btnAgregarCategoria.Image = Properties.Resources.add_circle;
			btnAgregarCategoria.Location = new Point(244, 370);
			btnAgregarCategoria.Name = "btnAgregarCategoria";
			btnAgregarCategoria.Size = new Size(28, 28);
			btnAgregarCategoria.TabIndex = 10;
			btnAgregarCategoria.UseVisualStyleBackColor = true;
			// 
			// btnEliminarCategoria
			// 
			btnEliminarCategoria.Anchor = AnchorStyles.Top;
			btnEliminarCategoria.Image = Properties.Resources.trash;
			btnEliminarCategoria.Location = new Point(494, 372);
			btnEliminarCategoria.Name = "btnEliminarCategoria";
			btnEliminarCategoria.Size = new Size(28, 28);
			btnEliminarCategoria.TabIndex = 9;
			btnEliminarCategoria.UseVisualStyleBackColor = true;
			// 
			// txtEstados
			// 
			txtEstados.Anchor = AnchorStyles.Top;
			txtEstados.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtEstados.Location = new Point(278, 188);
			txtEstados.Name = "txtEstados";
			txtEstados.Size = new Size(159, 25);
			txtEstados.TabIndex = 11;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// btnEditarEstado
			// 
			btnEditarEstado.Anchor = AnchorStyles.Top;
			btnEditarEstado.Image = Properties.Resources.edit;
			btnEditarEstado.Location = new Point(460, 186);
			btnEditarEstado.Name = "btnEditarEstado";
			btnEditarEstado.Size = new Size(28, 28);
			btnEditarEstado.TabIndex = 12;
			btnEditarEstado.UseVisualStyleBackColor = true;
			btnEditarEstado.Click += btnEditarEstado_Click;
			// 
			// lsbCategorias
			// 
			lsbCategorias.Anchor = AnchorStyles.Top;
			lsbCategorias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lsbCategorias.FormattingEnabled = true;
			lsbCategorias.ItemHeight = 16;
			lsbCategorias.Location = new Point(244, 280);
			lsbCategorias.Name = "lsbCategorias";
			lsbCategorias.Size = new Size(278, 84);
			lsbCategorias.TabIndex = 13;
			// 
			// txtCategorias
			// 
			txtCategorias.Anchor = AnchorStyles.Top;
			txtCategorias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtCategorias.Location = new Point(278, 372);
			txtCategorias.Name = "txtCategorias";
			txtCategorias.Size = new Size(159, 25);
			txtCategorias.TabIndex = 14;
			// 
			// btnEditarCategoria
			// 
			btnEditarCategoria.Anchor = AnchorStyles.Top;
			btnEditarCategoria.Image = Properties.Resources.edit;
			btnEditarCategoria.Location = new Point(460, 370);
			btnEditarCategoria.Name = "btnEditarCategoria";
			btnEditarCategoria.Size = new Size(28, 28);
			btnEditarCategoria.TabIndex = 15;
			btnEditarCategoria.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(233, 576);
			label1.Name = "label1";
			label1.Size = new Size(210, 16);
			label1.TabIndex = 16;
			label1.Text = "Modo de ventana por defecto";
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Por defecto", "Maximizado" });
			comboBox1.Location = new Point(250, 595);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(278, 25);
			comboBox1.TabIndex = 17;
			// 
			// FrmConfig
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(784, 561);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Controls.Add(btnEditarCategoria);
			Controls.Add(txtCategorias);
			Controls.Add(lsbCategorias);
			Controls.Add(btnEditarEstado);
			Controls.Add(txtEstados);
			Controls.Add(btnAgregarCategoria);
			Controls.Add(btnEliminarCategoria);
			Controls.Add(label3);
			Controls.Add(btnAgregarEstado);
			Controls.Add(btnEliminarEstado);
			Controls.Add(lsbEstados);
			Controls.Add(label2);
			Controls.Add(panel1);
			Name = "FrmConfig";
			Text = "Configuración";
			WindowState = FormWindowState.Minimized;
			Load += FrmConfig_Load;
			Click += FrmConfig_Click;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label lblTitulo;
		private Label label2;
		private ListBox lsbEstados;
		private Button btnEliminarEstado;
		private Button btnAgregarEstado;
		private Label label3;
		private Button btnAgregarCategoria;
		private Button btnEliminarCategoria;
		private TextBox txtEstados;
		private ErrorProvider errorProvider1;
		private Button btnEditarEstado;
		private Button btnEditarCategoria;
		private TextBox txtCategorias;
		private ListBox lsbCategorias;
		private Label label1;
		private ComboBox comboBox1;
	}
}