using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class ejercicio6
    {
        public void ejercicio_6()
        {
            DateTime fecha = DateTime.Now;
           
            Console.WriteLine("Hoy es {0} {1} de {2} del  {3}", fecha.ToString("dddd"),fecha.Day, fecha.ToString("MMMM"), fecha.Year);
        }
    }
}
