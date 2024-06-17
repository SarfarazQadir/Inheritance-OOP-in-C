using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__OOP_
{
    internal class Program
    {
        public int num1;
        public int num2;
        public int result;

       public void Add()
        {
            int num1 = 50;
            int num2 = 30;
            int result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }


        public void Sub()
        {
           int num1 = 50;
          int  num2 = 30;
            int result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }     
    }
    class inherit : Program
    {
        /*public int num3;
        public int num4;
        public int result1;
*/
        public void Mul()
        {
            int num1 = 50;
            int num2 = 30;
            int result = num1 * num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public void Div()
        {
            int num1 = 50;
            int num2 = 30;
            int result = num1 / num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            inherit obj = new inherit();

           /* obj.num1 = 60;
            obj.num2 = 30;*/
            obj.Add();
            obj.Sub();
            obj.Mul();
            obj.Div();
           /* Console.WriteLine(obj.result1);*/
            Console.WriteLine(obj.result);
            Console.WriteLine();
            Console.ReadLine();
            /*Console.ReadKey();*/
        }

    }
}

