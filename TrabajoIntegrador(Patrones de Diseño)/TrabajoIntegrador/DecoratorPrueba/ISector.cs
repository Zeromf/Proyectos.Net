using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
    public interface ISector
    {

        void Mojar(int agua);
        

        void setporcentajeAfectacion(double porcentajeAfectacion);
        

       double getporcentajeAfectacion();


       bool EstaApagado();

       string ToString();





    }
}
