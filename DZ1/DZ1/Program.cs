using System;

namespace Dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number in radians : ");
            float beforeNumber = float.Parse(Console.ReadLine());
            while ((beforeNumber <= 0) || (beforeNumber >= 2))
            {
                Console.WriteLine("Please enter number in the range 0 <a <2 : ");
                beforeNumber = float.Parse(Console.ReadLine());
            }
            float afterNumber = beforeNumber * 180;
            Console.Write($"Number in degrees : {afterNumber}");
        }
    }
}
