
using System;
using System.IO;
namespace TeletronicGUI
{
	public class Artefacto : Linea
	{
		private string nroSerie,marca,nroGarantía,fechaCompra;
		private int duracionGarantía;
		private char linea;
		//private double precio;
		private Servicio[] S=new Servicio[100];
		private int nroServicios;
//		private Pieza[] P=new Pieza[100];

		public Artefacto() :base()
		{
			nroServicios = 0;
//			nroSerie="k-2021";
//			marca="samsung";
//			nroGarantía="enero2021";
//			fechaCompra="23/06/2017";
//			duracionGarantía=3;
//			//precio=2000;
////			nroPiezas=0;
//			S=new Servicio();
//			linea = 'b';
//			//nombreArtefacto="refrigerador";
		}
//		public Artefacto(string no,int ge,string ns,string ma,string ng,string fc,int dg,int nroO,bool rr,string fi,string dp,string fe, char l) :base(no,ge)
//		{
//			nroSerie=ns;
//			marca=ma;
//			nroGarantía=ng;
//			fechaCompra=fc;
//			duracionGarantía=dg;
//			//precio=pr;
////			nroPiezas=0;
//			S=new Servicio(nroO,rr,fi,dp,fe);
//			//nombreArtefacto=na;
//			linea = l;
//		}
//		public void adiPieza(Pieza px){
//			nroPiezas++;
//			P[nroPiezas]=px;
//		}
		public void adiServicio(Servicio x){
			S[nroServicios] = x;
			nroServicios++;
		}
		public void leerArt(){
			base.leerLi();
			Console.WriteLine("Ingrese numero de serie del artefacto : ");
			nroSerie=Console.ReadLine();
			Console.WriteLine("Ingrese marca del artefacto :");
			marca=Console.ReadLine();
			Console.WriteLine("Ingrese numero de garantia del artefacto :");
			nroGarantía=Console.ReadLine();
			Console.WriteLine("Ingrese fecha de compra del artefacto :");
			fechaCompra=Console.ReadLine();
			Console.WriteLine("Ingrese duracion de la garantía(int) del artefacto :");
			duracionGarantía=int.Parse(Console.ReadLine());
//			Console.WriteLine("Ingrese precio(double) del artefacto :");
//			precio=double.Parse(Console.ReadLine());
//			S.leerSe();
//			Console.WriteLine("Ingrese nombre del artefacto (refrigerador,cocina,microondas,estereo de sonido):");
//			nombreArtefacto=Console.ReadLine();
		}
		public void mostrarArt(){
			base.mostrarLi();
			Console.WriteLine("Numero de serie del artefacto : "+nroSerie);
			Console.WriteLine("Marca del artefacto : "+marca);
			Console.WriteLine("Numero de garantia del artefacto : "+nroGarantía);
			Console.WriteLine("Fecha de compra del artefacto : "+fechaCompra);
			Console.WriteLine("Duracion de la garantía(int) del artefacto : "+duracionGarantía);
//			Console.WriteLine("Precio(double) del artefacto : "+precio);
//			S.mostrarSe();
//			Console.WriteLine("Nombre del artefacto : "+nombreArtefacto);
//			for(int i=1;i<=nroPiezas;i++){
//				P[i].mostrarPi();
//			}
		}
		public void escribirArtefacto(BinaryWriter escritor){
			escritor.Write(nroSerie);
			escritor.Write(marca);
			escritor.Write(linea);
			escritor.Write(nroGarantía);
			escritor.Write(fechaCompra);
			escritor.Write(duracionGarantía);
			for(int i = 0; i<nroServicios; i++){
				S[i].escribirServicio(escritor);
			}
		}
		public void leerArtefacto(BinaryReader lector){
			nroSerie = lector.ReadString();
			marca = lector.ReadString();
			linea = lector.ReadChar();
			nroGarantía = lector.ReadString();
			fechaCompra = lector.ReadString();
			duracionGarantía = lector.ReadInt32();
			for(int i = 0; i<nroServicios; i++){
				S[i] = new Servicio();
				S[i].leerServicio(lector);
			}
		}
//		public string getNombreArt(){
//			return nombreArtefacto;
//		}
		public double validezGarantia(){
			int ma = DateTime.Now.Month;
			int aa = DateTime.Now.Year;
			int mg = int.Parse(fechaCompra.Substring(3,2));
			int ag = int.Parse(fechaCompra.Substring(6,4));
			return ((aa - ag) * 12) + ma - mg;
			
		}
		
		public void setNroSerie(string x){
			nroSerie = x;
		}
		public void setMarca(string x){
			marca = x;
		}
		public void setLinea(char x){
			linea = x;
		}
		public void setNroGarantia(string x){
			nroGarantía = x;
		}
		public void setFechaCompra(string x){
			fechaCompra = x;
		}
		public void setDuracionGarantia(int x){
			duracionGarantía = x;
			
		}
public string getNroSerie(){
	return nroSerie;
}
		
	}
}
