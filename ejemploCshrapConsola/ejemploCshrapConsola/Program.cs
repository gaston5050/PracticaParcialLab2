using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploCshrapConsola
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Estudiante estudiante = new Estudiante();

            estudiante.Nombre = "jose";
            Console.WriteLine(estudiante.Nombre);
            estudiante.Nombre = Console.ReadLine(); 
            Console.WriteLine(estudiante.Nombre);
            Console.ReadKey();


        }
    }
}
