using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool unlimitedLoop = true;

            string userInput;
            string exit = "exit";
            string sun = "sum";
            int addingNumber;
            int sumNumbers;
            List<int> numbers = new List<int>();

            while (unlimitedLoop)
            {
                Console.WriteLine($"Ввседите значение для массива. Чтобы посчитать сумму всех введеных данных введите: {sun}; Что бы выйти из программы введите: {exit}.");
                userInput = Console.ReadLine();
                sumNumbers = 0;

                if (userInput == exit)
                {
                    unlimitedLoop = false;
                }
                else if (userInput == sun)
                {
                    sumNumbers += numbers.ToArray().Sum();
                    Console.WriteLine($"Сумма всех введеных чисел = {sumNumbers}");
                }
                else
                {
                    bool result = int.TryParse(userInput, out addingNumber);

                    if (result == true)
                    {
                       numbers.Add(addingNumber);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число.");
                    }
                }
            }
        }
    }
}