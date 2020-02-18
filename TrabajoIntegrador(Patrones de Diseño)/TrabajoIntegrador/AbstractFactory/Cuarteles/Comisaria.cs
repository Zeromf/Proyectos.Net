using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory.Fabricas;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.AbstractFactory
{
    public class Comisaria:ICuartel
    {

        private static Comisaria instance { get; set; }
        private Comisaria()
        {
            responsables = new List<IResponsable>();
            vehiculos = new List<IVehiculo>();

            herramientas = new List<IHerramienta>();
        }



        public static Comisaria getInstance()
        {
            if (instance == null)
                instance = new Comisaria();

            return instance;
        }

        
        public override void agregarVehiculo(IVehiculo v)
        {
      

            vehiculos.Add(v);
        }

        public override void agregarPersona(iterator.IResponsable r)
        {
            responsables.Add(r);
        }

        public override void agregarHerramienta(IHerramienta h)
        {
       

            herramientas.Add(h);
        }

        public override iterator.IResponsable getPersonal()
        {
            Policia aux = (Policia)responsables[0];
            responsables.Remove(aux);
            IHerramienta her = herramientas[0];
            IVehiculo ve = vehiculos[0];
            herramientas.Remove(her);
            vehiculos.Remove(ve);

            aux.herramienta= her;
            aux.vehiculo = ve;

            //aux.PrepararResponsable(ve, her);
            return aux;
        }


        public override void devolverAlICuartl(IResponsable PoliciaResponsable)
        {
            IFabricaDeHeroe fabricaHeroe = new FabricaDePolicia();

            ICuartel cuartel = fabricaHeroe.crearCuartel();
            cuartel.agregarHerramienta(PoliciaResponsable.getHerramienta());
            cuartel.agregarVehiculo(PoliciaResponsable.getVehiculo());
            cuartel.agregarPersona(PoliciaResponsable);
            


            Console.WriteLine("El Policia volvio al Cuartel");


        }
    }
}
