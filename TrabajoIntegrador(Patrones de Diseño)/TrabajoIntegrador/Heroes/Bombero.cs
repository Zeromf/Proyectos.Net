using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Strategy;
using TrabajoIntegrador.Observer;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.AbstractFactory;
namespace TrabajoIntegrador
{

    public class Bombero : IResponsable,IObservador
    {

        public Bombero(IResponsable r) : base(r) { }

        public Calle Calle { get; set; }


       public Casa Casa { get; set; }

        private IStrategyApagado strategyApagado;


        public void setEstrategiaDeApagado(IStrategyApagado strategyApagado)
        {
            this.strategyApagado = strategyApagado;
  
        }

        public void setlugar(Casa casa, Calle calle)
        {
            this.Casa = casa;
            this.Calle = calle;
        }

        public ILugar getLugar()
        {
            return this.Casa;
        }
     

        public Bombero() { }

        public Bombero(IStrategyApagado strategy)
        {
            this.Strategy = strategy;

        }

        //Builder
        public Bombero(Casa casa,IStrategyApagado strategy)
        {
            this.Casa = casa;
            this.Strategy = strategy;
           
        }


       public IStrategyApagado Strategy { get { return strategyApagado; } set { strategyApagado = value; } }


       override public void Apagarincendio(ILugar lugar, Calle calle)
        {
            Autobomba a = new Autobomba();
            Manguera m = new Manguera();
           
           a.encenderSirena();
            a.Conducir();

            m.usar();
           
           this.strategyApagado.ApagarIncendio(lugar, calle);
            m.guardar();
        }


       public void StrategyApagadoEscalera (){
           this.strategyApagado = new StrategiaDeApagadoEscalera();
       
       
       }
       public void StrategyApagadoSecuencial()
       {
           this.strategyApagado = new StrategiaDeApagadoSecuencial();


       }

       public void StrategyApagadoEspiral()
       {
           this.strategyApagado = new StrategiaDeApagadoEspiral();


       }

        public void bajarGatitoDeArbol()
        {
            Console.WriteLine("El bombero esta bajando el gatito del arbol");

            
        }


        public string Nombre{get;set;}

       public Bombero (string nombre){
           strategyApagado = new StrategiaDeApagadoEscalera();
           this.Nombre = nombre;

    }

        public void Actualizar(IObservado o)
        {
            Console.WriteLine("Bombero:"+""+this.Nombre+" "+ "Apagando Lugar: "+ ((ILugar)o).Nombre);
            
            
            this.Apagarincendio((ILugar)o,((ILugar)o).calle);



        }











      
    }
}
