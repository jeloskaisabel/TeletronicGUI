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
		public bool buscar(string x) {
		// Abrimos el archivo o se crea un nuevo archivo si no existe
		Stream archp = File.Open(nombre, FileMode.Open);
		BinaryReader lector = new BinaryReader(archp);
		Tecnico t = new Tecnico();
		bool sw = false;
		try {
			while( true ) {
				t.leerTecnico(lector);
				if(t.getCI().Equals(x)){
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
		public bool adiServicio( Servicio y,string x ) {
		bool sw = false;
		try {
			// Abrimos el archivo o se crea un nuevo archivo si no existe
			Stream archp = File.Open(nombre, FileMode.OpenOrCreate);
			Stream archTemporal = File.Open("tempTecnico.dat", FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(archp);
			BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
			Tecnico t = new Tecnico();
			try {
				while( true ) {
					t.leerTecnico(lector);
					if( t.getCI().Equals(x) ) {
						t.adiServicio(y);
						sw = true;
					}
					t.escribirTecnico(escribeTemp);
				}
			}
			catch( Exception ) {
				// No hace nada.
			}
			finally {
				archp.Close();
				archTemporal.Close();
				File.Replace("tempTecnico.dat", nombre, nombre+".bak");
			}
		}
		catch( Exception ) {
		}
		return sw;
	}
		
		
	}
}


