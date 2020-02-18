using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.AbstractFactory
{
   public abstract class ICuartel
    {

        protected List<IVehiculo> vehiculos;
        protected List<IHerramienta> herramientas;
        protected List<IResponsable> responsables;


        public abstract void agregarVehiculo(IVehiculo v);

        public abstract void agregarPersona(IResponsable r);

        public abstract void agregarHerramienta(IHerramienta h);

        public abstract IResponsable getPersonal();


        public abstract void devolverAlICuartl(IResponsable responsable);
          
       
       
    }
}
