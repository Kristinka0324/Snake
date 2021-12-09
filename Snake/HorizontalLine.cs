using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine    //список точек
    {
        List<Point> pList;    //горизонтальная линия это тот же список точек


        // При создании гориз линии передадим сюда параметры,
        // которые будут задавать длинну и положение линии.
        // зададим координату по оси Х- левой точки гор линии, координату по оси Х- правого конца, координату по оси У и символ.
        public HorizontalLine(int xLeft, int xRight, int y, char sym)                                                     
        {
            pList = new List<Point>();      // создали пустой список
            for(int x = xLeft; x <= xRight; x++)
            // в данном цикле на каждой итерации переменна Х будет принимать значения начиная от xLeft, заканчивая xRignt.
            {
                Point p = new Point(x, y, sym);  
                pList.Add(p);
            }
           
        }

        //теперь выведем эти точки на экран
        
        public void Drow() // для этого используем аналогичный метод Draw для вывода на экран, из класса Point 
        {
            foreach(Point p in pList) //пробежимся по всем точкам
            {
                p.Draw(); // и выведем их на экран
            }
        }
    }
}
