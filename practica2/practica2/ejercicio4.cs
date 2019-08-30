using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class ejercicio4
    {
        public void ejercicio_4()
        {
            
            Console.WriteLine("Fecha de inicio | formato de fecha: dd/MM/yy");
            Console.Write(":");
            DateTime fechainicio = Convert.ToDateTime(Console.ReadLine() );
            Console.WriteLine("Fecha de entrega | formato de fecha: dd/MM/yy");
            Console.Write(":");
            DateTime fechaentrega = Convert.ToDateTime(Console.ReadLine());
            TimeSpan pago = (fechaentrega - fechainicio);
            Console.WriteLine("Costo por dia");
            Console.Write(":");
            decimal costo = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Dias transcurridos:" + pago.ToString("dd"));
            decimal totalpago = costo * pago.Days;
            Console.WriteLine("Total a pagar: "+totalpago.ToString("C2"));
            Console.ReadKey();

        }
    }
}
