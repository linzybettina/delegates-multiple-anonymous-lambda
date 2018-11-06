using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multiple_delegates
{ 
    public delegate void RectDelegate(double width,double height);
     
    class Program
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of the Rectangle:"+width * height);
        }
        public void GetPerimeter(double Width, double height)
        {
            Console.WriteLine("Perimeter of the Rectangle:"+2 * (Width + height));

        }
    
       static void Main()
        {
            Program rect = new Program();
            RectDelegate obj = rect.GetArea;
            //obj.Invoke(34, 45);
            obj += rect.GetPerimeter;
            obj.Invoke(12, 10);
            obj.Invoke(12, 12);

            //rect.GetArea(12.34, 56.78);
            //rect.GetPerimeter(12.34, 56.78);
            Console.ReadLine();

        }
    }
}
