using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.AbstractFactory.Fabricas
{
    public class FabricaDeBombero:IFabricaDeHeroe
    {
        public iterator.IResponsable crearHeroe()
        {
            return new Bombero();
        }

        public IVehiculo crearVehiculo()
        {
            return new Autobomba();
        }

        public IHerramienta crearHerramienta()
        {
            return new Manguera();
        }

        public ICuartel crearCuartel()
        {
            return CuartelDeBomberos.getInstance();
        }
    }
}
