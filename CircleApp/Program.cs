using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle=new Circle();
            aCircle._radius = 100;

            
            Console.WriteLine("Diameter is :" + aCircle.Diameter());
            Console.WriteLine("Perimeter is :" + aCircle.Perimeter());
            Console.WriteLine("Area is :" + aCircle.Area());

            Console.ReadKey();

        }
    }
}
