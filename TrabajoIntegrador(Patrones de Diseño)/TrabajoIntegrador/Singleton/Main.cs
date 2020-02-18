using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory;
using TrabajoIntegrador.AbstractFactory.Fabricas;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.Singleton
{
   public class Main
    {



       public static void Run() {



           IFabricaDeHeroe bombero = new FabricaDeBombero();
           IFabricaDeHeroe policia = new FabricaDePolicia();
           IFabricaDeHeroe electricista = new FabricaDeElectricista();
           IFabricaDeHeroe medico = new FabricaDeMedico();

           CrearHeroe(bombero);
           CrearHeroe(policia);
           CrearHeroe(electricista);
           CrearHeroe(medico);


           CuartelDeBomberos cuartel = CuartelDeBomberos.getInstance();

           Comisaria comisaria = Comisaria.getInstance();

           Hospital hospital = Hospital.getInstance();

           CentralElectrica central = CentralElectrica.getInstance();


           Console.WriteLine("Creando Bombero....");
           IResponsable c1 = cuartel.getPersonal();
           Console.WriteLine("Creando Policia....");
           IResponsable c2 = comisaria.getPersonal();
           Console.WriteLine("Creando Medico....");
           IResponsable c3 = hospital.getPersonal();
           Console.WriteLine("Creando Electricista......");
           IResponsable c4 = central.getPersonal();
       
       
       
       }


       public static ICuartel CrearHeroe(IFabricaDeHeroe fabricaHeroe)
       {
           ICuartel cuartel = fabricaHeroe.crearCuartel();

           IResponsable responsable = fabricaHeroe.crearHeroe();

           IVehiculo vehiculo = fabricaHeroe.crearVehiculo();

           IHerramienta herramienta = fabricaHeroe.crearHerramienta();


           cuartel.agregarVehiculo(vehiculo);
           cuartel.agregarPersona(responsable);
           cuartel.agregarHerramienta(herramienta);
           return cuartel;
       }




    }
}
