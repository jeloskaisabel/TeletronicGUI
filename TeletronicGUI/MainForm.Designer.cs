/*
 * Created by SharpDevelop.
 * User: Jeloska Chavez
 * Date: 21/11/2021
 * Time: 11:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TeletronicGUI
{
	partial class MainForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxApellidos = new System.Windows.Forms.TextBox();
			this.textBoxCi = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.labelCelular = new System.Windows.Forms.Label();
			this.textBoxCelular = new System.Windows.Forms.TextBox();
			this.buttonRegistrar = new System.Windows.Forms.Button();
			this.buttonSalir = new System.Windows.Forms.Button();
			this.buttonNuevo = new System.Windows.Forms.Button();
			this.labelId = new System.Windows.Forms.Label();
			this.advNombre = new System.Windows.Forms.Label();
			this.advApellidos = new System.Windows.Forms.Label();
			this.advCelular = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
			this.advCi = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(222, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(333, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registrar Cliente";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelNombre
			// 
			this.labelNombre.Location = new System.Drawing.Point(45, 96);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(80, 24);
			this.labelNombre.TabIndex = 1;
			this.labelNombre.Text = "Nombres:";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(183, 93);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(192, 20);
			this.textBoxNombre.TabIndex = 2;
			this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombreTextChanged);
			this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNombreKeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(45, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cédula de identidad CI:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(410, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellidos:";
			// 
			// textBoxApellidos
			// 
			this.textBoxApellidos.Location = new System.Drawing.Point(479, 93);
			this.textBoxApellidos.Name = "textBoxApellidos";
			this.textBoxApellidos.Size = new System.Drawing.Size(277, 20);
			this.textBoxApellidos.TabIndex = 5;
			this.textBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxApellidosKeyPress);
			// 
			// textBoxCi
			// 
			this.textBoxCi.Location = new System.Drawing.Point(183, 141);
			this.textBoxCi.Name = "textBoxCi";
			this.textBoxCi.Size = new System.Drawing.Size(192, 20);
			this.textBoxCi.TabIndex = 6;
			this.textBoxCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCiKeyPress);
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(45, 200);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(100, 23);
			this.label.TabIndex = 7;
			this.label.Text = "ID:";
			// 
			// labelCelular
			// 
			this.labelCelular.Location = new System.Drawing.Point(410, 144);
			this.labelCelular.Name = "labelCelular";
			this.labelCelular.Size = new System.Drawing.Size(100, 23);
			this.labelCelular.TabIndex = 8;
			this.labelCelular.Text = "Celular: ";
			// 
			// textBoxCelular
			// 
			this.textBoxCelular.Location = new System.Drawing.Point(479, 146);
			this.textBoxCelular.Name = "textBoxCelular";
			this.textBoxCelular.Size = new System.Drawing.Size(277, 20);
			this.textBoxCelular.TabIndex = 9;
			this.textBoxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCelularKeyPress);
			// 
			// buttonRegistrar
			// 
			this.buttonRegistrar.Location = new System.Drawing.Point(331, 240);
			this.buttonRegistrar.Name = "buttonRegistrar";
			this.buttonRegistrar.Size = new System.Drawing.Size(129, 50);
			this.buttonRegistrar.TabIndex = 10;
			this.buttonRegistrar.Text = "Registrar";
			this.buttonRegistrar.UseVisualStyleBackColor = true;
			this.buttonRegistrar.Click += new System.EventHandler(this.ButtonRegistrarClick);
			// 
			// buttonSalir
			// 
			this.buttonSalir.Location = new System.Drawing.Point(567, 347);
			this.buttonSalir.Name = "buttonSalir";
			this.buttonSalir.Size = new System.Drawing.Size(129, 50);
			this.buttonSalir.TabIndex = 11;
			this.buttonSalir.Text = "Salir";
			this.buttonSalir.UseVisualStyleBackColor = true;
			this.buttonSalir.Click += new System.EventHandler(this.ButtonSalirClick);
			// 
			// buttonNuevo
			// 
			this.buttonNuevo.Location = new System.Drawing.Point(99, 347);
			this.buttonNuevo.Name = "buttonNuevo";
			this.buttonNuevo.Size = new System.Drawing.Size(139, 50);
			this.buttonNuevo.TabIndex = 12;
			this.buttonNuevo.Text = "Nuevo";
			this.buttonNuevo.UseVisualStyleBackColor = true;
			this.buttonNuevo.Click += new System.EventHandler(this.ButtonNuevoClick);
			// 
			// labelId
			// 
			this.labelId.Location = new System.Drawing.Point(90, 191);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(139, 42);
			this.labelId.TabIndex = 0;
			// 
			// advNombre
			// 
			this.advNombre.Location = new System.Drawing.Point(222, 115);
			this.advNombre.Name = "advNombre";
			this.advNombre.Size = new System.Drawing.Size(153, 23);
			this.advNombre.TabIndex = 13;
			// 
			// advApellidos
			// 
			this.advApellidos.Location = new System.Drawing.Point(549, 120);
			this.advApellidos.Name = "advApellidos";
			this.advApellidos.Size = new System.Drawing.Size(207, 23);
			this.advApellidos.TabIndex = 14;
			// 
			// advCelular
			// 
			this.advCelular.Location = new System.Drawing.Point(531, 169);
			this.advCelular.Name = "advCelular";
			this.advCelular.Size = new System.Drawing.Size(189, 23);
			this.advCelular.TabIndex = 16;
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
			// advCi
			// 
			this.advCi.Location = new System.Drawing.Point(246, 168);
			this.advCi.Name = "advCi";
			this.advCi.Size = new System.Drawing.Size(100, 23);
			this.advCi.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(246, 416);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 33);
			this.button1.TabIndex = 18;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(436, 416);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(159, 33);
			this.button2.TabIndex = 19;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.advCi);
			this.Controls.Add(this.advCelular);
			this.Controls.Add(this.advApellidos);
			this.Controls.Add(this.advNombre);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.buttonNuevo);
			this.Controls.Add(this.buttonSalir);
			this.Controls.Add(this.buttonRegistrar);
			this.Controls.Add(this.textBoxCelular);
			this.Controls.Add(this.labelCelular);
			this.Controls.Add(this.label);
			this.Controls.Add(this.textBoxCi);
			this.Controls.Add(this.textBoxApellidos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.labelNombre);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "TeletronicGUI";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ErrorProvider errorProvider4;
		private System.Windows.Forms.ErrorProvider errorProvider3;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label advCelular;
		private System.Windows.Forms.Label advCi;
		private System.Windows.Forms.Label advApellidos;
		private System.Windows.Forms.Label advNombre;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.Button buttonNuevo;
		private System.Windows.Forms.Button buttonSalir;
		private System.Windows.Forms.Button buttonRegistrar;
		private System.Windows.Forms.TextBox textBoxCelular;
		private System.Windows.Forms.Label labelCelular;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox textBoxCi;
		private System.Windows.Forms.TextBox textBoxApellidos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label label1;
		

	}
}
