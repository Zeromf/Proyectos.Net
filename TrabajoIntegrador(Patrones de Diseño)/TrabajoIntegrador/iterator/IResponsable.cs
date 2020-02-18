using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory;
using TrabajoIntegrador.Command;
using TrabajoIntegrador.Composite;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.TemplateMethod;

namespace TrabajoIntegrador.iterator
{
    public abstract class IResponsable
    {
        IResponsable sucesor = null;

        public IVehiculo vehiculo { get; set; }
        public IHerramienta herramienta { get; set; }



        public IResponsable(){}
        public IResponsable(IResponsable sucesor){
            this.sucesor=sucesor;
        
        
        }

        virtual public void Apagarincendio(ILugar lugar, Calle calle)
        {
            if (sucesor != null)
            {
                sucesor.Apagarincendio(lugar, calle);
            }
        }


        virtual public void atenderInfarto(IInfartable infartable)
        {
            if (sucesor != null)
            {
                sucesor.atenderInfarto(infartable);
            }
    
        }

     

        virtual public void Revisar(IILuminable ilu ) {
            if (sucesor != null)
            {
                sucesor.Revisar(ilu);
            }
        
        }

        virtual public void patrullarCalles(IPatrullable patrullable, Comand comand) {
            if (sucesor != null)
            {
                sucesor.patrullarCalles(patrullable,comand);
            }
        
       
        
        }

        virtual public void patrullarCalles(IPatrullable patrullable)
        {
            if (sucesor != null)
            {
                sucesor.patrullarCalles(patrullable);
            }

        }


        public IVehiculo getVehiculo() {
            return this.vehiculo;
        
        
        
        }

        public IHerramienta getHerramienta()
        {
            return this.herramienta;



        }







    }
}
