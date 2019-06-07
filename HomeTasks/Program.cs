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
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            int countwords = rnd.Next(3, 8);
            int[] countletters = new int[countwords];
            string[] result = new string [countwords];
            for (int i=0;i<countwords-1;i++)
            {
                countletters[i] = rnd.Next(5, 10);
            }
            for(int i=0;i<countwords-1;i++)
            {
                for (int j = 0; j < countletters[i]-1; j++)
                {
                    int temprnd = rnd.Next(abc.Length);
                    string tempresult = abc[temprnd].ToString();
                    result[i] += tempresult;
                   
                   
                }
              
            }

            for (int i = 0; i < countwords; i++)
            {

                    Console.WriteLine(result[i]);
                
            }


        }
    }
}
