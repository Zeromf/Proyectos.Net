using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.State;

namespace TrabajoIntegrador.AbstractFactory
{
   public class Camioneta:IVehiculo
    {



        public void encenderSirena()
        {
            Console.WriteLine("El chofer enciende la sirena");
        }

        public Boolean Conducir()
        {
          //  Console.WriteLine("El chofer esta conduciendo");
            Random prob = new Random();
            Boolean auto = false;
            if (prob.Next() <40)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Encender(); //punto muerto
                vehiculo.Acelerar(); //punto marcha lenta
                vehiculo.Acelerar(); //media marcha
                vehiculo.Desacelerar(); //
                vehiculo.Apagar();
                Console.WriteLine("Lo siento no a llegado a destino ,el motor se fundio ");
                auto = false;
                
                
            }

            if (prob.Next() >70)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Encender(); //punto muerto
                vehiculo.Acelerar(); //punto marcha lenta
                vehiculo.Acelerar(); //media marcha
                vehiculo.Desacelerar(); //
                vehiculo.Acelerar();
                vehiculo.Acelerar();//A toda velocidad
                vehiculo.Frenar();
                auto = true;

            }
            return auto;



        }
    }
}
