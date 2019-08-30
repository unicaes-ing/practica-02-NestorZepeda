using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class ejercicio2
    {
        public void ejercicio_2()
        { 
            string producto;
            int cantidad;
            decimal precio,subtotal,totalapagar,iva;
            
            Console.Write("ingrese nombre de producto: ");
            producto = Console.ReadLine();
            Console.WriteLine();
            Console.Write("cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("precio: ");
            precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            subtotal = cantidad * precio;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("................................................");
            Console.WriteLine("   su subtotal es de: " +subtotal.ToString("C2"));
            iva = subtotal * 0.13m;
            Console.WriteLine("................................................");
            Console.WriteLine("   IVA: "+iva.ToString("C2"));
            Console.WriteLine("................................................");
            totalapagar = subtotal + iva;
            Console.WriteLine("   Su total a pagar es de: " +totalapagar.ToString("C2"));
            Console.ReadKey();
        }
    }
}
