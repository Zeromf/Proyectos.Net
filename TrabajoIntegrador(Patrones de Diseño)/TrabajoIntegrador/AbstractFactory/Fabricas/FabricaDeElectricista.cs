using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory.Herramientas;

namespace TrabajoIntegrador.AbstractFactory.Fabricas
{
   public class FabricaDeElectricista:IFabricaDeHeroe
    {



        public iterator.IResponsable crearHeroe()
        {
            return new Electricista();
        }

        public IVehiculo crearVehiculo()
        {
            return new Camioneta();
        }

        public IHerramienta crearHerramienta()
        {
            return new Buscapolo();
        }

        public ICuartel crearCuartel()
        {
            return CentralElectrica.getInstance();
        }
    }
}
