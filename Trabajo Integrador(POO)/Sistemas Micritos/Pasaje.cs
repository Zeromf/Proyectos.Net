/*
 * Creado por SharpDevelop.
 * Usuario: Enzo
 * Fecha: 27/09/2018
 * Hora: 02:14 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections;
namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of Pasajes.
	/// </summary>
	public class Pasaje
	{
		

		private Chofer chofer ;
		private Omnibus omnibus ;
		private String recorrido;
		private String dia;
		
		/*======================
               CONSTRUCTORES
          ======================*/
		
		//Constructor Vacio
		public Pasaje()
		{
		}
		
	
		/*======================
              GETTER Y SETTER
          ======================*/
		
		
		public Chofer Chofer {
			get { return chofer; }
			set { chofer = value; }
		}
		

		
		public Omnibus Omnibus {
			get { return omnibus; }
			set { omnibus = value; }
		}
		
		public string Recorrido {
			get { return recorrido; }
			set { recorrido = value; }
		}
		
		public string Dia {
			get { return dia; }
			set { dia = value; }
		}
		
		
		
		/*======================
              ToString
       ======================*/

        public override String ToString(){

			return Chofer.ToString()+Omnibus.ToString()+Recorrido+Dia;

        }
		
		
		
	}
}
