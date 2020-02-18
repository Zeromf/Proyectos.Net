/*/*
 * Creado por SharpDevelop.
 * Usuario: Enzo
 * Fecha: 26/09/2018
 * Hora: 03:05 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of Terminales.
	/// </summary>
	public class Terminal
	{
		

		private String nombreDeTerminal=null;
		private String ciudad=null;
		private String terminal_salida;
		/*======================
               CONSTRUCTORES
          ======================*/
		
		///Constructor Vacio
		public Terminal( )
		{
		}
		
		
		//Constructor con parametros
		
		public Terminal(String NombreDeTerminal,String Ciudad){
			this.nombreDeTerminal=NombreDeTerminal;
			this.ciudad=Ciudad;
		
		}
		

		/*======================
               GETTER Y SETTER
          ======================*/
		
		
		public string TerminalSalida {
			get { return terminal_salida; }
			set { terminal_salida = value; }
		}
		
		
		private String Terminal_llegada;
		
		public string TerminalLlegada {
			get { return Terminal_llegada; }
			set { Terminal_llegada = value; }
		}
		
		private int Pasajes_Salida;
		
		public int PasajesSalida {
			get { return Pasajes_Salida; }
			set { Pasajes_Salida = value; }
		}
		
		private int Pasajes_llegada;
		
		public int PasajesLlegada {
			get { return Pasajes_llegada; }
			set { Pasajes_llegada = value; }
		}
		
		
		public string NombreDeTerminal {
			get { return nombreDeTerminal; }
			set { nombreDeTerminal = value; }
		}

		public string Ciudad {
			get { return ciudad; }
			set { ciudad = value; }
		}


		/*======================
              ToString
       ======================*/

        public override String ToString(){

            return nombreDeTerminal+"-" ;

        }
		
	
	}
}
