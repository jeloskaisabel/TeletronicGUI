
using System;
using System.IO;

namespace TeletronicGUI
{

	public class Tecnico: Persona
	{
		private string idTecnico;
		private string especialidad;
		//private int nroReparaciones;
		public Tecnico():base()
		{
		}
		public Tecnico(string n, string a, int nc, int c,string id, string es):base(n, a, nc, c){
			idTecnico = id;
			especialidad = es;
			//nroReparaciones = nr;
		}
		public void leer(){
			base.leerPersona();
			idTecnico = Console.ReadLine();
			especialidad = Console.ReadLine();
			//nroReparaciones = int.Parse(Console.ReadLine());
		}
		public void mostrar(){
			base.mostrarPersona();
			Console.WriteLine("ID Empleado: "+idTecnico+"\nEspecialidad: "+especialidad);
		}
		public void escribirTecnico(BinaryWriter escritor){
			escritor.Write(nombre);
			escritor.Write(apellidos);
			escritor.Write(nroCelular);
			escritor.Write(ci);
			escritor.Write(idTecnico);
			escritor.Write(especialidad);
			//escritor.Write(nroReparaciones);
		}
		public void leerEscritor(BinaryReader lector){
			nombre = lector.ReadString();
			apellidos = lector.ReadString();
			nroCelular = lector.ReadInt32();
			ci = lector.ReadInt32();
			idTecnico = lector.ReadString();
			especialidad = lector.ReadString();
			//nroReparaciones = lector.ReadInt32();		
		}
		public string getIdTecnico(){
			return idTecnico;
		}
		public string getEspecialidad(){
			return especialidad;
		}
//		public int getNroReparaciones(){
//			return nroReparaciones;
//		}
		public void setIdTecnico(string x){
			idTecnico = x;
		}
		public void setEspecialidad(string x){
			especialidad = x;
		}
//		public void setNroReparaciones(int x){
//			nroReparaciones = x;
//		}
	}
}
