using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_activity_week03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int  sum = 0;
            while(i <= 9)
            {
            
                sum += i;
                i++;
            }
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadLine();

            

        }
    }
}
