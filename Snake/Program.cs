using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            // Добавили символ * с координатами x и y .
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            //Выведем символ на экран с помощью метода Draw описанным внизу
            Draw(x1, y1, sym1);

            // Добавили символ * с координатами x и y .
            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);

            Console.ReadLine();
        }
        
        /*Чтобы не испльзовать Copy Pass изменим наш код 
         * добавив в него функцию которая будет выводить на жкран значения 
         * координат которые мы им дадим. 
        */
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
