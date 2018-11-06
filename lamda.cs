using System;
using System.Collections.Generic;
using System.Text;

namespace lambda_expressions
{
   public delegate string GreetingsDelegate(string Name);
    class Program
    {
        static void Main(string[] args)
        {
            GreetingsDelegate obj =( Name)=>
            {
                return "hello    " + Name +   "   a very Good Morning ";
            };

            string str = obj.Invoke("sajan");
            Console.WriteLine(str);
            Console.ReadLine();
        

        }
    }
}
