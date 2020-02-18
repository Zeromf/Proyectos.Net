using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;

namespace TrabajoIntegrador.Command
{
    class MainCommand
    {


        public static void Run() {

            Policia policia = new Policia();
            List<Comand>commands=new List<Comand>();
            
            commands.Add(new ComandoAlto(new DarAlto()));
            commands.Add(new ComandoAlto(new DarAlto()));
            commands.Add(new ComandoAlto(new DarAlto()));
            commands.Add(new ComandoAlto(new DarAlto()));
            commands.Add(new ComandoAlto(new DarAlto()));
           
            commands.Add(new ComandoPerseguir(new Perseguir()));
            commands.Add(new ComandoPerseguir(new Perseguir()));
            commands.Add(new ComandoPerseguir(new Perseguir()));
            commands.Add(new ComandoPerseguir(new Perseguir()));
            commands.Add(new ComandoPerseguir(new Perseguir()));

            commands.Add(new ComandoRefuerzos(new Refuerzos()));
            commands.Add(new ComandoRefuerzos(new Refuerzos()));
            commands.Add(new ComandoRefuerzos(new Refuerzos()));
            commands.Add(new ComandoRefuerzos(new Refuerzos()));
            commands.Add(new ComandoRefuerzos(new Refuerzos()));

            
            
            foreach (Comand command in commands)
            {
                command.Execute();
            }











        
        }











    }
}
