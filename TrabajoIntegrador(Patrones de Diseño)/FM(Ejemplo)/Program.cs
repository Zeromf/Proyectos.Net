using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_Ejemplo_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Eliga una opcion: ");
            Console.WriteLine("1 - BMX");
            Console.WriteLine("2 - MTB");
            var opcion = Console.ReadLine();
            Bicicleta bicicleta = null;
            bicicleta = FMBicicleta.crearBicicleta(int.Parse(opcion));


            /*switch (opcion)
            {
                case "1":
                    bicicleta = new FMBicicletaBMX().crearBicicleta();
                    break;

                case "2":
                    bicicleta = new FMBicicletaMTB().crearBicicleta();
                    break;

                default:
                    Console.WriteLine("No eligia ninguna opcion: "+opcion);
                    break;
            }*/



            Console.WriteLine(bicicleta);
            Console.ReadKey();

        }
    }
}
