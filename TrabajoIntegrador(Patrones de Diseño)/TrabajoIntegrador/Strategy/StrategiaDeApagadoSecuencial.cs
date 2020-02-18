using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.Strategy
{
    public class StrategiaDeApagadoSecuencial : IStrategyApagado
    {

        /*public void ApagarIncendio(ILugar l, Calle c)
        {
            int[][] mapa = l.GetSectores();
            int N = mapa.Length;
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    int actual = mapa[x][y];
                    Console.Write("({0},{1})", x + 1, y + 1);
                    while (actual != 0)
                    {
                        mapa[x][y] = (mapa[x][y] - c.CaudalAguaporMinu) >= 0 ? (mapa[x][y] - c.CaudalAguaporMinu) : 0;
                        actual = mapa[x][y];
                        Console.Write("->" + actual);
                    }
                    Console.WriteLine("");
                }
            }
        }*/
        
        /*public void ApagarIncendio(ILugar lugar, Calle calle) {
            Random r = new Random();
            Console.WriteLine("Apagando Incendio");
            int caudal = calle.CaudalAguaporMinu;

            for (int j = 0; j <lugar.getSectores().GetLength(0); j++)
            {
                for (int i = 0; i < lugar.getSectores().GetLength(0); i++)
                {
                    
                    Console.WriteLine("Caudal Restante = "+caudal);

                    ISector sector = lugar.getSectores()[j, i];
                    Console.WriteLine("Apagando columna = "+ j+", fila = "+i);
                    Console.WriteLine("Porcentaje de afectacion "+ sector.getporcentajeAfectacion());
                    if (caudal <sector.getporcentajeAfectacion())
                    {
                        Console.WriteLine("No se puede apagar todo el lugar por falta de agua");
                        break;
                    }
                    sector.Mojar(caudal);
                    if (sector.EstaApagado())
                    {
                        Console.WriteLine("El incendio fue extinguido en su totalidad columna "+j);
                    }
                    else {

                        Console.WriteLine("El incendio no fue extinguido en su totalidad columna "+i);

                    
                    }

                }
                Console.WriteLine("El incendio fue extinguido en su totalidad");
            }
           
        
        }*/



        public void ApagarIncendio(ILugar lugar, Calle calle)
        {

            ISector[,] matrizDelIncendio = lugar.getSectores();
            int anchuraDeMatrizDeIncendio = matrizDelIncendio.GetLength(0);

            for (int fila = 0; fila < anchuraDeMatrizDeIncendio; fila++)
            {
                for (int columna = 0; columna < anchuraDeMatrizDeIncendio; columna++)
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
            Console.WriteLine("");
            Console.WriteLine("¡¡¡¡¡¡ El fuego de " + lugar.getNombre() + " fue extinguido en su totalidad con la estrategia SECUENCIAL¡¡¡¡¡¡ ");
            Console.WriteLine("");
        }




    }
}
