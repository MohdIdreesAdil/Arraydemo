using System;

namespace Arraydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows for star pattern");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine();
            }

        }
    }
}
