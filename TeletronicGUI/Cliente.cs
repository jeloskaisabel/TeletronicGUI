
using System;
using System.IO;
namespace TeletronicGUI
{
	public class Cliente:Persona
	{
		private string idCliente;
		private Artefacto[]A = new Artefacto[100];
		private int nroArtefactos;
		public Cliente(string n, string a, int nc, int c,string id):base(n, a, nc, c)
		{
			idCliente = id;
			nroArtefactos = 0;
		}
		public Cliente():base(){
			nroArtefactos = 0;
		}
		public void adiArtefacto(Artefacto x){
			A[nroArtefactos] = x;
			nroArtefactos++;
		}
		public void leer(){
			base.leerPersona();
			idCliente = Console.ReadLine();
			nroArtefactos = int.Parse(Console.ReadLine());
		}
		public void mostrar(){
			base.mostrarPersona();
			Console.WriteLine("ID Cliente: "+idCliente);
			Console.WriteLine(nroArtefactos);
		}
		public void escribirCliente(BinaryWriter escritor){
			escritor.Write(nombre);
			escritor.Write(apellidos);
			escritor.Write(nroCelular);
			escritor.Write(ci);
			escritor.Write(idCliente);
			escritor.Write(nroArtefactos);
			for(int i = 0; i<nroArtefactos; i++){
				A[i].escribirArtefacto(escritor);
			}
		}
		public void leerCliente(BinaryReader lector){
			nombre = lector.ReadString();
			apellidos = lector.ReadString();
			nroCelular = lector.ReadInt32();
			ci = lector.ReadInt32();
			idCliente = lector.ReadString();
			nroArtefactos = lector.ReadInt32();
			for(int i = 0; i<nroArtefactos; i++){
				A[i] = new Artefacto();
				A[i].leerArtefacto(lector);
			}
		}
		public string getIdCliente(){
			return idCliente;
		}
		public void setIdCliente(string x){
			idCliente = x;
		}
		public bool adiServicio(Servicio x, string y){
			bool sw = false;
			for(int i = 0; i<nroArtefactos; i++){
				if(A[i].getNroSerie().Equals(y)){
					A[i].adiServicio(x);
					sw = true;
					return sw;
				}
			}
			return sw;
		}
			
		}
}

	
	
	
	



		
