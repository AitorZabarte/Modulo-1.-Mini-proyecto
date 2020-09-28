using System;
//OPCION A  
namespace Modulo_1._Mini_proyecto
{
    class Program
    {
        static string duracion(int dias)
        {
            string dura;
            if (dias % 7 == 0)
            {
                dura=(dias / 7 + " semanas");
            }
            else if (dias < 7)
            {
                dura=(dias + " dias");
            }
            else
            {
                dura=(dias / 7 + " semanas " + (dias - ((dias/7 )* 7)) + " dias");
            }

            return dura;
        }
        static void Main(string[] args)
        {
            string nombre, carnet_respuesta,ciudad=""; 
            int edad,dias=0,alquiler=0;
            bool carnet=false,respuesta_valida=false,ciudad_valida=false;
            
            Console.WriteLine("Introduzca su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca su edad");
            int.TryParse(Console.ReadLine(),out edad);
            if (edad >= 18)
            {
                do
                {
                    Console.WriteLine("Tiene carnet de conducir? Escribe'S' o 's' si tienes y 'N' o 'n' si no lo tienes");
                    carnet_respuesta = Console.ReadLine();
                    if (carnet_respuesta == "S" || carnet_respuesta == "s")
                    {
                        carnet = true;
                        respuesta_valida = true;
                    }
                    else if (carnet_respuesta == "N" || carnet_respuesta == "n")
                    {
                        carnet = false;
                        respuesta_valida = true;
                    }
                    else
                    {
                        Console.WriteLine("Respuesta no valida");
                        respuesta_valida = false;
                    }
                } while (respuesta_valida == false);
            }
            else
            {
                carnet = false;
            }
            if (carnet==false)
            {
                Console.WriteLine("Cliente " + nombre + " de " + edad + " años " + "sin carnet de conducir");

            }
            else
            {
                Console.WriteLine("Cliente " + nombre + " de " + edad + " años " + "con carnet de conducir");

            }

            if (carnet == true)
            {
                do {
                    Console.WriteLine("De donde quiere recoger el coche? Las opciones son 1.Bilbao,2.Madrid,3.Barcelona o 4.Santander");
                    ciudad = Console.ReadLine();
                    switch (ciudad)
                    {
                        case "Bilbao":
                            ciudad = "Bilbao";
                            ciudad_valida = true;
                            break;
                        case "Madrid":
                            ciudad = "Madrid";
                            ciudad_valida = true;
                            break;
                        case "Barcelona":
                            ciudad = "Barcelona";
                            ciudad_valida = true;
                            break;
                        case "Santander":
                            ciudad = "Santander";
                            ciudad_valida = true;
                            break;
                        case "1":
                            goto case "Bilbao";
                        case "2":
                            goto case "Madrid";
                        case "3":
                            goto case "Barcelona";
                        case "4":
                            goto case "Santander";
                        default:
                            Console.WriteLine("Ha introducido una ciudad en la que ni prestamos servicio");
                            ciudad_valida = false;
                            break;
                    }
                } while (ciudad_valida!=true);
                Console.WriteLine("Has elegido " + ciudad);
                Console.WriteLine("Durante cuantos dias quiere alquilar el coche?");
                int.TryParse(Console.ReadLine(), out dias);
                Console.WriteLine(duracion(dias));
                if (dias < 6)
                {
                    alquiler = dias * 10;
                }
                else
                {
                    alquiler = dias * 10 - (dias / 7)*10;
                }
                Console.WriteLine("El precio total del alquiler es "+alquiler);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nombre: "+nombre);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Tiene carnet");
                Console.WriteLine("Punto de recogida: "+ciudad);
                Console.WriteLine("Duracion del alquiler: " +duracion(dias) );
                Console.WriteLine("El precio del alquiler: "+alquiler);
            }
        }
    }
}
