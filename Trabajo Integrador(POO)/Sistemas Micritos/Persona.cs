/*
 * Creado por SharpDevelop.
 * Usuario: Enzo
 * Fecha: 12/10/2018
 * Hora: 01:46 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		
		private String nombre;
		private String apellido;
		private String dni;
		private String fechaDenacimiento;
		
		
		
		
		/*======================
               CONSTRUCTORES
          ======================*/
		
		//Constructor con parametros
 		public Persona(String nombre , String apellido,String Dni,String FechaDeNacimiento){
			this.nombre=nombre;
			this.apellido=apellido;
			this.dni=Dni;
			this.fechaDenacimiento=FechaDeNacimiento;
			
		}
		
		//Constructor con tres parametros
			public Persona(String nombre , String apellido,String Dni){
			this.nombre=nombre;
			this.apellido=apellido;
			this.dni=Dni;
			
		}
		
		//Constructor Vacio
		public Persona()
		{
		}
	
	
	
		/*======================
              GETTER Y SETTER
          ======================*/
	
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
	
		public string Apellido {
			get { return apellido; }
			set { apellido = value; }
		}
	
		public String Dni {
			get { return dni; }
			set { dni = value; }
		}
	
		public String FechaDenacimiento {
			get { return fechaDenacimiento; }
			set { fechaDenacimiento = value; }
		}
		
	
	
	}
}
