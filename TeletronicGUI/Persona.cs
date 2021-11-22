
using System;
using System.IO;
namespace TeletronicGUI
{

	public class Persona
	{
		protected string nombre;
		protected string apellidos;
		protected int nroCelular;
		protected int ci;
		public Persona(){
		}
		public Persona(string n, string a, int nc, int c)
		{
			nombre = n;
			apellidos = a;
			nroCelular = nc;
			ci = c;
			
		}
		public void leerPersona(){
			nombre = Console.ReadLine();
			apellidos = Console.ReadLine();
			nroCelular = int.Parse(Console.ReadLine());
			ci = int.Parse(Console.ReadLine());
		}
		public void mostrarPersona(){
			Console.WriteLine("\nNombre: "+nombre+"\nApellidos: "+apellidos+"\nNro. Celular: "+nroCelular+"\nCi: "+ci);
		}
		public string getNombre(){
			return nombre;
		}
		public string getApellidos(){
			return apellidos;
		}
		public int getNroCelular(){
			return nroCelular;
		}
		public int getCI(){
			return ci;
		}
		public void setNombre(string x){
			nombre = x;
		}
		public void setApellidos(string x){
			apellidos = x;
		}
		public void setNroCelular(int x){
			nroCelular = x;
		}
		public void setCi(int x){
			ci = x;
		}
	}
}
