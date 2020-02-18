using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.FactoryMethod
{
    public class MainFM
    {


        public static void Run() {
            ISector sector = crearSector(100, 45);
            sector.setporcentajeAfectacion(80);
            sector.Mojar(20);
            Console.WriteLine("porcentaje de afectacion despues de decorar: " + sector);
        }
       
        
        
        
        public static ISector crearSector(int caudalLLuvia,int velocidadViento) {

            Sector sector = new Sector(80);
            Console.WriteLine("porcentaje de afectacion: " + sector);
            return DecoratorSector(sector, caudalLLuvia, 30,velocidadViento);        
        }

        public static ISector DecoratorSector(ISector sector, int caudalLLuvia, int temperatura, int velocidadViento)
        {

            Random random = new Random();
         //   ISector sectorDecorado = sector;
            double prababilidad_de_decorar = 0.9;

            if (random.NextDouble()<prababilidad_de_decorar)
                sector = FactorySectores.crearSectores(FactorySectores.PastoSeco, sector);

            if (random.NextDouble() < prababilidad_de_decorar)
                sector = FactorySectores.crearSectores(FactorySectores.ArbolesGrandes, sector);

            if (random.NextDouble() < prababilidad_de_decorar)
                sector = FactorySectores.crearSectores(FactorySectores.GenteAsustada, sector);


            sector = FactorySectores.crearSectores(FactorySectores.DiaMuchoCalor, sector);

            sector = FactorySectores.crearSectores(FactorySectores.DiaVentoso, sector);

            sector = FactorySectores.crearSectores(FactorySectores.DiaLluvioso, sector);

            return sector;

        }



    }
}
