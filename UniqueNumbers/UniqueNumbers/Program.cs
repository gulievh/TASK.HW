namespace UniqueNumbers
{
    class program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 4, 5, 2, 6, 4, 3 };
            int[] numbers2 = { 7, 4, 2, 76, 45, 65 };

            Console.WriteLine("output:");
            foreach (int number1 in numbers1)
            {
                bool found = false;
                foreach (int number2 in numbers2)
                {
                    if (number1 == number2)
                    {
                        found = true;
                        break;
                    }
                } if (!found)
                {
                    Console.WriteLine(number1);
                }
            } 
        }
    }

}