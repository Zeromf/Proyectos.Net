using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory;
using TrabajoIntegrador.AbstractFactory.Fabricas;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Strategy;

namespace TrabajoIntegrador.Proxy
{
    public class BomberoProxy:IResponsable
    {
      

      // public IResponsable real = null;
        
        public String nombre { get; set; }

        public IFabricaDeHeroe Fabrica { get; set; }

        private IStrategyApagado strategyApagado= new StrategiaDeApagadoEspiral();
      
        public BomberoProxy(IResponsable r) : base(r) { }
       
        public BomberoProxy(String nombre,IFabricaDeHeroe fabrica) {
            this.nombre = nombre;
            this.Fabrica = fabrica;    
        }


        override public void Apagarincendio(ILugar lugar,Calle calle) {
            IFabricaDeHeroe Bombero = new FabricaDeBombero();

            ICuartel cuartel = Bombero.crearCuartel();

            IResponsable bomberoresponsable = Bombero.crearHeroe();


            Autobomba autobomba = new Autobomba();
            Manguera manguera = new Manguera();

            autobomba.encenderSirena();
            autobomba.Conducir();

            manguera.usar();


            this.strategyApagado.ApagarIncendio(lugar, calle);
            Console.WriteLine("¡¡¡¡¡¡¡ El fuego fue extinguido en su totalidad !!!!!!");
            manguera.guardar();

            cuartel.devolverAlICuartl(bomberoresponsable);
        
        }

      
        
      



    }
}
