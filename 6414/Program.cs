using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programadocsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar
            Console.WriteLine("Bienvenido a C#");
            //Definir Variables
            int a, b, suma;

            //Entradadde datos
            //Solicitando datos
            Console.WriteLine("Ingrese el primer numero");
            //Guardar Datos
            a = Convert.ToInt32(Console.ReadLine());
            //Solicitando datos
            Console.WriteLine("Ingrese el primer numero");
            //Guardar Datos
            b = Convert.ToInt32(Console.ReadLine());

            //Proceso
            suma = a + b;

            //Salida de Datos
            Console.WriteLine("lA SUMA ES: " + suma);
            Console.WriteLine($"La suma de {a} + {b} = {suma}");
            //Pausar para mostrar resultados
            Console.ReadKey();


            //Pausar para Mostrar Resultados
            Console.ReadKey();
        }
    }
}
