using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace oop_6_last_last
{
    public partial class Form1 : Form
    {

        public bool drawingCircle = false;
        public bool drawingTr = false;
        public bool drawingSquar = false;

        MyStorage<Shapes> ShapeSt = new MyStorage<Shapes> { };
        public static Size picbxSize;
        public Form1()
        {

            InitializeComponent();

            picbxSize = pictureBox1.Size;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void isSelected(int x, int y)
        {
            for (int i = 0; i < ShapeSt.count(); i++)
            {

                {
                    ShapeSt[i].selected = false;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                for (int i = ShapeSt.count() - 1; i >= 0; i--)


                    if (ShapeSt[i].selected)
                    {
                        ShapeSt.removeAtIndex(i);
                    }

            pictureBox1.Invalidate();




            pictureBox1.Invalidate();

            switch (e.KeyCode)
            {
                case (Keys.W):
                    for (int i = 0; i < ShapeSt.count(); i++)

                    {
                        if (ShapeSt[i].selected)
                        {
                            ShapeSt[i].move(0, 15);
                        }
                    }
                    pictureBox1.Invalidate();
                    break;
                case (Keys.S):
                    for (int i = 0; i < ShapeSt.count(); i++)

                    {
                        if (ShapeSt[i].selected)
                        {
                            ShapeSt[i].move(0, -15);
                        }
                    }
                    pictureBox1.Invalidate();
                    break;
                case (Keys.A):
                    for (int i = 0; i < ShapeSt.count(); i++)


                        if (ShapeSt[i].selected)
                        {
                            ShapeSt[i].move(-15, 0);
                        }

                    pictureBox1.Invalidate();
                    break;
                case (Keys.D):
                    for (int i = 0; i < ShapeSt.count(); i++)


                        if (ShapeSt[i].selected)
                        {
                            ShapeSt[i].move(15, 0);
                        }

                    pictureBox1.Invalidate();
                    break;
                default:
                    break;
            }
        }
        public void Select(Point F)
        {
            for (int i = 0; i < ShapeSt.count(); i++)
                ShapeSt[i].selected = ShapeSt[i].containe(F);

        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            for (int i = 0; i < ShapeSt.count(); i++)
            {



                ShapeSt[i].Draw(e.Graphics);



            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {





            {
                bool isOnScreen = false;
                if (e.Button == MouseButtons.Left && (ModifierKeys & Keys.Control) == Keys.Control)
                {
                    for (int i = 0; i < ShapeSt.count(); i++)
                    {


                        if (ShapeSt[i].containe(e.Location))
                        {
                            ShapeSt[i].selected = true;


                        }


                    }



                }
                else
                {
                    isSelected(e.X, e.Y);
                    for (int i = 0; i < ShapeSt.count(); i++)
                    {

                        if (ShapeSt[i].containe(e.Location))
                        {
                            ShapeSt[i].selected = true;
                            isOnScreen = true;
                            break;
                        }


                    }
                    if (!isOnScreen)

                    {
                        if (drawingSquar)
                        {
                            Square Rect = new Square(e.X, e.Y);
                            if (Rect.stena() == false)
                            {

                                ShapeSt.add(Rect);
                                Rect.selected = true;
                            }
                        }
                        else if (drawingCircle)
                        {
                            CCircle c = new CCircle(e.X, e.Y);
                            if (c.stena() == false)
                            {

                                ShapeSt.add(c);
                                c.selected = true;
                            }
                        }
                        else if (drawingTr)
                        {
                            Triangle t = new Triangle(e.X, e.Y);
                            if (t.stena() == false)
                            {

                                ShapeSt.add(t);
                                t.selected = true;
                            }
                        }

                    }
                }

                pictureBox1.Invalidate();
            }
        }

        private void SelectShapeSt(Point location)
        {
            throw new NotImplementedException();
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
            drawingCircle = true;
            drawingSquar = false;
            drawingTr = false;

        }

        private void drawRectangle_Click(object sender, EventArgs e)
        {
            drawingCircle = false;
            drawingSquar = false;
            drawingTr = true;
        }

        private void drawSquar_Click(object sender, EventArgs e)
        {
            drawingCircle = false;
            drawingSquar = true;
            drawingTr = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ShapeSt.count(); i++)
            {

                if (ShapeSt[i].selected == true)

                    ShapeSt[i].decrease();



            }
            pictureBox1.Invalidate();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ShapeSt.count(); i++)
            {

                if (ShapeSt[i].selected == true)

                    ShapeSt[i].increase();






            }
            pictureBox1.Invalidate();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            {
                colorDialog1.ShowDialog();
                for (int i = 0; i < ShapeSt.count(); i++)
                    if (ShapeSt[i].selected == true)
                    {
                        ShapeSt[i].SetColor(colorDialog1.Color);
                        Color.BackColor = ShapeSt[i].GetColor();
                        ShapeSt[i].selected = false;
                    }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < ShapeSt.count(); i++)

            {
                ShapeSt[i].UpdateBorders(pictureBox1.Height, pictureBox1.Width);

            }


        }




        private void Form1_Resize(object sender, EventArgs e)
        {



        }

        private void BtnGroup_Click(object sender, EventArgs e)
        {

            GoToGroupBrothers(SelectedCount());
            pictureBox1.Invalidate();
        }

        public void GoToGroupBrothers(int SelectedShapes) {

            Shapes GroupShapes = new CGroup(SelectedShapes);

            for (int i = 0; i < ShapeSt.count(); i++)
                if (ShapeSt[i].selected == true) {
                    (GroupShapes as CGroup).addShape(ShapeSt.GetAndDelete(i));
                    
                }
            ShapeSt.add(GroupShapes);
            



        }
        public void ExitFromGroupBrothers() {
        
        }
        public int SelectedCount() {
            int SelectedShapes = 0;
            for (int i = 0; i < ShapeSt.count(); i++)
                if (ShapeSt[i].selected == true)
                    SelectedShapes++;
            return SelectedShapes;
        }
    }
}
