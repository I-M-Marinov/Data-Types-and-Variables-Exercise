using System;

namespace P8.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfKegs = sbyte.Parse(Console.ReadLine());
            double biggestVolume = double.MinValue;
            string biggestKeg = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                double heightofKeg = double.Parse(Console.ReadLine());
                double volumeOfAKeg = Math.PI * radiusOfKeg * radiusOfKeg * heightofKeg;

                if (volumeOfAKeg > biggestVolume)
                {
                    biggestVolume = volumeOfAKeg;
                    biggestKeg = modelOfKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
