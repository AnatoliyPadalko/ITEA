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
            char[][] field = new char[10][];
            int dog = 0;
            char[] temp = new char[10];
            int dogEx = 0;
            int hp = 100;
            Random rnd = new Random();
            Boolean countdog = false;
            int[] bomb = new int [10];
            int[] aid = new int [10];
           
            
              do
                  {


                      for(int i=0;i<field.Length;i++)
                      {
                        do
                        {
                            bomb[i] = rnd.Next(1, 8);
                            aid[i] = rnd.Next(1, 8);
                        } while (bomb[i] == aid[i]);
                        for (int j = 0; j < temp.Length; j++)

                        {
                   
                        if (countdog == false && i == dogEx && j == dog && !(j == bomb[j]) && !(j == aid[j]))
                            {
                            temp[dog] = '@';
                            countdog = true;
                            }
                            if (!(j == bomb[i]) && !(j == aid[i]) && i != dogEx && j != dog)
                            {
                            temp[j] = '_';
                            }
                            if (j == bomb[i])
                            {
                                temp[j] = '*';
                            }
                            if (j == aid[i])
                            {
                                temp[j] = '+';
                            }
                       
                        }
                       field[i] = temp;
                      }
             

                Console.Clear();

                  for (int i = 0; i < field.Length; i++)
                  {

                      for (int j = 0; j < field.Length; j++)
                      {
                          Console.Write(field[i][j]);
                      }
                      Console.WriteLine();
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
                  if (user == "w")
                  {
                      dogEx++;
                      countdog = false;
                      hp = hp - 5;
                  }
                  if (user == "x")
                  {
                      dogEx--;
                      countdog = false;
                      hp = hp - 5;
                  }
                  if (dog == bomb[dogEx])
                      {
                          hp = hp - 40;
                      }
                      if (dog == aid[dogEx])
                      {
                          hp = hp + 40;
                      }
                      if (hp > 100)
                      {
                          hp = 100;
                      }
                  } while (dog >= 0 && hp > 0 && dog < 10 && dogEx>=0 && dogEx<10);
              
        }
    }
}
        
    

