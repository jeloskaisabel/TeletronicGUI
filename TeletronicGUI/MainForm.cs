
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TeletronicGUI
{

	public partial class MainForm : Form
	{
		Cliente c = new Cliente();
		ArchivoClientes ac = new ArchivoClientes("datosClientes.dat");
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void TextBoxNombreTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ButtonSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
			
		}
		
		void ButtonRegistrarClick(object sender, EventArgs e)
		{
			c.setNombre(textBoxNombre.Text);
			c.setApellidos(textBoxApellidos.Text);
			c.setCi(Convert.ToInt32(textBoxCi.Text));
			c.setNroCelular(Convert.ToInt32(textBoxCelular.Text));
			string id = textBoxCi.Text + textBoxNombre.Text.Substring(0)+textBoxApellidos.Text.Substring(0)+"-C";
			c.setIdCliente(id);
			labelId.Text = id;
			ac.adicionar(c);
			
		}
		void ButtonNuevoClick(object sender, EventArgs e)
		{
			textBoxNombre.Clear();
			textBoxApellidos.Clear();
			textBoxCi.Clear();
			textBoxCelular.Clear();
			labelId.Text = "";
			
		}
		//Te muestra errores
		void TextBoxNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.Handled==char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)){
				errorProvider1.SetError(advNombre, "Solo caracteres");
				advNombre.Text = "Solo caracteres";
			}
			else{
				errorProvider1.SetError(advNombre, "");
				advNombre.Text = "";
			}
			
		}
		
		void TextBoxApellidosKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.Handled==char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)){
				errorProvider2.SetError(advApellidos, "Solo caracteres");
				advApellidos.Text = "Solo caracteres";
			}
			else{
				errorProvider2.SetError(advApellidos, "");
				advApellidos.Text = "";
			}
			
		}
		
		void TextBoxCiKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.Handled==char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
				errorProvider3.SetError(advCi, "Solo numeros");
				advCi.Text = "Solo numeros";
			}
			else{
				errorProvider3.SetError(advCi, "");
				advCi.Text = "";
			}
			
		}
		
		
		void TextBoxCelularKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.Handled==char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
				errorProvider4.SetError(advCelular, "Solo numeros");
				advCelular.Text = "Solo numeros";
			}
			else{
				errorProvider4.SetError(advCelular, "");
				advCelular.Text = "";
			}
			
		}
		//Divar
		void Button1Click(object sender, EventArgs e)
		{
			var RegistroTecnicosForm = new RegistroTecnicosForm();
			
			RegistroTecnicosForm.Show();
			
				
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			var RegistroServicio = new RegistroServicio();
			
			RegistroServicio.Show();
	
			
		}
	}
}
