using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador
{
    class HeroesDeCiudad
    {
        static void Main(string[] args)
        {


            int opcion;
            do
            {

                do
                {
                    opcion = InterfaceSistema();




                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Strategy.MainStrategy.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            
                            break;

                        case 2:
                            Console.Clear();
                            Command.MainCommand.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();


                            break;
                        case 3:
                            Console.Clear();
                            Observer.MainObserver.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();


                            break;
                        case 4:
                            Console.Clear();
                            Composite.MainComposite.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            DecoratorPrueba.Main.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.Clear();
                            TemplateMethod.MainTemplate.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;
                        case 7:
                            Console.Clear();
                            Adapter.MainAdapter.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;

                        case 8:
                            Console.Clear();
                            FactoryMethod.MainFM.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;
                        case 9:
                            Console.Clear();
                            Builder.MainBuilder.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;

                        case 10:
                            Console.Clear();
                            iterator.MainIterator.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;

                        case 11:
                            Console.Clear();
                            ChainofResponsibility.MainChain.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;

                        case 12:
                            Console.Clear();
                            AbstractFactory.MainAbstract.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;
                        case 13:
                            Console.Clear();
                            Singleton.Main.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;

                        case 14:
                            Console.Clear();
                            Proxy.MainProxy.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;

                        case 15:
                            Console.Clear();
                            State.MainState.Run();
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar....");
                            Console.ReadKey();
                            break;

                    }//Fin del Switch

                } while (opcion < 16 & opcion >= 1);

                if (opcion > 16 | opcion < 1)
                {

                    Console.WriteLine("ingrese una opcion valida");
                    Console.ReadKey();
                }

            } while (opcion != 16);


            Console.Clear();
            Console.WriteLine("Fin del Programa");
            Console.WriteLine("");
            Console.WriteLine("Good bye!");
            Environment.Exit(-1); //fin del programa

        }





		public static int InterfaceSistema()
		{
			int opcion;
			
			Console.Clear();

            Console.WriteLine("*********************PATRONES DE DISEÑO*******************");
            Console.WriteLine("");

			Console.WriteLine   ("¿Que Patron desea ingresar?\n\n"+
			                     "1) Strategy\n\n"+
                                 "2) Command \n\n" +
                                 "3) Observer \n\n" +
                                 "4) Composite \n\n" +
                                 "5) Decorator \n\n" +
                                 "6) Template Method \n\n" +
                                 "7) Adapter \n\n"+
                                 "8) Factory Method \n\n" +
                                 "9) Builder \n\n" +
                                 "10) Iterator \n\n" +
                                 "11) ChainOfResponsibility \n\n" +
                                 "12) AbstractFactory \n\n" +
                                 "13) Singleton \n\n" +
                                 "14) Proxy \n\n" +
                                 "15) State \n\n" +
			                     "16) Salir del sistema\n");
			
			return opcion = Convert.ToInt16(Console.ReadLine());
		}


    }

}
