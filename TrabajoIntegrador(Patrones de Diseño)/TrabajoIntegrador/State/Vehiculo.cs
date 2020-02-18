using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
   public class Vehiculo
    {
       private state estado;
       public Vehiculo()
        {
            estado = new Apagado(this);
        }
       public void setEstado(state e)
       {
           estado = e; 
       }


        public void Encender()
        {
            this.estado.Encender();

        }


        public void Apagar()
        {
            this.estado.Apagar();

        }


        public void Acelerar()
        {
            this.estado.Acelerar();

        }

        public void Desacelerar()
        {
            this.estado.Desacelerar();


        }


        public void Frenar()
        {
           this. estado.Frenar();


        }


        public void Arreglar()
        {
            this.estado.Arreglar();



        }








    }
}
