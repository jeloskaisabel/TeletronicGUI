
using System;

namespace TeletronicGUI
{
	public class Inventario
	{
		private int nroPiezasInv;
		private int[,] Pi=new int[3,100];
		private Artefacto A1=new Artefacto();
		private Artefacto A2=new Artefacto();
		private Artefacto A3=new Artefacto();
		private Artefacto A4=new Artefacto();
		public Inventario()
		{
			nroPiezasInv=1;
			Pi[1,1]=1;
			Pi[2,1]=20;
		}
		public Inventario(int nrPI)
		{
			nroPiezasInv=nrPI;
			for(int i=1;i<=nroPiezasInv;i++){
				Console.WriteLine("Ingrese numero de pieza");
				Pi[1,i]=int.Parse(Console.ReadLine());
				Console.WriteLine("Cuantas piezas existen de esta pieza");
				Pi[2,i]=int.Parse(Console.ReadLine());
			}
		}
//		public void adiArtefacto(Artefacto ax){
//			if(ax.getNombreArt()=="refrigerador" || ax.getNombreArt()=="cocina" || ax.getNombreArt()=="microondas" || ax.getNombreArt()=="estereo de sonido"){
//				string Art=ax.getNombreArt();
//				switch(Art){
//					case "refigerador":
//						adiRefrigerador(ax);
//						break;
//					case "cocina":
//						adiCocina(ax);
//						break;
//					case "microondas":
//						adiMicroondas(ax);
//						break;
//					case "estereo de sonido":
//						adiEstereo(ax);
//						break;
//					default:
//						Console.WriteLine("no se agregó el artefacto");
//						break;
//				}
//			}
//			else{
//				Console.WriteLine("El artefacto no está disponible");
//			}
//			
//		}
		public void adiRefrigerador(Artefacto ax){
			A1=ax;
		}
		public void adiCocina(Artefacto ax){
			A2=ax;
		}
		public void adiMicroondas(Artefacto ax){
			A3=ax;
		}
		public void adiEstereo(Artefacto ax){
			A4=ax;
		}
		public void leerInv(){
			Console.WriteLine("Ingrese numero de piezas : ");
			nroPiezasInv=int.Parse(Console.ReadLine());
			for(int i=1;i<=nroPiezasInv;i++){
				Console.WriteLine("Ingrese Cod numero de pieza");
				Pi[1,i]=int.Parse(Console.ReadLine());
				Console.WriteLine("Cuantas piezas existen de esta pieza?");
				Pi[2,i]=int.Parse(Console.ReadLine());
			}
		}
		public void mostrarInv(){
			Console.WriteLine("Numero de piezas : "+nroPiezasInv);
			Console.WriteLine("\npieza \t piezas existentes");
			for(int i=1;i<=nroPiezasInv;i++){
				Console.WriteLine(Pi[1,i]+"\t"+Pi[2,i]);
			}
		}
	}
}
