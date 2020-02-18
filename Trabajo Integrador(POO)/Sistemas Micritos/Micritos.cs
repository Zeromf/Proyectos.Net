/*
 * Creado por SharpDevelop.
 * Usuario: Enzo
 * Fecha: 21/09/2018
 * Hora: 10:40 p.m.
 *
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;
namespace Sistemas_Micritos
{
	/// <summary>
	/// Description of Micritos.
	/// </summary>
	public class Micritos
	{
		private int opcioan;
		private int opcion2s;
		private int PasajeTotales ;
	 	private List<Terminal>listaTerminales;
		private List<Omnibus>listaOmnibus;
		private List<Chofer>listaChoferes;
		private List<Recorrido>listaRecorridos;
		private List<Usuario>listaUsuarios;
		private List<Pasaje>listaPasajes;
		private List<Terminal>ListaTerminalesSalida=new List<Terminal>();
		private List<Terminal>ListaTerminalesLlegada=new List<Terminal>();
		private List<Usuario> UsuarioPasajes=new List<Usuario>();


		private ArrayList ListaCompras = new ArrayList();

		 /*======================
           	  CONSTRUCTORES
      	  ======================*/


		//Crear nuevas listas de atributos vacios para la clase MenuPrincipal
		public Micritos()
		{
			listaTerminales=new List<Terminal>();
			listaOmnibus=new List<Omnibus>();
			listaChoferes=new List<Chofer>();
			listaRecorridos=new List<Recorrido>();
			listaUsuarios=new List<Usuario>();
			listaPasajes=new List<Pasaje>();
			carga_test();

		}


		/*======================
               	 METODOS
          ======================*/



		//Datos cargados para el sistemas,no recomendable
		public void carga_test(){

			// Crea el Omnibus los setea y lo agrega a la listaOmnibus


			Omnibus omni2=new Omnibus("Iveco",2015,55,"Basico");
			listaOmnibus.Add(omni2);



			// Crea la terminal ,los setea y lo agrega a la listaterminales
			Terminal terminal1=new Terminal("Villa dolores","Cordoba");
			Terminal terminal2=new Terminal("Retiro","Buenos Aires");
			Terminal terminal3=new Terminal("Mariano Moreno","Rosario");
			Terminal terminal4=new Terminal("Rio Grande","Tierra del fuego");
			Terminal terminal5=new Terminal("San Rafael","Mendoza");
			Terminal terminal6=new Terminal("Aguas Blancas","Salta");
			Terminal terminal7=new Terminal("la plata","Chaco");
			Terminal terminal8=new Terminal("Rosario","Santa fe");

			listaTerminales.Add(terminal1);
			listaTerminales.Add(terminal2);
			listaTerminales.Add(terminal3);
			listaTerminales.Add(terminal4);
			listaTerminales.Add(terminal5);


			Chofer chofer1=new Chofer("Lucy","Fernanda","40212938");
			Chofer chofer2=new Chofer("Martin","Gonzales","42131245");

			listaChoferes.Add(chofer1);
			listaChoferes.Add(chofer2);

		}



		/*###########################################################
		  ##################[ MENU PRINCIPAL ]######################
		  ###########################################################*/


		public void MenuInicio(){
			do{

				do{
				opcion =InterfaceSistema();




				switch (opcion) {
					case 1:
						Console.Clear();
				    	//inicia Modulo Recorridos
				    	MenuReco();
						break;

					case 2:
						Console.Clear();
						//inicia Modulo Choferes
						MenuChofer();


						break;
					case 3:
						Console.Clear();
						MenuPasajes();
						//inicia Modulo Ventas de pasaje


						break;
					case 4:
						Console.Clear();
						MenuEstadistica();
						break;


				}//Fin del Switch

				}while (opcion < 5 & opcion >=1);
					if(opcion > 5 | opcion < 1 ){

						Console.WriteLine("ingrese una opcion valida");
						Console.ReadKey();
					}

			}while(opcion != 5);


			Console.Clear();
			Console.WriteLine ("Fin del Programa");
			Console.WriteLine ("");
			Console.WriteLine ("Good bye!");
			Environment.Exit (-1); //fin del programa
		}//Fin MenuPrincipal








		/*###########################################################
		  ##################[ MENU RECORRIDOS ]######################
		  ###########################################################*/

		public void MenuReco(){

			do{


				do{
				 	opcion=InterfaceRecorrido();

				switch (opcion) {
					case 1:
						//Alta de Terminal

						//Pide los datos de la termina y la agrega a lista listaterminal
						Console.WriteLine("Ingrese nombre de la terminal");
						String NombreDeTerminal = Console.ReadLine();
						Console.WriteLine("Ingrese nombre de la Ciudad");
						String Ciudad = Console.ReadLine();

						Terminal terminal=new Terminal(NombreDeTerminal,Ciudad);
						listaTerminales.Add(terminal);
						Console.WriteLine("La terminal fue dada de alta correctamente.");
						Console.ReadKey();
						Console.WriteLine ("Presione una tecla para continuar.");
						Console.ReadKey();

						break;
					case 2:
						//Alta de Omnibus

						//Pide los datos del Omnibus y la agrega a listaOmnibus
						Console.WriteLine("Ingrese la marca: ");

						String Marca=Console.ReadLine();

						Console.WriteLine("Ingrese el modelo: ");
						int Modelo=int.Parse(Console.ReadLine());

						Console.WriteLine("Ingrese la capacidad");
						int capacidad=int.Parse(Console.ReadLine());

						Console.WriteLine("ingrese el tipo(Basico,Semi-Cama,Coche-Cama,Suite): ");
						String Tipo=Console.ReadLine();

						Omnibus omnibu=new Omnibus(Marca,Modelo,capacidad,Tipo);

						Console.WriteLine("El omnibus fue dado de alta correctamente.A la unidad se le asigno el numero "+omnibu.getNumeroDeUnidad());
						Console.ReadKey();
						Console.WriteLine ("Presione una tecla para continuar.");
						Console.ReadKey();

						listaOmnibus.Add(omnibu);

						Console.Clear();
						break;
					case 3:
						//ALTA DE RECORRIDOS
						Recorrido recorrido=new Recorrido(listaTerminales);

						listaRecorridos.Add(recorrido);

						break;
					case 4:
						//Listado de Omnibus y choferes
						Console.Clear();
						Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");
						Console.WriteLine("-------Listado De Omnibus---------");
						Console.WriteLine("");
						int i=1;
						foreach( Omnibus show in listaOmnibus)
						{
							Console.WriteLine(i+")"+"Marca:"+" "+show.getMarca()+","+"Modelo:"+" "+show.getModelo()+","+"Tipo: "+show.getTipo()+","+"Capacidad;"+" "+show.getCapacidad());
							i++;
						}
						Console.WriteLine("");
						Console.WriteLine("-------Listado De Terminales------");
						Console.WriteLine("");
						i=1;
						foreach( Terminal show in listaTerminales)
						{
							Console.WriteLine(i+")"+"Ciudad:"+" "+"("+show.Ciudad+")"+","+"Terminal:"+" "+"("+show.NombreDeTerminal+")");
							i++;
						}
						Console.WriteLine("");
						Console.WriteLine("Presiona una tecla para continuar...");
						Console.ReadKey();
						break;

					case 5:
						Console.Clear();
						MenuInicio();
						break;



				 }

				}while (opcion < 6 & opcion >=1);
					if(opcion > 6 | opcion < 1 ){

						Console.WriteLine("ingrese una opcion valida");
						Console.ReadKey();
					}

			}while(opcion != 5);



		}//Fin del metodo menuReco




		/*###########################################################
		  ##################[ MENU CHOFER ]######################
		  ###########################################################*/

		public void MenuChofer(){
			do{

				do{
					opcion=InterfaceChoferes();


				switch (opcion) {
					case 1:
						//ALTA CHOFER

						Console.WriteLine("Ingrese el nombre : ");
						String Nombre =Console.ReadLine();

						Console.WriteLine("Ingrese el Apellido: ");
						String Apellido=Console.ReadLine();

						Console.WriteLine("Ingrese el Dni: ");
						String Dni=Console.ReadLine();
						Chofer NuevoChofer=new Chofer(Nombre,Apellido,Dni);
						//Pide los datos del chofer y lo agrega a la listaChoferes


						if (Chofer.Control_Dni(listaChoferes,NuevoChofer)) {
								Console.WriteLine("Ya existe un chofer con ese DNI en la empresa");
								Console.ReadKey();
								Console.WriteLine("Presiona una tecla para continuar...");

								Console.ReadKey();

						}
						else{
								listaChoferes.Add(NuevoChofer);
								Console.WriteLine("EL chofer ha sido dado de alta correctamente,su legajo es "+NuevoChofer.getNumeroDeLegajo());
								Console.ReadKey();
								Console.WriteLine("Presione una tecla para continuar...");
								Console.ReadKey();

						}
						Console.Clear();//Limpio Pantalla

						break;

					case 2:

					//Asignacion De Recorridos

					Pasaje pasaje=new Pasaje();


					//Cargo el chofer en el grupo a vender
					//Entra Lista de Choferes Y sale un   selecto
					pasaje.Chofer = ImprimirListadoChoferes(listaChoferes);


					//Cargo el Omnibus en el grupo a vender
					//Entra lista de omnibus y sale omnibus selecto
					pasaje.Omnibus = ImprimirListadoOmnibus(listaOmnibus);

					//Cargo el recorrido en el grupo a vender
					//Entra lista de recorridos y sale un String con todas la terminales
					//que conforman el recorrido

					pasaje.Recorrido = Recorrido.ImprimirListadoRecorrido(listaRecorridos);



					//Dia electo dentro del Array
					//Devuelve el dia seleccionado
					string dia ="";

					//VALIDACIONES
					//Imprime los dias y devuelve el dia seleccionado, si esta repetido, devuelve"dia repetido"
					dia = ImprimirListadoDias(listaPasajes,pasaje.Chofer.Nombre);


					if (dia=="DiaRepetido") {
						Console.WriteLine("El chofer ya hace viaje ese dia");
						Console.ReadKey();
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey();
					}else{
						String ValidacionOmnibus;

						ValidacionOmnibus=Omnibus.ValidacionOmnibus(pasaje.Omnibus,listaPasajes,dia);
						if (ValidacionOmnibus=="OmnibusValidadoMismoDia") {
								Console.WriteLine("El omnibus ya esta reservado ese dia");
								Console.ReadKey();
								Console.WriteLine("Presione una tecla para continuar...");
								Console.ReadKey();
						}else{
							pasaje.Dia=dia;
							listaPasajes.Add(pasaje);
							Console.WriteLine("La asignacion del recorrido fue dada de alta correctamente.");
							Console.ReadKey();
							Console.WriteLine("Presione una tecla para continuar...");
							Console.ReadKey();

						}
					}



					Console.Clear();//Limpio Pantalla
					break;
					case 3:
						Console.Clear();
						MenuInicio();
						break;
				}//Fin del Switch

				}while(opcion < 3 & opcion >=1  );

					if(opcion > 3 | opcion < 1 )
					{
						Console.WriteLine("ingrese una opcion valida");
						Console.ReadKey();
					}

			}while(opcion != 3);


			}//Fin MenuChofer


	  /*###########################################################
		##################[ MENU PASAJES ]#########################
		###########################################################*/

	  public void MenuPasajes(){

	  		do{

				do{



	  			opcion=InterfaceVentaPasajes();





				switch (opcion) {
					case 1:
						//ALTA DE USUARIOS
	  					Console.WriteLine("Ingrese el nombre");
						String nombre=Console.ReadLine();

						Console.WriteLine("Ingrese el Apellido");
						String apellido=Console.ReadLine();

						etiqueta2:
						Console.WriteLine("Ingrese el Dni");
						String Dni=Console.ReadLine();
						try {
							ValidadDni(Dni);
						} catch (DniException) {
							Console.WriteLine(DniException.LongitudNoCorrecta);
	  						goto etiqueta2;
						}

						etiqueta:
						Console.WriteLine("Ingrese la fecha de nacimiento con el formato dd/mm/yyyy");
						String fechanac=Console.ReadLine();

						if (IsDate(fechanac)) {
						}else{
							Console.WriteLine("ingrese la Fecha nuevamente con solo este formato dd/mm/yyyy");
							Console.WriteLine("Presiona una tecla para continuar...");
							Console.ReadKey();
							goto etiqueta;
						}

					Usuario usuario=new Usuario(nombre,apellido,Dni,fechanac);
					listaUsuarios = ControlUsuario(usuario,listaUsuarios);
					Console.Clear();
					break;
					case 2:

						//COMPRA DE PASAJES


						ComprarPasaje(listaUsuarios,listaTerminales,listaPasajes);

						Console.Clear();
						break;
					case 3:
						Console.Clear();
						MenuInicio();
						break;

			}//Fin del Switch

				}while(opcion < 3 & opcion >=1  );

					if(opcion > 3 | opcion < 1 )
					{
						Console.WriteLine("ingrese una opcion valida");
						Console.ReadKey();
					}

			}while(opcion != 3);


			}//Fin MenuPasajes



		/*###########################################################
		##################[ MENU ESTADISTICA ]#########################
		###########################################################*/

		public void MenuEstadistica(){
			do{

				do{
				opcion2 =InterfaceEstadisticas();




				switch (opcion2) {
					case 1:
						//Consulta Total de Pasajes Vendidos
						Console.WriteLine("En total se han vendido: "+"("+imprimirPasajesTotales()+")"+" pasajes.");
						Console.ReadKey();
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey();
						break;

					case 2:
						//Consulta Usuario
						//Imprime a todos los usuarios con la cantidad de pasajes que compraron


						ConsultarUsuario();



						break;
					case 3:
						//CONSULTAR TERMINAL COMO PARTIDA

						ImprimirTerminalesSalida();


						Console.Clear();




						break;
					case 4:
						//CONSULTAR TERMINAL COMO ARRIBO

						ImprimirTerminalesLlegada();
						break;


					case 5:
						Console.Clear();
						MenuInicio();
						break;
				}//Fin del Switch

		}while (opcion2 <5  & opcion2 >=1);
			if(opcion2 > 5 | opcion2 < 1 ){
					Console.WriteLine("ingrese una opcion valida");
					Console.ReadKey();
				}

		}while(opcion2 != 5);







		}


		//Valida la fecha con su formato
	  	public bool IsDate(Object inValue)
        {
            bool bValid;
            try
            {
                DateTime myDT = DateTime.Parse(inValue.ToString());
                bValid = true;
            }
            catch (Exception)
            {
                bValid = false;
            }

            return bValid;
        }

	  	//Valida el Dni
	  	public void ValidadDni(String Dni){

	  	if (!(Dni.Length>=8 && Dni.Length<=10)){
	  		throw new DniException(DniException.LongitudNoCorrecta);
	  	}
	  }


		//Metodo para elegir un dia donde viajar
		private String[] DiasSemana={"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};

		//Impresion de dias.

		public String ImprimirListadoDias(List<Pasaje> listaPasajes,String ChoferActual){
			int p=1;

			int DiaIndice=0;

			string DiaSeleccionado="";
			Console.Clear();

			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");
			Console.WriteLine("Seleccione el dia donde hacer el recorrido\n");

			for (int i = 0; i <=DiasSemana.Length-1; i++) {
				Console.WriteLine(p+")"+DiasSemana[i]);
				p++;
			}
			DiaIndice = Convert.ToInt16(Console.ReadLine());

			p=0;

			for (int i=0;i<=DiasSemana.Length-1;i++){
				if(DiaIndice-1 == i){

					DiaSeleccionado = DiasSemana[i];
				}
			}

			//Recorro Lista de pasajes

			foreach (Pasaje x in listaPasajes) {
				if (x.Dia==DiaSeleccionado && x.Chofer.Nombre==ChoferActual) {
					DiaSeleccionado= "DiaRepetido";
					break;


				}
			}
			return DiaSeleccionado;




		}


		//Retorno la cantidad de pasajes totales
		public int imprimirPasajesTotales()
		{
			return PasajeTotales;

		}


		//Imprime la cantidad de colectivos ingresados con todos sus datos
 		public Omnibus ImprimirListadoOmnibus(List<Omnibus> ListaObjetosChofer)
		{
			int OmnibusSelecto;
			int i =1;
			Omnibus omnibus = new Omnibus();
			Console.Clear();
			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");

			foreach( Omnibus show in ListaObjetosChofer)
			{
				Console.WriteLine(i+")"+show.getMarca()+"-"+show.getModelo()+","+show.getTipo()+","+show.getCapacidad());
				i++;
			}
			OmnibusSelecto =Convert.ToInt32(Console.ReadLine());

			i =1;

			foreach( Omnibus show in ListaObjetosChofer)

			{
				if (i == OmnibusSelecto)
				{
					omnibus = show;
					break;
				}
				i++;
			}

			return omnibus;
		}

		//Imprime la cantidad de choferes ingresados con todos sus datos
		public Chofer ImprimirListadoChoferes(List<Chofer> ListaObjetosChofer)
		{
			int ChoferSelecto;
			int i =1;

			Chofer chofer = new Chofer();
			Console.Clear();
			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");
			foreach( Chofer show in ListaObjetosChofer)
			{
				Console.WriteLine(i+")"+show.Nombre+" "+show.Apellido+"("+i+")");
				i++;
			}
			ChoferSelecto =Convert.ToInt32(Console.ReadLine());

			i =1;

			foreach( Chofer show in ListaObjetosChofer)
			{
				if (i == ChoferSelecto)
				{
					chofer = show;
					break;
				}

				i++;
			}
			return chofer;
		}


		//Imprime las Terminales de Salida
		public void ImprimirTerminalesSalida()
		{
			Console.WriteLine("Listado de terminales como partida");

			ListaTerminalesSalida = OrdenarListaTerminalesSalida(ListaTerminalesSalida);
			foreach( Terminal show in ListaTerminalesSalida)
			{
				Console.WriteLine(show.TerminalSalida+" "+ "("+show.PasajesSalida+")");

	             		}

			Console.WriteLine("Presione una tecla para continuar.");
			Console.ReadKey();

		}


		//Imprime las Terminales de Llegada
		public void ImprimirTerminalesLlegada()
		{
			Console.WriteLine("Listado de terminales como llegada");
			ListaTerminalesLlegada = OrdenarListaTerminalesLlegada(ListaTerminalesLlegada);
			foreach( Terminal show in  ListaTerminalesLlegada)
			{
				Console.WriteLine(show.TerminalLlegada+" "+ "("+show.PasajesLlegada+")");

			}

			Console.ReadKey();
			Console.WriteLine("Presione una tecla para continuar.");
			Console.ReadKey();

		}



		//Imprimo los usuarios ordenados con sus compras
		public void ConsultarUsuario(){
				Console.WriteLine("Listado de ventas por usuario\n");

				UsuarioPasajes = OrdenarListaUsuarios (UsuarioPasajes);
				foreach (Usuario show in UsuarioPasajes) {

					Console.WriteLine(show.Nombre+" "+ show.Apellido+"("+ show.Pasajes+ ")");


				}


			Console.ReadKey();
			Console.WriteLine("Presione una tecla para continuar.");
			Console.ReadKey();


			}


		//Devuevel la lista de Usuarios con los pasajes que compro
		public List<Usuario> DevolverListaUsuariosConPasajes(){
				return UsuarioPasajes;
			}


		//Controlo que no entre un usuario repetido

		public bool ControlDni(List<Usuario> ListaUsuarios, Usuario NuevoUsuario)
		{
			String encontrado = " ";

			foreach(Usuario show in ListaUsuarios)
			{

				if(show.Dni == NuevoUsuario.Dni)
				{
					encontrado = "igualusuario";
				}
			}
			if( encontrado == "igualusuario")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		//Metodo Validar Usuario
		public List<Usuario> ControlUsuario( Usuario NuevoUsuario, List<Usuario> ListaUsuarios)
		{
			if(ControlDni(ListaUsuarios,NuevoUsuario))
			{
				Console.WriteLine("Ya existe un usuario con ese DNI en el sistema");
				Console.ReadKey();
				Console.WriteLine("Presiona una tecla para continuar...");
				Console.ReadKey();
				return ListaUsuarios;
			}else{
				NuevoUsuario.NumeroDeUsuario= NuevoUsuario.Numero_usuario_estatico++;
				ListaUsuarios.Add(NuevoUsuario);
				Console.WriteLine("EL usuario fue dado de alta correctamente con el numero "+NuevoUsuario.NumeroDeUsuario);
				Console.ReadKey();
				Console.WriteLine("Presione una tecla para continuar...");
				Console.ReadKey();
				return ListaUsuarios;
			}
		}


		//Metodo que carga la compra a una lista
		public void CargarCompra(Pasaje venta){
				ListaCompras.Add(venta);



			}


		//Metodo de Comprar un pasaje
 		public void  ComprarPasaje(List<Usuario> ListaUsuarios,List<Terminal> ListaTerminales,List<Pasaje> ListaVentas)
		{
			String encontrado = String.Empty;
			String TerminalInicio;
			String TerminalLlegada;
			String UsuarioQueCompraNom = String.Empty;
			String UsuarioQueCompraApe=String.Empty;
			Console.WriteLine("Ingrese el numero de usuario");
			int NumeroUsuario = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese el dni");
			String Dni = Console.ReadLine();

			bool CoincidenciaUsuario = false;

			foreach(Usuario show in listaUsuarios)
			{
				if(show.Dni == Dni | show.NumeroDeUsuario == NumeroUsuario)
				{
					UsuarioQueCompraApe=show.Apellido;
					UsuarioQueCompraNom = show.Nombre;
					CoincidenciaUsuario = true;

				}
			}

 		if(CoincidenciaUsuario)
			{

				Console.Clear();

				Console.WriteLine	("*******************************************************************************"+
			                         "******                                 Micritos                             ****"+
			                         "*********************************************************************************");
				Console.WriteLine("Seleccione la terminal de partida\n");

				//imprime todas las terminales recibidas y se carga la seleccionada de inicio
				int p = 1;
				for(int i=0;i<=ListaTerminales.Count-1;i++)
				{
					Console.WriteLine(p+")"+ListaTerminales[i].Ciudad);
					p++;
				}

				TerminalInicio = Console.ReadLine();
				TerminalInicio = ListaTerminales[int.Parse(TerminalInicio)-1].Ciudad;

 				Console.Clear();

				Console.WriteLine	("*******************************************************************************"+
			                         "******                                 Micritos                             ****"+
			                         "*********************************************************************************");
				Console.WriteLine("Seleccione la terminal de arribo\n");
 				p = 1;

				//imprime todas las terminales recibidas y carga la terminal de llegada

				for(int i=0;i<=ListaTerminales.Count-1;i++)
				{
					Console.WriteLine(p+")"+ListaTerminales[i].Ciudad);
					p++;
				}

				TerminalLlegada = Console.ReadLine();
				TerminalLlegada = ListaTerminales[int.Parse(TerminalLlegada)-1].Ciudad;

				// si la terminal de llegada es igual que la de inicio, termina.

				if(TerminalInicio == TerminalLlegada)
				{
					Console.WriteLine("La terminal de partida y arribo es la misma");
					Console.ReadKey();
					Console.WriteLine("Presione una tecla para continuar...");
					Console.ReadKey();
				}
				else
				{

 				Console.Clear();

				Console.WriteLine	("*******************************************************************************"+
			                         "******                                 Micritos                             ****"+
			                         "*********************************************************************************");
				Console.WriteLine("Seleccione el itinerario\n");
 				//Se recorre la lista , si se encuentran las dos terminales de llegada e inicio, validacion se pone en true
 				//si no ,sigue en false
					bool terminales_encontradas = false;

					p= 1;
					//recorro las ventas.recorrido , si la terminal de inicio se encuentra en algun recorrido...
					foreach(Pasaje show in ListaVentas)
					{
						if(show.Recorrido.Contains(TerminalInicio) && show.Recorrido.Contains(TerminalLlegada))
						{
							//obtengo ese Recorrido y lo separo en Strings en el array
							String[] terminales = show.Recorrido.Split("-".ToCharArray());



							//luego imprimo la pos inicial de ese array y la final
							Console.WriteLine("{0})Saliendo de {1} y llegando a {2} ({3} paradas intermedias,{4},{5})"
							                  ,p,terminales[0],terminales[terminales.Length-2],(terminales.Length-3),show.Dia,show.Omnibus.getTipo());

							terminales_encontradas = true;
							p++;
						}
					}

					if (terminales_encontradas)
					{
						//el p lo uso para posicionarme en la seleccion
						p = 1;

						int seleccion = Convert.ToInt16(Console.ReadLine());
						Console.WriteLine("¿Cuantos pasajes desea?\n");
						int cant_pasajes_comprados  = Convert.ToInt16(Console.ReadLine());

						//vuelvo a recorrer y me posiciono en el recorrido selecto
						foreach(Pasaje show in ListaVentas)
						{
							if(show.Recorrido.Contains(TerminalInicio) && show.Recorrido.Contains(TerminalLlegada))
							{
								if (p == seleccion)
								{
									CargarUsuarioQueCompro(UsuarioQueCompraNom,UsuarioQueCompraApe, cant_pasajes_comprados);

									Terminal NuevaTerminalSalida = new Terminal();

									NuevaTerminalSalida.TerminalSalida = TerminalInicio;
									NuevaTerminalSalida.PasajesSalida = cant_pasajes_comprados;

									CargarTerminalesSalidaPasaje(NuevaTerminalSalida);

									Terminal NuevaTerminalLlegada = new Terminal();

									NuevaTerminalLlegada.TerminalLlegada = TerminalLlegada;
									NuevaTerminalLlegada.PasajesLlegada = cant_pasajes_comprados;

									CargarTerminalesLlegadaPasaje(NuevaTerminalLlegada);


									CargarCompra(show);

								}
								p++;
							}
						}

						Console.WriteLine("La venta se ha realizado con exito");
						Console.ReadKey();
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey();
					}else{
						Console.WriteLine("No existe ningun recorrido con las terminales de partida y arribo solicitadas.");
						Console.ReadKey();
						Console.WriteLine("Presione una tecla para continuar...\n");
						Console.ReadKey();
					}
				}
				}else{
				Console.WriteLine("El usuario solicitado no existe en el sistema");
				Console.ReadKey();
				Console.WriteLine("Presione una tecla para continuar...");
				Console.ReadKey();
			}







 		}//Fin del metodo comprar_pasaje


		//Carga los usuario que hicieron la compra
		public void CargarUsuarioQueCompro(String nombre, String apellido, int CantPasajesQueCompro)
		{
			//cuando cargo el usuario que compro , lo cargo en la lista que contiene los usuarios con sus pasajes
			//en la marcha chequeo si el usuario volvio a comprar, que no se genere otro user repetido

			Usuario nuevocomprador = new Usuario();

			nuevocomprador.Apellido=apellido;
			nuevocomprador.Nombre = nombre;
			nuevocomprador.Pasajes = CantPasajesQueCompro;
			PasajeTotales =  PasajeTotales + CantPasajesQueCompro;

			bool esnuevo = true;

			foreach( Usuario show in UsuarioPasajes)
			{
				if(nuevocomprador.Nombre == show.Nombre)
				{

					show.Pasajes = show.Pasajes + nuevocomprador.Pasajes;
					esnuevo = false;
				}
			}
			if( esnuevo)
			{
				UsuarioPasajes.Add(nuevocomprador);

			}
		}

		//Carga las terminales de Salida
		public void CargarTerminalesSalidaPasaje(Terminal TerminalSalida){
				bool NuevaTerminal=true;

				foreach (Terminal show in ListaTerminalesSalida) {

					if (show.TerminalSalida==TerminalSalida.TerminalSalida) {
						show.PasajesSalida=show.PasajesSalida+ TerminalSalida.PasajesSalida;

						NuevaTerminal=false;

					}
				}

				if (NuevaTerminal) {
						ListaTerminalesSalida.Add(TerminalSalida);
					}
			}

		//Carga la terminales de llegada
		public void CargarTerminalesLlegadaPasaje(Terminal NuevaterminalLlegada){

			bool NuevaTerminal = true;
			foreach( Terminal show in ListaTerminalesLlegada)
			{
				if( show.TerminalLlegada == NuevaterminalLlegada.TerminalLlegada)
				{

					show.PasajesLlegada = show.PasajesLlegada + NuevaterminalLlegada.PasajesLlegada;
					NuevaTerminal = false;
				}

			}
			if( NuevaTerminal)
			{
				ListaTerminalesLlegada.Add(NuevaterminalLlegada);

			}
		}


		//Ordena la lista de Usuarios por metodo de intercambio
		private List<Usuario> OrdenarListaUsuarios(List<Usuario> lista){
			Usuario [] array=  lista.ToArray(); //Copio los elemento del arraylist en una matriz

			int n = array.Length;               //Guardo el numero del elemento del array en un int

			for(int i=0; i<(n-1); i++){

				for(int j=i+1; j<n; j++){

					if(array[i].Pasajes < array[j].Pasajes){
						Usuario swap = array[i];
			 			array[i] = array[j];
						array[j] = swap;
			 }
				}

			      }

				List<Usuario> ListaOrdenada = new List<Usuario> (array);

				return ListaOrdenada;

		}


		//Ordena la lista terminales de Salida por metodo de intercambio
		public List<Terminal> OrdenarListaTerminalesSalida ( List<Terminal> lista){

			Terminal [] array=  lista.ToArray();

			int n = array.Length;

			for(int i=0; i<(n-1); i++){

				for(int j=i+1; j<n; j++){

					if(array[i].PasajesSalida < array[j].PasajesSalida){
						Terminal swap = array[i];
			 			array[i] = array[j];
						array[j] = swap;
			 }
				}

			      }

				List<Terminal> ListaOrdenada = new List<Terminal> (array);

				return ListaOrdenada;

		}

		//Ordena la lista terminales de llegada por metodo de intercambio
		public List<Terminal> OrdenarListaTerminalesLlegada ( List<Terminal> lista)
		{

			Terminal [] array=  lista.ToArray();

			int n = array.Length;

			for(int i=0; i<(n-1); i++){

				for(int j=i+1; j<n; j++){

					if(array[i].PasajesLlegada < array[j].PasajesLlegada){
						Terminal swap = array[i];
			 			array[i] = array[j];
						array[j] = swap;
			 }
				}

			      }

				List<Terminal> ListaOrdenada = new List<Terminal> (array);

				return ListaOrdenada;

		}



		/*============================
              GETTERS Y SETTERS
      	 ============================*/

		public  int Pasajes_Totales {
			get { return PasajeTotales; }
			set { PasajeTotales = value; }
		}




		//Interfaz de los menus

		public int InterfaceSistema()
		{
			int opcion;

			Console.Clear();

			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");

			Console.WriteLine   ("¿Que modulo desea ingresar?\n\n"+
			                     "1) Armado de recorridos\n"+
			                     "2) Gestion de choferes\n"+
			                     "3) Ventas de pasajes\n"+
			                     "4) Estadisticas\n"+
			                     "5) Salir del sistema\n");

			return opcion = Convert.ToInt16(Console.ReadLine());
		}
		public int InterfaceRecorrido()
		{
			int opcion;

			Console.Clear();

			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");


			    Console.WriteLine(
				"1) Alta de terminales\n"+
				"2) Alta de omnibus\n"+
				"3) Alta de recorridos\n"+
				"4) Listado Omnibus y Choferes\n"+
				"5) Volver\n");



			return opcion = Convert.ToInt16(Console.ReadLine());
		}
		public int InterfaceChoferes()
		{

			Console.Clear();
			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");


			    Console.WriteLine(
				"1) Alta de choferes\n"+
				"2) Asignacion de recorridos\n"+
				"3) Volver\n");

			return opcion = Convert.ToInt16(Console.ReadLine());
		}
		public int InterfaceVentaPasajes()
		{
			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");

			    Console.WriteLine(
				"1) Alta de usuarios\n"+
				"2) Compra de pasajes\n"+
				"3) Volver\n");
			return opcion = Convert.ToInt16(Console.ReadLine());

		}
		public int InterfaceEstadisticas()
		{
			Console.Clear();

			Console.WriteLine	("*******************************************************************************"+
			                    "******                                 Micritos                             ****"+
			                   "*********************************************************************************");
			    Console.WriteLine(
				"1) Consultar total de pasajes vendidos\n"+
				"2) Consultar usuarios\n"+
				"3) Consultar terminal como partida\n"+
				"4) Consultar terminal como arribo\n"+
				"5) Volver\n");

			return	opcion2 = Convert.ToInt16(Console.ReadLine());

		}


	}
}
