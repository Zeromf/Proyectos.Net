using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory.Fabricas;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.AbstractFactory
{
   public class CentralElectrica:ICuartel
    {
      

        private static CentralElectrica instance { get; set; }
        private CentralElectrica()
        {
            responsables = new List<IResponsable>();
            vehiculos = new List<IVehiculo>();

            herramientas = new List<IHerramienta>();
        }
        public static CentralElectrica getInstance()
        {
            if (instance == null)
                instance = new CentralElectrica();

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
            //IResponsable
            Electricista aux = (Electricista)responsables[0];
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



       public override void devolverAlICuartl( IResponsable ElectricistaResponsable){
           IFabricaDeHeroe fabricaHeroe = new FabricaDeElectricista();
     
           ICuartel cuartel = fabricaHeroe.crearCuartel();

           cuartel.agregarHerramienta(ElectricistaResponsable.getHerramienta());
           cuartel.agregarVehiculo(ElectricistaResponsable.getVehiculo());
           cuartel.agregarPersona(ElectricistaResponsable);

           Console.WriteLine("El electricista volvio al Cuartel");
       
       
       }







    }
}
