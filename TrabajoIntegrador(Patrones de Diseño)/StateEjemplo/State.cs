using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploState
{
    public abstract class State
    {
        public State(MaquinaGaseosas maquinaGaseosas)
        {
            this.MaquinaGaseosas = maquinaGaseosas;
        }
        protected MaquinaGaseosas MaquinaGaseosas { get; set; }

        public abstract void seleccion();
        public abstract void insertarMoneda();
        public abstract void retirarGeseosa();

    }
}
