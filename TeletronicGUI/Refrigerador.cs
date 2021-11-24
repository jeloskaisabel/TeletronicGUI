
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeletronicGUI
{
	/// <summary>
	/// Description of Refrigerador.
	/// </summary>
	public partial class Refrigerador : Form
	{
		Servicio s = new Servicio();
		ArchivoTecnicos archT = new ArchivoTecnicos("datosTecnicos.dat");
		ArchivoClientes archC = new ArchivoClientes("datosClientes.dat");
		ArchivoServicios archS = new ArchivoServicios("datosServicios.dat");
		ArchivoArtefactos archA = new ArchivoArtefactos("datosArtefactos.dat");
		public Refrigerador()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dateTimePicker1.CustomFormat = "dd-MM-yyyy";
			dateTimePicker2.CustomFormat = "dd-MM-yyyy";
			comboBox1.Items.Add("Top Mount(Congelador Superior)"); 
			comboBox1.Items.Add("Bottom Mount(Congelador inferior)");
			comboBox1.Items.Add("Dúplex");
			comboBox1.Items.Add("French Door(estilo francés)");
			comboBox1.Items.Add("Frigobar");
			pictureBox1.SizeMode =PictureBoxSizeMode.StretchImage;
			pictureBox1.Image = Image.FromFile(@"assets\refrigerador\frigobar.jpg");
			

			
	
		}
		
//		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
//		{
//			if()
//		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox1.Text.Equals("Top Mount(Congelador Superior)")){
				pictureBox1.Image = Image.FromFile(@"assets\refrigerador\topMount.jpg"); 
			}
			else if(comboBox1.Text.Equals("Bottom Mount(Congelador inferior)")){
				pictureBox1.Image = Image.FromFile(@"assets\refrigerador\bottomMount.jpg"); 
			}
			else if(comboBox1.Text.Equals("Dúplex")){
				pictureBox1.Image = Image.FromFile(@"assets\refrigerador\duplex.jpg"); 
			}
			else if(comboBox1.Text.Equals("French Door(estilo francés)")){
				pictureBox1.Image = Image.FromFile(@"assets\refrigerador\frenchDoor.jpg"); 
			}
			else if(comboBox1.Text.Equals("Frigobar")){
				pictureBox1.Image = Image.FromFile(@"assets\refrigerador\frigobar.jpg"); 
			}
		}
			
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton1.Checked){
				label2.Enabled = true;
				numericUpDown1.Enabled = true;
				label14.Visible = true;
			
			numericUpDown2.Enabled = true;
				numericUpDown3.Enabled = true;
				numericUpDown4.Enabled = true;
				numericUpDown5.Enabled = true;	
		
			}
			else{
				label2.Enabled = false;
				numericUpDown1.Enabled = false;
				label14.Visible = false;
				numericUpDown2.Enabled = false;
				numericUpDown3.Enabled = false;
				numericUpDown4.Enabled = false;
				numericUpDown5.Enabled = false;
		
			
			}
			
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			int total = int.Parse(numericUpDown2.Text) + int.Parse(numericUpDown3.Text)+int.Parse(numericUpDown4.Text)+int.Parse(numericUpDown5.Text);
			if(total>(int)numericUpDown1.Value){
				MessageBox.Show("Error. El número de piezas seleccionadas no coincide con el número de piezas totales definidas.");
				
			}
			else{
				MessageBox.Show("Piezas seleccionadas exitosamente.");
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if(archT.buscar(textBox2.Text)){
				s.setTecnico(textBox2.Text);
				MessageBox.Show("Técnico asignado exitosamente.");
			}
			else{
				
				MessageBox.Show("Técnico no encontrado.");
			}
		}
		
		void RefrigeradorLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e, Artefacto x)
		{
			s.setNroOrden(int.Parse(textBox4.Text));
			s.setTipo(comboBox1.Text);
			s.setDescrpcion(textBox1.Text);
			if(radioButton1.Checked){
				s.setRequierePiezas(true);
			}
			if(radioButton2.Checked){
				s.setRequierePiezas(false);
			}
			s.setNroPiezas((int)numericUpDown1.Value);
			s.setFechaIngreso(dateTimePicker1.Value.ToString());
			s.setFechaEntrega(dateTimePicker2.Value.ToString());
			s.setPrecio(double.Parse(textBox3.Text));
			string serie = labelSerie.Text;
			string ci = textBox2.Text;
			archS.adicionar(s);
			archT.adiServicio(s, ci);
			archA.adiServicio(s, serie);
			archC.adiServicio(s, serie);
			
		}
		
	public string LabelText
{
    get
    {
        return this.labelSerie.Text;
    }
    set
    {
        this.labelSerie.Text = value;
    }
}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
