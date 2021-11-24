
using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace TeletronicGUI
{
	/// <summary>
	/// Description of ArchivoServicios.
	/// </summary>
	public class ArchivoServicios
	{
		private string nombre;
		public ArchivoServicios(string nombre)
		{
			this.nombre = nombre;
		}
		public void adicionar(Servicio s)
		{
		    	Stream arch=File.Open(nombre,FileMode.Append);
		    	BinaryWriter escribe=new BinaryWriter(arch);
		    	bool sw = false;
		    	try
		    	{
		    		do
		    		{
		                s.escribirServicio(escribe);
		                sw = true;
		                MessageBox.Show("Servicio registrado existosamente.");
		    		}while(!sw);
		      }
		    	catch(Exception )
		    	{
		    		
		    		MessageBox.Show("Error. No se pudo registrar el servicio.");
		    	}
		    	finally
		    	{
		    		arch.Close();
		    	}
		 }
	}
}
