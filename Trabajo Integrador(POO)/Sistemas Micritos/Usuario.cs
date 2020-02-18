/*
 * Created by SharpDevelop.
 * User: Enzo
 * Date: 19/09/2018
 * Time: 10:57 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of Usuarios.
	/// </summary>
	public class Usuario:Persona
	{
		
		private static int NumeroDeUsuarioStatico=1;
		private int numeroDeUsuario;
		private int pasajes ;
		private ArrayList pasaje=new ArrayList();
		
		/*======================
               CONSTRUCTORES
          ======================*/
		
		//Constructor con parametros
		public Usuario(String nombre , String apellido,String Dni,String FechaDeNacimiento):base(nombre,apellido,Dni,FechaDeNacimiento){
			this.numeroDeUsuario=NumeroDeUsuarioStatico;
		
		
		}
		

		
		//Constructor Vacio
 		public Usuario()
		{
		}
		
 		/*======================
              GETTER Y SETTER
          ======================*/
		
 		public int Pasajes {
			get { return pasajes; }
			set { pasajes = value; }
		}
		
		public int Numero_usuario_estatico
		{
			get{return NumeroDeUsuarioStatico;}
			set{NumeroDeUsuarioStatico = value;}
			
		}
		
		public int NumeroDeUsuario {
			get { return numeroDeUsuario; }
			set { numeroDeUsuario = value; }
		}
		
		public ArrayList Pasaje {
			get { return pasaje; }
			set { pasaje = value; }
		}
      /*======================
              ToString
       ======================*/

        public override String ToString(){

      	return (" apellido= "+Apellido);

        }
		
		
	}	
}
