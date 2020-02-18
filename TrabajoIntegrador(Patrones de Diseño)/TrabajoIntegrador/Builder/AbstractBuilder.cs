using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.Builder
{
    public abstract class AbstractBuilder
    {
        public ISector Sector { get; set; }


        public void crearSector() {
            Random porcentajeDeAfeccionDeIncendio = new Random();
            Sector = new Sector(porcentajeDeAfeccionDeIncendio.Next(0, 101));
        
        }

        public ISector obtenerSector() {
            return Sector;
        
        }


        public abstract void DecorarSector();



    }
}
