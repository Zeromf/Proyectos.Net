/*
 * Created by SharpDevelop.
 * User: Enzo
 * Date: 19/09/2018
 * Time: 10:53 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Sistemas_Micritos
{
	class Program
	{
		public static void Main(string[] args)
		{
		etiqueta:
			try {
				Micritos micritos=new Micritos();
				micritos.MenuInicio();
				Console.ReadKey();
			} catch (Exception error) {
				Console.WriteLine(error.Message);
				Console.ReadKey();
				Console.WriteLine("El programa se reiniciara..");
				Console.ReadKey();
				goto etiqueta; /*El goto rompe el programa. Si el usuario ingresa un caracter o algun simbolo
								raro vueve a ejecutar el programa donde indica Etiqueta,similar a un bucle*/								
			}
			
		}
		
		
		
		
		
		
		
	

		
		
		
	
	
	}
	
}