
using System;
using System.IO;
namespace TeletronicGUI
{
	public class Servicio
	{
		private int nroOrden;
		private string tipo;
		private string descripcionServicio;
		private bool requierePiezas;
		private int nroPiezas;
		private string tecnico;
		private string fechaIngreso;
		private string fechaEntrega;
		private double precio;
		
		public Servicio()
		{
//			nroOrden=1;
//			requiereRepuesto=true;
//			fechaIngreso="12/12/2020";
//			descripcionProblema="cables infuncionales";
//			fechaEntrega="20/12/2020";
		}
//		public Servicio(int nroO,bool rr,string fi,string dp,string fe)
//		{
//			nroOrden=nroO;
//			requiereRepuesto=rr;
//			fechaIngreso=fi;
//			descripcionProblema=dp;
//			fechaEntrega=fe;
//		}
//		public void leerSe(){
//			Console.WriteLine("Ingrese nroOrden : ");
//			nroOrden=int.Parse(Console.ReadLine());
//			Console.WriteLine("Ingrese si Requiere repuesto? (bool) : ");
//			requiereRepuesto=bool.Parse(Console.ReadLine());
//			Console.WriteLine("Ingrese Fecha de ingreso : ");
//			fechaIngreso=Console.ReadLine();
//			Console.WriteLine("Ingrese descripcion el problema : ");
//			descripcionProblema=Console.ReadLine();
//			Console.WriteLine("Ingrese Fecha de Entrega : ");
//			fechaIngreso=Console.ReadLine();
//		}
//		public void mostrarSe(){
//			Console.WriteLine("NroOrden : "+ nroOrden);
//			Console.WriteLine("Requiere repuesto (bool) : "+requiereRepuesto);
//			Console.WriteLine("Fecha de ingreso : "+fechaIngreso);
//			Console.WriteLine("Descripcion del problema : "+descripcionProblema);
//			Console.WriteLine("Fecha de Entrega : "+fechaEntrega);
//		}
		public void escribirServicio(BinaryWriter escritor){
			escritor.Write(nroOrden);
			escritor.Write(tipo);
			escritor.Write(descripcionServicio);
			escritor.Write(requierePiezas);
			escritor.Write(nroPiezas);
			escritor.Write(tecnico);
			escritor.Write(fechaIngreso);
			escritor.Write(fechaEntrega);
			escritor.Write(precio);
		}
		public void leerServicio(BinaryReader lector){
			nroOrden = lector.ReadInt32();
			tipo = lector.ReadString();
			descripcionServicio = lector.ReadString();
			requierePiezas = lector.ReadBoolean();
			nroPiezas = lector.ReadInt32();
			tecnico = lector.ReadString();
			fechaIngreso = lector.ReadString();
			fechaEntrega = lector.ReadString();
			precio = lector.ReadDouble();
		}
		public void setNroOrden(int x){
			nroOrden = x;
		}
		public void setTipo(string x){
			tipo = x;
		}
		public void setDescrpcion(string x){
			descripcionServicio = x;
		}
		public void setRequierePiezas(bool x){
			requierePiezas = x;
			
		}
		public void setNroPiezas(int x){
			nroPiezas = x;
		}
		public void setTecnico(string x){
			tecnico = x;
		}
		public void setFechaIngreso(string x){
			fechaIngreso = x;
		}
		public void setFechaEntrega(string x){
			fechaEntrega = x;
		}
		public void setPrecio(double p){
			precio = p;
		}
	}
}
