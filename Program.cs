using System;
using System.Collections.Generic;

namespace Collection3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число и я его запомню\nвведите sum - сложение введеных чисел\nвведите exit - закрытие программы\n");

            bool isContinueCycle = true;

            List<int> listOfNumbers = new List<int>();

            while (isContinueCycle)
            {
                string inputString = Console.ReadLine();

                switch (inputString)
                {
                    case "sum":

                        int sum = 0;

                        foreach (int number in listOfNumbers)
                        {
                            sum += number;
                        }

                        Console.WriteLine("Сумма набранных чисел = " + sum);

                        listOfNumbers.Clear();

                        break;
                    case "exit":

                        isContinueCycle = false;

                        break;
                    default:

                        if(inputString!="")
                        {
                            listOfNumbers.Add(Convert.ToInt32(inputString));
                        }

                        break;
                }
            }
        }
    }
}
