
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeletronicGUI
{

	public partial class RegistroServicio : Form
	{
		ArchivoClientes ac = new ArchivoClientes("datosClientes.dat");
		Artefacto a = new Artefacto();
		ArchivoArtefactos aa = new ArchivoArtefactos("datosArtefactos.dat");
		
		public RegistroServicio()
		{
			  
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			groupBox1.Visible = false;
			groupBox2.Visible = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		
		void ButtonRegistrarAparatoClick(object sender, EventArgs e)
		{
			a.setNroSerie(textBoxNroSerie.Text);
			a.setMarca(comboBoxMarca.Text);
			if(radioButtonBlanca.Checked){
				a.setLinea('b');
			}
			if(radioButtonMarron.Checked){
				a.setLinea('m');
			}
			a.setNroGarantia(textBoxNroGarantia.Text);
			int d = dateTimePicker1.Value.Day;
			int m = dateTimePicker1.Value.Month;
			int ac = dateTimePicker1.Value.Year;
			string dc = d.ToString();
			string mc = m.ToString();
			if(d<10){
				dc = "0"+d.ToString();
			}
			if(m<10){
				mc = "0"+m.ToString();
			}
			
			string fc = dc +"/"+mc+"/"+ac;
			a.setFechaCompra(fc);
			a.setDuracionGarantia((int)numericUpDownDuracion.Value);
			aa.adicionar(a);
			int ci = int.Parse(textBox1.Text);
				//ac.adiArtefacto(ci,a);
			
			
			
		}
		
	
	
		
//		void TextBoxDuracionKeyPress(object sender, KeyPressEventArgs e)
//		{
//			if((double)(TextBoxDuracion.Value) >= a.validezGarantia()){
//				labelValidez.Text = "Válida";
//			}
//			else{
//				labelValidez.Text = "Inválida";
//			}
//			
//		}
		

		
		void Button5Click(object sender, EventArgs e)
		{
			if((double)(numericUpDownDuracion.Value) <= a.validezGarantia()){
				labelValidez.Text = a.validezGarantia().ToString();
			}
			else{
				labelValidez.Text = "Inválida";
			}
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if(!ac.buscar(textBox1.Text)){
				MessageBox.Show("Cliente no encontrado. Registre al cliente");
				textBox1.Clear();
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			var MainForm = new MainForm();
			this.Close();
			MainForm.Show();
			
		}
		
		
		void RadioButtonMarronCheckedChanged(object sender, EventArgs e)
		{
			if(radioButtonMarron.Checked){
				groupBox1.Visible = true;
				groupBox2.Visible = false;
			}
			
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void RadioButtonBlancaCheckedChanged(object sender, EventArgs e)
		{
			if(radioButtonBlanca.Checked){
				groupBox2.Visible = true;
				groupBox1.Visible = false;
			}
			
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			var Refrigerador = new Refrigerador();
			Refrigerador.LabelText = textBoxNroSerie.Text;
			Refrigerador.Show();
		}
		
		
		
	}
}
