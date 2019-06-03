using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] months = new int[12];
            for (int i = 0; i < months.Length; i++)
            {
                months[i] = ((i + 1) % 2 == 0 ? 30 : 31);
                if (i >= 7)
                {

                   months[i]=(i + 1) % 2 == 0 ? months[i]+1 : months[i]-1;
                   Console.WriteLine("hi");
                }
            if (i == 1) { months[i] = 28; }
            }
            for (int i = 0; i < months.Length; i++)
            {
                Console.Write("month" + (i + 1) + "=" + months[i] + '\n');
            }
        }
    }
}
