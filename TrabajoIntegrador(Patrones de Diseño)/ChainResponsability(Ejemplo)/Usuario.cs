using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo_
{
    class Usuario
    {
        static void Main(string[] args)
        {

            ObjetoBasico vehiculo1 = new Vehiculo("Auto++ KT500 Vehiculo de ocasion en buen estado");

            Console.WriteLine(vehiculo1.devuelveDescripcion());

            ObjetoBasico modelo1 = new Modelo("KT400","Vehiculo amplio y confortable");

            ObjetoBasico vehiculo2 = new Vehiculo(null);

            vehiculo2.setSiguiente(modelo1);

            Console.WriteLine(vehiculo2.devuelveDescripcion());

            ObjetoBasico marca1 = new Marca("Auto++","Marca del automovil","de gran calidad");

            ObjetoBasico modelo2 = new Modelo("KT700", null);

            modelo2.setSiguiente(marca1);

            ObjetoBasico vehiculo3 = new Vehiculo(null);

            vehiculo3.setSiguiente(modelo2);

            Console.WriteLine(vehiculo3.devuelveDescripcion());

            ObjetoBasico vehiculo4 = new Vehiculo(null);

            Console.WriteLine(vehiculo4.devuelveDescripcion());


            Console.ReadKey();








        }
    }
}
