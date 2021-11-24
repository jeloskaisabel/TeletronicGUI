
using System;

namespace TeletronicGUI
{
	public class Linea
	{
		protected string nombre;
		protected int generacion;
		public Linea()
		{
			nombre="Blanco";
			generacion=2;
		}
		public Linea(string no,int ge)
		{
			nombre=no;
			generacion=ge;
		}
		public void leerLi(){
			Console.WriteLine("Ingrese nombre de linea");
			nombre=Console.ReadLine();
			Console.WriteLine("Ingrese Generacion de linea(int)");
			generacion=int.Parse(Console.ReadLine());
		}
		public void mostrarLi(){
			Console.WriteLine("Nombre Linea : "+ nombre);
			Console.WriteLine("Generacion Linea : "+ generacion);
		}
	}
}
