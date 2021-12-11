using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure  //змейка является некой фигурой на карте и состоит из точек
    {
        Direction direction;
        public Snake(Point tail,int Length, Direction _direction) //у змейки есть какая-то стартовая позиция на карте, tail 
                                                           //она находится в каких-то конкретных координатах, зададим ей длинну, Lenght
                                                           //и в каком будет двигаться направлении, direction
        {
            direction = _direction;
            pList = new List<Point>();
            for(int i = 0; i < Length; i++)
            {
                Point p = new Point(tail);         //в цикле будет создаваться новая точка
                p.Move(i, direction);              // перемещаться на одну в сторону дирекшона
                pList.Add(p);                       //и добавиться в список
                                               // получается что получим length точек, которые будут добавлены в список
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove( tail );
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
