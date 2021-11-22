/*
 * Created by SharpDevelop.
 * User: Jeloska Chavez
 * Date: 22/11/2021
 * Time: 16:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeletronicGUI
{
	/// <summary>
	/// Description of RegistroTecnicosForm.
	/// </summary>
	public partial class RegistroTecnicosForm : Form
	{
		Tecnico t = new Tecnico();
		ArchivoTecnicos at = new ArchivoTecnicos("datosTecnicos.dat");
		public RegistroTecnicosForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonSalirClick(object sender, EventArgs e)
		{
			Application.Exit();	
		}
		
		
		void ButtonRegistrarClick(object sender, EventArgs e)
		{
			t.setNombre(textBoxNombre.Text);
			t.setApellidos(textBoxApellidos.Text);
			t.setCi(Convert.ToInt32(textBoxCi.Text));
			t.setNroCelular(Convert.ToInt32(textBoxCelular.Text));
			t.setEspecialidad(textBoxEspecialidad.Text);
			string id = textBoxCi.Text + textBoxNombre.Text.Substring(0)+textBoxApellidos.Text.Substring(0)+"-T";
			t.setIdTecnico(id);
			labelId.Text = id;
			at.adicionar(t);
		}
		
		
		void ButtonNuevoClick(object sender, EventArgs e)
		{
			textBoxNombre.Clear();
			textBoxApellidos.Clear();
			textBoxCi.Clear();
			textBoxCelular.Clear();
			textBoxEspecialidad.Clear();
			labelId.Text = "";
		}

		
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
		
		void TextBoxEspecialidadKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.Handled==char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)){
				errorProvider5.SetError(advEspecialidad, "Solo caracteres");
				advEspecialidad.Text = "Solo caracteres";
			}
			else{
				errorProvider5.SetError(advEspecialidad, "");
				advEspecialidad.Text = "";
			}
			
		}
	}
}
