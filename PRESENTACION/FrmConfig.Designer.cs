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
			panel1.Size = new Size(800, 57);
			panel1.TabIndex = 2;
			// 
			// lblTitulo
			// 
			lblTitulo.AutoSize = true;
			lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblTitulo.ForeColor = Color.White;
			lblTitulo.Location = new Point(340, 17);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(120, 20);
			lblTitulo.TabIndex = 1;
			lblTitulo.Text = "Configuración";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(12, 60);
			label2.Name = "label2";
			label2.Size = new Size(138, 16);
			label2.TabIndex = 3;
			label2.Text = "Estados de las tareas";
			// 
			// lsbEstados
			// 
			lsbEstados.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lsbEstados.FormattingEnabled = true;
			lsbEstados.ItemHeight = 16;
			lsbEstados.Location = new Point(12, 79);
			lsbEstados.Name = "lsbEstados";
			lsbEstados.Size = new Size(278, 84);
			lsbEstados.TabIndex = 5;
			// 
			// btnEliminarEstado
			// 
			btnEliminarEstado.Image = Properties.Resources.trash;
			btnEliminarEstado.Location = new Point(262, 169);
			btnEliminarEstado.Name = "btnEliminarEstado";
			btnEliminarEstado.Size = new Size(28, 28);
			btnEliminarEstado.TabIndex = 6;
			btnEliminarEstado.UseVisualStyleBackColor = true;
			btnEliminarEstado.Click += btnEliminarEstado_Click;
			// 
			// btnAgregarEstado
			// 
			btnAgregarEstado.Image = Properties.Resources.add_circle;
			btnAgregarEstado.Location = new Point(12, 168);
			btnAgregarEstado.Name = "btnAgregarEstado";
			btnAgregarEstado.Size = new Size(28, 28);
			btnAgregarEstado.TabIndex = 7;
			btnAgregarEstado.UseVisualStyleBackColor = true;
			btnAgregarEstado.Click += btnAgregarEstado_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(189, 306);
			label3.Name = "label3";
			label3.Size = new Size(154, 16);
			label3.TabIndex = 8;
			label3.Text = "Categorías de las tareas";
			// 
			// btnAgregarCategoria
			// 
			btnAgregarCategoria.Image = Properties.Resources.add_circle;
			btnAgregarCategoria.Location = new Point(324, 349);
			btnAgregarCategoria.Name = "btnAgregarCategoria";
			btnAgregarCategoria.Size = new Size(28, 28);
			btnAgregarCategoria.TabIndex = 10;
			btnAgregarCategoria.UseVisualStyleBackColor = true;
			// 
			// btnEliminarCategoria
			// 
			btnEliminarCategoria.Image = Properties.Resources.trash;
			btnEliminarCategoria.Location = new Point(324, 383);
			btnEliminarCategoria.Name = "btnEliminarCategoria";
			btnEliminarCategoria.Size = new Size(28, 28);
			btnEliminarCategoria.TabIndex = 9;
			btnEliminarCategoria.UseVisualStyleBackColor = true;
			// 
			// txtEstados
			// 
			txtEstados.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtEstados.Location = new Point(46, 171);
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
			btnEditarEstado.Image = Properties.Resources.edit;
			btnEditarEstado.Location = new Point(228, 169);
			btnEditarEstado.Name = "btnEditarEstado";
			btnEditarEstado.Size = new Size(28, 28);
			btnEditarEstado.TabIndex = 12;
			btnEditarEstado.UseVisualStyleBackColor = true;
			btnEditarEstado.Click += btnEditarEstado_Click;
			// 
			// FrmConfig
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
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
	}
}