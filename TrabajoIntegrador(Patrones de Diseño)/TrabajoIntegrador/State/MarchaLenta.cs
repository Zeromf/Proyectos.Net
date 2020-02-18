using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
   public class MarchaLenta:state
    {


        public MarchaLenta(Vehiculo vehiculo)
           : base(vehiculo)
        {
        }

       public override void Encender() {
           Console.WriteLine("No disponible,vehiculo Encendido");
       
       }


       public override void Apagar()
       {
           Console.WriteLine("El vehiculo se apago.Motor Roto!");
           vehiculo.setEstado(new Roto(this.vehiculo));


       }


       public override void Acelerar()
       {
           Console.WriteLine("Acelerar a media marcha");
           vehiculo.setEstado(new MediaMarcha(this.vehiculo));


       }

       public override void Desacelerar()
       {
           Console.WriteLine("El vehiculo esta desacelerando,a punto muerto");
           vehiculo.setEstado(new PuntoMuerto(this.vehiculo));


       }


       public override void Frenar()
       {
           Console.WriteLine("Frenando");
           vehiculo.setEstado(new PuntoMuerto(this.vehiculo));


       }


       public override void Arreglar()
       {
           Console.WriteLine("No disponible ,el vehiculo funciona");


       }























    }
}
