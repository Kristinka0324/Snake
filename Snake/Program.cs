using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point p1 = new Point(1,3, '*');  //  конструктор который принимает координаты точки. объект класса Point.
            p1.Draw();  // и выводит на экран

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine Line = new HorizontalLine(); //вызвали конструктор из класса HorizontalLine (объект класса HorizontalLine)
            Line.Draw();

            Console.ReadLine();
        }
        
    }
}
