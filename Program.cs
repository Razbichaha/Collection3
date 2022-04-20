using System;
using System.Collections.Generic;

namespace Collection3
{
//    В массивах вы выполняли задание "Динамический массив"
//Используя всё изученное, напишите улучшенную версию динамического массива(не обязательно брать своё старое решение)
//Задание нужно, чтобы вы освоились с List и прощупали его преимущество.
//Проверка на ввод числа обязательна.

//Пользователь вводит числа, и программа их запоминает.
//Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.

//Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число и я его запомню\nвведите sum - сложение введеных чисел\nвведите exit - закрытие программы\n");

            bool continueCycle = true;
            List<int> temp = new List<int>();

            while (continueCycle)
            {
                string inputString = Console.ReadLine();

                switch (inputString)
                {
                    case "sum":

                        int sum = 0;

                        foreach (int number in temp)
                        {
                            sum += number;
                        }

                        Console.WriteLine("Сумма набранных чисел = " + sum);

                        temp.Clear();

                        break;
                    case "exit":

                        continueCycle = false;

                        break;
                    default:

                        if(inputString!="")
                        {
                            temp.Add(Convert.ToInt32(inputString));
                        }

                        break;
                }
            }
        }
    }
}
