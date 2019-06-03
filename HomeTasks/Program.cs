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
            const int  year=2019;
            for (int i = 0; i < months.Length; i++)
            {
                months[i] = DateTime.DaysInMonth(year,i+1);
            }
            for(int i=0;i<months.Length;i++)
            {
                Console.Write(months[i]);
            }
        }
    }
}
