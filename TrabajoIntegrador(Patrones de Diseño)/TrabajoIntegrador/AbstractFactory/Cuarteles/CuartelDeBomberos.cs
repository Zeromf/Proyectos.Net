using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory.Fabricas;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.AbstractFactory
{
    public class CuartelDeBomberos:ICuartel
    {
      

        private static CuartelDeBomberos instance { get; set; }



        public static CuartelDeBomberos getInstance()
        {
            if (instance == null)
                instance = new CuartelDeBomberos();

            return instance;
        }





        private CuartelDeBomberos()
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

            Bombero aux = (Bombero)responsables[0];
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


        public override void devolverAlICuartl(IResponsable BomberoResponsable)
        {
            IFabricaDeHeroe fabricaHeroe = new FabricaDeBombero();

            ICuartel cuartel = fabricaHeroe.crearCuartel();

            cuartel.agregarHerramienta(BomberoResponsable.getHerramienta());
            cuartel.agregarVehiculo(BomberoResponsable.getVehiculo());
            cuartel.agregarPersona(BomberoResponsable);



            Console.WriteLine("El Bombero volvio al Cuartel");


        }
    }
}
