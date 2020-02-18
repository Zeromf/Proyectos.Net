using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_Ejemplo_
{
    public class FMBicicletaBMX:FMBicicleta
    {



        public override Bicicleta crearBicicleta()
        {
            return new BicicletaBMX();
        }
    }
}
