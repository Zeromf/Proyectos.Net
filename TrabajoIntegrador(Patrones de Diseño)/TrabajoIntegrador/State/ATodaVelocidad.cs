using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
    public class ATodaVelocidad:state
    {

        public ATodaVelocidad(Vehiculo vehiculo)
           : base(vehiculo)
        {
        }

       public override void Encender() {
           Console.WriteLine("No disponible,vehiculo Encendido");
       
       }


       public override void Apagar()
       {
           Console.WriteLine("Motor fundido ,el vehiculo se apago.Necesita ser reparado.Cambiando a estado Roto");
           vehiculo.setEstado(new Roto(this.vehiculo));

       }


       public override void Acelerar()
       {
           Console.WriteLine("El motor se fundio .Necesita ser reparado.Cambiando a estado Roto");
           vehiculo.setEstado(new Roto(this.vehiculo));



       }

       public override void Desacelerar()
       {
           Console.WriteLine("El vehiculo esta desacelerando,a media marcha.Cambuando de estado a media marcha");
           vehiculo.setEstado(new MediaMarcha(this.vehiculo));


       }


       public override void Frenar()
       {
           Console.WriteLine("El vehiculo esta Frenando a punto muerto.Cambiando de estado a punto muerto");
           vehiculo.setEstado(new PuntoMuerto(this.vehiculo));



       }


       public override void Arreglar()
       {
           Console.WriteLine("No disponible ,el vehiculo funciona");


       }





















    }
}
