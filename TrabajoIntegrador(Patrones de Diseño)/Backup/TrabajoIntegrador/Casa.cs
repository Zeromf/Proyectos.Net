using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador
{
    class Casa
    {
      
        private int numPuerta;
        private float superficieMCuadrados;
        private int cantHabitantes = 0;

        //Constructor Vacio
        public Casa(){}

        //Constructor con parametros
        public void Casa(int numPuerta,float superficieMCuadrados,int cantHabitantes) {
            this.numPuerta = numPuerta;
            this.superficieMCuadrados = superficieMCuadrados;
            this.cantHabitantes = cantHabitantes;
        }

        //Setters y getters
        public void setNumPuerta(int numPuerta){
            this.numPuerta = numPuerta;
        
        }

        public int getNumPuerta()
        {
            return this.numPuerta;

        }

        public void setSuperficieMCuadrados(float superficieMCuadrados)
        {
            this.superficieMCuadrados = superficieMCuadrados;

        }

        public float getSuperficieMCuadrados()
        {
            return this.superficieMCuadrados;

        }

        public void setCantHabitantes(int cantHabitantes)
        {
           this.cantHabitantes=cantHabitantes;

        }

        public int getCantHabitantes()
        {
            return this.setCantHabitantes;

        }













    }
}
