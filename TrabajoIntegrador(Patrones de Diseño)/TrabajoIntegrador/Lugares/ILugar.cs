using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Observer;
using TrabajoIntegrador.DecoratorPrueba;
using TrabajoIntegrador.FactoryMethod;
namespace TrabajoIntegrador.Lugares
{
    public abstract class ILugar:IObservado{

        public ILugar() { }

        //protected int[,] sectores;  


        public ISector[,] sectores; 


        public string Nombre{get;set;}


        public string getNombre() {
            return this.Nombre;
        
        
        
        }

        public int Superficie { get; set; }

        /*public int[][] GetSectores()
        {
            Random r = new Random();
            double raiz = Math.Sqrt(this.Superficie);
            int N = (int)Math.Round(raiz);
            int[][] sectores = new int[N][];
            for (int i = 0; i < N; i++)
            {
                sectores[i] = new int[N];
                for (int j = 0; j < N; j++)
                {
                    sectores[i][j] = r.Next(101);
                }
            }
            return sectores;
        }*/



        public ISector[,] getSectores() {
            return sectores;
        
        
        }


        
        private  List<IObservador>bomberosObservadores=new List<IObservador>();
        
        
        public ILugar(string nombre, int superficie) {
            this.Nombre = nombre;
            this.Superficie = superficie;
            int n = Convert.ToInt32(Math.Sqrt(superficie));

            sectores = new ISector[n,n];

            Random r = new Random();

            for (int j = 0; j < sectores.GetLength(0); j++) {
                for (int i = 0; i < sectores.GetLength(1); i++)
                {
                    sectores[j, i] = crearSector(r.Next(101),35,20);
                }
                
            }
        
        
        }
        public ISector decorarSector(Sector sector){
            return new ArbolesGrandesDecorator(sector);
        
        }




        public ISector crearSector(int caudalLLuvia,int temperatura,int velocidadViento) {
            Random random = new Random();
            int caudal = random.Next(100);
            Sector sector = new Sector(caudal);

            return DecoratorSector(sector, caudalLLuvia, temperatura, velocidadViento);
        
        }

       /* public ISector DecoratorSector(ISector sector, int caudalLLuvia, int temperatura, int velocidadViento)
        {

            Random random = new Random();
            ISector sectorDecorado = sector;
            double prababilidad_de_decorar = 0.2;

            if (random.NextDouble()<prababilidad_de_decorar)
                sectorDecorado = new PastoSecoDecorator(sector);
            
            if (random.NextDouble() < prababilidad_de_decorar)
                sectorDecorado = new ArbolesGrandesDecorator(sector);

            //if (random.NextDouble() < prababilidad_de_decorar)
              //  sectorDecorado = new GenteAsustadaDecorator(sector);    

            if (temperatura > 30)
                sectorDecorado = new MuchoCalorDecorator(sector,temperatura);

            if (velocidadViento>80)
                sectorDecorado = new DiaVentosoDecorator(sector,velocidadViento);

            if (caudalLLuvia>0)
                sectorDecorado = new DiaLluviosoDecorator(sector, velocidadViento);

            return sector;

        }*/


        public static ISector DecoratorSector(ISector sector, int caudalLLuvia, int temperatura, int velocidadViento)
        {

            Random random = new Random();
            ISector sectorDecorado = sector;
            double prababilidad_de_decorar = 0.9;

            if (random.NextDouble() < prababilidad_de_decorar)
                sectorDecorado = FactorySectores.crearSectores(FactorySectores.PastoSeco, sectorDecorado);

            if (random.NextDouble() < prababilidad_de_decorar)
                sectorDecorado = FactorySectores.crearSectores(FactorySectores.ArbolesGrandes, sectorDecorado);

            if (random.NextDouble() < prababilidad_de_decorar)
                sectorDecorado = FactorySectores.crearSectores(FactorySectores.GenteAsustada, sectorDecorado);


            sectorDecorado = FactorySectores.crearSectores(FactorySectores.DiaMuchoCalor, sectorDecorado);

            sectorDecorado = FactorySectores.crearSectores(FactorySectores.DiaVentoso, sectorDecorado);

            sectorDecorado = FactorySectores.crearSectores(FactorySectores.DiaLluvioso, sectorDecorado);

            return sectorDecorado;

        }





        public void chispa() {
            Console.WriteLine("Hubo una chispa,sonando alarma");
            notificar();
        
        }

        public void AgregarObservador(IObservador bombero)
        {
            bomberosObservadores.Add(bombero);
        }

        public void QuitarObservador(IObservador bombero)
        {
            bomberosObservadores.Remove(bombero);
        }



        public void notificar()
        {
            foreach (IObservador o in bomberosObservadores)
            {
                o.Actualizar(this);
            }


        }



        public Calle calle { get; set; }
    }
}
