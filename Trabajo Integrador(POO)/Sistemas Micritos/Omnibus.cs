/*
 * Created by SharpDevelop.
 * User: Enzo
 * Date: 19/09/2018
 * Time: 10:57 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of Omnibus.
	/// </summary>
	public class Omnibus
	{
		private String Marca;
		private int Modelo;
		private int capacidad;
		private static int NumeroDeUnidad=1;
		private String Tipo;
		
		/*======================
               CONSTRUCTORES
          ======================*/
	
		//Constructor con Parametros
		
		public Omnibus(String Marca,int Modelo,int Capacidad,String Tipo){
			this.Marca=Marca;
			this.Modelo=Modelo;
			this.capacidad=Capacidad;
			this.Tipo=Tipo;
		
		}
		
	

		//Constructor Vacio
		public Omnibus()
		{
		}
		
		/*======================
               GETTER Y SETTER
          ======================*/
		
		
		public void setMarca(String Marca){
			this.Marca=Marca;
		
		}
		
		public String getMarca(){
			return this.Marca;
		
		}
		
		public void setModelo(int Modelo){
			this.Modelo=Modelo;
		
		}
		
		public int getModelo(){
			return this.Modelo;
		
		}
		
		public void setCapacidad(int Capacidad){
			this.capacidad=Capacidad;
		
		}
		
		public int getCapacidad(){
			return this.capacidad;
		
		}
		
		public void setTipo(String Tipo){
			this.Tipo=Tipo;
		
		
		}
		
		public String getTipo(){
			return this.Tipo;
		
		
		}
		
		
		public void setNumeroDeUnidad(int NumeroDeUnidad){
			NumeroDeUnidad+=NumeroDeUnidad++;
		
		}
		
		public int getNumeroDeUnidad(){
			return NumeroDeUnidad++;
		
		}
		
		
		
	/*======================
             METODOS
      ======================*/
		
		public static string ValidacionOmnibus(Omnibus OmnibusActual ,List<Pasaje> listaPasajes,string DiaActual)
		{
			string ValidacionOmnibus = "";
			
			foreach(Pasaje show in listaPasajes)
			{
				
				if(show.Dia == DiaActual && show.Omnibus == OmnibusActual)
				   {
					
					ValidacionOmnibus = "existeomnibusmismodia";
					break;
				   	
				   	
				   }		
			}	
			return ValidacionOmnibus;	
		}
	
		public string mostrarOmni(){
			return  " "+this.getNumeroDeUnidad()+" "+"<"+this.getMarca ()+" "+ "-" +" "+ this.getModelo().ToString()+"," +this.getTipo()+","+" "+this.getCapacidad().ToString()+">";
			
		
		
		
		
		}

	}
}
