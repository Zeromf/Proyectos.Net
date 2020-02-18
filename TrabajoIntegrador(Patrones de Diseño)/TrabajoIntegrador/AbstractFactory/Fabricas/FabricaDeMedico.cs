using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.AbstractFactory.Fabricas
{
   public class FabricaDeMedico:IFabricaDeHeroe
    {


        public iterator.IResponsable crearHeroe()
        {
            return new Medico();
        }

        public IVehiculo crearVehiculo()
        {
            return new Ambulancia();
        }

        public IHerramienta crearHerramienta()
        {
            return new Desfibrilador();
        }

        public ICuartel crearCuartel()
        {
            return Hospital.getInstance();
        }
    }
}
