using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class ejercicio1
    {
        public void ejercicio_1()
        {
            string nombre;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine(nombre.Replace("a", "#").Replace("e", "%").Replace("i", "$").Replace("o", "?").Replace("u", ""));

            Console.ReadKey();
        }
    }
}
