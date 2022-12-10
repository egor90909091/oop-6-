using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6_last_last
{
    public class CGroup : Shapes
    {
        // максимально возможное количество фигур в группе
        private int _maxcount;
        // текущее количество фигур в группе
        private int _count;
        // массив ссылок на хранимые фигусы
        private Shapes[] _shapes;
        public CGroup(int maxcount)
        {
            
            _maxcount = maxcount; 
            _count = 0;
            _shapes = new Shapes[_maxcount];
            for (int i = 0; i < _maxcount; i++)
                _shapes[i] = null;
        }
      
        // функция для добавления новой фигуры в массив
        public bool addShape(Shapes shape)
        {
            if (_count >= _maxcount)
                return false;

            _count++;
            _shapes[_count - 1] = shape;
            return true;
        }

        
        public override void move(int dx, int dy)
        {

            rect.X +=dx;
            rect.Y += dx;
            for (int i = 0; i < _count; i++)
                _shapes[i].move(dx, dy);
        }
       


        public override void Draw(Graphics g)
        {



            rect = GetRectangle();
            g.DrawRectangle(new Pen(Color.Red), rect.X, rect.Y, rect.Width, rect.Height);

            for (int i = 0; i < _count; i++)
            {
                _shapes[i].Draw(g);
            }
        }

        public override bool stena()
        {
            return false;
        }
        public override Rectangle GetRectangle()
        {
            Rectangle tmp=_shapes[0].GetRectangle();
            for (int i = 0; i < _count - 1; i++) { 
            if(_shapes[i+1]!=null)
                    tmp=Rectangle.Union(tmp, _shapes[i+1].GetRectangle());
            }
            center.X=rect.X+rect.Width/2;
            center.Y=rect.Y+rect.Height/2;
            return tmp;
        }
        public override bool containe(Point superpoint)
        {
           
            for (int i = 0; i < _count; i++)
            {
                if (_shapes[i].containe(superpoint))
                {
                    return true;

                }
                
            }
            return false;
        }
                
        public override void decrease()
        {
            for (int i = 0; i < _count; i++)
            {

                if (!_shapes[i].stena())
                {
                    _shapes[i].decrease();
                }
            } 
        }

        public override void increase()
        {
            for (int i = 0; i < _count; i++)
            {
                if (!_shapes[i].stena())
                {
                    _shapes[i].increase();
                }

            }
        }






    } }


