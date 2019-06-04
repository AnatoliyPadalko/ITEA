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

            string user;
            char[] field = new char[10];
            int dog = 0;
            Boolean countdog = false;
            do
            {
                for (int i = 0; i < field.Length; i++)
                {
                    if (countdog == false && i==dog)
                    {
                        field[dog] = '@';
                        countdog = true;
                    }
                    else
                    {
                        field[i] = '_';
                    }
                    Console.Write(field[i]);
                }
                user = Console.ReadLine();
                if (user == "d")
                {
                    dog++;
                    countdog = false;
                }
                else if (user == "a")
                {
                    dog--;
                    countdog = false;
                }
            } while (dog < 10);
        }
    }
}
        
    

