using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = CreateRandomList(10);
        Console.WriteLine("Список чисел:");
        PrintList(numbers);

        try
        {
            Console.Write("Введiть елекмент k, який потрiбно видалити: ");
            int k = int.Parse(Console.ReadLine());

            RemoveElement(numbers, k);
            Console.WriteLine("Список чисел без k:");
            PrintList(numbers);
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка: " + e.Message);
        }

        Console.ReadKey();
    }

    static List<int> CreateRandomList(int length)
    {
        List<int> numbers = new List<int>();
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            numbers.Add(random.Next(100));
        }
        return numbers;
    }

    static void PrintList(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }

    static void RemoveElement(List<int> numbers, int k)
    {
        if (k < 0 || k >= numbers.Count)
        {
            throw new ArgumentException("Не коректні дані");
        }
        for (int i = k; i < numbers.Count - 1; i++)
        {
            numbers[i] = numbers[i + 1];
        }
        numbers.RemoveAt(numbers.Count - 1);
    }
}
