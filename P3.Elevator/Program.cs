using System;

namespace P3.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peopleToTransport = int.Parse(Console.ReadLine());
            float capacityOfElevator = int.Parse(Console.ReadLine());
            float courses = peopleToTransport / capacityOfElevator;

            Console.WriteLine($"{Math.Ceiling(courses)}");

        }
    }
}
