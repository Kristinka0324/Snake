using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point p1 = new Point(1,3, '*');  // конструктор который принимает координаты точки  
            p1.Draw();  // и выводит на экран

            Point p2 = new Point(4, 5, '#');
            p2.Draw();


            Console.ReadLine();
        }
        
    }
}
