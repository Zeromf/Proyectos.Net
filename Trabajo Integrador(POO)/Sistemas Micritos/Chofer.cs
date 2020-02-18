/*
 * Created by SharpDevelop.
 * User: Enzo
 * Date: 19/09/2018
 * Time: 10:56 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of Choferes.
	/// </summary>
	public class Chofer:Persona
	{		
		private static int NumeroDeLegajo=1;
		private int legajo;
		
		/*======================
               CONSTRUCTORES
          ======================*/
		
		public Chofer(string nombre, string apellido,String Dni):base(nombre,apellido,Dni)
		{
			
			this.legajo = NumeroDeLegajo;
		}
	   
		
		
		//Constructor Vacio
		public Chofer()
		{
		}
		

		/*======================
              GETTER Y SETTER
          ======================*/
		
	
		public void setNumeroDeLegajo(int NumeroDeLegajo){
			NumeroDeLegajo=NumeroDeLegajo++;
		
		}
		
		public int getNumeroDeLegajo(){
			return NumeroDeLegajo++;
		
		}
		
		public void setlegajo(int legajo){
			this.legajo=legajo;
		
		}
		
		public int getlegajo(){
			return this.legajo;
		
		}
		
		
		/*======================
             	 METODOS
          ======================*/
		
		public static bool Control_Dni(List<Chofer> ListaObjetosChofer, Chofer NuevoChofer)
		{
			String encontrado =String.Empty;
			
			foreach(Chofer show in ListaObjetosChofer)
			{
				if(show.Dni == NuevoChofer.Dni)
				{
					encontrado = "Igual Dni";
				}
			}
			
			if( encontrado == "Igual Dni")
			{
				
				return true;
			}
			else
			{
				return false;
			}
		}
		
		
		
	
		public string mostrarChofer(){
			return this.Nombre  + " " + this.Apellido+" "+"("+NumeroDeLegajo+")";
		}
		
	}
}
