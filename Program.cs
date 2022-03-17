using System;

namespace Taskİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task2
            int n = 5;
            int m = 150;

            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 15 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count); ;
        

            //Task1
            //    int[] array = { 4, 12, 111, 123, 45, 66, 74, 41 };
            //int count = 0;
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    while (array[i] > 0)
            //    {
            //        sum += array[i] % 10;
            //        array[i] /= 10;

            //    }

            //    if (sum < 10)
            //    {
            //        count++;
            //    }
            //    sum = 0;
            //}
            //Console.WriteLine(count);
        }

    }


}
