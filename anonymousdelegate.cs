using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace anonymous_delegates
{
    public delegate string GreetingsDelegate(string name);
    class Program
    {

        //public static string Greetings(string Name)
        //{
        //    return "hello    " + Name + "   A very Good Morning";
        //}
        static void Main()
        {
           //GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            GreetingsDelegate obj = delegate(string name)//anonymous delegate
            {
                return "hello    " + name + "   A very Good Morning";
            };
            string str = obj.Invoke("scott");
            Console.WriteLine(str);
            Console.ReadLine();
        }

    }

}
