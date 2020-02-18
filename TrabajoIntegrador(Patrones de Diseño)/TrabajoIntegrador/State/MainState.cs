using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
    public class MainState
    {


        public static void Run(){

    

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Apagar();
            vehiculo.Encender();

            vehiculo.Acelerar();

            vehiculo.Acelerar();
            vehiculo.Acelerar();

            vehiculo.Acelerar();

            vehiculo.Desacelerar();
            vehiculo.Arreglar();
        
        
        
        
        
        
        }





    }
}
