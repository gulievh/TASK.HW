using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers1 = { 4, 5, 2, 6, 4, 3 };
        int[] numbers2 = { 7, 4, 2, 76, 45, 65 };

        var uniqueNumbers = numbers1.Except(numbers2);

        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
