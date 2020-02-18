using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploState
{
    public class StandBy : State
    {
        public StandBy(MaquinaGaseosas maquinaGaseosas) : base(maquinaGaseosas)
        {
        }

        public override void insertarMoneda()
        {
            Console.WriteLine("ingresando moneda y cambiando a estado EsperandoOpcion");

            this.MaquinaGaseosas.State = new EsperandoOpcion(this.MaquinaGaseosas);
        }

        public override void retirarGeseosa()
        {
            Console.WriteLine("no se puede retirar la gaseosa hasta que hay pueso y seleccionado una opcion");
        }

        public override void seleccion()
        {
            Console.WriteLine("no se puede seleccionar la gaseosa hasta que hay pueso la moneda");
        }
    }
}
