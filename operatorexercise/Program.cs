using System;

namespace operatorexercise
{
    class Program
    {
        static void Main(string[] args)

        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            


            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

                        
            var radius = double.Parse(Console.ReadLine());
            var answer = AreaOfCircle(radius);

            var userInput = Console.ReadLine();
                        
            var area = AreaOfCircle(radius);

            Console.WriteLine($"{area} is this the circle with a radius of (radius)")
                        
        }

        private static object AreaOfCircle(double radius)
        {
           return (Math.PI)*(radius * radius);
        }

    
    }
}
