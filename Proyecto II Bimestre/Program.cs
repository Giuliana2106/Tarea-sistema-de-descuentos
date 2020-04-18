using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_II_Bimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            double monto;
            double x;
            double descuento;
            double total;
            string linea;

            Console.WriteLine("Ingrese el total a pagar: ");
            linea = Console.ReadLine();
            monto = double.Parse(linea);

            if (monto > 1500) ;
            {
                if (monto > 2000) ;
                {
                    if (monto > 3000) ;
                    {
                        x = 0.25;
                        descuento = monto * x;
                        total = monto - descuento;
                        Console.WriteLine("El total a pagar es: +total");

                    }

                 else
                    {
                        x = 0.10;
                        descuento = monto * x;
                        total = monto - descuento;
                        Console.WriteLine("El total a pagar es: +total");
                    }
                }

                else
                {
                    x = 0.10;
                    descuento = monto * x;
                    total = monto - descuento;
                    Console.WriteLine("El total a pagar es: +total");
                }
                else
                {
                    Console.WriteLine("El total a pagar es: +monto");

                }
                Console.ReadKey();
            }

        
    }
}
