/*
 * Creado por SharpDevelop.
 * Usuario: Enzo
 * Fecha: 08/11/2018
 * Hora: 01:07 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of DniException.
	/// </summary>
	public class DniException:Exception
	{

		public static String LongitudNoCorrecta="La longitud debe estar entre 8 y 9";
		
		public DniException(String message){
			LongitudNoCorrecta=message;
		
		
		
		}
		
		
	}
}
