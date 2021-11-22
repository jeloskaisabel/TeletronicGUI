using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TeletronicGUI
{
	public class ArchivoTecnicos
	{
		private string nombre;
		public ArchivoTecnicos(string nombre)
		{
			this.nombre = nombre;
		}
//		public void crearNuevo()
//		{
//		   	if (System.IO.File.Exists(nombre))
//		   	    {
//		   	    	Console.WriteLine("Realmente quiere crear el archivo. Ojo se borraran los registros? s/n");
//		   	    	if (Console.ReadKey().KeyChar=='s')
//		   	    		System.IO.File.Delete(nombre);
//		   	    
//		   	    }
//		   	    else
//		   	    	Console.WriteLine("el archivo no existe");
//		 }
		public void adicionar(Tecnico t)
		{
		    	Stream arch=File.Open(nombre,FileMode.Append);
		    	BinaryWriter escribe=new BinaryWriter(arch);
		    	bool sw = false;
		    	try
		    	{
		    		do
		    		{
		                t.escribirTecnico(escribe);
		                sw = true;
		                MessageBox.Show("Técnico registrado existosamente.");
		    		}while(!sw);
		      }
		    	catch(Exception )
		    	{
		    		
		    		MessageBox.Show("Error. No se pudo registrar al técnico.");
		    	}
		    	finally
		    	{
		    		arch.Close();
		    	}
		 }
		
		
	}
}


