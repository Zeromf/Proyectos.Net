using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
   public class MediaMarcha:state
    {

         public MediaMarcha(Vehiculo vehiculo)
           : base(vehiculo)
        {
        }

       public override void Encender() {
           Console.WriteLine("No disponible,vehiculo Encendido");
       
       }


       public override void Apagar()
       {
           Console.WriteLine("Motor fundido ,el vehiculo se apago.Necesita ser reparado");
           vehiculo.setEstado(new Roto(this.vehiculo));


       }


       public override void Acelerar()
       {
           Console.WriteLine("El vehiculo acelera a toda velocidad");
           vehiculo.setEstado(new ATodaVelocidad(this.vehiculo));


       }

       public override void Desacelerar()
       {
           Console.WriteLine("El vehiculo esta desacelerando,a marcha lenta");
           vehiculo.setEstado(new MarchaLenta(this.vehiculo));


       }


       public override void Frenar()
       {
           Console.WriteLine("El vehiculo esta Frenando a punto muerto");
           vehiculo.setEstado(new PuntoMuerto(this.vehiculo));


       }


       public override void Arreglar()
       {
           Console.WriteLine("No disponible ,el vehiculo funciona");


       }














    }
}
