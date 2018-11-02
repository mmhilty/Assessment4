using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };

            int GetSum(int[] array)
            {
                int sum = 0;
                foreach (int item in array)
                {
                    sum = sum + item;
                }
                return sum;
            }

            int result = GetSum(array1);
            Console.WriteLine(result);


        }

        
    }
}
