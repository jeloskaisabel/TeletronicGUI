using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TeletronicGUI
{

	public class ArchivoArtefactos
	{
		private string nombre;
		public ArchivoArtefactos(string nombre)
		{
			this.nombre = nombre;
		}
		public void adicionar(Artefacto a)
		{
		    	Stream arch=File.Open(nombre,FileMode.Append);
		    	BinaryWriter escribe=new BinaryWriter(arch);
		    	bool sw = false;
		    	try
		    	{
		    		do
		    		{
		                a.escribirArtefacto(escribe);
		                sw = true;
		                MessageBox.Show("artefacto registrado existosamente.");
		    		}while(!sw);
		      }
		    	catch(Exception )
		    	{
		    		
		    		MessageBox.Show("Error. No se pudo registrar el artefacto.");
		    	}
		    	finally
		    	{
		    		arch.Close();
		    	}
		 }
		public bool adiServicio( Servicio y, string x ) {
		bool sw = false;
		try {
			Stream archp = File.Open(nombre, FileMode.OpenOrCreate);
			Stream archTemporal = File.Open("tempArtefacto.dat", FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(archp);
			BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
			Artefacto a = new Artefacto();
			try {
				while( true ) {
					a.leerArtefacto(lector);
					if(a.getNroSerie().Equals(x)){
						a.adiServicio(y);
						sw = true;
					}
					a.escribirArtefacto(escribeTemp);
				}
			}
			catch( Exception ) {
			}
			finally {
				archp.Close();
				archTemporal.Close();
				File.Replace("tempArfecto.dat", nombre, nombre+".bak");
			}
		}
		catch( Exception ) {
		}
		return sw;
	}
		
		
	}
}
