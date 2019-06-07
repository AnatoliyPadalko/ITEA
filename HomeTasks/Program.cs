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
            String name = "padalko anatoliy anatoliyovich";
            Console.WriteLine(name);
           
            char[] temp={' '};
            String[] splitname= name.Split(temp);
           
            //String tempresult = "";
            //Char[] Result = new char [name.Length];
       
            for (int i=0;i<splitname.Length;i++)
            {
                
                String tempstringresult = "";
                for (int j = 0; j < splitname[i].Length; j++)
                {
                  
                    char tempchar = splitname[i][j];
                   
                    if (j == 0)
                    {
                        string tempString = tempchar.ToString().ToUpper();
                        tempstringresult += tempString;
                       
                       
                    }
                    if (j > 0 && i==0) 
                    {
                        string tempString = tempchar.ToString();
                        tempstringresult += tempString;
                       
                    }
                    if (i == 0 & j == splitname[i].Length-1)
                    {
                        string tempString = " ";
                        tempstringresult += tempString;
                    }
                    if (j==1 && i>0)
                    {
                        string tempString = ".";
                        tempstringresult += tempString;
                    }
                   

                }

                splitname[i] = tempstringresult;
            }

            for (int i = 0; i < splitname.Length; i++)
            {
               for(int j=0;j<splitname[i].Length;j++)
                { 
                    Console.Write(splitname[i][j]);
                }
                
            }
            Console.Write("\n");
        }
    }
}
