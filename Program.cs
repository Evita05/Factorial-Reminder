using System;

namespace FactorialReminder
{
    class Program
    {
        private static int count = 0;
        static void Main(string[] args)
        {
            
            string n = Console.ReadLine();
            int num = Convert.ToInt32(n);
            
            for(int i= 1; i<=num; i++)
            {
                CalculateFactReminder(i);
            }
            Console.WriteLine("The count is :: " + count);
            Console.ReadLine();
           
        }

        private static void CalculateFactReminder(int i)
        {
            int number = i - 1;
            int fact = FactorialReminder(number);
            if(fact % i == number)
            {
                count = count + 1;
            }
            
        }

        private static int FactorialReminder(int num)
        {
            
            int fact = 1;
            for (int x = 1; x <= num; x++)
            {
                fact *= x;
            }
            return fact;
        }
    }


}
