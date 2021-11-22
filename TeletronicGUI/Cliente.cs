
using System;
using System.IO;
namespace TeletronicGUI
{
	public class Cliente:Persona
	{
		private string idCliente;
		public Cliente(string n, string a, int nc, int c,string id):base(n, a, nc, c)
		{
			idCliente = id;
		}
		public Cliente():base(){}
		public void leer(){
			base.leerPersona();
			idCliente = Console.ReadLine();
		}
		public void mostrar(){
			base.mostrarPersona();
			Console.WriteLine("ID Cliente: "+idCliente);
		}
		public void escribirCliente(BinaryWriter escritor){
			escritor.Write(nombre);
			escritor.Write(apellidos);
			escritor.Write(nroCelular);
			escritor.Write(ci);
			escritor.Write(idCliente);
		}
		public void leerCliente(BinaryReader lector){
			nombre = lector.ReadString();
			apellidos = lector.ReadString();
			nroCelular = lector.ReadInt32();
			ci = lector.ReadInt32();
			idCliente = lector.ReadString();
		}
		public string getIdCliente(){
			return idCliente;
		}
		public void setIdCliente(string x){
			idCliente = x;
		}
			
		}
}

	
	
	
	



		
