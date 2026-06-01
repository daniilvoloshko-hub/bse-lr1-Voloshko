using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testNumbers = { 10, 20, 30, 40 };
            double average = AiAssistant.CalculateAverage(testNumbers);

            Console.WriteLine("AI-згенерована funkcija praciuje!");
            Console.WriteLine($"Serednie aryfmetychne masyvu: {average}");
            Console.ReadKey();
        }
    }
}