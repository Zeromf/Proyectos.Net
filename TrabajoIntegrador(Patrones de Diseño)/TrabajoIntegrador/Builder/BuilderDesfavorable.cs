using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.FactoryMethod;

namespace TrabajoIntegrador.Builder
{
    public class BuilderDesfavorable:AbstractBuilder
    {

        public override void DecorarSector()
        {
            Random probabilidad = new Random();
            double probabilidadDeDecorar = 0.1;

              if (probabilidad.NextDouble() < probabilidadDeDecorar)
                  Sector = FactorySectores.crearSectores(FactorySectores.PastoSeco, Sector);
            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FactorySectores.crearSectores(FactorySectores.ArbolesGrandes, Sector);
            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FactorySectores.crearSectores(FactorySectores.GenteAsustada, Sector);
            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FactorySectores.crearSectores(FactorySectores.DiaVentoso, Sector);



        }







    }
}
