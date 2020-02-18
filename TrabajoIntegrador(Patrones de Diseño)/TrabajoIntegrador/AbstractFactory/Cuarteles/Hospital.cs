using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory.Fabricas;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.AbstractFactory
{
    public class Hospital:ICuartel
    {


        private static Hospital instance { get; set; }

        public static Hospital getInstance()
        {
            if (instance == null)
                instance = new Hospital();

            return instance;
        }



        private Hospital()
        {
            responsables = new List<IResponsable>();
            vehiculos = new List<IVehiculo>();

            herramientas = new List<IHerramienta>();
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
            Medico aux = (Medico)responsables[0];
            responsables.Remove(aux);
            IHerramienta her = herramientas[0];
            IVehiculo ve = vehiculos[0];
            herramientas.Remove(her);
            vehiculos.Remove(ve);

            aux.herramienta = her;
            aux.vehiculo = ve;

            //aux.PrepararResponsable(ve, her);
            return aux;
        
        
        }


        public override void devolverAlICuartl(IResponsable MedicoResponsable)
        {
            IFabricaDeHeroe fabricaHeroe = new FabricaDeMedico();

            ICuartel cuartel = fabricaHeroe.crearCuartel();
            cuartel.agregarHerramienta(MedicoResponsable.getHerramienta());
            cuartel.agregarVehiculo(MedicoResponsable.getVehiculo());

            cuartel.agregarPersona(MedicoResponsable);

            Console.WriteLine("El Medico volvio al Cuartel");


        }
    }
}
