using System.Security.Cryptography.X509Certificates;

namespace DoubleNumbers1
{
    class Program
    {
        public static int[] DoubleNumbers1(List<int> numbers)
    
        {
            int[] doubles = new int[numbers.Count];
            
            for (int i = 0; i < numbers.Count; i++)
            {
                doubles[i] = numbers[i] * 2;
            }
            return doubles;
        }
        public static void Main(string[] args)
        {
           List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int[] doubles = DoubleNumbers1(numbers);

            foreach (int num in doubles) 
            {
                Console.WriteLine(num);
            }
        }
    }
}