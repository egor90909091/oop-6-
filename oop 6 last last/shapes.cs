using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6_last_last
{
    public abstract class Shapes
    {
        
        protected Point center;
        public  bool selected;
        protected Color color=Color.Black;
        protected int maxheight = Form1.picbxSize.Height;
        protected int maxwidth = Form1.picbxSize.Width;

        public virtual void move(int dx,int dy) {
            Point oldcentr = center;
            center.X += dx;
            center.Y -= dy;
            if (stena())
                center = oldcentr;
            
        }
        public Rectangle rect;
        public abstract Rectangle GetRectangle();
        public abstract bool stena();
        public abstract void Draw(Graphics g);
        public abstract bool containe(Point superpoint);

        
        protected void setcolor(Color new_color) {
            this.color= new_color;

        }
        public abstract void increase();
        public abstract void decrease();
        public void SetColor(Color new_color)
        {
            color = new_color;
        }
        public Color GetColor()
        {
            return color;
        }
        public void UpdateBorders(int height,int width) {
            maxheight = height;
            maxwidth = width;
        }

    }




    public class CCircle : Shapes
    {
        
       
        private int r = 30;
        public CCircle()
        {
            rect = new Rectangle(0, 0, 0, 0);
            center = new Point(0, 0);
        }
        public CCircle(int x, int y)
        {
            rect = new Rectangle(x-r/2,y-r/2,r*2,r*2  );
            center = new Point(x, y);
        }
        public void SetCord(int _x, int _y)
        {
            center.X = _x;
            center.Y = _y;
        }

        public override void increase()
        {
            int oldr = r;
            if (!stena())
            {

                r += 10;
            }
            else
                r = oldr;
        }
        public override void decrease()
        {
            int oldr = r;
            if (r>0)
            {

                r -= 10;
            }
            else
                r = oldr;
        }

        public override void Draw(Graphics g)
        {
            
           
            g.DrawEllipse(new Pen(Color.Black), center.X - r / 2, center.Y - r / 2, r * 2, r * 2);
            if (selected == true)
                g.FillEllipse(new SolidBrush(Color.Red), center.X - r / 2, center.Y - r / 2, r * 2, r * 2);
            else
                g.FillEllipse(new SolidBrush(color), center.X - r / 2, center.Y - r / 2, r * 2, r * 2);

        }
        public override bool stena() {

            return (center.X + r >= maxwidth || center.X - r <= 0 || center.Y + r >= maxheight || center.Y - r <= 0);


          
               
        }

        public override Rectangle GetRectangle() {
            return rect;
        }
        public override bool containe(Point superpoint)
        {

            return ((Math.Pow(center.X - superpoint.X, 2)) + (Math.Pow(center.Y - superpoint.Y, 2)) <= Math.Pow(r, 2));

        }
        
        

    }








    public class Square : Shapes
    {
        
        private int side = 60;
        public Square()
        {

             center = new Point(0, 0);
            rect = new Rectangle(0, 0, 0, 0);
        }
        public Square(int x,int y )
        {
            center = new Point(x, y);
            
           
            
            rect = new Rectangle(x -side / 2, y - side / 2,side, side);


        }
        public override void Draw(Graphics g)
        {
           
            
            g.DrawRectangle(new Pen(Color.Black), center.X - side / 2, center.Y - side / 2, side , side );

            if (selected == true)
                g.FillRectangle(new SolidBrush(Color.Red), center.X - side / 2, center.Y - side / 2, side , side );
            else
                g.FillRectangle(new SolidBrush(color), center.X - side / 2, center.Y - side / 2, side , side );

        }
        public override bool stena()
        {
            return (center.X + this.side / 2 >= maxwidth || center.X - this.side / 2 <= 0 || center.Y + this.side / 2 >= maxheight || center.Y - this.side / 2 <= 0);
        }
        public override bool containe(Point superpoint)
        {
            if ((superpoint.X > center.X-side/2 && superpoint.X < center.X + side/2) && (superpoint.Y > center.Y-side/2 && superpoint.Y < center.Y+side / 2))
                return true;
            else return false;
            


        }
        public override Rectangle GetRectangle()
        {
            return rect;
        }
        public override void increase()
        {
            int oldside = side;
            if (!stena())
            {

                side += 10;
            }
            else
                side = oldside;
        }
        public override void decrease()
        {
            int oldside = side;
            if (side>0)
            {

                side -= 10;
            }
            else
                side = oldside;
        }

    }







    public partial class Triangle : Shapes
    {


    
         int side=60;
         double r;
        // double R;
         Point left;
         Point right;
         Point up;
         Point[] points;



        public Triangle()
        {
              rect=new Rectangle(0,0,0,0);
        center = new Point(0,0);
             r = side * (Math.Sqrt(3) / 3);
            // R = r * 2;
            left = new Point(center.X - side / 2, center.Y + (Convert.ToInt32(r)));
            right = new Point(center.X + side / 2, center.Y + (Convert.ToInt32(r)));
            up = new Point(center.X, center.Y - (Convert.ToInt32(r)));
            points = new Point[]{ up, left, right };
        }
        public Triangle(int x,int y)
        {
            
            center = new Point(x, y);
             r = side * (Math.Sqrt(3) / 3);
            rect = new Rectangle(x, y, Convert.ToInt32( r * 2), Convert.ToInt32(r * 2));
            //R = r * 2;
            left = new Point(center.X - side / 2, center.Y + (Convert.ToInt32(r)));
            right = new Point(center.X + side / 2, center.Y + (Convert.ToInt32(r)));
            up = new Point(center.X, center.Y - (Convert.ToInt32(r)));
            points =new Point [] { up, left, right };





        }
        public override Rectangle GetRectangle()
        {
            return rect;
        }
        public override bool stena()
        {
            
            return (center.X + side / 2 >= maxwidth || center.X - side / 2 <= 0 || center.Y + r >= maxheight || center.Y - r <= 0);

        }



        public override bool containe(Point superpoint)
        {
           
             var test1 = (left.X - superpoint.X) * (right.Y - left.Y) - (right.X - left.X) * (left.Y - superpoint.Y);
            var test2 = (right.X - superpoint.X) * (up.Y - right.Y) - (up.X - right.X) * (right.Y - superpoint.Y);
            var test3 = (up.X - superpoint.X) * (left.Y - up.Y) - (left.X - up.X) * (up.Y - superpoint.Y);

            return ((test1 >= 0 && test2 >= 0 && test3 >= 0) || (test1 <= 0 && test2 <= 0 && test3 <= 0));

        }
        public void updateAll()
        {
            r = side * (Math.Sqrt(3) / 3);
            //R = r * 2;
            left = new Point(center.X - side / 2, center.Y + (Convert.ToInt32(r)));
            right = new Point(center.X + side / 2, center.Y + (Convert.ToInt32(r)));
            up = new Point(center.X, center.Y - (Convert.ToInt32(r)));
            points = new Point[] { up, left, right };

        }
        public override void Draw(Graphics g)
        {
            updateAll();
            g.DrawPolygon(new Pen(Color.Black), points);
            if (selected == true)
                g.FillPolygon(new SolidBrush(Color.Red), points);

            else
                g.FillPolygon(new SolidBrush(color), points);



        }
        public override void increase()
        {
            int oldside = side;
            if (!stena())
            {

                side += 12;
              
            }
            else
                side = oldside;
           
        }

      

public override void decrease()
        {
            int oldside = side;
            if (side > 0)
            {
                
                side -= 12;
                
            }
            else
                side = oldside;
           

        }
        


    }
}
