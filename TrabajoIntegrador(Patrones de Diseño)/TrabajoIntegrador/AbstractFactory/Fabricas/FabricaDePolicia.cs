using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.AbstractFactory.Fabricas
{
   public class FabricaDePolicia:IFabricaDeHeroe
    {


        public iterator.IResponsable crearHeroe()
        {
            return  new Policia();
        }

        public IVehiculo crearVehiculo()
        {
            return new Patrullero();
        }

        public IHerramienta crearHerramienta()
        {
            return new Pistola();
        }

        public ICuartel crearCuartel()
        {
            return Comisaria.getInstance();
        }
    }
}
