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
            int hp = 100;
            Random rnd = new Random();
            Boolean countdog = false;
            int bomb = 0;
            int aid = 0;
            do
            {
                bomb = rnd.Next(1, 8);
                aid = rnd.Next(1, 8);
            } while (bomb == aid);

            field[bomb] = '*';
            field[aid] = '+';

            do
            {


                Console.Write("\b");
                for (int i = 0; i < field.Length; i++)
                {
                    
                    if (countdog == false && i==dog && !(i==bomb) && !(i==aid))
                    {
                        field[dog] = '@';
                        countdog = true;
                    }
                    else if(!(i == bomb)&& !(i == aid))
                    {
                        field[i] = '_';
                    }
 
                }
               
                Console.Clear();
                for (int i = 0; i < field.Length; i++)
                {
                    Console.Write(field[i]);
                    
                }
                Console.Write("\tHelth = " + hp + "");
                
              
                user = Console.ReadLine();
                if (user == "d")
                {
                    dog++;
                    countdog = false;
                    hp = hp - 5;
                }
                else if (user == "a")
                {
                    dog--;
                    countdog = false;
                    hp = hp - 5;
                }
                if(dog==bomb)
                {
                    hp = hp - 40;
                }
                if (dog == aid)
                {
                    hp = hp + 40;
                }
                if (hp > 100)
                {
                    hp = 100;
                }
            } while (dog >= 0 && hp>0 && dog<10);
          
        }
    }
}
        
    

