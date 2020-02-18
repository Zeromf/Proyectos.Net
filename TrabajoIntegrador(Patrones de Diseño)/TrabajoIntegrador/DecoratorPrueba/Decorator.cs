using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
    public abstract class Decorator:ISector
    {

        protected ISector componente;

        public Decorator(ISector componente) {
            this.componente = componente;
        
        
        }

        public bool EstaApagado() {
            return this.componente.EstaApagado();
        }


        public abstract void Mojar(int agua);


        public void setporcentajeAfectacion(double porcentajeAfectacion)
        {
            this.componente.setporcentajeAfectacion(porcentajeAfectacion);
        }

        public double getporcentajeAfectacion()
        {
            return this.componente.getporcentajeAfectacion();
        }

        public override string ToString() {
           return "Sector original afectado por el fuego en: " + getporcentajeAfectacion();
;
        }
        
       



    }
}
