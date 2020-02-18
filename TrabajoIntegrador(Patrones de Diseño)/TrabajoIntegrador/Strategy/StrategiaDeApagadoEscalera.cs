using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.Strategy
{
    public class StrategiaDeApagadoEscalera:IStrategyApagado
    {

       /* public void ApagarIncendio(ILugar lugar, Calle calle)
        {
            Console.WriteLine("El fuego se esta apagando de forma Escalera");
        }
        */



        /*public void ApagarIncendio(ILugar lugar, Calle calle)
        {
            Console.WriteLine("Apagando incendios");
            int caudal = calle.CaudalAguaporMinu;

            for (int j = 0; j < lugar.getSectores().GetLength(0); j++)
            {
                for (int i = 0; i < lugar.getSectores().GetLength(1); i++)
                {
                    int ii;
                    if ((j % 2) == 0)
                        ii = i;
                    else
                        ii = lugar.getSectores().GetLength(1) - 1 - i;


                    Console.WriteLine("Caudal restante = " + caudal);
                    ISector sector=lugar.getSectores()[j,ii];

                    Console.WriteLine("Apagando sector de columna - "+ j +",fila - " +ii);
                    Console.WriteLine(sector.ToString());
                    Console.WriteLine("porcentaje de afectacion " + sector.getporcentajeAfectacion());
                    if (caudal <sector.getporcentajeAfectacion())
                    {
                        Console.WriteLine("No se puede paagar el lugar por falta de agua");
                        break;
                    }
                    sector.Mojar(caudal);
                    if (sector.EstaApagado())
                    {
                        Console.WriteLine("El incendio fue extinguido en su totalidad");
                    }
                    else {
                        Console.WriteLine("El incendio NO fue extinguido en su totalidad");
                    
                    }

                }
            }
          
        }*/


        public void ApagarIncendio(ILugar lugar, Calle calle)
        {

            ISector[,] matrizDelIncendio = lugar.getSectores();
            int anchuraDeMatrizDeIncendio = matrizDelIncendio.GetLength(0);

            for (int fila = 0; fila < anchuraDeMatrizDeIncendio; fila++)
            {
                if (fila % 2 == 0)
                {
                    for (int nuevaColumna = anchuraDeMatrizDeIncendio - 1; nuevaColumna >= 0; nuevaColumna--)
                    {
                        apagarSector(matrizDelIncendio, fila, nuevaColumna, calle);
                    }
                }
                else
                {
                    for (int columna = 0; columna < anchuraDeMatrizDeIncendio; columna++)
                    {
                        apagarSector(matrizDelIncendio, fila, columna, calle);
                    }
                }

            }
            Console.WriteLine("");
            Console.WriteLine("¡¡El fuego de " + lugar.getNombre() + " fue extinguido en su totalidad con la estrategia ESCALERA¡¡ ");
        }


        private static void apagarSector(ISector[,] matrizDelIncendio, int fila, int columna, Calle calle)
        {
            int caudal = calle.getCaudalAguaPorMinu();
            ISector sectorActual = matrizDelIncendio[fila, columna];
            Console.Write("(" + fila + " , " + columna + ")  " + sectorActual);
            while (!sectorActual.EstaApagado())
            {
                sectorActual.Mojar(caudal);
            }
        }





    }
}
