using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ""; 
            int n1 = 0;
            int n2 = 0;
            Console.Write("Please input an operator:");
            s = Console.ReadLine();
            Console.Write("Please input the first operand:");
            n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Please input the second operand:");
            n2 = Int32.Parse(Console.ReadLine());
            if (s =="+")
                Console.Write($"result:{n1 + n2}");
            else if(s =="-")
                Console.Write($"result:{n1 - n2}");
            else if(s=="*")
                Console.Write($"result:{n1 * n2}");
            else if(s=="/")
                Console.Write($"result:{n1 / n2}");
            
        }
    }
}
