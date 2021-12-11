using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    // Создали новый класс. Point
    // Теперь наш класс состояит не тольуо из данных, но из из функции
    class Point
    {
        public int x;       //данные класса Point
        public int y;        //данные класса Point
        public char sym;      //данные класса Point

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)   // конструктор  
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            if (direction == Direction.UP)
            {
                y = y - offset;
            }
            if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }


        public void Draw()     // функция которая будет выводить наши символы.
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }


        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

    
    }
}
