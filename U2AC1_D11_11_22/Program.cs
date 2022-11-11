using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2AC1_D11_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreAlumno, curso;
            byte unidadUno, unidadDos, unidadTres, unidadCuatro, unidadCinco;
            int calificacionesAlumno;

            Console.WriteLine("Teclea tu nombre completo y despues presiona Enter:");
            nombreAlumno = Console.ReadLine();
            

            Console.WriteLine("Teclea el nombre de tu curso y despues presiona Enter:");
            curso = Console.ReadLine();

            Console.WriteLine("Teclea la calificacion de la unidad 1 y despues presiona Enter:");
            unidadUno = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Teclea la calificacion de la unidad 2 y despues presiona Enter:");
            unidadDos = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Teclea la calificacion de la unidad 3 y despues presiona Enter:");
            unidadTres = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Teclea la calificacion de la unidad 4 y despues presiona Enter:");
            unidadCuatro = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Teclea la calificacion de la unidad 5 y despues presiona Enter:");
            unidadCinco = Convert.ToByte(Console.ReadLine());

            calificacionesAlumno = (unidadUno + unidadDos + unidadTres +unidadCuatro + unidadCinco)/5;

            if (calificacionesAlumno >=70) {

                Console.WriteLine("Excelente acabas de acreditar el curso");

                Console.WriteLine(" \n Tu nombre es {0} \n El nombre de tu curso es {0}" ,nombreAlumno, curso);



            }

           else
            {
                Console.WriteLine("Lo siento, tendras que repetir el curso");

            }


            Console.ReadKey();
        }
    }
}
