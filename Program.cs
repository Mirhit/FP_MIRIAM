using System;
using System.Threading;

namespace FPU3D_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar dos variables

            string nombreUsuario;
            byte edadUsuario;
            string primerApellido, segundoApellido, direccion, celular, perfil, usuarioAcceso, contrasena, confirmContrasena, codigoAcceso;


            //Que el suario ingrese por teclado los valores de las variabes

            Console.WriteLine("Ingresa tu nombre, despúes presiona ENTER");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad, despúes presiona ENTER:");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            //if
            if (edadUsuario > 18)
            {//Generar codigo de acceso

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.WriteLine("Tu código de acceso es: 345678");

                Console.WriteLine("Ingresa tu primer apellido, despues preciona ENTER:");
                primerApellido = Console.ReadLine();

                Console.WriteLine("Ingresa tu segundo apellido, despues preciona ENTER:");
                segundoApellido = Console.ReadLine();


                Console.WriteLine("Ingresa tu direccion, despues preciona ENTER:");
                direccion = Console.ReadLine();

                Console.WriteLine("Ingresa tu numero celular, despues preciona ENTER:");
                celular = Console.ReadLine();

                Console.WriteLine("Ingresa tu perfil de Facebook, despues preciona ENTER:");
                perfil = Console.ReadLine();

                Console.WriteLine("Ingresa tu nombre de usuario, despues preciona ENTER:");
                usuarioAcceso = Console.ReadLine();

                Console.WriteLine("Ingresa tu contraseña, despues preciona ENTER:");
                contrasena = Console.ReadLine();

                Console.WriteLine("Confirma tu contraseña, despues preciona ENTER:");
                confirmContrasena = Console.ReadLine();



                if (contrasena == confirmContrasena)
                {
                    //Numero Aleatorio
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Random aleatorio = new Random();
                    aleatorio.Next(1000, 9999);
                    codigoAcceso = aleatorio.ToString();

                    Console.WriteLine("Tu nuevo numero de acceso es el siguiente: {0}", codigoAcceso);

                    Console.WriteLine("\n Tu nombre es: {0}  \n Tu edad es: {1} \n Tu primer apellido es: {2} \n Tu segundo apellido es:{3}" +
                       "\n Tu direccion es: {4} \n Tu numero celular es: {5} \n Tu perfil de Facebook es Usuario: {6} \n Tu nombre de usuario es:{7}" +
                       " \n Tu contraseña es: {8} \n Tu confirmacion de contraseña es: {9}", nombreUsuario, edadUsuario, primerApellido, segundoApellido, direccion, celular, perfil, usuarioAcceso,
                       contrasena, confirmContrasena);




                    Console.ReadKey();

                }



            }

            else
            {
                Console.WriteLine("No podemos validar tu acceso, debes ser mayor de edad");


                Console.WriteLine("Saliendo del sistema.");
                Thread.Sleep(800);
                Console.WriteLine("Saliendo del sistema..");
                Thread.Sleep(800);
                Console.WriteLine("Saliendo del sistema...");
                Thread.Sleep(800);
                Console.WriteLine("Saliendo del sistema....");
                Thread.Sleep(800);

                // + Hugo, Gael, Eleazar, Nacho, Saul, Karina
                // - Jonathan Carlos Torres, Jorge  Collazo, Miriam, 

                Console.ReadKey();

            }

        }
    }
}
