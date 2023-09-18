using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Información;



namespace Cinemark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string i, m, Option3;
            int Option1, Option2, Option4, Option5, Contador, Asientos;

            Console.WriteLine("Bienvenido al programa de reservas e información de cinemark");
            Console.WriteLine("A continuación se le mostrará los horarios de las peliculas en el momento");
            Console.WriteLine("SELECCIONE: ");
            Console.WriteLine("A. La monja II");
            Console.WriteLine("B. Caceria en Venecia");
            Console.WriteLine("C. Gran Turismo");

            i = Console.ReadLine();
            m = Información.Class1.Información(i);
            Console.WriteLine(m);

            Console.WriteLine("¿Desea revisar el horario de otra pelicula?");
            Console.WriteLine("Digite 1 para si O 2 para no");

            Option1 = Convert.ToInt32(Console.ReadLine());


            if (Option1 == 1)
            {
                Console.WriteLine("Bienvenido al programa de reservas e información de cinemark");
                Console.WriteLine("A continuación se le mostrará los horarios de las peliculas en el momento");
                Console.WriteLine("SELECCIONE: ");
                Console.WriteLine("A. La monja II");
                Console.WriteLine("B. Caceria en Venecia");
                Console.WriteLine("C. Gran Turismo");

                i = Console.ReadLine();
                m = Información.Class1.Información(i);
                Console.WriteLine(m);
                
            }

            else if (Option1 == 2)
            {
                Console.WriteLine("Has elegido no continuar viendo más horarios");
            }

            Console.WriteLine("Luego de ver los horarios, ¿Desería realizar una reserva?");
            Console.WriteLine("Digite 1 para si o 2 para no");

            Option2 = Convert.ToInt32(Console.ReadLine());

            if (Option2 == 1)
            {
                Console.WriteLine("Si quiere realizar una reserva para La monja II digite la opción A");
                Console.WriteLine("Si quiere realizar una reserva para Caceria en Venecia digite la opción B");
                Console.WriteLine("Si quiere realizar una reserva para Gran Turismo digite la opción C");
                Option3 = Console.ReadLine();

                if (Option3 == "A")
                {
                    Console.WriteLine("Ha seleccionado la Monja II");
                    Console.WriteLine("Un sacerdote es asesinado. Un mal se está extendiendo. La hermana Irene una vez más");
                    Console.WriteLine("se encuentra cara a cara con Valak, la monja demonio. Secuela de La monja");
                    Console.WriteLine("Seleccione un horario:");
                    Console.WriteLine("1 para las 2:30PM");
                    Console.WriteLine("2 para las 5:30PM");
                    Console.WriteLine("3 para las 8:30PM");

                    Option4 = Convert.ToInt32(Console.ReadLine());

                    switch (Option4)
                    {
                        case 1:



                            Contador = 25;
                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("La monja II para las 2:30 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("La monja II para las 2:30 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }



                            break;

                        case 2:
                            Contador = 25;
                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("La monja II para las 5:30 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("La monja II para las 5:30 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }

                            break;

                        case 3:
                            Contador = 25;
                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("La monja II para las 8:30 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("La monja II para las 8:30 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }

                            break;

                    }
                }

                else if (Option3 == "B")
                {
                    Console.WriteLine("Ha seleccionado Caceria en Venecia");
                    Console.WriteLine("En la Venecia posterior a la Segunda Guerra Mundial, Poirot, ahora retirado y viviendo en su propio exilio, asiste a regañadientes a una sesión de espiritismo");
                    Console.WriteLine("Cuando uno de los invitados es asesinado, depende del ex detective descubrir una vez más al asesino.");
                    Console.WriteLine("Seleccione un horario:");
                    Console.WriteLine("1 para las 1:55PM");
                    Console.WriteLine("2 para las 4:30PM");
                    Console.WriteLine("3 para las 9:30PM");

                    Option4 = Convert.ToInt32(Console.ReadLine());

                    switch (Option4)
                    {
                        case 1:



                            Contador = 25;
                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("Caceria en Venecia para las 1:55 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("Caceria en Venecia para las 1:55 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }



                            break;

                        case 2:
                            Contador = 25;

                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("Caceria en Venecia para las 4:30 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("Caceria en Venecia para las 4:30 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }

                            break;

                        case 3:
                            Contador = 25;
                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("Caceria en Venecia para las 9:30 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("Caceria en Venecia para las 9:30 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }

                            break;

                    }
                }

                else if (Option3 == "C")
                {
                    Console.WriteLine("Ha seleccionado Gran Turismo");
                    Console.WriteLine("Basada en la historia real de Jann Mardenborough, la película es la historia definitiva de deseos cumplidos de un jugador adolescente de “Gran Turismo”");
                    Console.WriteLine("cuyas habilidades de gaming le llevaron a ganar una serie de competencias de Nissan");
                    Console.WriteLine("Seleccione un horario:");
                    Console.WriteLine("1 para las 1:30PM");
                    Console.WriteLine("2 para las 6:30PM");
                    Console.WriteLine("3 para las 7:30PM");

                    Option4 = Convert.ToInt32(Console.ReadLine());

                    switch (Option4)
                    {
                        case 1:



                            Contador = 25;
                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("Gran Turismo para las 1:30 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("Gran Turismo para las 1:30 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }



                            break;

                        case 2:
                            Contador = 25;

                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("Gran Turismo para las 6:30 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("Gran Turismo para las 6:30 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }

                            break;

                        case 3:
                            Contador = 25;
                            while (Contador < 26)
                            {
                                Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite el numero de asientos que desea reservar");
                                Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                Asientos = Convert.ToInt32(Console.ReadLine());
                                Contador = Contador - Asientos;

                                Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                Console.WriteLine("Gran Turismo para las 7:30 PM fue realizada");

                                Console.WriteLine("¿Desea realizar otra reservación para esta función, quedan " + Contador + " asientos disponibles");
                                Console.WriteLine("Digite 1 para si, o digite 2 para salir del programa y acabar su reservación");

                                Option5 = Convert.ToInt32(Console.ReadLine());
                                if (Option5 == 1)
                                {
                                    Console.WriteLine("En el momento contamos con " + Contador + " asientos disponibles");
                                    Console.WriteLine("Digite el numero de asientos que desea reservar");
                                    Console.WriteLine("Si dijitas un numero de asientos mayor al disponible, el programa no te dejará continuar y se cerrará");

                                    Asientos = Convert.ToInt32(Console.ReadLine());
                                    Contador = Contador - Asientos;

                                    Console.WriteLine("Su reserva de " + Asientos + " Para la función de: ");
                                    Console.WriteLine("Gran Turismo para las 7:30 PM fue realizada");

                                    Console.WriteLine("Quedaron " + Contador + " asientos disponibles en esta función");
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");
                                }
                                else if (Option5 == 2)
                                {
                                    Console.WriteLine("Gracias por utilizar el servicio de Cinemark");

                                }
                                break;

                            }

                            break;

                    }
                }
            }
            

            Console.ReadKey();
        }
    }
}
