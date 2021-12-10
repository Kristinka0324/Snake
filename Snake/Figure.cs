using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;   //список точек      
        public void Draw()    // метод 
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }


    }
}
