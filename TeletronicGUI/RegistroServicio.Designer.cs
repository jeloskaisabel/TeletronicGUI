/*
 * Created by SharpDevelop.
 * User: Jeloska Chavez
 * Date: 22/11/2021
 * Time: 19:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TeletronicGUI
{
	partial class RegistroServicio
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
			this.label1 = new System.Windows.Forms.Label();
			this.labelCliente = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelSerie = new System.Windows.Forms.Label();
			this.labelMarca = new System.Windows.Forms.Label();
			this.comboBoxMarca = new System.Windows.Forms.ComboBox();
			this.labelLinea = new System.Windows.Forms.Label();
			this.radioButtonMarron = new System.Windows.Forms.RadioButton();
			this.radioButtonBlanca = new System.Windows.Forms.RadioButton();
			this.labelNroGarantia = new System.Windows.Forms.Label();
			this.textBoxNroGarantia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labelDuracionGarantia = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxNroSerie = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.buttonRegistrarAparato = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.labelValidez = new System.Windows.Forms.Label();
			this.numericUpDownDuracion = new System.Windows.Forms.NumericUpDown();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuracion)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(222, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(359, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registrar Reparacion(Artefacto)";
			// 
			// labelCliente
			// 
			this.labelCliente.Location = new System.Drawing.Point(36, 44);
			this.labelCliente.Name = "labelCliente";
			this.labelCliente.Size = new System.Drawing.Size(100, 23);
			this.labelCliente.TabIndex = 1;
			this.labelCliente.Text = "Cliente:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(86, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(197, 20);
			this.textBox1.TabIndex = 2;
			//this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// labelSerie
			// 
			this.labelSerie.Location = new System.Drawing.Point(36, 73);
			this.labelSerie.Name = "labelSerie";
			this.labelSerie.Size = new System.Drawing.Size(100, 23);
			this.labelSerie.TabIndex = 3;
			this.labelSerie.Text = "Nro. Serie";
			// 
			// labelMarca
			// 
			this.labelMarca.Location = new System.Drawing.Point(419, 67);
			this.labelMarca.Name = "labelMarca";
			this.labelMarca.Size = new System.Drawing.Size(100, 23);
			this.labelMarca.TabIndex = 5;
			this.labelMarca.Text = "Marca:";
			// 
			// comboBoxMarca
			// 
			this.comboBoxMarca.FormattingEnabled = true;
			this.comboBoxMarca.Items.AddRange(new object[] {
									"Oster",
									"Samsung",
									"LG",
									"Panasonic",
									"Daewoo",
									"Otro"});
			this.comboBoxMarca.Location = new System.Drawing.Point(508, 67);
			this.comboBoxMarca.Name = "comboBoxMarca";
			this.comboBoxMarca.Size = new System.Drawing.Size(230, 21);
			this.comboBoxMarca.TabIndex = 6;
			// 
			// labelLinea
			// 
			this.labelLinea.Location = new System.Drawing.Point(36, 119);
			this.labelLinea.Name = "labelLinea";
			this.labelLinea.Size = new System.Drawing.Size(100, 23);
			this.labelLinea.TabIndex = 7;
			this.labelLinea.Text = "Linea:";
			// 
			// radioButtonMarron
			// 
			this.radioButtonMarron.Location = new System.Drawing.Point(95, 113);
			this.radioButtonMarron.Name = "radioButtonMarron";
			this.radioButtonMarron.Size = new System.Drawing.Size(104, 24);
			this.radioButtonMarron.TabIndex = 8;
			this.radioButtonMarron.TabStop = true;
			this.radioButtonMarron.Text = "Marron";
			this.radioButtonMarron.UseVisualStyleBackColor = true;
			this.radioButtonMarron.CheckedChanged += new System.EventHandler(this.RadioButtonMarronCheckedChanged);
			// 
			// radioButtonBlanca
			// 
			this.radioButtonBlanca.Location = new System.Drawing.Point(95, 133);
			this.radioButtonBlanca.Name = "radioButtonBlanca";
			this.radioButtonBlanca.Size = new System.Drawing.Size(104, 24);
			this.radioButtonBlanca.TabIndex = 9;
			this.radioButtonBlanca.TabStop = true;
			this.radioButtonBlanca.Text = "Blanca";
			this.radioButtonBlanca.UseVisualStyleBackColor = true;
			this.radioButtonBlanca.CheckedChanged += new System.EventHandler(this.RadioButtonBlancaCheckedChanged);
			// 
			// labelNroGarantia
			// 
			this.labelNroGarantia.Location = new System.Drawing.Point(419, 130);
			this.labelNroGarantia.Name = "labelNroGarantia";
			this.labelNroGarantia.Size = new System.Drawing.Size(100, 23);
			this.labelNroGarantia.TabIndex = 10;
			this.labelNroGarantia.Text = "Nro. Garantia:";
			// 
			// textBoxNroGarantia
			// 
			this.textBoxNroGarantia.Location = new System.Drawing.Point(508, 133);
			this.textBoxNroGarantia.Name = "textBoxNroGarantia";
			this.textBoxNroGarantia.Size = new System.Drawing.Size(230, 20);
			this.textBoxNroGarantia.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(36, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 41);
			this.label2.TabIndex = 12;
			this.label2.Text = "Fecha de Compra:";
			// 
			// labelDuracionGarantia
			// 
			this.labelDuracionGarantia.Location = new System.Drawing.Point(419, 195);
			this.labelDuracionGarantia.Name = "labelDuracionGarantia";
			this.labelDuracionGarantia.Size = new System.Drawing.Size(121, 26);
			this.labelDuracionGarantia.TabIndex = 14;
			this.labelDuracionGarantia.Text = "Duración de Garantía: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(685, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "meses";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(222, 385);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(345, 36);
			this.label5.TabIndex = 18;
			this.label5.Text = "Registrar Reparacion(Servicio)";
			// 
			// textBoxNroSerie
			// 
			this.textBoxNroSerie.Location = new System.Drawing.Point(95, 70);
			this.textBoxNroSerie.Name = "textBoxNroSerie";
			this.textBoxNroSerie.Size = new System.Drawing.Size(201, 20);
			this.textBoxNroSerie.TabIndex = 35;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(337, 41);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(35, 26);
			this.button3.TabIndex = 36;
			this.button3.Text = "📋";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(289, 39);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 26);
			this.button4.TabIndex = 37;
			this.button4.Text = "🔍";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// buttonRegistrarAparato
			// 
			this.buttonRegistrarAparato.Location = new System.Drawing.Point(317, 326);
			this.buttonRegistrarAparato.Name = "buttonRegistrarAparato";
			this.buttonRegistrarAparato.Size = new System.Drawing.Size(162, 46);
			this.buttonRegistrarAparato.TabIndex = 38;
			this.buttonRegistrarAparato.Text = "Registrar aparato";
			this.buttonRegistrarAparato.UseVisualStyleBackColor = true;
			this.buttonRegistrarAparato.Click += new System.EventHandler(this.ButtonRegistrarAparatoClick);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(106, 189);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(259, 244);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 39;
			this.label4.Text = "Estado garantía: ";
			// 
			// labelValidez
			// 
			this.labelValidez.Location = new System.Drawing.Point(388, 244);
			this.labelValidez.Name = "labelValidez";
			this.labelValidez.Size = new System.Drawing.Size(193, 23);
			this.labelValidez.TabIndex = 40;
			// 
			// numericUpDownDuracion
			// 
			this.numericUpDownDuracion.Location = new System.Drawing.Point(547, 189);
			this.numericUpDownDuracion.Name = "numericUpDownDuracion";
			this.numericUpDownDuracion.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownDuracion.TabIndex = 41;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(79, 233);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(120, 35);
			this.button5.TabIndex = 42;
			this.button5.Text = "Verificar validez garantia";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.button10);
			this.groupBox1.Location = new System.Drawing.Point(49, 460);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(677, 182);
			this.groupBox1.TabIndex = 47;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(473, 34);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(145, 126);
			this.button2.TabIndex = 3;
			this.button2.Text = "DVD/BLUE-RAY";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(256, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 126);
			this.button1.TabIndex = 2;
			this.button1.Text = "EQUIPO DE SONIDO";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(256, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(163, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Línea marrón";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(19, 34);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(145, 126);
			this.button10.TabIndex = 0;
			this.button10.Text = "TELEVISOR";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Location = new System.Drawing.Point(49, 460);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(677, 182);
			this.groupBox2.TabIndex = 48;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(473, 34);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(145, 126);
			this.button6.TabIndex = 3;
			this.button6.Text = "AIRE ACONDICIONADO";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(256, 34);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(145, 126);
			this.button7.TabIndex = 2;
			this.button7.Text = "LAVADORA";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(256, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(163, 23);
			this.label8.TabIndex = 1;
			this.label8.Text = "Línea blanca";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(19, 34);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(145, 126);
			this.button8.TabIndex = 0;
			this.button8.Text = "REFRIGERADOR";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// RegistroServicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 686);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.numericUpDownDuracion);
			this.Controls.Add(this.labelValidez);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonRegistrarAparato);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBoxNroSerie);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelDuracionGarantia);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNroGarantia);
			this.Controls.Add(this.labelNroGarantia);
			this.Controls.Add(this.radioButtonBlanca);
			this.Controls.Add(this.radioButtonMarron);
			this.Controls.Add(this.labelLinea);
			this.Controls.Add(this.comboBoxMarca);
			this.Controls.Add(this.labelMarca);
			this.Controls.Add(this.labelSerie);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelCliente);
			this.Controls.Add(this.label1);
			this.Name = "RegistroServicio";
			this.Text = "RegistroServicio";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuracion)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.NumericUpDown numericUpDownDuracion;
		private System.Windows.Forms.Label labelValidez;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonRegistrarAparato;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBoxNroSerie;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelDuracionGarantia;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNroGarantia;
		private System.Windows.Forms.Label labelNroGarantia;
		private System.Windows.Forms.RadioButton radioButtonBlanca;
		private System.Windows.Forms.RadioButton radioButtonMarron;
		private System.Windows.Forms.Label labelLinea;
		private System.Windows.Forms.ComboBox comboBoxMarca;
		private System.Windows.Forms.Label labelMarca;
		private System.Windows.Forms.Label labelSerie;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelCliente;
		private System.Windows.Forms.Label label1;
		

	}
}
