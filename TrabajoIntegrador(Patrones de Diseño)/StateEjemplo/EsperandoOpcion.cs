using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploState
{
    public class EsperandoOpcion : State
    {
        public EsperandoOpcion(MaquinaGaseosas maquinaGaseosas) : base(maquinaGaseosas)
        {
        }

        public override void insertarMoneda()
        {
            Console.WriteLine("opcion no disponible");
        }

        public override void retirarGeseosa()
        {
            Console.WriteLine("opcion no disponible");
        }

        public override void seleccion()
        {
            Console.WriteLine("ingresando seleccion y cambiando a estado RetirrGaseosa");
            this.MaquinaGaseosas.State = new RetirarGaseosa(this.MaquinaGaseosas);
        }
    }
}
