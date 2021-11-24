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
		public bool adiArtefacto( int  x, Artefacto y ) {
		bool sw = false;
		try {
			Stream archp = File.Open(nombre, FileMode.OpenOrCreate);
			Stream archTemporal = File.Open("tempCliente.dat", FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(archp);
			BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
			Cliente c = new Cliente();
			try {
				while( true ) {
					c.leerCliente(lector);
					if(c.getCI() == x){
						c.adiArtefacto(y);
						sw = true;
					}
					c.escribirCliente(escribeTemp);
				}
			}
			catch( Exception ) {
			}
			finally {
				archp.Close();
				archTemporal.Close();
				File.Replace("tempCliente.dat", nombre, nombre+".bak");
			}
		}
		catch( Exception ) {
		}
		return sw;
	}
		
	public bool buscar(string x) {
		// Abrimos el archivo o se crea un nuevo archivo si no existe
		Stream archp = File.Open(nombre, FileMode.Open);
		BinaryReader lector = new BinaryReader(archp);
		Cliente c = new Cliente();
		bool sw = false;
		try {
			while( true ) {
				c.leerCliente(lector);
				if(c.getCI().Equals(x)){
					sw = true;
				}
				
			}
		}
		catch( Exception ) {
			Console.WriteLine("Fin de archivo ...");
		}
		finally {
			archp.Close();
		}
		return sw;
	}
		public void adiServicio(Servicio x, string y){
			try {
			Stream archp = File.Open(nombre, FileMode.OpenOrCreate);
			Stream archTemporal = File.Open("tempCliente.dat", FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(archp);
			BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
			Cliente c = new Cliente();
			try {
				while( true ) {
					c.leerCliente(lector);
					c.adiServicio(x,y);

					
					
					c.escribirCliente(escribeTemp);
				}
			}
			catch( Exception ) {
			}
			finally {
				archp.Close();
				archTemporal.Close();
				File.Replace("tempCliente.dat", nombre, nombre+".bak");
			}
		
		}
				catch( Exception ) {
		}
		}
		
		
	
		
		
		
	}
}



