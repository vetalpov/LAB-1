using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 4, 2, 7, 1, 8, 3, 6, 5 };

        var oddNumbers = numbers
            .Where(n => n % 2 == 1) 
            .Select(n => n.ToString())
            .OrderBy(n => n); 

        Console.WriteLine(string.Join(", ", oddNumbers)); 
    }
}
