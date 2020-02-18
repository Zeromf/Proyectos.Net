using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.AbstractFactory.Fabricas
{
    public interface IFabricaDeHeroe
    {

        IResponsable crearHeroe();

        IVehiculo crearVehiculo();

        IHerramienta crearHerramienta();

        ICuartel crearCuartel();







    }
}
