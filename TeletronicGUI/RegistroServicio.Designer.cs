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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.labelMarca = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.labelLinea = new System.Windows.Forms.Label();
			this.radioButtonMarron = new System.Windows.Forms.RadioButton();
			this.radioButtonBlanca = new System.Windows.Forms.RadioButton();
			this.labelNroGarantia = new System.Windows.Forms.Label();
			this.textBoxNroGarantia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.labelDuracionGarantia = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
			this.labelCliente.Location = new System.Drawing.Point(36, 76);
			this.labelCliente.Name = "labelCliente";
			this.labelCliente.Size = new System.Drawing.Size(100, 23);
			this.labelCliente.TabIndex = 1;
			this.labelCliente.Text = "Cliente:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(95, 76);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// labelSerie
			// 
			this.labelSerie.Location = new System.Drawing.Point(326, 73);
			this.labelSerie.Name = "labelSerie";
			this.labelSerie.Size = new System.Drawing.Size(100, 23);
			this.labelSerie.TabIndex = 3;
			this.labelSerie.Text = "Nro. Serie";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(403, 71);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 4;
			// 
			// labelMarca
			// 
			this.labelMarca.Location = new System.Drawing.Point(36, 125);
			this.labelMarca.Name = "labelMarca";
			this.labelMarca.Size = new System.Drawing.Size(100, 23);
			this.labelMarca.TabIndex = 5;
			this.labelMarca.Text = "Marca:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Oster",
									"Samsung",
									"LG",
									"Panasonic",
									"Daewoo"});
			this.comboBox1.Location = new System.Drawing.Point(86, 125);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 6;
			// 
			// labelLinea
			// 
			this.labelLinea.Location = new System.Drawing.Point(326, 120);
			this.labelLinea.Name = "labelLinea";
			this.labelLinea.Size = new System.Drawing.Size(100, 23);
			this.labelLinea.TabIndex = 7;
			this.labelLinea.Text = "Linea:";
			// 
			// radioButtonMarron
			// 
			this.radioButtonMarron.Location = new System.Drawing.Point(419, 119);
			this.radioButtonMarron.Name = "radioButtonMarron";
			this.radioButtonMarron.Size = new System.Drawing.Size(104, 24);
			this.radioButtonMarron.TabIndex = 8;
			this.radioButtonMarron.TabStop = true;
			this.radioButtonMarron.Text = "Marron";
			this.radioButtonMarron.UseVisualStyleBackColor = true;
			// 
			// radioButtonBlanca
			// 
			this.radioButtonBlanca.Location = new System.Drawing.Point(419, 146);
			this.radioButtonBlanca.Name = "radioButtonBlanca";
			this.radioButtonBlanca.Size = new System.Drawing.Size(104, 24);
			this.radioButtonBlanca.TabIndex = 9;
			this.radioButtonBlanca.TabStop = true;
			this.radioButtonBlanca.Text = "Blanca";
			this.radioButtonBlanca.UseVisualStyleBackColor = true;
			// 
			// labelNroGarantia
			// 
			this.labelNroGarantia.Location = new System.Drawing.Point(36, 174);
			this.labelNroGarantia.Name = "labelNroGarantia";
			this.labelNroGarantia.Size = new System.Drawing.Size(100, 23);
			this.labelNroGarantia.TabIndex = 10;
			this.labelNroGarantia.Text = "Nro. Garantia:";
			// 
			// textBoxNroGarantia
			// 
			this.textBoxNroGarantia.Location = new System.Drawing.Point(123, 171);
			this.textBoxNroGarantia.Name = "textBoxNroGarantia";
			this.textBoxNroGarantia.Size = new System.Drawing.Size(100, 20);
			this.textBoxNroGarantia.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(326, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Fecha de Compra:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(432, 174);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// labelDuracionGarantia
			// 
			this.labelDuracionGarantia.Location = new System.Drawing.Point(36, 225);
			this.labelDuracionGarantia.Name = "labelDuracionGarantia";
			this.labelDuracionGarantia.Size = new System.Drawing.Size(121, 26);
			this.labelDuracionGarantia.TabIndex = 14;
			this.labelDuracionGarantia.Text = "Duración de Garantía: ";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(164, 225);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(291, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "meses";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(222, 276);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(345, 36);
			this.label5.TabIndex = 18;
			this.label5.Text = "Registrar Reparacion(Servicio)";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(326, 353);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(140, 129);
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(539, 353);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(144, 129);
			this.pictureBox3.TabIndex = 21;
			this.pictureBox3.TabStop = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(314, 312);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 36);
			this.label6.TabIndex = 23;
			this.label6.Text = "Linea blanca";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(360, 400);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 23);
			this.label7.TabIndex = 24;
			this.label7.Text = "LAVADORA";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(555, 388);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 50);
			this.label8.TabIndex = 25;
			this.label8.Text = "AIRE ACONDICIONADO";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(555, 570);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 50);
			this.label9.TabIndex = 32;
			this.label9.Text = "DVD/Blu-Ray";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(346, 582);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(106, 38);
			this.label10.TabIndex = 31;
			this.label10.Text = "EQUIPO DE SONIDO";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(314, 494);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(163, 36);
			this.label11.TabIndex = 30;
			this.label11.Text = "Linea Marrón";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(539, 535);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(144, 129);
			this.pictureBox4.TabIndex = 28;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(326, 535);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(140, 129);
			this.pictureBox5.TabIndex = 27;
			this.pictureBox5.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(95, 353);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 137);
			this.button1.TabIndex = 33;
			this.button1.Text = "REFRIGERADOR";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(95, 535);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 137);
			this.button2.TabIndex = 34;
			this.button2.Text = "TELEVISOR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// RegistroServicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 833);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.labelDuracionGarantia);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNroGarantia);
			this.Controls.Add(this.labelNroGarantia);
			this.Controls.Add(this.radioButtonBlanca);
			this.Controls.Add(this.radioButtonMarron);
			this.Controls.Add(this.labelLinea);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.labelMarca);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.labelSerie);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelCliente);
			this.Controls.Add(this.label1);
			this.Name = "RegistroServicio";
			this.Text = "RegistroServicio";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label labelDuracionGarantia;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNroGarantia;
		private System.Windows.Forms.Label labelNroGarantia;
		private System.Windows.Forms.RadioButton radioButtonBlanca;
		private System.Windows.Forms.RadioButton radioButtonMarron;
		private System.Windows.Forms.Label labelLinea;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label labelMarca;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label labelSerie;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelCliente;
		private System.Windows.Forms.Label label1;
	}
}
