/*
 * Creado por SharpDevelop.
 * Usuario: Enzo
 * Fecha: 21/09/2018
 * Hora: 09:47 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections;
namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of Recorridos.
	/// </summary>
	public class Recorrido
	{
		private String recorrido;
	 	private List<Terminal>listaTerminales;
	 	private List<Chofer>listaChoferes;

	
	 /*======================
           CONSTRUCTORES
      ======================*/
		
		//Constructor Vacio
		public Recorrido(){
        }
		
		//Constructor con parametros
		public Recorrido(List <Terminal> listaTerminales,List<Chofer> listaChoferes){
			this.listaTerminales=listaTerminales;
			this.listaChoferes=listaChoferes;
		
	
		}
		
		
		

	//Constructor que recibe por parametro la lista de terminales
	//Y calcula las lista derecha e izquierda para el texto de recorridos
		public Recorrido (List <Terminal> listaTerminales)
		{
			List <Terminal> ListaIzquierda =  new List<Terminal>(listaTerminales);
			
			         List <Terminal> ListaDerecha = new List<Terminal>();
			         
		    
				
				
			int opcion;
				
			do
			{			
				
				
					Console.Clear();
					
			Console.WriteLine("*******************************************************************************"+
			                  "******                                 Micritos                             ****"+
			                 "*********************************************************************************");
					
					Console.WriteLine("Seleccione las terminales del recorrido,ingrese 0 para finalizar");
					
					//Este for muestra las ciudades que ingreso el usuario

					int puntero= 1;
					for(int i=0;i<=ListaIzquierda.Count-1;i++)
					{			
						Console.WriteLine(puntero+")"+ListaIzquierda[i].Ciudad);
						puntero++;
					}
					//Este for muestra las ciudades que selecciono el usuario 
					puntero = 8;
						for(int i=0;i<=ListaDerecha.Count-1;i++)
					{	
							Console.SetCursorPosition(35,puntero);//Set cursor mueve la lista que eligio
							Console.WriteLine(ListaDerecha[i].Ciudad);	
							puntero++;
					}
					opcion = Convert.ToInt16(Console.ReadLine());
				
					
					//En este If, Chequeo que no seleccionen fuera del rango de Terminal mostrados
					
					if(opcion <= ListaIzquierda.Count & opcion > 0)
					{
					
							ListaDerecha.Add(ListaIzquierda[opcion-1]);
							ListaIzquierda.RemoveAt(opcion-1);
							
					}	
					
			}while(opcion != 0);
			
			Console.WriteLine("El recorrido se ha dado de alta correctamente");
			Console.WriteLine("Presiona una tecla para continuar...");
			
			Console.ReadKey();
			Console.Clear();//Limpio Pantalla
			ListaIzquierda = listaTerminales;
			recorrido = "";
			
			for(int i =0;i<=ListaDerecha.Count-1;i++)
			{
				recorrido = recorrido  + ListaDerecha[i].Ciudad+" - ";
				
			}	
			
		}
		
		
		/*======================
               	 METODOS
          ======================*/
		
		public static string ImprimirListadoRecorrido(List<Recorrido> ListaObjetosRecorrido)
		{
			int RecorridoSelecto;
			int p=1;
			string DevolucionRecorridos = "";
			Console.Clear();
			
			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");
			foreach( Recorrido show in ListaObjetosRecorrido)
				
			{			
				Console.WriteLine(p+")"+show.recorrido);
				p++;			
			}
			
			RecorridoSelecto =Convert.ToInt32(Console.ReadLine());
			int i = 1;
			
			foreach( Recorrido show in ListaObjetosRecorrido)				
			{
				if (i == RecorridoSelecto)
				{
					DevolucionRecorridos = show.recorrido;
				
				}							
				i++;				
			}			
			return DevolucionRecorridos;
		}


		
	

		/*======================
              ToString
       ======================*/

        public override String ToString(){
			return recorrido;

        }
	
	
	}
}