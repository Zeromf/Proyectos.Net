using System;

namespace EjemploState
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaGaseosas maquinaGaseosas = new MaquinaGaseosas();
            maquinaGaseosas.retirarGeseosa();
            maquinaGaseosas.insertarMoneda();
            maquinaGaseosas.seleccion();
            maquinaGaseosas.retirarGeseosa();
            Console.ReadKey();
        }
    }
}
