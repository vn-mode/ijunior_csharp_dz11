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
            int minNumber = 3;
            int maxNumber = 101;
            int sumOfNumbersDivisibleByStepNumber1 = 0;
            int sumOfNumbersDivisibleByStepNumber2 = 0;
            int finalSum;

            Random random = new Random();
            number = random.Next(minNumber, maxNumber);

            for (int i = stepNumber1; i <= number; i += stepNumber1)
            {
                if ((i % stepNumber2) != 0)
                {
                    sumOfNumbersDivisibleByStepNumber1 += i;
                }
            }
            for (int i = stepNumber2; i <= number; i += stepNumber2)
            {
                sumOfNumbersDivisibleByStepNumber2 += i;
            }

            finalSum = sumOfNumbersDivisibleByStepNumber1 + sumOfNumbersDivisibleByStepNumber2;
            Console.WriteLine($"Рандомное чисно = {number}.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Cумма всех положительных чисел меньше {number} (включая число), которые кратные {stepNumber1} или {stepNumber2} = {finalSum}.");

        }
    }
}
