using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practica2
{
    class ejercicio5
    {
        public void ejercicio_5()
        {
          

            string telefono = String.Format("{0:(###) ####-####}", 5037271 - 0000);
            Console.WriteLine("Ingrese número de telefono");
            telefono = Console.ReadLine();
            Console.WriteLine("Ingrese la hora de inicio de llamada");
            DateTime hora = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese hora final de llamada");
            DateTime horaf = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el costo por minuto de llamada");
            decimal costo = Convert.ToDecimal(Console.ReadLine());
            TimeSpan totaltiempo = (horaf - hora);
             decimal totalpago = totaltiempo.Minutes*costo;
            Console.WriteLine();
            Console.WriteLine("Numero de telefono:"+telefono);
            Console.WriteLine();
            Console.WriteLine("Total de minutso:"+totaltiempo.TotalMinutes);
            Console.WriteLine();
            Console.WriteLine("Costo por la llamada:"+totalpago.ToString("C2"));
        }
    }
}
