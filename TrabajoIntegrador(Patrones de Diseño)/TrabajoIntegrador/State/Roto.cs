using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.State
{
   public class Roto : state
    {

       public Roto(Vehiculo vehiculo)
           : base(vehiculo)
        {
        }

       public override void Encender() {
           Console.WriteLine("No disponible,motor roto");
       
       }


       public override void Apagar()
       {
           Console.WriteLine("No disponible,motor roto");

       }


       public override void Acelerar()
       {
           Console.WriteLine("No disponible,motor roto");

       }

       public override void Desacelerar()
       {
           Console.WriteLine("No disponible,motor roto");

       }


       public override void Frenar()
       {
           Console.WriteLine("No disponible,motor roto");

       }


       public override void Arreglar()
       {
           Console.WriteLine("Reparando motor.............Cambiando a estado apagado");
           vehiculo.setEstado(new Apagado(this.vehiculo));



       }










    }
}
