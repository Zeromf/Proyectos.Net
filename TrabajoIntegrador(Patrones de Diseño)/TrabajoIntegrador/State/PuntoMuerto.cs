using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
    public class PuntoMuerto :state
    {

         public PuntoMuerto(Vehiculo vehiculo)
           : base(vehiculo)
        {
        }

       public override void Encender() {
           Console.WriteLine("No disponible,vehiculo Encendido");
       
       }


       public override void Apagar()
       {
           Console.WriteLine("El vehiculo se apago");
           vehiculo.setEstado(new Apagado(this.vehiculo));


       }


       public override void Acelerar()
       {
           Console.WriteLine("El vehiculo esta acelerando en marcha lenta");
           vehiculo.setEstado(new MarchaLenta(this.vehiculo));


       }

       public override void Desacelerar()
       {
           Console.WriteLine("No disponible,el vehiculo esta parado");

       }


       public override void Frenar()
       {
           Console.WriteLine("No disponible,el vehiculo esta parado");

       }


       public override void Arreglar()
       {
           Console.WriteLine("No disponible ,el vehiculo funciona");


       }








    }
}
