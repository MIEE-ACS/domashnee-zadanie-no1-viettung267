using System;

namespace Dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("Enter number in radians : ");
            double beforeNumber = double.Parse(Console.ReadLine());
            while ((beforeNumber <= 0) || (beforeNumber >= 2*pi))
            {
                Console.WriteLine("Please enter number in the range 0 <a <2*pi : ");
                beforeNumber = double.Parse(Console.ReadLine());
            }
            double afterNumber =(beforeNumber * 180 / pi);
            Console.Write($"Number in degrees : {Math.Round(afterNumber,3)}");
        }
    }
}
