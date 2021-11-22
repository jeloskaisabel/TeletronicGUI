/*
 * Created by SharpDevelop.
 * User: Jeloska Chavez
 * Date: 22/11/2021
 * Time: 16:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TeletronicGUI
{
	partial class RegistroTecnicosForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.labelNombre = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxApellidos = new System.Windows.Forms.TextBox();
			this.labelApellidos = new System.Windows.Forms.Label();
			this.labelCi = new System.Windows.Forms.Label();
			this.textBoxCi = new System.Windows.Forms.TextBox();
			this.labelCelular = new System.Windows.Forms.Label();
			this.textBoxCelular = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.textBoxEspecialidad = new System.Windows.Forms.TextBox();
			this.labelEspecialidad = new System.Windows.Forms.Label();
			this.labelId = new System.Windows.Forms.Label();
			this.buttonRegistrar = new System.Windows.Forms.Button();
			this.buttonNuevo = new System.Windows.Forms.Button();
			this.buttonSalir = new System.Windows.Forms.Button();
			this.advNombre = new System.Windows.Forms.Label();
			this.advApellidos = new System.Windows.Forms.Label();
			this.advCi = new System.Windows.Forms.Label();
			this.advCelular = new System.Windows.Forms.Label();
			this.advEspecialidad = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(277, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registrar Técnico";
			// 
			// labelNombre
			// 
			this.labelNombre.Location = new System.Drawing.Point(43, 88);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(100, 23);
			this.labelNombre.TabIndex = 1;
			this.labelNombre.Text = "Nombres:";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(99, 85);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(194, 20);
			this.textBoxNombre.TabIndex = 2;
			this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNombreKeyPress);
			// 
			// textBoxApellidos
			// 
			this.textBoxApellidos.Location = new System.Drawing.Point(520, 88);
			this.textBoxApellidos.Name = "textBoxApellidos";
			this.textBoxApellidos.Size = new System.Drawing.Size(161, 20);
			this.textBoxApellidos.TabIndex = 3;
			this.textBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxApellidosKeyPress);
			// 
			// labelApellidos
			// 
			this.labelApellidos.Location = new System.Drawing.Point(382, 85);
			this.labelApellidos.Name = "labelApellidos";
			this.labelApellidos.Size = new System.Drawing.Size(100, 23);
			this.labelApellidos.TabIndex = 4;
			this.labelApellidos.Text = "Apellidos:";
			// 
			// labelCi
			// 
			this.labelCi.Location = new System.Drawing.Point(43, 166);
			this.labelCi.Name = "labelCi";
			this.labelCi.Size = new System.Drawing.Size(142, 23);
			this.labelCi.TabIndex = 5;
			this.labelCi.Text = "Cédula de identidad Ci:";
			// 
			// textBoxCi
			// 
			this.textBoxCi.Location = new System.Drawing.Point(164, 163);
			this.textBoxCi.Name = "textBoxCi";
			this.textBoxCi.Size = new System.Drawing.Size(187, 20);
			this.textBoxCi.TabIndex = 6;
			this.textBoxCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCiKeyPress);
			// 
			// labelCelular
			// 
			this.labelCelular.Location = new System.Drawing.Point(382, 166);
			this.labelCelular.Name = "labelCelular";
			this.labelCelular.Size = new System.Drawing.Size(100, 23);
			this.labelCelular.TabIndex = 7;
			this.labelCelular.Text = "Celular: ";
			// 
			// textBoxCelular
			// 
			this.textBoxCelular.Location = new System.Drawing.Point(488, 163);
			this.textBoxCelular.Name = "textBoxCelular";
			this.textBoxCelular.Size = new System.Drawing.Size(181, 20);
			this.textBoxCelular.TabIndex = 8;
			this.textBoxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCelularKeyPress);
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(382, 230);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(100, 23);
			this.label.TabIndex = 9;
			this.label.Text = "ID Técnico:";
			// 
			// textBoxEspecialidad
			// 
			this.textBoxEspecialidad.Location = new System.Drawing.Point(150, 227);
			this.textBoxEspecialidad.Name = "textBoxEspecialidad";
			this.textBoxEspecialidad.Size = new System.Drawing.Size(212, 20);
			this.textBoxEspecialidad.TabIndex = 10;
			this.textBoxEspecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEspecialidadKeyPress);
			// 
			// labelEspecialidad
			// 
			this.labelEspecialidad.Location = new System.Drawing.Point(43, 224);
			this.labelEspecialidad.Name = "labelEspecialidad";
			this.labelEspecialidad.Size = new System.Drawing.Size(100, 23);
			this.labelEspecialidad.TabIndex = 11;
			this.labelEspecialidad.Text = "Especialidad:";
			// 
			// labelId
			// 
			this.labelId.Location = new System.Drawing.Point(488, 227);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(100, 23);
			this.labelId.TabIndex = 12;
			// 
			// buttonRegistrar
			// 
			this.buttonRegistrar.Location = new System.Drawing.Point(329, 279);
			this.buttonRegistrar.Name = "buttonRegistrar";
			this.buttonRegistrar.Size = new System.Drawing.Size(115, 33);
			this.buttonRegistrar.TabIndex = 13;
			this.buttonRegistrar.Text = "Registrar";
			this.buttonRegistrar.UseVisualStyleBackColor = true;
			this.buttonRegistrar.Click += new System.EventHandler(this.ButtonRegistrarClick);
			// 
			// buttonNuevo
			// 
			this.buttonNuevo.Location = new System.Drawing.Point(99, 379);
			this.buttonNuevo.Name = "buttonNuevo";
			this.buttonNuevo.Size = new System.Drawing.Size(114, 44);
			this.buttonNuevo.TabIndex = 14;
			this.buttonNuevo.Text = "Nuevo";
			this.buttonNuevo.UseVisualStyleBackColor = true;
			this.buttonNuevo.Click += new System.EventHandler(this.ButtonNuevoClick);
			// 
			// buttonSalir
			// 
			this.buttonSalir.Location = new System.Drawing.Point(551, 366);
			this.buttonSalir.Name = "buttonSalir";
			this.buttonSalir.Size = new System.Drawing.Size(141, 44);
			this.buttonSalir.TabIndex = 15;
			this.buttonSalir.Text = "Salir";
			this.buttonSalir.UseVisualStyleBackColor = true;
			this.buttonSalir.Click += new System.EventHandler(this.ButtonSalirClick);
			// 
			// advNombre
			// 
			this.advNombre.Location = new System.Drawing.Point(99, 115);
			this.advNombre.Name = "advNombre";
			this.advNombre.Size = new System.Drawing.Size(100, 23);
			this.advNombre.TabIndex = 16;
			// 
			// advApellidos
			// 
			this.advApellidos.Location = new System.Drawing.Point(520, 115);
			this.advApellidos.Name = "advApellidos";
			this.advApellidos.Size = new System.Drawing.Size(100, 23);
			this.advApellidos.TabIndex = 17;
			// 
			// advCi
			// 
			this.advCi.Location = new System.Drawing.Point(164, 189);
			this.advCi.Name = "advCi";
			this.advCi.Size = new System.Drawing.Size(100, 23);
			this.advCi.TabIndex = 18;
			// 
			// advCelular
			// 
			this.advCelular.Location = new System.Drawing.Point(489, 189);
			this.advCelular.Name = "advCelular";
			this.advCelular.Size = new System.Drawing.Size(100, 23);
			this.advCelular.TabIndex = 19;
			// 
			// advEspecialidad
			// 
			this.advEspecialidad.Location = new System.Drawing.Point(150, 254);
			this.advEspecialidad.Name = "advEspecialidad";
			this.advEspecialidad.Size = new System.Drawing.Size(100, 23);
			this.advEspecialidad.TabIndex = 20;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// errorProvider3
			// 
			this.errorProvider3.ContainerControl = this;
			// 
			// errorProvider4
			// 
			this.errorProvider4.ContainerControl = this;
			// 
			// errorProvider5
			// 
			this.errorProvider5.ContainerControl = this;
			// 
			// RegistroTecnicosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.advEspecialidad);
			this.Controls.Add(this.advCelular);
			this.Controls.Add(this.advCi);
			this.Controls.Add(this.advApellidos);
			this.Controls.Add(this.advNombre);
			this.Controls.Add(this.buttonSalir);
			this.Controls.Add(this.buttonNuevo);
			this.Controls.Add(this.buttonRegistrar);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.labelEspecialidad);
			this.Controls.Add(this.textBoxEspecialidad);
			this.Controls.Add(this.label);
			this.Controls.Add(this.textBoxCelular);
			this.Controls.Add(this.labelCelular);
			this.Controls.Add(this.textBoxCi);
			this.Controls.Add(this.labelCi);
			this.Controls.Add(this.labelApellidos);
			this.Controls.Add(this.textBoxApellidos);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.labelNombre);
			this.Controls.Add(this.label1);
			this.Name = "RegistroTecnicosForm";
			this.Text = "RegistroTecnicosForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider errorProvider5;
		private System.Windows.Forms.ErrorProvider errorProvider4;
		private System.Windows.Forms.ErrorProvider errorProvider3;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label advEspecialidad;
		private System.Windows.Forms.Label advCelular;
		private System.Windows.Forms.Label advCi;
		private System.Windows.Forms.Label advApellidos;
		private System.Windows.Forms.Label advNombre;
		private System.Windows.Forms.Button buttonSalir;
		private System.Windows.Forms.Button buttonNuevo;
		private System.Windows.Forms.Button buttonRegistrar;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.Label labelEspecialidad;
		private System.Windows.Forms.TextBox textBoxEspecialidad;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox textBoxCelular;
		private System.Windows.Forms.Label labelCelular;
		private System.Windows.Forms.TextBox textBoxCi;
		private System.Windows.Forms.Label labelCi;
		private System.Windows.Forms.Label labelApellidos;
		private System.Windows.Forms.TextBox textBoxApellidos;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label label1;
	}
}
