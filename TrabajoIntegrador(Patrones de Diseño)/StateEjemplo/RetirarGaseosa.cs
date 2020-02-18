using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploState
{
    public class RetirarGaseosa : State
    {
        public RetirarGaseosa(MaquinaGaseosas maquinaGaseosas) : base(maquinaGaseosas)
        {
        }

        public override void insertarMoneda()
        {
            Console.WriteLine("opcion no disponible");
        }

        public override void retirarGeseosa()
        {
            Console.WriteLine("retirando Gaseosas y cambiando a estado StandBy");
            this.MaquinaGaseosas.State = new StandBy(this.MaquinaGaseosas);
        }

        public override void seleccion()
        {
            Console.WriteLine("opcion no disponible");
        }
    }
}
