using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("The first exercise:");
            Console.WriteLine("Please input the source:");
            int n1 = Int32.Parse(Console.ReadLine());//n is source operand
            exercise1(n1);
            Console.WriteLine("\n");

            Console.WriteLine("The second exercise:");
            int[] n2 = new int[] { 2,3,1,123,421,43,12,65};
            exercise2(n2);

            Console.WriteLine("The third exercise:");
            int[] n3 = new int[99];
            for(int i =0;i<99;i++)
            {
                n3[i] = i + 2;
            }
            exercise3(n3);

            Console.WriteLine("The forth exercise:");
            int[][] n4 = new int[3][];
            n4[0] = new int[] { 1, 2, 3, 4 };
            n4[1] = new int[] { 5, 1, 2, 3 };
            n4[2] = new int[] { 9, 5, 1, 2 };
            Console.WriteLine(exercise4(n4));

            Console.ReadLine();
        }



        private static void exercise1(int e1)//the first exercise to find the prime factor
        {
            for (int i = 2; i < e1; i++)
            {
                if (e1 % i == 0)
                    Console.WriteLine($"{i}");

            }
        }

        private static void exercise2(int[] e2)//the second exercise to operate on the array
        {
            int max = e2[0], min = e2[0],sum = 0;
            for (int i = 0; i < e2.Length; i++)
            {
                if (e2[i] > max)
                {
                    max = e2[i];
                }
                if (e2[i] < min)
                {
                    min = e2[i];
                }
                sum += e2[i];
            }
            int avg = sum / e2.Length;
            Console.WriteLine($"The max is {max}");
            Console.WriteLine($"The min is {min}");
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {avg}\n\n");

        }

        private static void exercise3(int[]e3)//the third exercise to use Elbow Sieve
        {
           for(int i = 2;i<=100;i++)
            {
                for(int j = 0;j<e3.Length;j++)
                {
                    if (e3[j] / i != 1 && e3[j] % i == 0)
                        e3[j] = -1;
                }
            }
           foreach(int result in e3)
            {
                if (result != -1)
                    Console.WriteLine($"{result}");
            }
        }

        private static bool exercise4(int[][] e4)//the forth exercise to 
        {
            bool flag = true;
            for (int i = 0; i < e4.GetLength(1); i++)
            {
                int k = i;
                for (int j = 0; j < e4.GetLength(0); j++)
                {
                    
                    if (j + 1 < e4.GetLength(0) && k + 1 < e4.GetLength(1))
                    {
                        if (e4[j][k] != e4[j + 1][k + 1])
                            flag = false;
                    }
                    k++;
                }
            }
            for(int i = 0;i<e4.GetLength(0); i++)
            {
                int k = i;
                for(int j = 0;i< e4.GetLength(1); j++)
                {
                   
                    if (k + 1 < e4.GetLength(0) && j + 1 < e4.GetLength(1))
                    {
                        if (e4[k][j] != e4[k + 1][j + 1])
                            flag = false;
                    }
                    k++;
                }
            }
            return flag;
        }

    }
}
