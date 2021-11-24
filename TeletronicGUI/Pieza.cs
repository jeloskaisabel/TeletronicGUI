
using System;

namespace TeletronicGUI
{
	public class Pieza
	{
		private int np;
		private string[] P=new string[100];
		public Pieza()
		{
			np=1;
			P[1]="Tornillo";
		}
		public void leerPi(){
			Console.WriteLine("Ingrese numero de piezas ");
			np=int.Parse(Console.ReadLine());
			Console.WriteLine("ingerese Cod numero de pieza (numeros enteros)");
			for(int i=1;i<=np;i++){
				P[i]=Console.ReadLine();
			}
		}
		public void mostrarPi(){
			Console.WriteLine("Numero de piezas : "+ np);
			for(int i=1;i<=np;i++){
				Console.WriteLine("Pieza : "+P[i]); 
			}
			
		}
	}
}
