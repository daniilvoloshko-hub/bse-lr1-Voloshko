using System;

namespace ConsoleApp2
{
    public class AiAssistant
    {
        // Метод, який приймає масив чисел і повертає їхнє середнє арифметичне значення
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
    }
}