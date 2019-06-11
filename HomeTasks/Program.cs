using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public class Figure
    {
        public string Name;
        public string Color;
        public double Square;
        public int Perimetr;
        public void SetFigure(string answerstring,int parametr,int parametr2)
        {

            String[] colorstart = { "red", "black","white","yellow", "orange","purple","blue","gray","green", "virid" };
            Random randcolor = new Random();
            switch (answerstring)
            {
                case "1":
                    { Name = "foursquare";
                      Color = colorstart[randcolor.Next(9)];
                      Square = parametr * parametr;
                      Perimetr = parametr * 4;
                      break;
                    }

                case "2":
                    { 
                    Name = "circle";
                    Color = colorstart[randcolor.Next(9)];
                    Square =Math.PI * parametr * parametr;
                    Perimetr = parametr * 2;
                    break;
                    }
                case "3":
                    {
                        Name = "triangle";
                        Color = colorstart[randcolor.Next(9)];
                        Square = parametr * parametr2;
                        Perimetr = parametr2 * 2;
                        break;
                    }
            }
        }
    }
    public class   GetInfo
    {
        public string answerstring;
        public int parametr;
        public int parametr2;

        public void Ask()
        {
            Console.WriteLine("Please,make your choise:\n 0-exit;1-foursquare;2-circle;3-triangle");
            answerstring = Console.ReadLine();
            switch (answerstring)
            {
                case "0":
                    {
                        Console.Write("Good by!\n");
                        return;
                    }
                   
                case "1":
                    {
                        Console.WriteLine("Please,enter side of foursquare");
                        parametr = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Please,enter radius of circle");
                        parametr = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Please,enter radius  of inscribed circle");
                        parametr = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please,enter triangle semi-perimeter");
                        parametr2= Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You are wrong");
                        Ask();
                        break;
                    }

            }
        }
        public void Result(string Name, string Color, double Square, int Perimetr)
        {
            Console.WriteLine("Name:" + Name + "\nColor:" + Color + "\nSquare:" + Square + "\nPeremetr=" + Perimetr);
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            string answerstring=" ";
            int parametr;
            int parametr2;
            Figure figure = new Figure();
            GetInfo getInfo = new GetInfo();
            do
            {
                getInfo.Ask();
                answerstring = getInfo.answerstring;
                if (answerstring!="0")
                { 
                parametr = getInfo.parametr;
                parametr2 = getInfo.parametr2;
                figure.SetFigure(answerstring, parametr, parametr2);
                getInfo.Result(figure.Name, figure.Color, figure.Square, figure.Perimetr);
                }
            } while (answerstring != "0");
        }
    }
}
