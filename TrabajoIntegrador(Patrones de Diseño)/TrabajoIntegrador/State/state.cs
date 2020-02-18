using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
    public abstract class state
    {

         public state(Vehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
        }
        protected Vehiculo vehiculo { get; set; }


        public abstract void Encender();
        public abstract void Apagar();
        public abstract void Acelerar();
        public abstract void Desacelerar();
        public abstract void Frenar();
        public abstract void Arreglar();







    }
}
