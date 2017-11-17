using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double k = 1;
            Figura f = new Figura();
            while (k != 0)
            {
                Console.WriteLine("¿Que area de figura deceas realizar?");
                Console.WriteLine("1) Cuadrado \n 2) Triangulo \n 3) Circulo \n 0) Salir");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    f.Cuadrado();
                }
                if (n == 2)
                {
                    f.Triangulo();
                }
                if (n == 3)
                {
                    f.Circulo();
                }
                if(n == 0)
                {
                    k = n;
                }



            }
            
            Console.ReadKey();
        }
    }
}
