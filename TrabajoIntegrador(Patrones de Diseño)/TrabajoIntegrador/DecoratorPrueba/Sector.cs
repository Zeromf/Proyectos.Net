using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
    public class Sector:ISector
    {

        
        
        private double porcentajeAfectacion = 0;

        public Sector(double porcentajeAfectacion)
        {
            this.porcentajeAfectacion = porcentajeAfectacion;


        }

        public Sector()
        {
            
        }
       
        public void Mojar(int agua) {
            porcentajeAfectacion -= agua;
        
        }


        public void setporcentajeAfectacion(double porcentajeAfectacion)
        {
            this.porcentajeAfectacion = porcentajeAfectacion;


        }
        
        public double getporcentajeAfectacion()
        {
            return this.porcentajeAfectacion;
        
        
        }


        public bool EstaApagado() {
            return (porcentajeAfectacion <= 0);
        
        }


        public override string ToString() {


            return "Sector original afectado por el fuego en: " + getporcentajeAfectacion();
        
        
        }



    }
}
