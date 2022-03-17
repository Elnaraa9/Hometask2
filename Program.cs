using System;

namespace Hometask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaxElement(12, 13, 54, 32); 
            Console.WriteLine(Binary(9));
        }
        //static void MaxElement(params int [] array)
       // {
           // int max;
            //max = array[0];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (max<array[i])
            //    {
            //        max = array[i];
            //    }
            //}
            //Console.WriteLine(max);
         //}
        static int Binary(int num)
        {
            int count = 0;
            for (int i=0; num> 0; i++)
            {
                if (num%2==1)
                {
                    count++;
                }
                num = num / 2;
            }
            return count;
        }
        
    }
}
