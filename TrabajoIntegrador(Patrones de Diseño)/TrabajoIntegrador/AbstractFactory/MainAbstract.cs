using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory.Fabricas;
using TrabajoIntegrador.Command;
using TrabajoIntegrador.Composite;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.TemplateMethod;

namespace TrabajoIntegrador.AbstractFactory
{
    public class MainAbstract
    {


        public static ICuartel CrearHeroe(IFabricaDeHeroe fabricaHeroe) {
            ICuartel cuartel = fabricaHeroe.crearCuartel();
           
            IResponsable responsable = fabricaHeroe.crearHeroe();

            IVehiculo vehiculo = fabricaHeroe.crearVehiculo();

            IHerramienta herramienta = fabricaHeroe.crearHerramienta();

 
          cuartel.agregarVehiculo(vehiculo);
          cuartel.agregarPersona(responsable);
          cuartel.agregarHerramienta(herramienta);
          return cuartel;    
        }

       

        public static void Run() {

            IFabricaDeHeroe Bombero = new FabricaDeBombero();
            IFabricaDeHeroe Policia = new FabricaDePolicia();
            IFabricaDeHeroe Electricista = new FabricaDeElectricista();
            IFabricaDeHeroe Medico = new FabricaDeMedico();

         Console.WriteLine("---------------------------------------------------------------");
         Console.WriteLine("Ejecuntado con Heroe Bombero");
         Console.WriteLine("---------------------------------------------------------------");

            ICuartel CuartelDeBombero = CrearHeroe(Bombero);
            IResponsable bomberoResponsable = CuartelDeBombero.getPersonal();

            ((Bombero)bomberoResponsable).StrategyApagadoSecuencial();
            ((Bombero)bomberoResponsable).setlugar(new Casa(null, 4, 10, 2,10),new Calle("Varela",120, 8));
            bomberoResponsable.Apagarincendio(((Bombero)bomberoResponsable).getLugar(), new Calle("Varela", 200, 26));
            ((Bombero)bomberoResponsable).setEstrategiaDeApagado(null);
            ((Bombero)bomberoResponsable).setlugar(null,null);
          //  CuartelDeBombero.devolverAlICuartl(bomberoResponsable);

       Console.WriteLine("---------------------------------------------------------------");
       Console.WriteLine("Ejecutando con Heroe Policia");
       Console.WriteLine("---------------------------------------------------------------");

            ICuartel Comisaria = CrearHeroe(Policia);
            IResponsable PoliciaResponsable = Comisaria.getPersonal();
            DarAlto darAlto = new DarAlto(); ;
            PoliciaResponsable.patrullarCalles(new Plaza("pergamono", 100,80),new ComandoAlto(darAlto));
            //   Comisaria.devolverAlICuartl(PoliciaResponsable);


       Console.WriteLine("---------------------------------------------------------------");
       Console.WriteLine("Ejecutando con Heroe Medico");
       Console.WriteLine("---------------------------------------------------------------");

            ICuartel Hospital = CrearHeroe(Medico);
            IResponsable MedicoResponsable = Hospital.getPersonal();
            MedicoResponsable.atenderInfarto(new Transeunte());
         //   Hospital.devolverAlICuartl(MedicoResponsable);


       Console.WriteLine("---------------------------------------------------------------");
       Console.WriteLine("Ejecutando con Heroe Electricista");
       Console.WriteLine("---------------------------------------------------------------");

            Esquina esquina1 = new Esquina("El Centenario", 12);
            Esquina esquina2 = new Esquina("El Hueso", 4);
            Esquina esquina3 = new Esquina("El Nido", 5);
            Esquina esquina4 = new Esquina("La Gloria", 12);

            Calle calle1 = new Calle("Achával Rodríguez	", 100, 4);
            Calle calle2 = new Calle("9 de Julio	", 100, 7);
            Calle calle3 = new Calle("27 de Febrero	", 100, 6);
            Calle calle4 = new Calle("Acoyte", 100, 8);

            Plaza plaza = new Plaza("San Martin", 10, 40);

            IILuminable manzana1 = new composite("Barrio A");
            manzana1.Add(esquina1);
            manzana1.Add(esquina2);
            manzana1.Add(esquina3);
            manzana1.Add(esquina4);
            manzana1.Add(calle1);
            manzana1.Add(calle2);
            manzana1.Add(calle3);
            manzana1.Add(calle4);
            manzana1.Add(plaza);

            ICuartel CentralElectrica = CrearHeroe(Electricista);
            IResponsable ElectricistaResponsable = CentralElectrica.getPersonal();
            
            IVehiculo vehiculo = new Camioneta();
            vehiculo.Conducir();

            ElectricistaResponsable.Revisar(manzana1);
          
            CentralElectrica.devolverAlICuartl(ElectricistaResponsable);
            
            
        














        
        
        }



    }
}
