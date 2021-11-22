using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TeletronicGUI
{
	public class ArchivoClientes
	{
		private string nombre;
		public ArchivoClientes(string nombre)
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
		public void adicionar(Cliente c)
		{
		    	Stream arch=File.Open(nombre,FileMode.Append);
		    	BinaryWriter escribe=new BinaryWriter(arch);
		    	bool sw = false;
		    	try
		    	{
		    		do
		    		{
		                c.escribirCliente(escribe);
		                sw = true;
		                MessageBox.Show("Cliente registrado existosamente.");
		    		}while(!sw);
		      }
		    	catch(Exception )
		    	{
		    		
		    		MessageBox.Show("Error. No se pudo registrar al cliente.");
		    	}
		    	finally
		    	{
		    		arch.Close();
		    	}
		 }
		
		
	}
}


