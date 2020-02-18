using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_Ejemplo_
{
    public abstract class FMBicicleta
    {

        public abstract Bicicleta crearBicicleta();

        public static Bicicleta crearBicicleta(int opcion) {

            Bicicleta bicicleta = null;

            switch (opcion)
            {
                case 1:
                    bicicleta = new FMBicicletaBMX().crearBicicleta();
                    break;

                case 2:
                    bicicleta = new FMBicicletaMTB().crearBicicleta();
                    break;

                default:
                    Console.WriteLine("No eligia ninguna opcion: " + opcion);
                    break;
            }

            return bicicleta;
        
        
        
        
        
        }






    }
}
