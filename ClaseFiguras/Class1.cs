using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseFiguras
{
    class Figura
    {
       public void Cuadrado()
        {
            double lad = 0;
            Console.WriteLine("Introduce un lado del cuadrado");
            lad = double.Parse(Console.ReadLine());
            Console.WriteLine("Area del cuadrado = "+(lad*lad));
        }

        public void Triangulo()
        {
            double bas = 0, altura = 0;

            Console.WriteLine("Introduce la base");
            bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Area del Triangulo = " + (bas*altura)/2);
        }

        public void Circulo()
        {
            double rad = 0;

            Console.WriteLine("Introduce radio");
            rad = double.Parse(Console.ReadLine());
            Console.WriteLine("Area del Circulo = " + (13.1416*(rad*rad)));
        }
    }
}
