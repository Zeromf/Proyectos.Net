using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
    public class Apagado:state
    {
        public Apagado(Vehiculo vehiculo)
           : base(vehiculo)
        {
        }

       public override void Encender() {
           Console.WriteLine("Encendiendo el vehiculo.........Vehiculo encendido y cambiando de estado a punto muerto");
           vehiculo.setEstado(new PuntoMuerto(this.vehiculo));

       }


       public override void Apagar()
       {
           Console.WriteLine("No disponible,vehiculo apagado");

       }


       public override void Acelerar()
       {
           Console.WriteLine("No disponible,vehiculo apagado");


       }

       public override void Desacelerar()
       {
           Console.WriteLine("No disponible,vehiculo apagado");

       }


       public override void Frenar()
       {
           Console.WriteLine("No disponible,vehiculo apagado");

       }


       public override void Arreglar()
       {
           Console.WriteLine("No disponible,vehiculo andando");


       }









    }
}
