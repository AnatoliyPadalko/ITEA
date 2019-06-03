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

            int size = 9;
            char[][] arr3 = new char[size][];
            for (int i = 0; i < arr3.Length; i++)
            {
                char[] temp = new char[size];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (i == 0 || i == arr3.Length - 1 || j == 0 || j == temp.Length - 1  || i==(arr3.Length-1)/2 || j==(temp.Length-1)/2)
                    {
                        temp[j] = '*';
                    }
                    else
                    {
                        temp[j] = ' ';
                    }
                }
                arr3[i] = temp;
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.Write(arr3[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
        
    

