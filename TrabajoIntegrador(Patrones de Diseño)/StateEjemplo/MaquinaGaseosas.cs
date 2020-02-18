using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploState
{
   public class MaquinaGaseosas
   {
        public MaquinaGaseosas()
        {
            State = new StandBy(this);
        }
        public State State { get; set; }


        public void seleccion()
        {
            this.State.seleccion();
        }
        public void insertarMoneda()
        {
            this.State.insertarMoneda();
        }
        public void retirarGeseosa()
        {
            this.State.retirarGeseosa();
        }
    }
}
