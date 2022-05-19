using System;

namespace vn_mode_csharp_dz11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int stepNumber1 = 3;
            int stepNumber2 = 5;
            int sumOfNumbersDivisibleByThree = 0;
            int sumOfNumbersDivisibleByFive = 0;
            int finalSum;

            Random rand = new Random();
            number = rand.Next(3, 101);

            for (int i = stepNumber1; i <= number; i += stepNumber1)
            {
                sumOfNumbersDivisibleByThree += i;
            }
            for (int i = stepNumber2; i <= number; i += stepNumber2)
            {
                sumOfNumbersDivisibleByFive += i;
            }

            finalSum = sumOfNumbersDivisibleByThree + sumOfNumbersDivisibleByFive;
            Console.WriteLine($"Рандомное чисно = {number}.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Cумма всех положительных чисел меньше {number} (включая число), которые кратные 3 или 5 = {finalSum}.");

        }
    }
}
