
using System;
using System.IO;

namespace TeletronicGUI
{

	public class Tecnico: Persona
	{
		private string idTecnico;
		private string especialidad;
		private Servicio[]S = new Servicio[100];
		private int nroServicios;
		public Tecnico():base()
		{
			nroServicios =0;
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
		public void adiServicio(Servicio x){
			S[nroServicios] =x;
			nroServicios++;
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
			escritor.Write(nroServicios);
			for(int i = 0; i<nroServicios; i++){
				S[i].escribirServicio(escritor);
			}
		}
		public void leerTecnico(BinaryReader lector){
			nombre = lector.ReadString();
			apellidos = lector.ReadString();
			nroCelular = lector.ReadInt32();
			ci = lector.ReadInt32();
			idTecnico = lector.ReadString();
			especialidad = lector.ReadString();
			nroServicios = lector.ReadInt32();
			for(int i= 0; i<nroServicios; i++){
				S[i] = new Servicio();
				S[i].leerServicio(lector);
			}
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
